using FinancialCrm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm.childForms
{
    public partial class DashboardForm : Form
    {
        FinancialCrmDbEntities db = new FinancialCrmDbEntities();
        int userId;
        public DashboardForm(int _userId)
        {
            InitializeComponent();
            this.userId = _userId;
            contentPanel1.Tag = new { MouseEnterColor = Color.PapayaWhip, MouseLeaveColor = Color.Moccasin };
            contentPanel2.Tag = new { MouseEnterColor = Color.PapayaWhip, MouseLeaveColor = Color.Moccasin };
            contentPanel3.Tag = new { MouseEnterColor = Color.PapayaWhip, MouseLeaveColor = Color.Moccasin };
            timer1.Start();

        }
        byte indexByte1 = 4;
        byte indexByte2 = 0;
        private void btnRandom1_Click(object sender, EventArgs e)
        {
            GetContentValues1();
        }
        private void btnRandom2_Click(object sender, EventArgs e)
        {
            GetContentValues2();
        }
        private void SetLocationBalanceLabels(Label label, Panel panel, Panel panel2)
        {
            int width, height;
            width = panel.Width - (label.Width + 3);
            height = panel.Height - (label.Height + 3 + panel2.Height);
            label.Location = new Point(width, height);
        }
        private void GetGreetingsValues()
        {
            var values = db.Users.Where(x => x.UserId == userId).Select(x => new
            {
                x.Username,
                x.FirstName,
                x.LastName
            }).FirstOrDefault();
            lblGreetingsMessage.Text = $"Hoş geldiniz, {values.FirstName} {values.LastName}!";
        }
        private void GetContentValues1()
        {
            var values = db.Banks.Select(x => new
            {
                x.BankTitle,
                x.BankBalance,
                x.BankAccountNumber,
            }).ToList();

            if (indexByte1 <= values.Count - 1)
            {
                accountNoBank.Visible = true;
                lblBankTitle.Text = values[indexByte1].BankTitle;
                lblBankBalance.Text = values.Where(x => x.BankTitle == lblBankTitle.Text).Select(x => x.BankBalance).Sum().ToString() + " ₺";
                accountNoBank.Text = values.Where(x => x.BankTitle == lblBankTitle.Text).Select(y => y.BankAccountNumber).First();
                indexByte1++;
            }
            else
            {
                lblBankTitle.Text = "Toplam Bakiyem";
                accountNoBank.Visible = false;
                lblBankBalance.Text = values.Select(x => x.BankBalance).Sum().ToString() + " ₺";
                indexByte1 = 0;
            }
            SetLocationBalanceLabels(lblBankBalance, contentPanel1, contentControlPanel1);
        }
        private void GetContentValues2()
        {
            int lblPeriodLocX;
            var values = db.Bills.Select(x => new
            {
                x.BillTitle,
                x.BillAmount,
                x.BillPeriod
            }).ToList();

            // Eğer liste boşsa kontrol et
            if (values.Count == 0)
            {
                lblBillTitle.Text = "Veri yok";
                lblAmount.Text = "0 ₺";
                lblPeriod.Text = "Yok";

                // Label konumlarını yine de düzenlemek isterseniz
                lblPeriodLocX = contentPanel2.Width - (lblPeriod.Width + 6);
                lblPeriod.Location = new Point(lblPeriodLocX, 6);
                SetLocationBalanceLabels(lblAmount, contentPanel2, contentControlPanel2);

                return;
            }

            if (indexByte2 <= values.Count - 1)
            {
                lblBillTitle.Text = values[indexByte2].BillTitle;
                lblAmount.Text = values[indexByte2].BillAmount.ToString() + " ₺";
                lblPeriod.Text = values[indexByte2].BillPeriod.ToString();
                indexByte2++;
            }
            else
            {
                indexByte2 = 0;
                lblBillTitle.Text = values[indexByte2].BillTitle;
                lblAmount.Text = values[indexByte2].BillAmount.ToString() + " ₺";
                lblPeriod.Text = values[indexByte2].BillPeriod.ToString();
                indexByte2++;
            }

            lblPeriodLocX = contentPanel2.Width - (lblPeriod.Width + 6);
            lblPeriod.Location = new Point(lblPeriodLocX, 6);
            SetLocationBalanceLabels(lblAmount, contentPanel2, contentControlPanel2);
        }

        private void GetLastProcess()
        {
            var values = db.BankProcesses
                .Where(x => x.ProcessType == "Gelen Havale")
                .OrderByDescending(x => x.BankProcessId)
                .Select(y => new
                {
                    y.ProcessDate,
                    y.Amount,
                    y.Banks.BankTitle
                })
                .FirstOrDefault();

            // Null kontrolü
            if (values == null)
            {
                btnProcessDate.Text = "Veri yok";
                lblProcessAmount.Text = "0 ₺";
                lblProcessBankTitle.Text = "Banka bulunamadı";

                // Label konumlarını yine de düzenlemek isterseniz
                SetLocationBalanceLabels(lblProcessAmount, contentPanel3, contentControlPanel3);
                return;
            }

            DateTime lastProcessDate = DateTime.Parse(values.ProcessDate.ToString());
            decimal amount = decimal.Parse(values.Amount.ToString());

            btnProcessDate.Text = lastProcessDate.ToString("dd.MM.yyyy");
            lblProcessAmount.Text = amount.ToString("N2") + " ₺";
            lblProcessBankTitle.Text = values.BankTitle;

            SetLocationBalanceLabels(lblProcessAmount, contentPanel3, contentControlPanel3);
        }


        private void DashboardForm_Load(object sender, EventArgs e)
        {
            GetGreetingsValues();
            GetContentValues1();
            GetContentValues2();
            GetLastProcess();
        }

        private void accountNoBank_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(accountNoBank.Text);
            toolTip1.Show("Panoya kopyalandı!", accountNoBank, accountNoBank.Width / 2, accountNoBank.Height, 2000);
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

        byte indexTick = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            btnClock.Text = dateTime.ToString("HH:mm");
            FontAwesome.Sharp.IconChar[] iconChars = { FontAwesome.Sharp.IconChar.Hourglass1, FontAwesome.Sharp.IconChar.Hourglass2, FontAwesome.Sharp.IconChar.Hourglass3, FontAwesome.Sharp.IconChar.HourglassEmpty };

            if (indexTick < iconChars.Length - 1)
                indexTick++;
            else
                indexTick = 0;
            btnClock.IconChar = iconChars[indexTick];
        }
    }
}