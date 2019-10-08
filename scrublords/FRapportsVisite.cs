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
    public partial class FRapportsVisite : Form
    {
        public FRapportsVisite()
        {
            InitializeComponent();
            //LES RAPPORTS

            bsRapports.DataSource = Modele3.listeRapVis();
            bsOffrir.DataSource = Modele3.listeoffrir();
            dgvOffrir.DataSource = bsOffrir;

            dgvOffrir.Columns[0].Visible = false;
            dgvOffrir.Columns[3].Visible = false;
            dgvOffrir.Columns[4].Visible = false;

            dgvOffrir.Columns[1].HeaderText = "Médicament";
            dgvOffrir.Columns[2].HeaderText = "Quantité";

        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            //Les Praticiens
            cbPraticien.ValueMember = "idMedecin";
            cbPraticien.DisplayMember = "nom";
            bsMedecins.DataSource = Modele3.listeMedecins();
            cbPraticien.DataSource = bsMedecins;
            //Les Motifs
            cbMotif.ValueMember = "idMotif";
            cbMotif.DisplayMember = "libMotif";
            bsMotifs.DataSource = Modele3.listeMotif();
            cbMotif.DataSource = bsMotifs;
        }
      
        private void CbPraticien_Format(object sender, ListControlConvertEventArgs e)
        {
            string nomprenom = string.Concat(((MEDECIN)e.ListItem).nom, " ", ((MEDECIN)e.ListItem).prenom);
            e.Value = nomprenom;
        }

        private void Details_Click(object sender, EventArgs e)
        {
            System.Type type = bsMedecins.Current.GetType();
            var id = (int)type.GetProperty("idMedecin").GetValue(bsMedecins.Current, null);
            Modele3.trouverMedecinId(id);
            Form Details = new FDetails();
            Details.ShowDialog();
        }
    }
}