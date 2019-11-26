using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrublords
{
    public partial class FRemboursements : Form
    {
        private int i = 0;
        public FRemboursements()
        {
            InitializeComponent();
            bsvisiteur.DataSource = Modele3.listficheFrais(Modele3.VisiteurConnecte3.idVisiteur);
            dataGridView1.DataSource = bsvisiteur;
            lbnbfiches.Text = "Vous avez actuellement " + bsvisiteur.Count.ToString() + " fiches de remboursements";
            do
            {
                if(i<1 || i>=5)
                {
                    dataGridView1.Columns[i].Visible = false;
                }
                i++;
            } while (i <= 9);
           
        }

        private void FRemboursements_Load(object sender, EventArgs e)
        {
            lbNom.Text = "Bienvenue "+ Modele3.VisiteurConnecte3.prenom + ", voici vos fiches de remboursement";
           
        }

        private void ButtonCnlt_Click(object sender, EventArgs e)
        {
            System.Type type = bsvisiteur.Current.GetType();
            string mois = (string)type.GetProperty("mois").GetValue(bsvisiteur.Current, null);
            string id = (string)type.GetProperty("idEtat").GetValue(bsvisiteur.Current, null);
            if (id == "CR")
            {
                FFicheRemboursementCompleter Fiche = new FFicheRemboursementCompleter((fichefrais)bsvisiteur.Current);
                Fiche.ShowDialog();
                bsvisiteur.MoveLast();
                bsvisiteur.MoveFirst();
            }
            else
            {
                MessageBox.Show("Fiche cloturée, vous ne pouvez plus saisir d'informations");
            }
        }

        private void ButtonCmplt_Click(object sender, EventArgs e)
        {
            System.Type type = bsvisiteur.Current.GetType();
            string mois = (string)type.GetProperty("mois").GetValue(bsvisiteur.Current, null);
            FFicheRembousementConsulter Fiche = new FFicheRembousementConsulter((fichefrais)bsvisiteur.Current);
            Fiche.Show();
        }
    }
}
