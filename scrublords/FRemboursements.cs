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
        public FRemboursements()
        {
            InitializeComponent();
            bsvisiteur.DataSource = Modele3.listficheFrais(Modele3.VisiteurConnecte3.idVisiteur);
            dataGridView1.DataSource = bsvisiteur;
            lbnbfiches.Text = "Vous avez actuellement " + bsvisiteur.Count.ToString() + " fiches de remboursements";
        }

        private void FRemboursements_Load(object sender, EventArgs e)
        {
            lbNom.Text = "Bienvenue "+ Modele3.VisiteurConnecte3.prenom + ", voici vos fiches de remboursement";
           
        }

        private void ButtonCnlt_Click(object sender, EventArgs e)
        {
            System.Type type = bsvisiteur.Current.GetType();
            string mois = (string)type.GetProperty("mois").GetValue(bsvisiteur.Current, null);
            MessageBox.Show(bsvisiteur.Current.GetType().ToString());
            FFicheRemboursementCompleter Fiche = new FFicheRemboursementCompleter((fichefrais)bsvisiteur.Current);
            Fiche.ShowDialog();
        }

        private void DataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
        }
    }
}
