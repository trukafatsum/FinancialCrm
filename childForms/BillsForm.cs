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
    public partial class BillsForm : Form
    {
        string info;
        public BillsForm()
        {
            InitializeComponent();
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void BillsForm_Load(object sender, EventArgs e)
        {
            info = lblInformation.Text;
            GetDataGridValues();
        }

        private void GetDataGridValues()
        {
            var values = db.Bills.ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns["BillId"].HeaderText = "ID";
            dataGridView1.Columns["BillId"].Width = 48;
            dataGridView1.Columns["BillTitle"].HeaderText = "Fatura Başlığı";
            dataGridView1.Columns["BillAmount"].HeaderText = "Tutar";
            dataGridView1.Columns["BillPeriod"].HeaderText = "Periyot";
            ClearSelections();
        }
        private void ClearSelections()
        {
            txtBillAmount.Text = txtBillAmount.Tag as string;
            txtBillTitle.Text = txtBillTitle.Tag as string;
            txtPeriod.Text = txtPeriod.Tag as string;
            lblInformation.Tag = null;
            lblInformation.Text = info;
        }
        private void InsertData()
        {
            string title = txtBillTitle.Text;
            string period = txtPeriod.Text;
            decimal amount;
            if (decimal.TryParse(txtBillAmount.Text, out amount))
            {
                Bills bills = new Bills();
                bills.BillTitle = title;
                bills.BillAmount = amount;
                bills.BillPeriod = period;
                db.Bills.Add(bills);
                db.SaveChanges();
                MessageBox.Show("Ödeme bilgileri sisteme eklendi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Girilen sayı uygun değil!", "Hatalı Tutar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void DeleteData(int id)
        {
            var removeValue = db.Bills.Find(id);
            db.Bills.Remove(removeValue);
            db.SaveChanges();
            MessageBox.Show("Ödeme sistemden silindi", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateData(int id)
        {
            string title = txtBillTitle.Text;
            decimal amount = decimal.Parse(txtBillAmount.Text);
            string period = txtPeriod.Text;

            var values = db.Bills.Find(id);
            values.BillTitle = title;
            values.BillAmount = amount;
            values.BillPeriod = period;
            db.SaveChanges();
            MessageBox.Show("Ödeme bilgileri güncellendi.", "Ödeme & Faturalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnList_Click(object sender, EventArgs e)
        {
            GetDataGridValues();
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            InsertData();
            GetDataGridValues();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblInformation.Tag != null)
            {
                int id = int.Parse(lblInformation.Tag.ToString());
                DeleteData(id);
            }
            else
            {
                MessageBox.Show("Lütfen tablodan ilgili veriyi seçiniz.", "Silme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GetDataGridValues();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblInformation.Tag != null)
            {
                int id = int.Parse(lblInformation.Tag.ToString());
                UpdateData(id);
            }
            else
            {
                MessageBox.Show("Lütfen tablodan ilgili veriyi seçiniz.", "Güncelleme Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GetDataGridValues();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                lblInformation.Text = info;
                string idValue = dataGridView1.CurrentRow.Cells["BillId"].Value.ToString();
                lblInformation.Tag = idValue;
                lblInformation.Text = $"Seçilen Fatura ID: {idValue}";
                string titleValue = dataGridView1.CurrentRow.Cells["BillTitle"].Value.ToString();
                txtBillTitle.Text = titleValue;
                string amountValue = dataGridView1.CurrentRow.Cells["BillAmount"].Value.ToString();
                txtBillAmount.Text = amountValue;
                string periodValue = dataGridView1.CurrentRow.Cells["BillPeriod"].Value.ToString();
                txtPeriod.Text = periodValue;
            }
        }

        #region Textboxes Enter & Leave Events (using for Placeholder)
        private void HandleTextBoxEnterLeave(object sender, EventArgs e)
        {
            TextBox txtBox = sender as TextBox;

            if (txtBox == null) return; // Eğer sender TextBox değilse, çık

            if (e is EventArgs) // Enter olayını kontrol et
            {
                if (txtBox.Text == txtBox.Tag.ToString())
                {
                    txtBox.Text = string.Empty;
                }

                else if (string.IsNullOrEmpty(txtBox.Text) || string.IsNullOrWhiteSpace(txtBox.Text))
                {
                    txtBox.Text = txtBox.Tag.ToString();
                }
            }
        }
        #endregion
    }
}
