using FinancialCrm.Models;
using FinancialCrm.ValidationRules;
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
        private bool VerifyUserPassword(int id)
        {
            // Kullanıcıdan şifre girmesini istiyoruz
            string inputPassword = InputBox("Kayıtlı şifrenizi giriniz","Doğrulama",this.Icon);
            return db.Users.Any(x=>x.UserId == id && x.Password == inputPassword);
        }
        public static string InputBox(string prompt, string title, Icon icon)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = prompt;
            textBox.Text = "";
            form.Icon = icon;


            buttonOk.Text = "Accept";
            buttonCancel.Text = "Decline";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new System.Drawing.Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new System.Drawing.Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            return dialogResult == DialogResult.OK ? textBox.Text : null;
        }

        private void InsertData()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string userName = txtUserName.Text;
            string password = txtUserPassword.Text;
            bool status = FontAwesome.Sharp.IconChar.ToggleOn == btnStatus.IconChar;

            // UserValidator sınıfı ile kullanıcı bilgilerini doğrula
            UserValidator validator = new UserValidator();
            Users newUser = new Users()
            {
                FirstName = firstName,
                LastName = lastName,
                Username = userName,
                Password = password,
                Status = status
            };

            var validationResult = validator.Validate(newUser);

            if (validationResult.IsValid) // Eğer doğrulama başarılıysa, kullanıcıyı kaydedebilirsin
            {
                if (!IsUserExist(userName)) // Kullanıcı adı daha önce alınmamışsa
                {
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    MessageBox.Show("Kullanıcı bilgileri sisteme eklendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ekleme başarısız!\nKullanıcı adı sistemde zaten kayıtlı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else // Eğer doğrulama hatalıysa
            {
                // Hataları kullanıcıya göster
                string errorMessage = string.Join("\n", validationResult.Errors.Select(e => e.ErrorMessage));
                MessageBox.Show(errorMessage, "Doğrulama Hataları", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            GetUserDataValues();
        }
        private void DeletePassiveData(int id)
        {
            var values = db.Users.Find(id);
            if (values == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı","Hata",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            values.Status = false;
            db.SaveChanges();
            MessageBox.Show("Kullanıcı durumu pasif hale getirildi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GetUserDataValues();
        }
        private void DeleteData(int id)
        {
            var values = db.Users.Find(id);
            if (values == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (VerifyUserPassword(id))
            {
                db.Users.Remove(values);
                db.SaveChanges();

                MessageBox.Show("Kullanıcı kalıcı olarak silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sistemde kayıtlı eski şifreniz ile tekrar deneyin!", "Doğrulama Başarısız", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        private void UpdateData(int id)
        {
            var updateValues = db.Users.Find(id);
            if (updateValues == null)
            {
                MessageBox.Show("Kullanıcı bulunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            updateValues.Username = txtUserName.Text;
            updateValues.FirstName = txtFirstName.Text;
            updateValues.LastName = txtLastName.Text;
            updateValues.Password = txtUserPassword.Text;
            updateValues.Status = btnStatus.IconChar == FontAwesome.Sharp.IconChar.ToggleOn;

            UserValidator validator = new UserValidator();
            var validationResult = validator.Validate(updateValues);

            if (validationResult.IsValid)
            {
                if (!IsUserExist(updateValues.Username, id))
                {
                    if(VerifyUserPassword(id))
                    {
                        db.SaveChanges();
                        MessageBox.Show("Kullanıcı bilgileri güncellendi!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sistemde kayıtlı eski şifreniz ile tekrar deneyin!","Doğrulama Başarısız",MessageBoxButtons.OK,MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("Bu kullanıcı adı başka bir kullanıcı tarafından kullanılıyor!", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Hataları kullanıcıya göster
                string errorMessage = string.Join("\n", validationResult.Errors.Select(e => e.ErrorMessage));
                MessageBox.Show(errorMessage, "Doğrulama Hataları", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                // Kullanıcıya kalıcı silme veya pasif hale getirme işlemi için seçim yapma imkanı ver
                DialogResult result = MessageBox.Show("Kullanıcıyı kalıcı olarak silmek mi istiyorsunuz?\nAksi takdirde pasif hale getirilecektir.",
                                                      "Silme İşlemi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                // Eğer kullanıcı "Evet" seçerse, kalıcı silme işlemi yapılır
                if (result == DialogResult.Yes)
                {
                    DeleteData(id);  // Kalıcı silme
                }
                // Eğer kullanıcı "Hayır" seçerse, sadece pasif hale getirilir
                else if (result == DialogResult.No)
                {
                    DeletePassiveData(id);  // Pasif hale getirme
                }
                // Eğer kullanıcı "İptal" seçerse, hiçbir işlem yapılmaz
                else
                {
                    MessageBox.Show("Silme işlemi iptal edildi.", "İptal Edildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
