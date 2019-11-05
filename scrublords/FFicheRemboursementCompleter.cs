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
        private fichefrais ficheCourante;
        public FFicheRemboursementCompleter(fichefrais fiche)
        {
            InitializeComponent();
            this.ficheCourante = fiche;
            labMois.Text = fiche.mois;
            try
            {
                quaNui.Value = decimal.Parse(Modele3.ligneFraisForfait("NUI", Modele3.VisiteurConnecte3.idVisiteur, fiche.mois).quantite.ToString());
            }
            catch(Exception e)
            {
                quaNui.Value = 0;
            }
            try
            {
                quaRep.Value = decimal.Parse(Modele3.ligneFraisForfait("REP", Modele3.VisiteurConnecte3.idVisiteur, fiche.mois).quantite.ToString());
            }
            catch (Exception e)
            {
                quaRep.Value = 0;
            }
            try
            {
                quaKil.Value = decimal.Parse(Modele3.ligneFraisForfait("KM ", Modele3.VisiteurConnecte3.idVisiteur, fiche.mois).quantite.ToString());
            }
            catch (Exception e)
            {
                quaKil.Value = 0;
            }
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

        private void Fermer_Click(object sender, EventArgs e)
        {
            decimal total = quaNui.Value * monUniNui.Value + quaRep.Value * monUniRep.Value + quaKil.Value * monUniKil.Value;
            Modele3.modifFicheFrais(ficheCourante, total);
            try
            {
                Modele3.modifLigneForfait(Modele3.ligneFraisForfait("NUI", Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois), int.Parse(quaNui.Value.ToString()));
            }
            catch(Exception e1)
            {   
                Modele3.insertLigneForfait(Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois, "NUI", int.Parse(quaNui.Value.ToString()));
            }
            try
            {
                Modele3.modifLigneForfait(Modele3.ligneFraisForfait("KM ", Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois), int.Parse(quaKil.Value.ToString()));
            }
            catch(Exception e2)
            {
                Modele3.insertLigneForfait(Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois, "KM ", int.Parse(quaKil.Value.ToString()));
            }
            try
            {
                Modele3.modifLigneForfait(Modele3.ligneFraisForfait("REP", Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois), int.Parse(quaRep.Value.ToString()));
            }
            catch(Exception e3)
            {
                Modele3.insertLigneForfait(Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois, "REP", int.Parse(quaRep.Value.ToString()));
            }

        }
    }
}
