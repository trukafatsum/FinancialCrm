using FinancialCrm.Models;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace FinancialCrm.childForms
{
    public partial class BanksForm : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public BanksForm()
        {
            InitializeComponent();

            Panel[] panels = { processPanel1, processPanel2, processPanel3, processPanel4, processPanel5 };
            // Panellere renkleri "Tag" özelliği ile veriyoruz.
            SetColorTagPanels(panels);
            LoadPanels();

        }

        private void SetColorTagPanels(Panel[] panels)
        {
            int index = 0;
            foreach (Panel panel in panels)
            {
                if (index == 1 || index == 3)
                {
                    panel.Tag = new { MouseEnterColor = Color.FloralWhite, MouseLeaveColor = Color.Wheat };
                }
                else
                {
                    panel.Tag = new { MouseEnterColor = Color.FloralWhite, MouseLeaveColor = Color.PapayaWhip };
                }
                index++;
            }
        }
        private void SetLocationBalanceLabels(Label label, Panel panel)
        {
            int width, height;
            width = panel.Width - (label.Width + 3);
            height = panel.Height - (label.Height + 6);
            label.Location = new Point(width, height);
        }

        private void BanksForm_Load(object sender, EventArgs e)
        {
            GetBankBalances();
            GetBankTitleAccNo();
            GetBankProcesses();
        }
        private void GetBankTitleAccNo()
        {
            var ziraatAccNo = db.Banks
                .Where(x => x.BankTitle == "Ziraat Bankası")
                .Select(y => y.BankAccountNumber)
                .FirstOrDefault();

            var vakifBankAccNo = db.Banks
                .Where(x => x.BankTitle == "Vakıfbank")
                .Select(y => y.BankAccountNumber)
                .FirstOrDefault();

            var isBankAccNo = db.Banks
                .Where(x => x.BankTitle == "İş Bankası")
                .Select(y => y.BankAccountNumber)
                .FirstOrDefault();

        }
        private void LoadPanels()
        {

            var banks = db.Banks.ToList();
            
            int panelHeight = 114;
            int panelWidth = this.Width / 3 - 9;
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
            tableLayoutPanel.Controls.Add(layoutPanel);

            if (!banks.Any())
            {
                Panel panel = new Panel
                {
                    Size = new Size(panelWidth, panelHeight),
                    BackColor = Color.Moccasin,
                    Margin = new Padding(padding),
                    Tag = new { MouseEnterColor = Color.FloralWhite, MouseLeaveColor = Color.Wheat },
                };

                panel.MouseEnter += (sender, e) => Panel_MouseEnter(sender, e);
                panel.MouseLeave += (sender, e) => Panel_MouseLeave(sender, e);

                System.Windows.Forms.Label lblBankInfo = new System.Windows.Forms.Label
                {
                    Text = "Banka bilgisi bulunamadı.",
                    Font = new Font("Calibri", 12, FontStyle.Bold),
                    ForeColor = Color.FromArgb(101, 67, 33),
                    Location = new Point(9, 9),
                    AutoSize = true
                };

                panel.Controls.Add(lblBankInfo);
                layoutPanel.Controls.Add(panel);
                return;
            }

            foreach (var bank in banks)
            {
                // Panel oluşturma
                Panel panel = new Panel
                {
                    Size = new Size(panelWidth, panelHeight),
                    BackColor = Color.Moccasin,
                    Margin = new Padding(padding),
                    Tag = new { MouseEnterColor = Color.FloralWhite, MouseLeaveColor = Color.Wheat },
                };

                panel.MouseEnter += (sender, e) => Panel_MouseEnter(sender,e);
                panel.MouseLeave += (sender, e) => Panel_MouseLeave(sender, e);

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
                bankNo.Click += (sender, e) => accountNoButton_Click(bankNo, sender, e); 
                bankNo.FlatAppearance.BorderSize = 0;
                panel.Controls.Add(bankNo);

                // Paneli TableLayoutPanel'e ekle
                layoutPanel.Controls.Add(panel);

                SetLocationBalanceLabels(lblBankBalance, panel);
            }
        }
        private void GetBankBalances()
        {
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).Sum();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).Sum();
            var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).Sum();
        }

        private void GetBankProcesses()
        {
            var bankProcesses = db.BankProcesses
                .OrderByDescending(x => x.BankProcessId)
                .Take(5)
                .ToList();

            var labels = new[] { lblProcess1, lblProcess2, lblProcess3, lblProcess4, lblProcess5 };

            for (int i = 0; i < bankProcesses.Count; i++)
            {
                var processDate = bankProcesses[i].ProcessDate.HasValue
                    ? bankProcesses[i].ProcessDate.Value.ToString("dd.MM.yyyy")
                    : "Tarih Bulunamadı";

                var amount = bankProcesses[i].Amount.HasValue
                    ? bankProcesses[i].Amount.Value.ToString("f0") : "";
                labels[i].Text =
                    $"📅{processDate} \n İşlem Türü: {bankProcesses[i].ProcessType.PadRight(12)} | Miktar :{amount.PadLeft(5)}₺ | Açıklama : {bankProcesses[i].Description}";
            }
        }

        private void accountNoButton_Click(IconButton button, object sender, EventArgs e)
        {
            Clipboard.SetText(button.Text);
            toolTip1.Show("Panoya kopyalandı!", button, button.Width/ 2, button.Height, 2000);
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Panel üzerinde fare hareketi başladığında rengi değiştir.
                dynamic tag = panel.Tag;
                panel.BackColor = tag.MouseEnterColor;

                // Panel içindeki tüm bileşenlerin MouseEnter olayını dinleyerek, rengin panelin içinde kalmasını sağlıyoruz
                foreach (Control control in panel.Controls)
                {
                    control.MouseEnter += (subSender, subEventArgs) =>
                    {
                        // Bileşenin üzerine gelindiğinde, fare panelin üzerine kaldığı sürece renk değişikliğini engelle
                        panel.BackColor = tag.MouseEnterColor;
                    };
                }
            }
        }
        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel != null)
            {
                // Tag'den renkleri alıyoruz.
                dynamic tag = panel.Tag;
                panel.BackColor = tag.MouseLeaveColor;
            }
        }
    }
}
