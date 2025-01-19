using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialCrm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool isConnected = IsConnectionCorrect();
            if (isConnected)
            {
                Application.Run(new LoginForm());
            }
            else
            {
                Application.Run(new ConfigurationForm());
            }
        }
        static bool IsConnectionCorrect()
        {
            string defaultConnectionString = $"data source={Properties.Settings.Default.DataSource};" +
                                                 $"initial catalog={Properties.Settings.Default.InitialCatalog};" +
                                                 $"integrated security={Properties.Settings.Default.IntegratedSecurity};" +
                                                 $"user id={Properties.Settings.Default.UserId};" +
                                                 $"password={Properties.Settings.Default.Password};" +
                                                 "trustservercertificate=True;MultipleActiveResultSets=True;App=EntityFramework";
            try
            {
                // Bağlantıyı kontrol et
                using (var connection = new SqlConnection(defaultConnectionString))
                {
                    connection.Open(); // Bağlantıyı açmayı dener
                }
                return true; // Başarılı
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"SQL hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show($"Bağlantı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bilinmeyen bir hata: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
