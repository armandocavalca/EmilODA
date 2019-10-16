using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmilODA
{
    static class Program
    {
        public static bool Valido;
        public static string myConnString = string.Format("Data Source={0};User Id={1};Password={2};Default Collection={3};ConnectionTimeout={4}", "192.168.1.100", "QSECOFR", "TRADING4", "$EMIEDATI", "60");

        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }
}
