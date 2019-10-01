using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace scrublords
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Modele1.init();
            Modele1.trouvVisiteurId("a13");
            Modele3.init();
            Modele3.trouvVisiteurId("a13");
            Application.Run(new Menu());
        }
    }
}
