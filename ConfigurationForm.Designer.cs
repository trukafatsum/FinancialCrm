namespace FinancialCrm
{
    partial class ConfigurationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.btnInformation = new FontAwesome.Sharp.IconButton();
            this.btnFormClose = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.databaseControlPanel = new System.Windows.Forms.Panel();
            this.btnSaveProperties = new FontAwesome.Sharp.IconButton();
            this.databaseControlAccessPanel = new System.Windows.Forms.Panel();
            this.checkTrustedServerCertificate = new System.Windows.Forms.CheckBox();
            this.checkIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtInitialCatalog = new System.Windows.Forms.TextBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.databasePanel = new System.Windows.Forms.Panel();
            this.dataGridViewDatabase = new System.Windows.Forms.DataGridView();
            this.databaseTitlePanel = new System.Windows.Forms.Panel();
            this.btnDatabaseInfo = new FontAwesome.Sharp.IconButton();
            this.lblChildInformation = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.databaseControlPanel.SuspendLayout();
            this.databaseControlAccessPanel.SuspendLayout();
            this.databasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).BeginInit();
            this.databaseTitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.SaddleBrown;
            this.headerPanel.Controls.Add(this.btnInformation);
            this.headerPanel.Controls.Add(this.btnFormClose);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.ForeColor = System.Drawing.Color.PapayaWhip;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(417, 42);
            this.headerPanel.TabIndex = 0;
            // 
            // btnInformation
            // 
            this.btnInformation.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnInformation.FlatAppearance.BorderSize = 0;
            this.btnInformation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SaddleBrown;
            this.btnInformation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SaddleBrown;
            this.btnInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformation.IconChar = FontAwesome.Sharp.IconChar.Code;
            this.btnInformation.IconColor = System.Drawing.Color.PapayaWhip;
            this.btnInformation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInformation.IconSize = 42;
            this.btnInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformation.Location = new System.Drawing.Point(0, 0);
            this.btnInformation.Name = "btnInformation";
            this.btnInformation.Size = new System.Drawing.Size(369, 42);
            this.btnInformation.TabIndex = 1;
            this.btnInformation.Text = "Veri Tabanı Konfigürasyonu";
            this.btnInformation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInformation.UseVisualStyleBackColor = true;
            this.btnInformation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragForm_MouseDown);
            // 
            // btnFormClose
            // 
            this.btnFormClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFormClose.FlatAppearance.BorderSize = 0;
            this.btnFormClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormClose.IconChar = FontAwesome.Sharp.IconChar.Remove;
            this.btnFormClose.IconColor = System.Drawing.Color.PapayaWhip;
            this.btnFormClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFormClose.IconSize = 42;
            this.btnFormClose.Location = new System.Drawing.Point(375, 0);
            this.btnFormClose.Name = "btnFormClose";
            this.btnFormClose.Size = new System.Drawing.Size(42, 42);
            this.btnFormClose.TabIndex = 0;
            this.btnFormClose.UseVisualStyleBackColor = true;
            this.btnFormClose.Click += new System.EventHandler(this.btnFormClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.databaseControlPanel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.databaseControlAccessPanel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.databasePanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(417, 466);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // databaseControlPanel
            // 
            this.databaseControlPanel.Controls.Add(this.lblChildInformation);
            this.databaseControlPanel.Controls.Add(this.btnSaveProperties);
            this.databaseControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseControlPanel.Location = new System.Drawing.Point(3, 392);
            this.databaseControlPanel.Name = "databaseControlPanel";
            this.databaseControlPanel.Size = new System.Drawing.Size(411, 71);
            this.databaseControlPanel.TabIndex = 6;
            // 
            // btnSaveProperties
            // 
            this.btnSaveProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProperties.BackColor = System.Drawing.Color.DarkOrange;
            this.btnSaveProperties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProperties.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.btnSaveProperties.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnSaveProperties.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.btnSaveProperties.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProperties.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveProperties.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSaveProperties.IconColor = System.Drawing.Color.NavajoWhite;
            this.btnSaveProperties.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaveProperties.Location = new System.Drawing.Point(280, 9);
            this.btnSaveProperties.Name = "btnSaveProperties";
            this.btnSaveProperties.Size = new System.Drawing.Size(122, 53);
            this.btnSaveProperties.TabIndex = 5;
            this.btnSaveProperties.Text = "Kaydet";
            this.btnSaveProperties.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSaveProperties.UseVisualStyleBackColor = false;
            this.btnSaveProperties.Click += new System.EventHandler(this.btnSaveProperties_Click);
            // 
            // databaseControlAccessPanel
            // 
            this.databaseControlAccessPanel.Controls.Add(this.checkTrustedServerCertificate);
            this.databaseControlAccessPanel.Controls.Add(this.checkIntegratedSecurity);
            this.databaseControlAccessPanel.Controls.Add(this.txtPassword);
            this.databaseControlAccessPanel.Controls.Add(this.txtUserId);
            this.databaseControlAccessPanel.Controls.Add(this.txtInitialCatalog);
            this.databaseControlAccessPanel.Controls.Add(this.txtDataSource);
            this.databaseControlAccessPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databaseControlAccessPanel.Location = new System.Drawing.Point(3, 320);
            this.databaseControlAccessPanel.Name = "databaseControlAccessPanel";
            this.databaseControlAccessPanel.Size = new System.Drawing.Size(411, 66);
            this.databaseControlAccessPanel.TabIndex = 4;
            // 
            // checkTrustedServerCertificate
            // 
            this.checkTrustedServerCertificate.AutoSize = true;
            this.checkTrustedServerCertificate.Location = new System.Drawing.Point(259, 38);
            this.checkTrustedServerCertificate.Name = "checkTrustedServerCertificate";
            this.checkTrustedServerCertificate.Size = new System.Drawing.Size(155, 23);
            this.checkTrustedServerCertificate.TabIndex = 7;
            this.checkTrustedServerCertificate.Text = "Trusted Server Cert.";
            this.checkTrustedServerCertificate.UseVisualStyleBackColor = true;
            // 
            // checkIntegratedSecurity
            // 
            this.checkIntegratedSecurity.AutoSize = true;
            this.checkIntegratedSecurity.Location = new System.Drawing.Point(259, 5);
            this.checkIntegratedSecurity.Name = "checkIntegratedSecurity";
            this.checkIntegratedSecurity.Size = new System.Drawing.Size(150, 23);
            this.checkIntegratedSecurity.TabIndex = 6;
            this.checkIntegratedSecurity.Text = "Integrated Security";
            this.checkIntegratedSecurity.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPassword.BackColor = System.Drawing.Color.SandyBrown;
            this.txtPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtPassword.Location = new System.Drawing.Point(131, 3);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(122, 27);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.Tag = "Password";
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // txtUserId
            // 
            this.txtUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserId.BackColor = System.Drawing.Color.SandyBrown;
            this.txtUserId.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtUserId.Location = new System.Drawing.Point(3, 3);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.Size = new System.Drawing.Size(122, 27);
            this.txtUserId.TabIndex = 4;
            this.txtUserId.Tag = "UserID";
            this.txtUserId.Text = "UserID";
            this.txtUserId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUserId.Enter += new System.EventHandler(this.TextBoxPlaceHolder_Enter);
            this.txtUserId.Leave += new System.EventHandler(this.TextBoxPlaceHolder_Leave);
            // 
            // txtInitialCatalog
            // 
            this.txtInitialCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtInitialCatalog.BackColor = System.Drawing.Color.SandyBrown;
            this.txtInitialCatalog.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtInitialCatalog.Location = new System.Drawing.Point(131, 36);
            this.txtInitialCatalog.Name = "txtInitialCatalog";
            this.txtInitialCatalog.Size = new System.Drawing.Size(122, 27);
            this.txtInitialCatalog.TabIndex = 3;
            this.txtInitialCatalog.Tag = "Database";
            this.txtInitialCatalog.Text = "Database";
            this.txtInitialCatalog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtInitialCatalog.Enter += new System.EventHandler(this.TextBoxPlaceHolder_Enter);
            this.txtInitialCatalog.Leave += new System.EventHandler(this.TextBoxPlaceHolder_Leave);
            // 
            // txtDataSource
            // 
            this.txtDataSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDataSource.BackColor = System.Drawing.Color.SandyBrown;
            this.txtDataSource.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtDataSource.Location = new System.Drawing.Point(3, 35);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(122, 27);
            this.txtDataSource.TabIndex = 2;
            this.txtDataSource.Tag = "Data Source";
            this.txtDataSource.Text = "Data Source";
            this.txtDataSource.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDataSource.Enter += new System.EventHandler(this.TextBoxPlaceHolder_Enter);
            this.txtDataSource.Leave += new System.EventHandler(this.TextBoxPlaceHolder_Leave);
            // 
            // databasePanel
            // 
            this.databasePanel.Controls.Add(this.dataGridViewDatabase);
            this.databasePanel.Controls.Add(this.databaseTitlePanel);
            this.databasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.databasePanel.Location = new System.Drawing.Point(3, 3);
            this.databasePanel.Name = "databasePanel";
            this.databasePanel.Padding = new System.Windows.Forms.Padding(6);
            this.databasePanel.Size = new System.Drawing.Size(411, 311);
            this.databasePanel.TabIndex = 2;
            // 
            // dataGridViewDatabase
            // 
            this.dataGridViewDatabase.AllowUserToAddRows = false;
            this.dataGridViewDatabase.AllowUserToDeleteRows = false;
            this.dataGridViewDatabase.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.dataGridViewDatabase.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDatabase.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridViewDatabase.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewDatabase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewDatabase.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDatabase.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewDatabase.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDatabase.EnableHeadersVisualStyles = false;
            this.dataGridViewDatabase.GridColor = System.Drawing.Color.Sienna;
            this.dataGridViewDatabase.Location = new System.Drawing.Point(6, 45);
            this.dataGridViewDatabase.Name = "dataGridViewDatabase";
            this.dataGridViewDatabase.ReadOnly = true;
            this.dataGridViewDatabase.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDatabase.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewDatabase.RowHeadersWidth = 28;
            this.dataGridViewDatabase.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.dataGridViewDatabase.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridViewDatabase.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.dataGridViewDatabase.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewDatabase.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewDatabase.Size = new System.Drawing.Size(399, 260);
            this.dataGridViewDatabase.TabIndex = 6;
            this.dataGridViewDatabase.TabStop = false;
            this.dataGridViewDatabase.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDatabase_CellClick);
            this.dataGridViewDatabase.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewDatabase_CellFormatting);
            // 
            // databaseTitlePanel
            // 
            this.databaseTitlePanel.Controls.Add(this.btnDatabaseInfo);
            this.databaseTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.databaseTitlePanel.Location = new System.Drawing.Point(6, 6);
            this.databaseTitlePanel.Name = "databaseTitlePanel";
            this.databaseTitlePanel.Size = new System.Drawing.Size(399, 39);
            this.databaseTitlePanel.TabIndex = 5;
            // 
            // btnDatabaseInfo
            // 
            this.btnDatabaseInfo.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnDatabaseInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDatabaseInfo.FlatAppearance.BorderSize = 0;
            this.btnDatabaseInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatabaseInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDatabaseInfo.ForeColor = System.Drawing.Color.Moccasin;
            this.btnDatabaseInfo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDatabaseInfo.IconColor = System.Drawing.Color.Moccasin;
            this.btnDatabaseInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDatabaseInfo.Location = new System.Drawing.Point(0, 0);
            this.btnDatabaseInfo.Name = "btnDatabaseInfo";
            this.btnDatabaseInfo.Size = new System.Drawing.Size(399, 39);
            this.btnDatabaseInfo.TabIndex = 1;
            this.btnDatabaseInfo.Text = "Veritabanı Bilgileri";
            this.btnDatabaseInfo.UseVisualStyleBackColor = false;
            // 
            // lblChildInformation
            // 
            this.lblChildInformation.AutoSize = true;
            this.lblChildInformation.ForeColor = System.Drawing.Color.Blue;
            this.lblChildInformation.Location = new System.Drawing.Point(9, 9);
            this.lblChildInformation.Name = "lblChildInformation";
            this.lblChildInformation.Size = new System.Drawing.Size(103, 19);
            this.lblChildInformation.TabIndex = 6;
            this.lblChildInformation.Text = "Bilgilendirme*";
            this.lblChildInformation.Visible = false;
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(417, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.headerPanel);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.SaddleBrown;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConfigurationForm";
            this.Load += new System.EventHandler(this.ConfigurationForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.databaseControlPanel.ResumeLayout(false);
            this.databaseControlPanel.PerformLayout();
            this.databaseControlAccessPanel.ResumeLayout(false);
            this.databaseControlAccessPanel.PerformLayout();
            this.databasePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDatabase)).EndInit();
            this.databaseTitlePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel databaseControlPanel;
        private FontAwesome.Sharp.IconButton btnSaveProperties;
        private System.Windows.Forms.Panel databaseControlAccessPanel;
        private System.Windows.Forms.CheckBox checkTrustedServerCertificate;
        private System.Windows.Forms.CheckBox checkIntegratedSecurity;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.TextBox txtInitialCatalog;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Panel databasePanel;
        private System.Windows.Forms.DataGridView dataGridViewDatabase;
        private System.Windows.Forms.Panel databaseTitlePanel;
        private FontAwesome.Sharp.IconButton btnDatabaseInfo;
        private FontAwesome.Sharp.IconButton btnFormClose;
        private FontAwesome.Sharp.IconButton btnInformation;
        private System.Windows.Forms.Label lblChildInformation;
    }
}