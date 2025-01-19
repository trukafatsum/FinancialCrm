using System.Windows.Forms;

namespace FinancialCrm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.headerPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanelHeader = new System.Windows.Forms.TableLayoutPanel();
            this.leftHeaderPanel = new System.Windows.Forms.Panel();
            this.btnLogo = new FontAwesome.Sharp.IconButton();
            this.centerHeaderPanel = new System.Windows.Forms.Panel();
            this.rightHeaderPanel = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.footerPanel = new System.Windows.Forms.Panel();
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.btnBills = new FontAwesome.Sharp.IconButton();
            this.btnCloseApp = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnDashboard = new FontAwesome.Sharp.IconButton();
            this.btnBankProcesses = new FontAwesome.Sharp.IconButton();
            this.btnSpendings = new FontAwesome.Sharp.IconButton();
            this.btnBanks = new FontAwesome.Sharp.IconButton();
            this.btnCategories = new FontAwesome.Sharp.IconButton();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.notifyIconMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.headerPanel.SuspendLayout();
            this.tableLayoutPanelHeader.SuspendLayout();
            this.leftHeaderPanel.SuspendLayout();
            this.rightHeaderPanel.SuspendLayout();
            this.sidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.headerPanel.Controls.Add(this.tableLayoutPanelHeader);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1024, 36);
            this.headerPanel.TabIndex = 0;
            // 
            // tableLayoutPanelHeader
            // 
            this.tableLayoutPanelHeader.ColumnCount = 3;
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178F));
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanelHeader.Controls.Add(this.leftHeaderPanel, 0, 0);
            this.tableLayoutPanelHeader.Controls.Add(this.centerHeaderPanel, 1, 0);
            this.tableLayoutPanelHeader.Controls.Add(this.rightHeaderPanel, 2, 0);
            this.tableLayoutPanelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHeader.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelHeader.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelHeader.Name = "tableLayoutPanelHeader";
            this.tableLayoutPanelHeader.RowCount = 1;
            this.tableLayoutPanelHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHeader.Size = new System.Drawing.Size(1024, 36);
            this.tableLayoutPanelHeader.TabIndex = 0;
            // 
            // leftHeaderPanel
            // 
            this.leftHeaderPanel.Controls.Add(this.btnLogo);
            this.leftHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftHeaderPanel.Location = new System.Drawing.Point(3, 3);
            this.leftHeaderPanel.Name = "leftHeaderPanel";
            this.leftHeaderPanel.Size = new System.Drawing.Size(172, 30);
            this.leftHeaderPanel.TabIndex = 0;
            // 
            // btnLogo
            // 
            this.btnLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLogo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLogo.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogo.IconSize = 24;
            this.btnLogo.Location = new System.Drawing.Point(0, 0);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(172, 30);
            this.btnLogo.TabIndex = 0;
            this.btnLogo.Text = "Default";
            this.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // centerHeaderPanel
            // 
            this.centerHeaderPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.centerHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerHeaderPanel.Location = new System.Drawing.Point(181, 3);
            this.centerHeaderPanel.Name = "centerHeaderPanel";
            this.centerHeaderPanel.Size = new System.Drawing.Size(726, 30);
            this.centerHeaderPanel.TabIndex = 1;
            this.centerHeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.centerHeaderPanel_MouseDown);
            // 
            // rightHeaderPanel
            // 
            this.rightHeaderPanel.Controls.Add(this.btnMinimize);
            this.rightHeaderPanel.Controls.Add(this.btnMaximize);
            this.rightHeaderPanel.Controls.Add(this.btnExit);
            this.rightHeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightHeaderPanel.Location = new System.Drawing.Point(910, 0);
            this.rightHeaderPanel.Margin = new System.Windows.Forms.Padding(0);
            this.rightHeaderPanel.Name = "rightHeaderPanel";
            this.rightHeaderPanel.Size = new System.Drawing.Size(114, 36);
            this.rightHeaderPanel.TabIndex = 2;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnMinimize.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 32;
            this.btnMinimize.Location = new System.Drawing.Point(6, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(36, 36);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Tag = "";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            this.btnMaximize.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 32;
            this.btnMaximize.Location = new System.Drawing.Point(42, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(36, 36);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Sienna;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SandyBrown;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.btnExit.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 32;
            this.btnExit.Location = new System.Drawing.Point(78, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(36, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.TabStop = false;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // footerPanel
            // 
            this.footerPanel.BackColor = System.Drawing.Color.Sienna;
            this.footerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footerPanel.Location = new System.Drawing.Point(0, 544);
            this.footerPanel.Name = "footerPanel";
            this.footerPanel.Size = new System.Drawing.Size(1024, 32);
            this.footerPanel.TabIndex = 1;
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(90)))), ((int)(((byte)(57)))));
            this.sidebarPanel.Controls.Add(this.btnBills);
            this.sidebarPanel.Controls.Add(this.btnCloseApp);
            this.sidebarPanel.Controls.Add(this.btnSettings);
            this.sidebarPanel.Controls.Add(this.btnDashboard);
            this.sidebarPanel.Controls.Add(this.btnBankProcesses);
            this.sidebarPanel.Controls.Add(this.btnSpendings);
            this.sidebarPanel.Controls.Add(this.btnBanks);
            this.sidebarPanel.Controls.Add(this.btnCategories);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 36);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(178, 508);
            this.sidebarPanel.TabIndex = 2;
            // 
            // btnBills
            // 
            this.btnBills.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBills.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBills.FlatAppearance.BorderSize = 0;
            this.btnBills.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBills.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            this.btnBills.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBills.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBills.IconSize = 32;
            this.btnBills.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBills.Location = new System.Drawing.Point(0, 94);
            this.btnBills.Name = "btnBills";
            this.btnBills.Size = new System.Drawing.Size(178, 41);
            this.btnBills.TabIndex = 2;
            this.btnBills.Text = "Faturalar";
            this.btnBills.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBills.UseVisualStyleBackColor = false;
            this.btnBills.Click += new System.EventHandler(this.btnBills_Click);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseApp.FlatAppearance.BorderSize = 0;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.IconChar = FontAwesome.Sharp.IconChar.Expeditedssl;
            this.btnCloseApp.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCloseApp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCloseApp.IconSize = 32;
            this.btnCloseApp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCloseApp.Location = new System.Drawing.Point(0, 329);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(178, 41);
            this.btnCloseApp.TabIndex = 7;
            this.btnCloseApp.Text = "Çıkış Yap";
            this.btnCloseApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Gears;
            this.btnSettings.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSettings.Location = new System.Drawing.Point(0, 282);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(178, 41);
            this.btnSettings.TabIndex = 6;
            this.btnSettings.Text = "Ayarlar";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.SandyBrown;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnDashboard.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDashboard.IconSize = 32;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDashboard.Location = new System.Drawing.Point(0, 235);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(178, 41);
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnBankProcesses
            // 
            this.btnBankProcesses.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBankProcesses.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBankProcesses.FlatAppearance.BorderSize = 0;
            this.btnBankProcesses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBankProcesses.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassChart;
            this.btnBankProcesses.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBankProcesses.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBankProcesses.IconSize = 32;
            this.btnBankProcesses.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBankProcesses.Location = new System.Drawing.Point(0, 188);
            this.btnBankProcesses.Name = "btnBankProcesses";
            this.btnBankProcesses.Size = new System.Drawing.Size(178, 41);
            this.btnBankProcesses.TabIndex = 4;
            this.btnBankProcesses.Text = "Banka Hareketleri";
            this.btnBankProcesses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBankProcesses.UseVisualStyleBackColor = false;
            this.btnBankProcesses.Click += new System.EventHandler(this.btnBankProcesses_Click);
            // 
            // btnSpendings
            // 
            this.btnSpendings.BackColor = System.Drawing.Color.SandyBrown;
            this.btnSpendings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpendings.FlatAppearance.BorderSize = 0;
            this.btnSpendings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpendings.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnSpendings.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSpendings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSpendings.IconSize = 32;
            this.btnSpendings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpendings.Location = new System.Drawing.Point(0, 141);
            this.btnSpendings.Name = "btnSpendings";
            this.btnSpendings.Size = new System.Drawing.Size(178, 41);
            this.btnSpendings.TabIndex = 3;
            this.btnSpendings.Text = "Giderler";
            this.btnSpendings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpendings.UseVisualStyleBackColor = false;
            this.btnSpendings.Click += new System.EventHandler(this.btnSpendings_Click);
            // 
            // btnBanks
            // 
            this.btnBanks.BackColor = System.Drawing.Color.SandyBrown;
            this.btnBanks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanks.FlatAppearance.BorderSize = 0;
            this.btnBanks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanks.IconChar = FontAwesome.Sharp.IconChar.SackDollar;
            this.btnBanks.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBanks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBanks.IconSize = 32;
            this.btnBanks.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanks.Location = new System.Drawing.Point(0, 47);
            this.btnBanks.Name = "btnBanks";
            this.btnBanks.Size = new System.Drawing.Size(178, 41);
            this.btnBanks.TabIndex = 1;
            this.btnBanks.Text = "Bankalar";
            this.btnBanks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanks.UseVisualStyleBackColor = false;
            this.btnBanks.Click += new System.EventHandler(this.btnBanks_Click);
            // 
            // btnCategories
            // 
            this.btnCategories.BackColor = System.Drawing.Color.SandyBrown;
            this.btnCategories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategories.FlatAppearance.BorderSize = 0;
            this.btnCategories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategories.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnCategories.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCategories.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCategories.IconSize = 32;
            this.btnCategories.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCategories.Location = new System.Drawing.Point(0, 0);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(178, 41);
            this.btnCategories.TabIndex = 0;
            this.btnCategories.Text = "Kategoriler";
            this.btnCategories.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategories.UseVisualStyleBackColor = false;
            this.btnCategories.Click += new System.EventHandler(this.btnCategories_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.SystemColors.Desktop;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(178, 36);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(846, 508);
            this.contentPanel.TabIndex = 3;
            // 
            // notifyIconMain
            // 
            this.notifyIconMain.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconMain.Icon")));
            this.notifyIconMain.Text = "Financial Crm";
            this.notifyIconMain.Visible = true;
            this.notifyIconMain.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIconMain_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.footerPanel);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.tableLayoutPanelHeader.ResumeLayout(false);
            this.leftHeaderPanel.ResumeLayout(false);
            this.rightHeaderPanel.ResumeLayout(false);
            this.sidebarPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel headerPanel;
        private Panel footerPanel;
        private Panel sidebarPanel;
        private Panel contentPanel;
        private FontAwesome.Sharp.IconButton btnCategories;
        private FontAwesome.Sharp.IconButton btnCloseApp;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnDashboard;
        private FontAwesome.Sharp.IconButton btnBankProcesses;
        private FontAwesome.Sharp.IconButton btnSpendings;
        private FontAwesome.Sharp.IconButton btnBills;
        private FontAwesome.Sharp.IconButton btnBanks;
        private TableLayoutPanel tableLayoutPanelHeader;
        private Panel leftHeaderPanel;
        private Panel centerHeaderPanel;
        private Panel rightHeaderPanel;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnLogo;
        private NotifyIcon notifyIconMain;
        private ToolTip toolTip1;
    }
}

