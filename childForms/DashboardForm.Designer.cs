namespace FinancialCrm.childForms
{
    partial class DashboardForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contentPanel1 = new System.Windows.Forms.Panel();
            this.lblBankTitle = new System.Windows.Forms.Label();
            this.contentControlPanel1 = new System.Windows.Forms.Panel();
            this.btnRandom1 = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.contentPanel2 = new System.Windows.Forms.Panel();
            this.lblBillTitle = new System.Windows.Forms.Label();
            this.contentControlPanel2 = new System.Windows.Forms.Panel();
            this.btnRandom2 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contentPanel3 = new System.Windows.Forms.Panel();
            this.lblLastBankProcess = new System.Windows.Forms.Label();
            this.contentControlPanel3 = new System.Windows.Forms.Panel();
            this.btnRandom3 = new FontAwesome.Sharp.IconButton();
            this.greetingsPanel = new System.Windows.Forms.Panel();
            this.btnClock = new FontAwesome.Sharp.IconButton();
            this.lblGreetingsMessage = new System.Windows.Forms.Label();
            this.accountNoBank = new FontAwesome.Sharp.IconButton();
            this.lblBankBalance = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.btnProcessDate = new FontAwesome.Sharp.IconButton();
            this.lblProcessAmount = new System.Windows.Forms.Label();
            this.lblProcessBankTitle = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.contentPanel1.SuspendLayout();
            this.contentControlPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contentPanel2.SuspendLayout();
            this.contentControlPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.contentPanel3.SuspendLayout();
            this.contentControlPanel3.SuspendLayout();
            this.greetingsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.greetingsPanel, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(846, 508);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(840, 422);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.contentPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(274, 416);
            this.panel1.TabIndex = 5;
            // 
            // contentPanel1
            // 
            this.contentPanel1.BackColor = System.Drawing.Color.Moccasin;
            this.contentPanel1.Controls.Add(this.lblBankBalance);
            this.contentPanel1.Controls.Add(this.accountNoBank);
            this.contentPanel1.Controls.Add(this.lblBankTitle);
            this.contentPanel1.Controls.Add(this.contentControlPanel1);
            this.contentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentPanel1.Location = new System.Drawing.Point(3, 3);
            this.contentPanel1.Name = "contentPanel1";
            this.contentPanel1.Size = new System.Drawing.Size(268, 178);
            this.contentPanel1.TabIndex = 0;
            this.contentPanel1.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.contentPanel1.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
            // 
            // lblBankTitle
            // 
            this.lblBankTitle.AutoSize = true;
            this.lblBankTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankTitle.Location = new System.Drawing.Point(9, 9);
            this.lblBankTitle.Name = "lblBankTitle";
            this.lblBankTitle.Size = new System.Drawing.Size(121, 19);
            this.lblBankTitle.TabIndex = 1;
            this.lblBankTitle.Text = "Toplam Bakiyem";
            // 
            // contentControlPanel1
            // 
            this.contentControlPanel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.contentControlPanel1.Controls.Add(this.btnRandom1);
            this.contentControlPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contentControlPanel1.ForeColor = System.Drawing.Color.Moccasin;
            this.contentControlPanel1.Location = new System.Drawing.Point(0, 142);
            this.contentControlPanel1.Name = "contentControlPanel1";
            this.contentControlPanel1.Size = new System.Drawing.Size(268, 36);
            this.contentControlPanel1.TabIndex = 0;
            // 
            // btnRandom1
            // 
            this.btnRandom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRandom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom1.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.btnRandom1.IconColor = System.Drawing.Color.Moccasin;
            this.btnRandom1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRandom1.IconSize = 36;
            this.btnRandom1.Location = new System.Drawing.Point(0, 0);
            this.btnRandom1.Name = "btnRandom1";
            this.btnRandom1.Size = new System.Drawing.Size(268, 36);
            this.btnRandom1.TabIndex = 0;
            this.btnRandom1.UseVisualStyleBackColor = true;
            this.btnRandom1.Click += new System.EventHandler(this.btnRandom1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.contentPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(283, 3);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(274, 416);
            this.panel2.TabIndex = 6;
            // 
            // contentPanel2
            // 
            this.contentPanel2.BackColor = System.Drawing.Color.Moccasin;
            this.contentPanel2.Controls.Add(this.lblPeriod);
            this.contentPanel2.Controls.Add(this.lblAmount);
            this.contentPanel2.Controls.Add(this.lblBillTitle);
            this.contentPanel2.Controls.Add(this.contentControlPanel2);
            this.contentPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentPanel2.Location = new System.Drawing.Point(3, 3);
            this.contentPanel2.Name = "contentPanel2";
            this.contentPanel2.Size = new System.Drawing.Size(268, 178);
            this.contentPanel2.TabIndex = 1;
            this.contentPanel2.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.contentPanel2.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
            // 
            // lblBillTitle
            // 
            this.lblBillTitle.AutoSize = true;
            this.lblBillTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBillTitle.Location = new System.Drawing.Point(9, 9);
            this.lblBillTitle.Name = "lblBillTitle";
            this.lblBillTitle.Size = new System.Drawing.Size(71, 19);
            this.lblBillTitle.TabIndex = 2;
            this.lblBillTitle.Text = "Faturalar";
            // 
            // contentControlPanel2
            // 
            this.contentControlPanel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.contentControlPanel2.Controls.Add(this.btnRandom2);
            this.contentControlPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contentControlPanel2.ForeColor = System.Drawing.Color.Moccasin;
            this.contentControlPanel2.Location = new System.Drawing.Point(0, 142);
            this.contentControlPanel2.Name = "contentControlPanel2";
            this.contentControlPanel2.Size = new System.Drawing.Size(268, 36);
            this.contentControlPanel2.TabIndex = 1;
            // 
            // btnRandom2
            // 
            this.btnRandom2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRandom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom2.IconChar = FontAwesome.Sharp.IconChar.Random;
            this.btnRandom2.IconColor = System.Drawing.Color.Moccasin;
            this.btnRandom2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRandom2.IconSize = 36;
            this.btnRandom2.Location = new System.Drawing.Point(0, 0);
            this.btnRandom2.Name = "btnRandom2";
            this.btnRandom2.Size = new System.Drawing.Size(268, 36);
            this.btnRandom2.TabIndex = 1;
            this.btnRandom2.UseVisualStyleBackColor = true;
            this.btnRandom2.Click += new System.EventHandler(this.btnRandom2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.contentPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(563, 3);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(274, 416);
            this.panel3.TabIndex = 7;
            // 
            // contentPanel3
            // 
            this.contentPanel3.BackColor = System.Drawing.Color.Moccasin;
            this.contentPanel3.Controls.Add(this.lblProcessBankTitle);
            this.contentPanel3.Controls.Add(this.lblProcessAmount);
            this.contentPanel3.Controls.Add(this.btnProcessDate);
            this.contentPanel3.Controls.Add(this.lblLastBankProcess);
            this.contentPanel3.Controls.Add(this.contentControlPanel3);
            this.contentPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentPanel3.Location = new System.Drawing.Point(3, 3);
            this.contentPanel3.Name = "contentPanel3";
            this.contentPanel3.Size = new System.Drawing.Size(268, 178);
            this.contentPanel3.TabIndex = 1;
            this.contentPanel3.MouseEnter += new System.EventHandler(this.Panel_MouseEnter);
            this.contentPanel3.MouseLeave += new System.EventHandler(this.Panel_MouseLeave);
            // 
            // lblLastBankProcess
            // 
            this.lblLastBankProcess.AutoSize = true;
            this.lblLastBankProcess.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLastBankProcess.Location = new System.Drawing.Point(9, 9);
            this.lblLastBankProcess.Name = "lblLastBankProcess";
            this.lblLastBankProcess.Size = new System.Drawing.Size(128, 19);
            this.lblLastBankProcess.TabIndex = 3;
            this.lblLastBankProcess.Text = "Son Gelen Havale";
            // 
            // contentControlPanel3
            // 
            this.contentControlPanel3.BackColor = System.Drawing.Color.SaddleBrown;
            this.contentControlPanel3.Controls.Add(this.btnRandom3);
            this.contentControlPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contentControlPanel3.ForeColor = System.Drawing.Color.Moccasin;
            this.contentControlPanel3.Location = new System.Drawing.Point(0, 142);
            this.contentControlPanel3.Name = "contentControlPanel3";
            this.contentControlPanel3.Size = new System.Drawing.Size(268, 36);
            this.contentControlPanel3.TabIndex = 1;
            // 
            // btnRandom3
            // 
            this.btnRandom3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRandom3.Enabled = false;
            this.btnRandom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRandom3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRandom3.IconColor = System.Drawing.Color.Moccasin;
            this.btnRandom3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRandom3.IconSize = 36;
            this.btnRandom3.Location = new System.Drawing.Point(0, 0);
            this.btnRandom3.Name = "btnRandom3";
            this.btnRandom3.Size = new System.Drawing.Size(268, 36);
            this.btnRandom3.TabIndex = 1;
            this.btnRandom3.UseVisualStyleBackColor = true;
            // 
            // greetingsPanel
            // 
            this.greetingsPanel.Controls.Add(this.btnClock);
            this.greetingsPanel.Controls.Add(this.lblGreetingsMessage);
            this.greetingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.greetingsPanel.Location = new System.Drawing.Point(3, 3);
            this.greetingsPanel.Name = "greetingsPanel";
            this.greetingsPanel.Size = new System.Drawing.Size(840, 74);
            this.greetingsPanel.TabIndex = 1;
            // 
            // btnClock
            // 
            this.btnClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClock.FlatAppearance.BorderSize = 0;
            this.btnClock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClock.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClock.IconChar = FontAwesome.Sharp.IconChar.HourglassHalf;
            this.btnClock.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.btnClock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClock.IconSize = 20;
            this.btnClock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClock.Location = new System.Drawing.Point(750, 3);
            this.btnClock.Name = "btnClock";
            this.btnClock.Size = new System.Drawing.Size(81, 28);
            this.btnClock.TabIndex = 6;
            this.btnClock.Text = "23:59";
            this.btnClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClock.UseVisualStyleBackColor = true;
            // 
            // lblGreetingsMessage
            // 
            this.lblGreetingsMessage.AutoSize = true;
            this.lblGreetingsMessage.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGreetingsMessage.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblGreetingsMessage.Location = new System.Drawing.Point(9, 6);
            this.lblGreetingsMessage.Name = "lblGreetingsMessage";
            this.lblGreetingsMessage.Size = new System.Drawing.Size(344, 39);
            this.lblGreetingsMessage.TabIndex = 0;
            this.lblGreetingsMessage.Text = "Hoş geldiniz, [Ad Soyad]!";
            // 
            // accountNoBank
            // 
            this.accountNoBank.FlatAppearance.BorderSize = 0;
            this.accountNoBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accountNoBank.Font = new System.Drawing.Font("Calibri", 8F);
            this.accountNoBank.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.accountNoBank.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.accountNoBank.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.accountNoBank.IconSize = 16;
            this.accountNoBank.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.accountNoBank.Location = new System.Drawing.Point(10, 28);
            this.accountNoBank.Margin = new System.Windows.Forms.Padding(0);
            this.accountNoBank.Name = "accountNoBank";
            this.accountNoBank.Size = new System.Drawing.Size(192, 20);
            this.accountNoBank.TabIndex = 6;
            this.accountNoBank.Text = "TR";
            this.accountNoBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.accountNoBank.UseCompatibleTextRendering = true;
            this.accountNoBank.UseVisualStyleBackColor = false;
            this.accountNoBank.Click += new System.EventHandler(this.accountNoBank_Click);
            // 
            // lblBankBalance
            // 
            this.lblBankBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBankBalance.AutoSize = true;
            this.lblBankBalance.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBankBalance.Location = new System.Drawing.Point(96, 80);
            this.lblBankBalance.Name = "lblBankBalance";
            this.lblBankBalance.Size = new System.Drawing.Size(169, 59);
            this.lblBankBalance.TabIndex = 7;
            this.lblBankBalance.Text = "00.00 ₺";
            this.lblBankBalance.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAmount.Location = new System.Drawing.Point(96, 81);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(169, 59);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "00.00 ₺";
            // 
            // lblPeriod
            // 
            this.lblPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPeriod.Location = new System.Drawing.Point(180, 10);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(79, 19);
            this.lblPeriod.TabIndex = 4;
            this.lblPeriod.Text = "Ocak 2025";
            // 
            // btnProcessDate
            // 
            this.btnProcessDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnProcessDate.FlatAppearance.BorderSize = 0;
            this.btnProcessDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcessDate.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnProcessDate.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.btnProcessDate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.btnProcessDate.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnProcessDate.IconSize = 24;
            this.btnProcessDate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcessDate.Location = new System.Drawing.Point(154, 7);
            this.btnProcessDate.Name = "btnProcessDate";
            this.btnProcessDate.Size = new System.Drawing.Size(107, 25);
            this.btnProcessDate.TabIndex = 4;
            this.btnProcessDate.Text = "10.10.2025";
            this.btnProcessDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProcessDate.UseVisualStyleBackColor = true;
            // 
            // lblProcessAmount
            // 
            this.lblProcessAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProcessAmount.AutoSize = true;
            this.lblProcessAmount.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProcessAmount.Location = new System.Drawing.Point(96, 81);
            this.lblProcessAmount.Name = "lblProcessAmount";
            this.lblProcessAmount.Size = new System.Drawing.Size(169, 59);
            this.lblProcessAmount.TabIndex = 5;
            this.lblProcessAmount.Text = "00.00 ₺";
            // 
            // lblProcessBankTitle
            // 
            this.lblProcessBankTitle.AutoSize = true;
            this.lblProcessBankTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProcessBankTitle.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblProcessBankTitle.Location = new System.Drawing.Point(9, 29);
            this.lblProcessBankTitle.Name = "lblProcessBankTitle";
            this.lblProcessBankTitle.Size = new System.Drawing.Size(73, 19);
            this.lblProcessBankTitle.TabIndex = 6;
            this.lblProcessBankTitle.Text = "BankTitle";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(846, 508);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(67)))), ((int)(((byte)(33)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.contentPanel1.ResumeLayout(false);
            this.contentPanel1.PerformLayout();
            this.contentControlPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.contentPanel2.ResumeLayout(false);
            this.contentPanel2.PerformLayout();
            this.contentControlPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.contentPanel3.ResumeLayout(false);
            this.contentPanel3.PerformLayout();
            this.contentControlPanel3.ResumeLayout(false);
            this.greetingsPanel.ResumeLayout(false);
            this.greetingsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel greetingsPanel;
        private System.Windows.Forms.Label lblGreetingsMessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel contentPanel1;
        private System.Windows.Forms.Panel contentPanel2;
        private System.Windows.Forms.Panel contentPanel3;
        private System.Windows.Forms.Panel contentControlPanel1;
        private System.Windows.Forms.Panel contentControlPanel2;
        private System.Windows.Forms.Panel contentControlPanel3;
        private FontAwesome.Sharp.IconButton btnRandom1;
        private FontAwesome.Sharp.IconButton btnRandom2;
        private FontAwesome.Sharp.IconButton btnRandom3;
        private FontAwesome.Sharp.IconButton btnClock;
        private System.Windows.Forms.Label lblBankTitle;
        private System.Windows.Forms.Label lblBillTitle;
        private System.Windows.Forms.Label lblLastBankProcess;
        private FontAwesome.Sharp.IconButton accountNoBank;
        private System.Windows.Forms.Label lblBankBalance;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblPeriod;
        private FontAwesome.Sharp.IconButton btnProcessDate;
        private System.Windows.Forms.Label lblProcessAmount;
        private System.Windows.Forms.Label lblProcessBankTitle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
    }
}