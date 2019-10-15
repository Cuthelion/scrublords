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
            bsvisiteur.DataSource = Modele1.VisiteurConnecte;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection("Data Source=Srublords_PPE3;Initial Catalog=BDD;User ID=Scrublords;Password=Btssio2");
            string query = " Select password From VISITEUR ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.Add("@nomvisiteur", textBox1);
            command.Parameters.Add("@password", textBox2);
            connection.Open();
            string result = (string)command.ExecuteScalar();
           
            connection.Close();






        }




           Form InfosVistiteurs = new FInfosVistiteurs();
           InfosVistiteurs.ShowDialog();
        }

        
    }
    }