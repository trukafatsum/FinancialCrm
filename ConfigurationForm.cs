using FinancialCrm.Models;
using FinancialCrm.ValidationRules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }
        bool IsChild;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationForm"/> class.
        /// Determines whether the form is displayed as a child form and adjusts the visibility of the header panel accordingly.
        /// </summary>
        /// <param name="IsChild">A boolean value indicating whether the form is a child form. If true, the header panel will be visible; otherwise, it will be hidden.</param>
        public ConfigurationForm(bool IsChild)
        {
            InitializeComponent();
            this.IsChild = IsChild;
            headerPanel.Visible = !IsChild;
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            GetDatabaseValues();
        }

        #region Drag Event WinAPI
        // Windows API çağrısı
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void dragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion

        #region Database Settings
        private void GetDatabaseValues()
        {
            // DataTable oluştur
            var table = new DataTable();
            table.Columns.Add("Key", typeof(string));   // Key sütunu
            table.Columns.Add("Value", typeof(string)); // Value sütunu

            // Key-Value çiftlerini tabloya ekle
            table.Rows.Add("DataSource", Properties.Settings.Default.DataSource);
            table.Rows.Add("InitialCatalog", Properties.Settings.Default.InitialCatalog);
            table.Rows.Add("UserId", Properties.Settings.Default.UserId);
            table.Rows.Add("Password", Properties.Settings.Default.Password);
            table.Rows.Add("IntegratedSecurity", Properties.Settings.Default.IntegratedSecurity);
            table.Rows.Add("TrustedServerCertificate", Properties.Settings.Default.TrustedServerCertificate);

            // DataTable'ı DataGridView'e bağla
            dataGridViewDatabase.DataSource = table;

            // Opsiyonel: Sütun başlıklarını daha okunabilir hale getirmek için yeniden adlandırabilirsiniz
            dataGridViewDatabase.Columns["Key"].HeaderText = "Ayar";
            dataGridViewDatabase.Columns["Value"].HeaderText = "Değer";
        }

        private void dataGridViewDatabase_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridViewDatabase.Rows[e.RowIndex].Cells[0].Value.ToString() == "Password")
            {
                e.Value = "•••••••"; // Şifreyi maskele
                e.FormattingApplied = true;
            }
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

        public void SetTextBoxPasswordValue(TextBox textBox, string value)
        {
            textBox.Text = value;
            textBox.UseSystemPasswordChar = true;
        }

        private void LoadDatabaseValuesToTextBoxes()
        {
            // Tablodaki değerleri TextBox'lara yükle
            foreach (DataGridViewRow row in dataGridViewDatabase.Rows)
            {
                string key = row.Cells["Key"].Value.ToString();
                string value = row.Cells["Value"].Value?.ToString() ?? "";

                switch (key)
                {
                    case "DataSource":
                        txtDataSource.Text = value;
                        break;
                    case "InitialCatalog":
                        txtInitialCatalog.Text = value;
                        break;
                    case "UserId":
                        txtUserId.Text = value;
                        break;
                    case "Password":
                        SetTextBoxPasswordValue(txtPassword, value); // Şifreyi gizli tut
                        break;
                    case "IntegratedSecurity":
                        checkIntegratedSecurity.Checked = bool.Parse(value);
                        break;
                    case "TrustedServerCertificate":
                        checkTrustedServerCertificate.Checked = bool.Parse(value);
                        break;
                }
            }
        }

        private void SaveValuesToProperties()
        {
            // TextBox'lardaki değerleri Properties.Settings.Default'a kaydet
            Properties.Settings.Default.DataSource = txtDataSource.Text;
            Properties.Settings.Default.InitialCatalog = txtInitialCatalog.Text;
            Properties.Settings.Default.UserId = txtUserId.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.IntegratedSecurity = checkIntegratedSecurity.Checked;
            Properties.Settings.Default.TrustedServerCertificate = checkTrustedServerCertificate.Checked;

            // Değişiklikleri kaydet
            Properties.Settings.Default.Save();
            MessageBox.Show("Değerler başarıyla kaydedildi.\nUygulamayı yeniden başlatılacaktır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewDatabase_CellClick(object sender, DataGridViewCellEventArgs e) => LoadDatabaseValuesToTextBoxes();

        private void btnSaveProperties_Click(object sender, EventArgs e)
        {
            var values = new DBConnection
            {
                DataSource = txtDataSource.Text,
                InitialCatalog = txtInitialCatalog.Text,
                UserId = txtUserId.Text,
                Password = txtPassword.Text,
                IntegratedSecurity = checkIntegratedSecurity.Checked,
                TrustedServerCertificate = checkTrustedServerCertificate.Checked,
            };
            var validator = new DBConnectionValidator();
            var validationResult = validator.Validate(values);

            if (validationResult.IsValid)
            {

                SaveValuesToProperties();
                GetDatabaseValues();
                lblChildInformation.Visible = IsChild;
                lblChildInformation.ForeColor = Color.Green;
                lblChildInformation.Text = "Bağlantı başarılı.\nAyarlar default olarak kayıt edildi.";
                UpdateEntityFrameworkConnectionString();
                Application.Restart();
            }
            else
            {
                btnInformation.Text = string.Join("\n", validationResult);
                btnInformation.ForeColor = Color.Yellow;
                btnInformation.IconColor = Color.Yellow;
                lblChildInformation.Visible = IsChild;
                lblChildInformation.Text = string.Join ("\n", validationResult);
                lblChildInformation.ForeColor = Color.Red;
                return;
            }
        }

        private void UpdateEntityFrameworkConnectionString()
        {
            // Yeni connection string değerlerini oluştur
            string newProviderConnectionString = $"data source={Properties.Settings.Default.DataSource};" +
                                                 $"initial catalog={Properties.Settings.Default.InitialCatalog};" +
                                                 $"integrated security={Properties.Settings.Default.IntegratedSecurity};" +
                                                 $"user id={Properties.Settings.Default.UserId};" +
                                                 $"password={Properties.Settings.Default.Password};" +
                                                 "trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";

            // Metadata bilgilerini koruyarak yeni connection string'i birleştir
            string newConnectionString = $"metadata=res://*/Models.FinancialCrmDb.csdl|res://*/Models.FinancialCrmDb.ssdl|res://*/Models.FinancialCrmDb.msl;" +
                                         $"provider=System.Data.SqlClient;provider connection string=\"{newProviderConnectionString}\"";

            // Yeni bağlantı dizgesinin doğruluğunu test et
            if (!TestDatabaseConnection(newProviderConnectionString))
            {
                //MessageBox.Show("Veritabanı bağlantısı başarısız! Lütfen bilgilerinizi kontrol edin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // app.config'i yükle
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            // Mevcut connection string'i güncelle
            var connectionStringsSection = config.ConnectionStrings.ConnectionStrings["FinancialCrmDbEntities"];
            if (connectionStringsSection != null)
            {
                connectionStringsSection.ConnectionString = newConnectionString;
            }
            else
            {
                // Eğer yoksa yeni bir bağlantı ekleyin
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings
                {
                    Name = "FinancialCrmDbEntities",
                    ConnectionString = newConnectionString,
                    ProviderName = "System.Data.EntityClient"
                });
            }

            // Değişiklikleri kaydet
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("connectionStrings");

            //MessageBox.Show("Connection string başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private bool TestDatabaseConnection(string connectionString)
        {
            try
            {
                // Bağlantıyı kontrol et
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open(); // Bağlantıyı açmayı dener
                }
                return true; // Başarılı
            }
            catch (Exception ex)
            {
                // Hata oluşursa false döner
                //MessageBox.Show($"Veritabanı bağlantı testi başarısız: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        private void btnFormClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
