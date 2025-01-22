using FinancialCrm.Models;
using FinancialCrm.ValidationRules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialCrm.childForms
{
    public partial class SpendingsForm : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        string info;
        public SpendingsForm()
        {
            InitializeComponent();
        }
        private void GetDataGridValues()
        {
            var values = db.Spendings.Select(x => new
            {
                x.SpendingId,
                x.SpendingTitle,
                x.SpendingAmount,
                x.SpendingDate,
                x.Categories.CategoryName,
            }).ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns["SpendingId"].Visible = false;
            dataGridView1.Columns["SpendingTitle"].HeaderText = "Harcama Başlığı";
            dataGridView1.Columns["SpendingTitle"].Width = 140;
            dataGridView1.Columns["SpendingAmount"].HeaderText = "Tutar";
            dataGridView1.Columns["SpendingDate"].HeaderText = "Tarih";
            dataGridView1.Columns["CategoryName"].HeaderText = "Kategori";

            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;

            SetDefaultChart();
            ClearSelection();
        }
        private void SetDefaultChart()
        {
            var values = db.Spendings.GroupBy(x => x.Categories.CategoryName)
                .Select(g => new
                {
                    CategoryName = g.Key,
                    TotalSpending = g.Sum(x => x.SpendingAmount)
                }).ToList();

            double totalSpendingAll = values.Sum(v => (double)v.TotalSpending);

            chart1.Series.Clear();
            chart1.Legends.Clear();

            Series series = new Series("Harcamalar")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true,
                LabelFormat = "{0:N2}%",
                Font = new System.Drawing.Font(Font.FontFamily, Font.Size, FontStyle.Bold)
            };

            var colorPalette = new List<System.Drawing.Color>
            {
                System.Drawing.Color.Moccasin,
                System.Drawing.Color.Sienna,
                System.Drawing.Color.AntiqueWhite,
                System.Drawing.Color.SaddleBrown,
                System.Drawing.Color.Brown,
            };
            int colorIndex = 0;

            foreach (var item in values)
            {
                double percentage = ((double)item.TotalSpending / totalSpendingAll) * 100;

                DataPoint dp = new DataPoint
                {
                    AxisLabel = item.CategoryName,
                    YValues = new double[] { (double)item.TotalSpending },
                    Label = $"{item.CategoryName}\n{percentage:N2}%"
                };
                dp.Color = colorPalette[colorIndex % colorPalette.Count];
                colorIndex++;
                series.Points.Add(dp);
            }
            foreach (var point in series.Points)
            {
                Color pointColor = point.Color;
                double brightness = pointColor.GetBrightness();

                if (brightness < 0.5)
                {
                    point.LabelForeColor = Color.Moccasin;
                }
                else
                {
                    point.LabelForeColor = Color.SaddleBrown;
                }
            }
            chart1.Series.Add(series);

            chart1.BackColor = Color.BurlyWood;
            Legend legend = new Legend("Legend1")
            {
                Docking = Docking.Top,
                Alignment = System.Drawing.StringAlignment.Center,
                BackColor = System.Drawing.Color.Transparent,
                Title = "Kategoriler ve Harcama Tutarları",
                TitleFont = new System.Drawing.Font("Calibri", 12, System.Drawing.FontStyle.Bold)
            };

            chart1.Legends.Add(legend);

            for (int i = 0; i < series.Points.Count; i++)
            {
                var point = series.Points[i];
                point.LegendText = $"{point.AxisLabel}: {point.YValues[0]:C}";
            }
            chart1.ChartAreas[0].AxisX.Title = "Kategoriler";
            chart1.ChartAreas[0].AxisY.Title = "Toplam Tutar";
            chart1.ChartAreas[0].BackColor = Color.BurlyWood;
        }
        private void GetCategoriesToCmb()
        {
            var values = db.Categories.Select(x => new
            {
                x.CategoryId,
                x.CategoryName
            }).ToList();
            cmbCategories.DisplayMember = "CategoryName";
            cmbCategories.ValueMember = "CategoryId";
            cmbCategories.DataSource = values;
        }
        private void ClearSelection()
        {
            txtSpendingTitle.Text = txtSpendingTitle.Tag as string;
            txtSpendingAmount.Text = txtSpendingAmount.Tag as string;
            txtDate.Text = txtDate.Tag as string;
            lblInformation.Tag = null;
            cmbCategories.SelectedIndex = cmbCategories.Items.Count > 0 ? 0 : -1;
            lblInformation.Text = info;
        }
        private void InsertData()
        {
            string title = txtSpendingTitle.Text;
            decimal amount;
            DateTime date;
            int categoryID;

            // Kullanıcıdan gelen verileri doğrulama
            if (decimal.TryParse(txtSpendingAmount.Text, out amount) &&
                DateTime.TryParse(txtDate.Text, out date) &&
                int.TryParse(cmbCategories.SelectedValue.ToString(), out categoryID))
            {
                // Yeni harcama nesnesi oluştur
                Spendings spendings = new Spendings();
                spendings.SpendingTitle = title;
                spendings.SpendingAmount = amount;
                spendings.SpendingDate = date;
                spendings.CategoryId = categoryID;

                // FluentValidation kullanarak doğrulama
                var spendingValidator = new SpendingValidator();
                var validationResult = spendingValidator.Validate(spendings);

                if (validationResult.IsValid)
                {
                    db.Spendings.Add(spendings);
                    db.SaveChanges();
                    MessageBox.Show("Harcama bilgileri sisteme eklendi.", "Gider & Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Eğer doğrulama hatalıysa, hataları kullanıcıya göster
                    foreach (var failure in validationResult.Errors)
                    {
                        MessageBox.Show(failure.ErrorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Girilen bilgileri tekrar kontrol ediniz.", "Başarısız Ekleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DeleteData(int id)
        {
            // Silinecek harcamanın veritabanında mevcut olup olmadığını kontrol et
            var removeValue = db.Spendings.Find(id);

            // Eğer harcama bulunamazsa
            if (removeValue == null)
            {
                MessageBox.Show("Harcama kaydı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Silme işleminden önce kullanıcıdan onay al
            var confirmResult = MessageBox.Show("Bu harcamayı silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {
                // Harcama kaydını sil
                db.Spendings.Remove(removeValue);
                db.SaveChanges();
                MessageBox.Show("Harcama sistemden silindi.", "Gider & Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Silme işlemi iptal edildiğinde
                MessageBox.Show("Silme işlemi iptal edildi.", "İptal", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void UpdateData(int id)
        {
            string title = txtSpendingTitle.Text;
            decimal amount;
            DateTime date;
            int categoryID;
            var values = db.Spendings.Find(id);
            if (values == null)
            {
                MessageBox.Show("Harcama kaydı bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Girilen verilerin geçerliliğini kontrol ediyoruz
            bool isAmountValid = decimal.TryParse(txtSpendingAmount.Text, out amount);
            bool isDateValid = DateTime.TryParse(txtDate.Text, out date);
            bool isCategoryValid = int.TryParse(cmbCategories.SelectedValue.ToString(), out categoryID);

            // Eğer herhangi bir alan geçerli değilse, hata mesajı gösteriyoruz
            if (!isAmountValid || !isDateValid || !isCategoryValid)
            {
                MessageBox.Show("Girilen verileri tekrar gözden geçirin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            values.SpendingTitle = title;
            values.SpendingAmount = amount;
            values.SpendingDate = date;
            values.CategoryId = categoryID;

            SpendingValidator validator = new SpendingValidator();
            var validationResult = validator.Validate(values);
            if (validationResult.IsValid)
            {
                db.SaveChanges();
                MessageBox.Show("Harcama bilgileri güncellendi.", "Gider & Harcamalar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Hataları kullanıcıya gösteriyoruz
                string errorMessage = string.Join("\n", validationResult.Errors.Select(e => e.ErrorMessage));
                MessageBox.Show(errorMessage, "Doğrulama Hataları", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void SpendingsForm_Load(object sender, EventArgs e)
        {
            info = lblInformation.Text;
            GetCategoriesToCmb();
            GetDataGridValues();
            SetDefaultChart();
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
                string idValue = dataGridView1.CurrentRow.Cells["SpendingId"].Value.ToString();
                lblInformation.Tag = idValue;
                lblInformation.Text = $"Seçilen Harcama ID: {idValue}";
                string titleValue = dataGridView1.CurrentRow.Cells["SpendingTitle"].Value.ToString();
                txtSpendingTitle.Text = titleValue;
                string amountValue = dataGridView1.CurrentRow.Cells["SpendingAmount"].Value.ToString();
                txtSpendingAmount.Text = amountValue;
                DateTime dateValue = DateTime.Parse(dataGridView1.CurrentRow.Cells["SpendingDate"].Value.ToString());
                txtDate.Text = dateValue.ToString();
                string categoryValue = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
                // ComboBox'taki öğeleri tarayıp uygun öğeyi buluyoruz
                for (int i = 0; i < cmbCategories.Items.Count; i++)
                {
                    var item = cmbCategories.Items[i] as dynamic;
                    if (item != null && item.CategoryName == categoryValue)
                    {
                        cmbCategories.SelectedIndex = i;  // Seçilen öğe olarak uygun öğeyi belirliyoruz
                        break;
                    }
                }
            }
        }

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
    }
}
