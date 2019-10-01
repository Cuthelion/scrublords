using System;
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
    public partial class FAjoutRapVis : Form
    {
        private string msgErreur;
        public FAjoutRapVis()
        {
            InitializeComponent();
        }

        private void FAjoutRapVis_Load(object sender,EventArgs e)
        {



        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.None;
            // Verif
            if (Control() == false)
            {
                MessageBox.Show(msgErreur, "Attention");
            }
            else
            {
                //init Var  
                DateTime date = dtpDate.Value;
                string bilan = rtbBilan.Text;

                //Créer Rapport
                RAPPORT newRapport = new RAPPORT();
                newRapport.dateRapport = date;
                newRapport.bilan = bilan;
                
                //Messagebox
                MessageBox.Show("Rapport Ajouté");
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }

        private bool Control()
        {
            msgErreur = "Erreur de saisie :\n";
            bool vretour = true;
            return vretour;
        }
    }
}
