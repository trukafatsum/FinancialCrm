using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm.childForms
{
    public partial class BanksForm : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        public BanksForm()
        {
            InitializeComponent();

            Panel[] panels = { contentPanel1, contentPanel2, contentPanel3, processPanel1, processPanel2, processPanel3, processPanel4, processPanel5 };
            // Panellere renkleri "Tag" özelliği ile veriyoruz.
            SetColorTagPanels(panels);

        }
        private void SetColorTagPanels(Panel[] panels)
        {
            int index = 0;
            foreach (Panel panel in panels)
            {
                if (index < 3)
                {
                    panel.Tag = new { MouseEnterColor = Color.PapayaWhip, MouseLeaveColor = Color.Moccasin };
                }
                else if (index == 3 || index == 5)
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

            accountNoZiraatbank.Text += ziraatAccNo ?? "Hesap numarası bulunamadı";
            accountNoVakifbank.Text += vakifBankAccNo ?? "Hesap numarası bulunamadı";
            accountNoIsbank.Text += isBankAccNo ?? "Hesap numarası bulunamadı";
        }

        private void GetBankBalances()
        {
            var ziraatBankBalance = db.Banks.Where(x => x.BankTitle == "Ziraat Bankası").Select(y => y.BankBalance).Sum();
            var vakifBankBalance = db.Banks.Where(x => x.BankTitle == "Vakıfbank").Select(y => y.BankBalance).Sum();
            var isBankBalance = db.Banks.Where(x => x.BankTitle == "İş Bankası").Select(y => y.BankBalance).Sum();
            lblZiraatBankBalance.Text = ziraatBankBalance.ToString() + " ₺";
            lblVakifBankBalance.Text = vakifBankBalance.ToString() + " ₺";
            lblIsBankBalance.Text = isBankBalance.ToString() + " ₺";
            SetLocationBalanceLabels(lblZiraatBankBalance, contentPanel1);
            SetLocationBalanceLabels(lblVakifBankBalance, contentPanel2);
            SetLocationBalanceLabels(lblIsBankBalance, contentPanel3);
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

        private void accountNoZiraatbank_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(accountNoZiraatbank.Text);
            toolTip1.Show("Panoya kopyalandı!", accountNoZiraatbank, accountNoZiraatbank.Width / 2, accountNoZiraatbank.Height, 2000);
        }

        private void accountNoVakifbank_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(accountNoVakifbank.Text);
            toolTip1.Show("Panoya kopyalandı!", accountNoVakifbank, accountNoVakifbank.Width / 2, accountNoVakifbank.Height, 2000);
        }

        private void accountNoIsbank_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(accountNoIsbank.Text);
            toolTip1.Show("Panoya kopyalandı!", accountNoIsbank, accountNoIsbank.Width / 2, accountNoIsbank.Height, 2000);
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
