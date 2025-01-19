using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm.childForms
{
    public partial class SettingsForm : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            GetUserDataValues();
            dataGridViewUser.ClearSelection();
            dataGridViewUser.CurrentCell = null;
            OpenChildFormInTableLayout(new ConfigurationForm(true),tableLayoutMain);
        }

        #region User Settings
        private void GetUserDataValues()
        {
            var values = db.Users.Select(x => new
            {
                x.UserId,
                x.Username,
                x.Password,
                x.FirstName,
                x.LastName,
                x.Status
            }).ToList();
            dataGridViewUser.DataSource = values;
            dataGridViewUser.Columns["UserId"].HeaderText = "Id";
            dataGridViewUser.Columns["UserId"].Width = 48;
            dataGridViewUser.Columns["Username"].HeaderText = "Kullanıcı Adı";
            dataGridViewUser.Columns["Password"].HeaderText = "Şifre";
            dataGridViewUser.Columns["FirstName"].HeaderText = "Adı";
            dataGridViewUser.Columns["LastName"].HeaderText = "Soyadı";
            dataGridViewUser.Columns["Status"].HeaderText = "Durum";

            dataGridViewUser.ClearSelection();
            dataGridViewUser.CurrentCell = null;

        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            bool status;
            if (e.RowIndex >= 0)
            {
                txtUserName.Text = dataGridViewUser.CurrentRow.Cells["UserName"].Value.ToString();
                SetTextBoxPasswordValue(txtUserPassword, dataGridViewUser.CurrentRow.Cells["Password"].Value.ToString());
                txtFirstName.Text = dataGridViewUser.CurrentRow.Cells["FirstName"].Value.ToString();
                txtLastName.Text = dataGridViewUser.CurrentRow.Cells["LastName"].Value.ToString();
                numUpDownID.Value = int.Parse(dataGridViewUser.CurrentRow.Cells["UserId"].Value.ToString());
                status = bool.Parse(dataGridViewUser.CurrentRow.Cells["Status"].Value.ToString());
                btnStatus.IconChar = status ? FontAwesome.Sharp.IconChar.ToggleOn : FontAwesome.Sharp.IconChar.ToggleOff;
            }
        }
        private bool IsUserExist(string userName, int? userId = null)
        {
            if (userId.HasValue)
            {
                return db.Users.Any(x => x.Username == userName && x.UserId != userId.Value);
            }
            else
            {
                return db.Users.Any(x => x.Username == userName);
            }
        }
        private void InsertData()
        {
            string firstName, lastName, userName, password;
            bool status;
            userName = txtUserName.Text;
            password = txtUserPassword.Text;
            firstName = txtFirstName.Text;
            lastName = txtLastName.Text;
            status = FontAwesome.Sharp.IconChar.ToggleOn == btnStatus.IconChar;
            if (!IsUserExist(userName))
            {
                Users user = new Users()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Username = userName,
                    Password = password,
                    Status = status
                };
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Kullanıcı bilgileri sisteme eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ekleme başarısız!\nKullanıcı adı sistemde zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GetUserDataValues();
        }
        private void DeletePassiveData(int id)
        {
            var values = db.Users.Find(id);
            values.Status = false;
            db.SaveChanges();
            MessageBox.Show("Kullanıcı durumu pasif hale getirildi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetUserDataValues();
        }
        private void UpdateData(int id)
        {
            var updateValues = db.Users.Find(id);
            updateValues.Username = txtUserName.Text;
            updateValues.FirstName = txtFirstName.Text;
            updateValues.LastName = txtLastName.Text;
            updateValues.Password = txtUserPassword.Text;
            updateValues.Status = btnStatus.IconChar == FontAwesome.Sharp.IconChar.ToggleOn;
            if (!IsUserExist(updateValues.Username,id))
            {
                db.SaveChanges();
                MessageBox.Show("Kullanıcı bilgileri güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu kullanıcı adı başka bir kullanıcı tarafından kullanılıyor!","Bilgilendirme",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GetUserDataValues();
        }

        private void dataGridViewUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // Password sütunundaki hücrelerin değerini gizli karakterlerle göstermek için
            if (dataGridViewUser.Columns[e.ColumnIndex].Name == "Password" && e.RowIndex >= 0)
            {
                e.Value = new string('•', e.Value.ToString().Length); // '•' ile şifreyi gizle
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            InsertData();
            GetUserDataValues();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(numUpDownID.Value.ToString(), out id))
            {
                DeletePassiveData(id);
            }
            else
            {
                MessageBox.Show("Geçersiz Id değeri girildi!", "Başarısız Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GetUserDataValues();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(numUpDownID.Value.ToString(), out id))
            {
                UpdateData(id);
            }
            else
            {
                MessageBox.Show("Geçersiz Id değeri girildi!", "Başarısız Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GetUserDataValues();
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            btnStatus.IconChar = btnStatus.IconChar == FontAwesome.Sharp.IconChar.ToggleOn ? FontAwesome.Sharp.IconChar.ToggleOff : FontAwesome.Sharp.IconChar.ToggleOn;
        }

        public void SetTextBoxPasswordValue(TextBox textBox, string value)
        {
            textBox.Text = value;
            textBox.UseSystemPasswordChar = true;
        }

        private void TextBoxPlaceHolder_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && textBox.Text == textBox.Tag.ToString())
            {
                textBox.Text = string.Empty;
            }
        }
        private void TextBoxPlaceHolder_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox && string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = textBox.Tag.ToString();
            }
        }
        private void TextBoxPassword_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (textBox.Text == textBox.Tag.ToString())
                {
                    textBox.Text = string.Empty;
                }
                textBox.UseSystemPasswordChar = true;
            }
        }

        private void TextBoxPassword_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                if (string.IsNullOrEmpty(textBox.Text) || textBox.Text == textBox.Tag?.ToString())
                {
                    textBox.Text = textBox.Tag?.ToString();
                    textBox.UseSystemPasswordChar = false;
                }
                else
                {
                    textBox.UseSystemPasswordChar = true;
                }
            }
        }
        #endregion

        #region Database Settings için ChildForm Metodu
        private void OpenChildFormInTableLayout(Form childForm, TableLayoutPanel tableLayoutPanel)
        {
            // TableLayoutPanel'de hedef hücreyi temizleyin
            Control existingControl = tableLayoutPanel.GetControlFromPosition(1, 0); // 2. sütun (index 1), ilk satır
            if (existingControl != null)
            {
                existingControl.Dispose();
            }

            // Yeni formu ayarla
            childForm.TopLevel = false; // Form'un TopLevel olmasını devre dışı bırakır
            childForm.FormBorderStyle = FormBorderStyle.None; // Kenarlıkları kaldırır
            childForm.Dock = DockStyle.Fill; // Hücreyi kaplasın

            // TableLayoutPanel'e form'u ekle ve sütun/satır konumunu ayarla
            tableLayoutPanel.Controls.Add(childForm, 1, 0); // 2. sütun (index 1), ilk satır
            tableLayoutPanel.SetColumn(childForm, 1); // 2. sütun
            tableLayoutPanel.SetRow(childForm, 0); // 1. satır

            // Formu göster
            childForm.Show();
        }
        #endregion

    }
}
