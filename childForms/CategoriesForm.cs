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
    public partial class CategoriesForm : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        string info;
        public CategoriesForm()
        {
            InitializeComponent();
            info = lblInformation.Text;
        }
        private void GetDataGridValues()
        {
            var values = db.Categories.Select(x => new { x.CategoryId, x.CategoryName }).ToList();
            dataGridView1.DataSource = values;
            dataGridView1.Columns["CategoryId"].HeaderText = "ID";
            dataGridView1.Columns["CategoryId"].Width = 48;
            dataGridView1.Columns["CategoryName"].HeaderText = "Kategori Adı";
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            ClearSelection();
        }
        private bool IsCategoryExist(string categoryName, int? id = null)
        {
            if (id.HasValue)
            {
                return db.Categories.Any(x => x.CategoryName == categoryName && x.CategoryId != id.Value);
            }
            else
            {
                return db.Categories.Any(x => x.CategoryName == categoryName);
            }
        }
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            GetDataGridValues();
        }
        private void ClearSelection()
        {
            lblInformation.Text = info;
            lblInformation.Tag = null;
            txtCategoryName.Text = txtCategoryName.Tag as string;
        }

        private void InsertData()
        {
            string categoryName = txtCategoryName.Text;
            if (!IsCategoryExist(categoryName)) 
            {
                Categories categories = new Categories();
                categories.CategoryName = categoryName;
                db.Categories.Add(categories);
                db.SaveChanges();
                MessageBox.Show("Kategori sisteme eklendi.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu kategori adı zaten sistemde kayıtlı.","Hatırlatma!",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void DeleteData(int id)
        {
            if (lblInformation.Tag != null)
            {
                var removeValues = db.Categories.Find(id);
                db.Categories.Remove(removeValues);
                db.SaveChanges();
                MessageBox.Show("Kategori bilgisi silindi.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lütfen tablodan ilgili veriyi seçiniz.", "Hatalı Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateData(int id)
        {
            string categoryName = txtCategoryName.Text;
            var updateValues = db.Categories.Find(id);
            updateValues.CategoryName = categoryName;
            if (!IsCategoryExist(categoryName,id))
            {
                db.SaveChanges();
                MessageBox.Show("Kategori bilgileri güncellendi.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Bu kategori adı zaten sistemde kayıtlı.", "Hatırlatma!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string idValue = dataGridView1.CurrentRow.Cells["CategoryId"].Value.ToString();
                lblInformation.Tag = idValue;
                lblInformation.Text = $"Seçilen Kategori ID: {idValue}";
                string nameValue = dataGridView1.CurrentRow.Cells["CategoryName"].Value.ToString();
                txtCategoryName.Text = nameValue;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
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

        private bool IsCategoryUsed(int categoryId)
        {
            return db.Spendings.Any(id => id.CategoryId == categoryId);
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
                if (!IsCategoryUsed(id))
                {
                    DeleteData(id);
                }
                else
                {
                    MessageBox.Show("İlgili kategori, giderler tablosunda yer almaktadır.", "Başarısız Silme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen tablodan ilgili veriyi seçiniz.", "Kategoriler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            GetDataGridValues();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // lblInformation.Tag'in null olmadığını kontrol et
            if (lblInformation.Tag != null)
            {
                // ID'yi al ve geçerli bir int olup olmadığını doğrula
                int id;
                if (int.TryParse(lblInformation.Tag.ToString(), out id))
                {
                    // Kategori kullanılıyor mu kontrol et
                    if (IsCategoryUsed(id))
                    {
                        // Kullanılıyorsa kullanıcıdan onay al
                        var result = MessageBox.Show(
                            "Güncelleme işlemi 'Giderler' tablosunda değişikliğe sebep olabilir.\nKabul ediyor musunuz?",
                            "Uyarı",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        // Kullanıcı onayladıysa işlemi gerçekleştir
                        if (result == DialogResult.Yes)
                        {
                            UpdateData(id);
                        }
                    }
                    else
                    {
                        // Kategori kullanılmıyorsa doğrudan işlemi gerçekleştir
                        UpdateData(id);
                    }
                }
                else
                {
                    MessageBox.Show("Geçersiz kategori ID'si.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Güncellenecek bir kategori seçilmedi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetDataGridValues();
        }
    }
}
