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
    public partial class FFicheRembousementConsulter : Form
    {
        private Visiteur vis;
        public FFicheRembousementConsulter(fichefrais Fiche)
        {
            InitializeComponent();
            vis = Modele3.VisiteurConnecte3;
            Matricule.Text = vis.idVisiteur;
            nom.Text = vis.nom + " " + vis.prenom;
            labMois.Text = Fiche.mois;
            infNui.Text = Modele3.ligneFraisForfait("NUI", vis.idVisiteur, Fiche.mois).quantite.ToString() + " Nuit(s) à 80 € la nuit pour un total de " + Modele3.ligneFraisForfait("NUI", vis.idVisiteur, Fiche.mois).quantite * 80 + "€";
            infRep.Text = Modele3.ligneFraisForfait("REP", vis.idVisiteur, Fiche.mois).quantite.ToString() + " Repas à 25 € le repas pour un total de " + Modele3.ligneFraisForfait("REP", vis.idVisiteur, Fiche.mois).quantite * 25 + "€";
            infKil.Text = Modele3.ligneFraisForfait("KM ", vis.idVisiteur, Fiche.mois).quantite.ToString() + " Kilomètre(s) à 0,86 € le kilomètre pour un total de " + Modele3.ligneFraisForfait("KM ", vis.idVisiteur, Fiche.mois).quantite * 0.86 + "€";
            try
            {
                int i = 0;
                foreach (LigneFraisHorsForfait lfhf in Modele3.ligneFraisHorsForfait(vis.idVisiteur, Fiche.mois))
                {
                    switch (i)
                    {
                        case 0:
                            infHorFor1.Text = decimal.Parse(lfhf.montant.ToString()) + " € de " + lfhf.libelle + " le " + DateTime.Parse(lfhf.date.ToString()).ToShortDateString();
                            break;
                        case 1:
                            infHorFor2.Text = decimal.Parse(lfhf.montant.ToString()) + " € de " + lfhf.libelle + " le " + DateTime.Parse(lfhf.date.ToString()).ToShortDateString();
                            break;
                        case 2:
                            infHorFor3.Text = decimal.Parse(lfhf.montant.ToString()) + " € de " + lfhf.libelle + " le " + DateTime.Parse(lfhf.date.ToString()).ToShortDateString();
                            break;
                        case 3:
                            infHorFor4.Text = decimal.Parse(lfhf.montant.ToString()) + " € de " + lfhf.libelle + " le " + DateTime.Parse(lfhf.date.ToString()).ToShortDateString();
                            break;
                        case 4:
                            infHorFor5.Text = decimal.Parse(lfhf.montant.ToString()) + " € de " + lfhf.libelle + " le " + DateTime.Parse(lfhf.date.ToString()).ToShortDateString();
                            break;
                    }
                    i++;
                }
            }
            catch (Exception)
            {

            }           
        }
    }
}
