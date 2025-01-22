using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.Models
{
    public class DBConnection
    {
        public DBConnection()
        {
            DataSource = Properties.Settings.Default.DataSource;
            InitialCatalog = Properties.Settings.Default.InitialCatalog;
            UserId = Properties.Settings.Default.UserId;
            Password = Properties.Settings.Default.Password;
            IntegratedSecurity = Properties.Settings.Default.IntegratedSecurity;
            TrustedServerCertificate = Properties.Settings.Default.TrustedServerCertificate;
        }

        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool IntegratedSecurity { get; set; }
        public bool TrustedServerCertificate { get; set; }
    }
}
