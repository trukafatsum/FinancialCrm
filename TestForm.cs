using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            this.BackColor = Color.SaddleBrown;
            LoadPanels();
        }

        private void LoadPanels()
        {
            using (var context = new FinancialCrmDbEntities())
            {
                var banks = context.Banks.ToList();

                int panelHeight = 114;
                int panelWidth = this.Width/3 - 9;
                int padding = 3;

                // TableLayoutPanel Ayarları
                TableLayoutPanel layoutPanel = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = banks.Count, /* Math.Min(banks.Count, 3), // Örnek: Her satırda en fazla 3 panel*/
                    RowCount = 1, // Tek satırda veya (int)Math.Ceiling((double)banks.Count / 3)
                    AutoScroll = true,
                    Padding = new Padding(padding),
                };

                foreach (var bank in banks)
                {
                    // Panel oluşturma
                    Panel panel = new Panel
                    {
                        Size = new Size(panelWidth, panelHeight),
                        BackColor = Color.Moccasin,
                        Margin = new Padding(padding)
                    };

                    // Label 1 (BankTitle)
                    System.Windows.Forms.Label lblBankTitle = new System.Windows.Forms.Label
                    {
                        Text = bank.BankTitle,
                        Font = new Font("Calibri", 12, FontStyle.Bold),
                        ForeColor = Color.FromArgb(101, 67, 33),
                        Location = new Point(9, 9),
                        AutoSize = true
                    };
                    panel.Controls.Add(lblBankTitle);

                    // Label 2 (BankBalance)
                    System.Windows.Forms.Label lblBankBalance = new System.Windows.Forms.Label
                    {
                        Text = bank.BankBalance.ToString() + "₺",
                        Font = new Font("Calibri", 36, FontStyle.Bold),
                        ForeColor = Color.FromArgb(101, 67, 33),
                        Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                        Location = new Point(10, 40),
                        AutoSize = true
                    };
                    panel.Controls.Add(lblBankBalance);

                    // IconButton (BankAccountNumber)
                    FontAwesome.Sharp.IconButton bankNo = new FontAwesome.Sharp.IconButton
                    {
                        Text = bank.BankAccountNumber,
                        Location = new Point(8, 28),
                        Size = new Size(192, 20),
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Calibri", 8),
                        ForeColor = Color.FromArgb(101, 67, 33),
                        IconColor = Color.FromArgb(101, 67, 33),
                        IconChar = FontAwesome.Sharp.IconChar.Copy,
                        IconFont = FontAwesome.Sharp.IconFont.Solid,
                        IconSize = 16,
                        ImageAlign = ContentAlignment.MiddleRight,
                        TextAlign = ContentAlignment.MiddleLeft,
                        UseVisualStyleBackColor = false
                    };
                    bankNo.FlatAppearance.BorderSize = 0;
                    panel.Controls.Add(bankNo);

                    // Paneli TableLayoutPanel'e ekle
                    layoutPanel.Controls.Add(panel);

                    SetLocationBalanceLabels(lblBankBalance,panel);
                }

                // TableLayoutPanel'i forma ekle
                this.Controls.Add(layoutPanel);
            }
        }
        private void SetLocationBalanceLabels(System.Windows.Forms.Label label, Panel panel)
        {
            int width, height;
            width = panel.Width - (label.Width + 3);
            height = panel.Height - (label.Height + 6);
            label.Location = new Point(width, height);
        }
    }
}
