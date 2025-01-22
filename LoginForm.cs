using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Drag Event WinAPI
        // Windows API çağrısı
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        private void centerHeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }
        #endregion

        private void btnCollapse_Click(object sender, EventArgs e)
        {
            CollapseExtendPanel(leftImagePanel, !leftImagePanel.Visible);
            btnCollapse.IconChar = !leftImagePanel.Visible ? FontAwesome.Sharp.IconChar.ChevronRight : FontAwesome.Sharp.IconChar.ChevronLeft;
        }
        private void CollapseExtendPanel(Panel panel, bool visibility)
        {
            panel.Visible = visibility;
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

        private void btnGithub_Click(object sender, EventArgs e)
        {
            string url = "https://www.github.com/trukafatsum/";
            OpenWebsite(url);
        }

        private void btnLinkedIn_Click(object sender, EventArgs e)
        {
            string url = "https://www.linkedin.com/in/trukafatsum/";
            OpenWebsite(url);
        }

        private void btnYouTube_Click(object sender, EventArgs e)
        {
            string url = "https://www.youtube.com/@trukafatsum/";
            OpenWebsite(url);
        }
        private void OpenWebsite(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata!");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            int userId;
            if (!db.Users.Any())
            {
                userId = -1;
                Properties.Settings.Default.IsLoggedOut = false;
                Properties.Settings.Default.Save();
                MainForm mainForm = new MainForm(userId, this);
                mainForm.Show();
                SetTextBoxDefaultValues();
                this.Hide();
            }
            else if (!db.Users.Any(x => x.Username == username))
            {
                lblInformation.Text = "Kullanıcı adı geçersiz.";
            }
            else if (!db.Users.Any(x => x.Username == username && x.Password == password))
            {
                lblInformation.Text = "Şifre geçersiz.";
            }
            else
            {
                userId = db.Users.Where(x => x.Username == username && x.Password == password).Select(x => x.UserId).FirstOrDefault();
                Properties.Settings.Default.IsLoggedOut = false;
                Properties.Settings.Default.Save();
                MainForm mainForm = new MainForm(userId, this);
                mainForm.Show();
                SetTextBoxDefaultValues();
                this.Hide();
            }
        }
        private void SetTextBoxDefaultValues()
        {
            txtUsername.Text = txtUsername.Tag.ToString();
            txtPassword.Text = txtPassword.Tag.ToString();
        }
    }
}