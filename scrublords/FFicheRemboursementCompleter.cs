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
    public partial class FFicheRemboursementCompleter : Form
    {
        public FFicheRemboursementCompleter(fichefrais fiche)
        {
            InitializeComponent();
            labMois.Text = fiche.mois;
            LigneFraisForfait ligneETP = Modele3.trouveLignefrais("ETP");
            quaNui.Value = Decimal.Parse(ligneETP.quantite.ToString());
            Matricule.Text = Modele3.VisiteurConnecte3.idVisiteur;
            nom.Text = Modele3.VisiteurConnecte3.nom+ " " + Modele3.VisiteurConnecte3.prenom;
            labTotNui.Text = (quaNui.Value * monUniNui.Value).ToString();
            labTotRep.Text = (quaRep.Value * monUniRep.Value).ToString();
            labTotKil.Text = (quaKil.Value * monUniKil.Value).ToString();
        }

        private void QuaNui_ValueChanged(object sender, EventArgs e)
        {
            labTotNui.Text = (quaNui.Value * monUniNui.Value).ToString();
        }

        private void QuaRep_ValueChanged(object sender, EventArgs e)
        {
            labTotRep.Text = (quaRep.Value * monUniRep.Value).ToString();
        }

        private void QuaKil_ValueChanged(object sender, EventArgs e)
        {
            labTotKil.Text = (quaKil.Value * monUniKil.Value).ToString();
        }

        private void MonUniKil_ValueChanged(object sender, EventArgs e)
        {
            labTotKil.Text = (quaKil.Value * monUniKil.Value).ToString();
        }
    }
}
