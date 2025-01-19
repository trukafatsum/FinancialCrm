using FinancialCrm.childForms;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        private bool ?isHiddenForm;
        int userId;
        ContextMenuStrip contextMenu = new ContextMenuStrip();
        public MainForm(int _userId,LoginForm _loginForm)
        {
            InitializeComponent();
            this.btnExit.Click += (sender, e) => Application.Exit();
            this.btnMaximize.Click += (sender, e) => WindowState = (WindowState != FormWindowState.Maximized ? FormWindowState.Maximized : FormWindowState.Normal);
            this.btnMinimize.Click += (sender, e) => HideShowForm();
            notifyIconMain.Icon = this.Icon;
            userId = _userId;
            loginForm = _loginForm;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            contextMenu.Items.Add("Göster",null,(s,args) => HideShowForm());
            contextMenu.Items.Add("Çıkış Yap",null,(s,args) => this.Close());
            notifyIconMain.ContextMenuStrip = contextMenu;
            OpenChildForm(new childForms.DashboardForm(userId));
            ActivatedButton(btnDashboard);
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

        #region ChildForm Method
        /// <summary>
        /// Opens the specified child form inside the content panel.
        /// If a form is already open in the content panel, the existing form is closed before the new one is loaded.
        /// </summary>
        /// <param name="childForm">The child form to be opened.</param>
        private void OpenChildForm(Form childForm)
        {
            // ContentPanel içinde zaten açık bir form varsa temizler
            if (this.contentPanel.Controls.Count > 0)
            {
                this.contentPanel.Controls[0].Dispose();
            }

            // Yeni formu ayarla
            childForm.TopLevel = false; // Form'un TopLevel olmasını devre dışı bırakır
            childForm.FormBorderStyle = FormBorderStyle.None; // Kenarlıkları kaldırır
            childForm.Dock = DockStyle.Fill; // ContentPanel'i kaplasın

            // ContentPanel'e form'u ekle ve göster
            this.contentPanel.Controls.Add(childForm);
            this.contentPanel.Tag = childForm;
            btnLogo.Text = childForm.Text;
            childForm.Show();
        }
        #endregion

        #region Sidebar Buttons & Hide/Show Form Method
        /// <summary>
        /// Toggles the form's visibility and updates the context menu text. <br/>
        /// Checks the <see cref="isHiddenForm"/> field to determine the current visibility state.
        /// </summary>
        private void HideShowForm()
        {
            if (isHiddenForm == false || isHiddenForm == null)
            {
                this.Hide();
                notifyIconMain.ShowBalloonTip(1000, "Bilgilendirme", "Uygulama arka planda çalışmaya devam ediyor.", ToolTipIcon.Info);
                isHiddenForm = true;
                contextMenu.Items[0].Text = "Göster";
            }
            else 
            {
                this.Show();
                isHiddenForm = false;
                contextMenu.Items[0].Text = "Gizle";
            }
        }

        private void ActivatedButton(IconButton button)
        {
            btnLogo.Text = button.Text;
            btnLogo.IconChar = button.IconChar;
        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.CategoriesForm());
            ActivatedButton(btnCategories);
        }

        private void btnBanks_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.BanksForm());
            ActivatedButton(btnBanks);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.BillsForm());
            ActivatedButton(btnBills);
        }

        private void btnSpendings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.SpendingsForm());
            ActivatedButton(btnSpendings);
        }

        private void btnBankProcesses_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.BankProcessesForm());
            ActivatedButton(btnBankProcesses);
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.DashboardForm(userId));
            ActivatedButton(btnDashboard);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new childForms.SettingsForm());
            ActivatedButton(btnSettings);
        }

        private void notifyIconMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            HideShowForm();
        }


        #endregion

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.Show("Gizemli buton!",btnMinimize,btnMinimize.Width,btnMinimize.Height,1000);
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.IsLoggedOut = true;
            Properties.Settings.Default.Save();
            loginForm.Show();
            this.Close();
        }
    }
}
