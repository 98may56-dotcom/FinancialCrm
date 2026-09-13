using System;
using System.Windows.Forms;
using FinancialCrm.Data;

namespace FinancialCrm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                DbInitializer.Initialize();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Veritabanına bağlanılamadı:\n" + ex.Message,
                    "Bağlantı Hatası",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new Form1());
        }
    }
}
