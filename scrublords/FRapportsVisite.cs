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
            bsRapVis.DataSource = Modele3.listeRapVis();

        }

        private void FRapportsVisiteMedecin_Load(object sender,EventArgs e)
        {
            //Medecin
            comboRapVisPrat.ValueMember = "idMedecin";
            comboRapVisPrat.DisplayMember = "nom";
            bsMed.DataSource = Modele3.listeMedecins();
            comboRapVisPrat.DataSource = bsMed;
            //Infos
            RAPPORT rapporttemp = Modele3.leRapportChoisi;
            tbNumRap.Text = rapporttemp.idRapport.ToString();
            tbMotVis.Text = rapporttemp.MOTIF.libMotif;
        }

        private void bsRapVis_CurrentChanged(object sender,EventArgs e)
        {

            RAPPORT v = (RAPPORT)bsRapVis.Current;
            int x = v.idRapport;

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Form AjoutRapVis = new FAjoutRapVis();
            AjoutRapVis.ShowDialog();

        }
    }
}