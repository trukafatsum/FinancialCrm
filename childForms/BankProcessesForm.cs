using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm.childForms
{
    public partial class BankProcessesForm : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public BankProcessesForm()
        {
            InitializeComponent();
        }

        private void BankProcessesForm_Load(object sender, EventArgs e)
        {
            GetDataGridValues();
        }

        private void GetDataGridValues()
        {
            var values = db.BankProcesses.Select(x => new
            {
                x.BankProcessId,
                x.Banks.BankTitle,
                x.ProcessType,
                x.Amount,
                x.Description,
                x.ProcessDate,
            }).ToList();

            dataGridView1.DataSource = values;
            ConfigureDataGridView();
        }
        private void ConfigureDataGridView()
        {
            dataGridView1.Columns["BankProcessId"].HeaderText = "ID";
            dataGridView1.Columns["Description"].HeaderText = "Açıklama";
            dataGridView1.Columns["ProcessDate"].HeaderText = "İşlem Tarihi";
            dataGridView1.Columns["ProcessType"].HeaderText = "İşlem Türü";
            dataGridView1.Columns["Amount"].HeaderText = "Tutar";
            dataGridView1.Columns["BankTitle"].HeaderText = "Banka Adı";

            dataGridView1.Columns["BankProcessId"].Width = 50;  // ID sütunu
            dataGridView1.Columns["Description"].Width = 200;   // Açıklama sütunu
            dataGridView1.Columns["ProcessDate"].Width = 100;   // İşlem Tarihi sütunu
            dataGridView1.Columns["ProcessType"].Width = 100;   // İşlem Türü sütunu
            dataGridView1.Columns["Amount"].Width = 80;         // Tutar sütunu
            dataGridView1.Columns["BankTitle"].Width = 150;     // Banka Adı sütunu
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtAdvSearch.Text = txtAdvSearch.Tag as string;
            GetDataGridValues();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private void txtAdvSearch_TextChanged(object sender, EventArgs e)
        {
            filterTimer.Stop();
            filterTimer.Start();
        }

        private void filterTimer_Tick(object sender, EventArgs e)
        {
            filterTimer.Stop();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string searchText = txtAdvSearch.Text.ToLower().Trim();
            var query = db.BankProcesses.AsQueryable();

            // Tarih ve tutar kontrolü
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                if (searchText.Contains(" ")) // Eğer birden fazla kelime varsa
                {
                    var parts = searchText.Split(' ');

                    // Tarih kontrolü: "2023 Ağustos" gibi bir format
                    if (parts.Length == 2 && int.TryParse(parts[0], out int year))
                    {
                        string month = parts[1];
                        int monthNumber = GetMonthNumber(month);

                        if (monthNumber > 0)
                        {
                            query = query.Where(x =>
                                x.ProcessDate.HasValue &&
                                x.ProcessDate.Value.Year == year &&
                                x.ProcessDate.Value.Month == monthNumber);
                        }
                        else
                        {
                            // Geçersiz ay adı durumunda listeyi boş göster
                            dataGridView1.DataSource = new List<object>();
                            return;
                        }
                    }
                }
                else if (searchText.Contains("-")) // Tutar aralığı: "500-1000" gibi
                {
                    var amounts = searchText.Split('-');
                    if (amounts.Length == 2 &&
                        decimal.TryParse(amounts[0], out decimal minAmount) &&
                        decimal.TryParse(amounts[1], out decimal maxAmount))
                    {
                        query = query.Where(x =>
                            x.Amount.HasValue &&
                            x.Amount >= minAmount &&
                            x.Amount <= maxAmount);
                    }
                    else
                    {
                        // Geçersiz tutar formatı durumunda listeyi boş göster
                        dataGridView1.DataSource = new List<object>();
                        return;
                    }
                }
                else if (searchText.Contains(".") || searchText.Contains("/")) // Noktalı, kesirli veya slashlı tarih formatı
                {
                    // "16.01.2023" veya "16/01/2023" formatlarını kontrol et
                    var dateParts = searchText.Split(new char[] { '.', '/', '-' });
                    if (dateParts.Length == 3 &&
                        int.TryParse(dateParts[0], out int day) &&
                        int.TryParse(dateParts[1], out int month) &&
                        int.TryParse(dateParts[2], out int year))
                    {
                        if (month >= 1 && month <= 12 && day >= 1 && day <= 31) // Ay ve gün geçerli bir değer mi?
                        {
                            query = query.Where(x =>
                                x.ProcessDate.HasValue &&
                                x.ProcessDate.Value.Day == day &&
                                x.ProcessDate.Value.Month == month &&
                                x.ProcessDate.Value.Year == year);
                        }
                        else
                        {
                            // Geçersiz ay veya gün durumu
                            dataGridView1.DataSource = new List<object>();
                            return;
                        }
                    }
                    else
                    {
                        // Geçersiz tarih formatı
                        dataGridView1.DataSource = new List<object>();
                        return;
                    }
                }
                else
                {
                    // Genel metin araması
                    query = query.Where(x =>
                        x.BankProcessId.ToString().Contains(searchText) ||
                        (x.Description != null && x.Description.ToLower().Contains(searchText)) ||
                        (x.ProcessType != null && x.ProcessType.ToLower().Contains(searchText)) ||
                        (x.Banks.BankTitle != null && x.Banks.BankTitle.ToLower().Contains(searchText))
                    );
                }
            }

            // Sonuçları listeye dönüştür
            var filteredValues = query
                .Select(x => new
                {
                    x.BankProcessId,
                    x.Banks.BankTitle,
                    x.ProcessType,
                    x.Amount,
                    x.Description,
                    x.ProcessDate,
                })
                .ToList();

            // Eğer sonuç yoksa boş bir liste ata
            if (filteredValues.Count == 0)
            {
                dataGridView1.DataSource = new List<object>();
            }
            else
            {
                dataGridView1.DataSource = filteredValues;
                ConfigureDataGridView();
            }
        }



        // Ay ismini ay numarasına çeviren yardımcı metot
        private int GetMonthNumber(string month)
        {
            switch (month)
            {
                case "ocak": return 1;
                case "şubat": return 2;
                case "mart": return 3;
                case "nisan": return 4;
                case "mayıs": return 5;
                case "haziran": return 6;
                case "temmuz": return 7;
                case "ağustos": return 8;
                case "eylül": return 9;
                case "ekim": return 10;
                case "kasım": return 11;
                case "aralık": return 12;
                default: return 0; // Geçersiz ay ismi
            }
        }

        private void txtAdvSearch_Enter(object sender, EventArgs e)
        {
            txtAdvSearch.Text = string.Empty;
        }

        private void txtAdvSearch_Leave(object sender, EventArgs e)
        {
            txtAdvSearch.Text = txtAdvSearch.Tag as string;
        }
    }
}
