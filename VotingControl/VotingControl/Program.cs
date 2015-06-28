using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingControl
{
    static class Program
    {
        /// <summary>
        /// Objeto de conexão com o banco
        /// </summary>
        public static MySqlConnection Connection = new MySqlConnection(Properties.Settings.Default.votingcontrolConnectionString);

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal("Ronaldo"));
        }
    }
}
