using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrublords
{
    public partial class FGestionVisiteur : Form
    {

        public FGestionVisiteur()
        {
            InitializeComponent();
            //bsvisiteur.DataSource = Modele1.VisiteurConnecte;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            //FGestionVisiteur.Close();  
            Form infosvisiteur = new FInfosVistiteurs();
        }
    }
}
            
                                    
           
        






        
    
