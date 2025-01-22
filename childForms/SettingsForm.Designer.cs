namespace FinancialCrm.childForms
{
    partial class SettingsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutUserSettings = new System.Windows.Forms.TableLayoutPanel();
            this.userPanel = new System.Windows.Forms.Panel();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.userTitlePanel = new System.Windows.Forms.Panel();
            this.btnUserInfo = new FontAwesome.Sharp.IconButton();
            this.userControlAccessPanel = new System.Windows.Forms.Panel();
            this.btnStatus = new FontAwesome.Sharp.IconButton();
            this.numUpDownID = new System.Windows.Forms.NumericUpDown();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtUserPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.userControlPanel = new System.Windows.Forms.Panel();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnCreate = new FontAwesome.Sharp.IconButton();
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutUserSettings.SuspendLayout();
            this.userPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.userTitlePanel.SuspendLayout();
            this.userControlAccessPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownID)).BeginInit();
            this.userControlPanel.SuspendLayout();
            this.tableLayoutMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutUserSettings
            // 
            this.tableLayoutUserSettings.ColumnCount = 1;
            this.tableLayoutUserSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutUserSettings.Controls.Add(this.userPanel, 0, 0);
            this.tableLayoutUserSettings.Controls.Add(this.userControlAccessPanel, 0, 1);
            this.tableLayoutUserSettings.Controls.Add(this.userControlPanel, 0, 2);
            this.tableLayoutUserSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutUserSettings.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutUserSettings.Name = "tableLayoutUserSettings";
            this.tableLayoutUserSettings.RowCount = 3;
            this.tableLayoutUserSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutUserSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutUserSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutUserSettings.Size = new System.Drawing.Size(417, 502);
            this.tableLayoutUserSettings.TabIndex = 0;
            // 
            // userPanel
            // 
            this.userPanel.Controls.Add(this.dataGridViewUser);
            this.userPanel.Controls.Add(this.userTitlePanel);
            this.userPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userPanel.Location = new System.Drawing.Point(3, 3);
            this.userPanel.Name = "userPanel";
            this.userPanel.Padding = new System.Windows.Forms.Padding(6);
            this.userPanel.Size = new System.Drawing.Size(411, 347);
            this.userPanel.TabIndex = 0;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.AllowUserToAddRows = false;
            this.dataGridViewUser.AllowUserToDeleteRows = false;
            this.dataGridViewUser.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.dataGridViewUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUser.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGridViewUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridViewUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewUser.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUser.EnableHeadersVisualStyles = false;
            this.dataGridViewUser.GridColor = System.Drawing.Color.Sienna;
            this.dataGridViewUser.Location = new System.Drawing.Point(6, 45);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.ReadOnly = true;
            this.dataGridViewUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewUser.RowHeadersWidth = 28;
            this.dataGridViewUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.BurlyWood;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Moccasin;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.dataGridViewUser.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewUser.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.dataGridViewUser.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Orange;
            this.dataGridViewUser.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridViewUser.Size = new System.Drawing.Size(399, 296);
            this.dataGridViewUser.TabIndex = 1;
            this.dataGridViewUser.TabStop = false;
            this.dataGridViewUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUser_CellClick);
            this.dataGridViewUser.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewUser_CellFormatting);
            // 
            // userTitlePanel
            // 
            this.userTitlePanel.Controls.Add(this.btnUserInfo);
            this.userTitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userTitlePanel.Location = new System.Drawing.Point(6, 6);
            this.userTitlePanel.Name = "userTitlePanel";
            this.userTitlePanel.Size = new System.Drawing.Size(399, 39);
            this.userTitlePanel.TabIndex = 0;
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnUserInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUserInfo.FlatAppearance.BorderSize = 0;
            this.btnUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserInfo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUserInfo.ForeColor = System.Drawing.Color.Moccasin;
            this.btnUserInfo.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnUserInfo.IconColor = System.Drawing.Color.Moccasin;
            this.btnUserInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUserInfo.Location = new System.Drawing.Point(0, 0);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(399, 39);
            this.btnUserInfo.TabIndex = 0;
            this.btnUserInfo.Text = "Kullanıcı Bilgileri";
            this.btnUserInfo.UseVisualStyleBackColor = false;
            // 
            // userControlAccessPanel
            // 
            this.userControlAccessPanel.Controls.Add(this.btnStatus);
            this.userControlAccessPanel.Controls.Add(this.numUpDownID);
            this.userControlAccessPanel.Controls.Add(this.txtLastName);
            this.userControlAccessPanel.Controls.Add(this.txtFirstName);
            this.userControlAccessPanel.Controls.Add(this.txtUserPassword);
            this.userControlAccessPanel.Controls.Add(this.txtUserName);
            this.userControlAccessPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAccessPanel.Location = new System.Drawing.Point(3, 356);
            this.userControlAccessPanel.Name = "userControlAccessPanel";
            this.userControlAccessPanel.Size = new System.Drawing.Size(411, 66);
            this.userControlAccessPanel.TabIndex = 2;
            // 
            // btnStatus
            // 
            this.btnStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnStatus.BackColor = System.Drawing.Color.BurlyWood;
            this.btnStatus.FlatAppearance.BorderSize = 0;
            this.btnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatus.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnStatus.IconChar = FontAwesome.Sharp.IconChar.ToggleOff;
            this.btnStatus.IconColor = System.Drawing.SystemColors.HighlightText;
            this.btnStatus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnStatus.Location = new System.Drawing.Point(259, 36);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(122, 27);
            this.btnStatus.TabIndex = 6;
            this.btnStatus.UseVisualStyleBackColor = false;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // numUpDownID
            // 
            this.numUpDownID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.numUpDownID.BackColor = System.Drawing.Color.SandyBrown;
            this.numUpDownID.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.numUpDownID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.numUpDownID.Location = new System.Drawing.Point(259, 3);
            this.numUpDownID.Name = "numUpDownID";
            this.numUpDownID.Size = new System.Drawing.Size(122, 27);
            this.numUpDownID.TabIndex = 5;
            this.numUpDownID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLastName
            // 
            this.txtLastName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtLastName.BackColor = System.Drawing.Color.SandyBrown;
            this.txtLastName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtLastName.Location = new System.Drawing.Point(131, 36);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(122, 27);
            this.txtLastName.TabIndex = 4;
            this.txtLastName.Tag = "Lastname";
            this.txtLastName.Text = "Lastname";
            this.txtLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtLastName.Enter += new System.EventHandler(this.TextBoxPlaceHolder_Enter);
            this.txtLastName.Leave += new System.EventHandler(this.TextBoxPlaceHolder_Leave);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFirstName.BackColor = System.Drawing.Color.SandyBrown;
            this.txtFirstName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtFirstName.Location = new System.Drawing.Point(3, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(122, 27);
            this.txtFirstName.TabIndex = 3;
            this.txtFirstName.Tag = "Firstname";
            this.txtFirstName.Text = "Firstname";
            this.txtFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtFirstName.Enter += new System.EventHandler(this.TextBoxPlaceHolder_Enter);
            this.txtFirstName.Leave += new System.EventHandler(this.TextBoxPlaceHolder_Leave);
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserPassword.BackColor = System.Drawing.Color.SandyBrown;
            this.txtUserPassword.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtUserPassword.Location = new System.Drawing.Point(131, 3);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.Size = new System.Drawing.Size(122, 27);
            this.txtUserPassword.TabIndex = 2;
            this.txtUserPassword.Tag = "Password";
            this.txtUserPassword.Text = "Password";
            this.txtUserPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUserPassword.Enter += new System.EventHandler(this.TextBoxPassword_Enter);
            this.txtUserPassword.Leave += new System.EventHandler(this.TextBoxPassword_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtUserName.BackColor = System.Drawing.Color.SandyBrown;
            this.txtUserName.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txtUserName.Location = new System.Drawing.Point(3, 3);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(122, 27);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.Tag = "Username";
            this.txtUserName.Text = "Username";
            this.txtUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUserName.Enter += new System.EventHandler(this.TextBoxPlaceHolder_Enter);
            this.txtUserName.Leave += new System.EventHandler(this.TextBoxPlaceHolder_Leave);
            // 
            // userControlPanel
            // 
            this.userControlPanel.Controls.Add(this.btnUpdate);
            this.userControlPanel.Controls.Add(this.btnDelete);
            this.userControlPanel.Controls.Add(this.btnCreate);
            this.userControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlPanel.Location = new System.Drawing.Point(3, 428);
            this.userControlPanel.Name = "userControlPanel";
            this.userControlPanel.Size = new System.Drawing.Size(411, 71);
            this.userControlPanel.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.btnUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnUpdate.IconColor = System.Drawing.Color.NavajoWhite;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdate.Location = new System.Drawing.Point(285, 9);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(126, 53);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDelete.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.btnDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.UserLargeSlash;
            this.btnDelete.IconColor = System.Drawing.Color.NavajoWhite;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(144, 9);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(122, 53);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCreate.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.btnCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnCreate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(77)))));
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreate.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnCreate.IconColor = System.Drawing.Color.NavajoWhite;
            this.btnCreate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreate.Location = new System.Drawing.Point(3, 9);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(122, 53);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Ekle";
            this.btnCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 2;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.Controls.Add(this.tableLayoutUserSettings, 0, 0);
            this.tableLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 1;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.Size = new System.Drawing.Size(846, 508);
            this.tableLayoutMain.TabIndex = 1;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(846, 508);
            this.Controls.Add(this.tableLayoutMain);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.tableLayoutUserSettings.ResumeLayout(false);
            this.userPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.userTitlePanel.ResumeLayout(false);
            this.userControlAccessPanel.ResumeLayout(false);
            this.userControlAccessPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownID)).EndInit();
            this.userControlPanel.ResumeLayout(false);
            this.tableLayoutMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutUserSettings;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel userTitlePanel;
        private FontAwesome.Sharp.IconButton btnCreate;
        private System.Windows.Forms.Panel userControlAccessPanel;
        private System.Windows.Forms.Panel userControlPanel;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private FontAwesome.Sharp.IconButton btnUserInfo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private FontAwesome.Sharp.IconButton btnStatus;
        private System.Windows.Forms.NumericUpDown numUpDownID;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
    }
}