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
        private List<LigneFraisHorsForfait> lesLignes;
        public FFicheRemboursementCompleter(fichefrais fiche)
        {
            InitializeComponent();
            this.ficheCourante = fiche;
            labMois.Text = fiche.mois;
            lesLignes = new List<LigneFraisHorsForfait>();
            try
            {
                int i = 0;
                foreach(LigneFraisHorsForfait lfhf in Modele3.ligneFraisHorsForfait(Modele3.VisiteurConnecte3.idVisiteur, fiche.mois))
                {
                    switch(i)
                    {
                        case 0: lfhf1.Text = lfhf.libelle;
                            montant1.Value = decimal.Parse(lfhf.montant.ToString());
                            date1.Value = lfhf.date.Value;
                            lesLignes.Add(lfhf);
                            break;
                        case 1: lfhf2.Text = lfhf.libelle;
                            montant2.Value = decimal.Parse(lfhf.montant.ToString());
                            date2.Value = lfhf.date.Value;
                            lesLignes.Add(lfhf);
                            break;
                        case 2: lfhf3.Text = lfhf.libelle;
                            montant3.Value = decimal.Parse(lfhf.montant.ToString());
                            date3.Value = lfhf.date.Value;
                            lesLignes.Add(lfhf);
                            break;
                        case 3: lfhf4.Text = lfhf.libelle;
                            montant4.Value = decimal.Parse(lfhf.montant.ToString());
                            date4.Value = lfhf.date.Value;
                            lesLignes.Add(lfhf);
                            break;
                        case 4: lfhf5.Text = lfhf.libelle;
                            montant5.Value = decimal.Parse(lfhf.montant.ToString());
                            date5.Value = lfhf.date.Value;
                            lesLignes.Add(lfhf);
                            break;
                    }
                    i++;    
                }
            }
            catch(Exception)
            {

            }
            try
            {
                quaNui.Value = decimal.Parse(Modele3.ligneFraisForfait("NUI", Modele3.VisiteurConnecte3.idVisiteur, fiche.mois).quantite.ToString());
            }
            catch(Exception)
            {
                quaNui.Value = 0;
            }
            try
            {
                quaRep.Value = decimal.Parse(Modele3.ligneFraisForfait("REP", Modele3.VisiteurConnecte3.idVisiteur, fiche.mois).quantite.ToString());
            }
            catch (Exception)
            {
                quaRep.Value = 0;
            }
            try
            {
                quaKil.Value = decimal.Parse(Modele3.ligneFraisForfait("KM ", Modele3.VisiteurConnecte3.idVisiteur, fiche.mois).quantite.ToString());
            }
            catch (Exception)
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
            //enregistrement/modification lignes forfaits
            decimal total = quaNui.Value * monUniNui.Value + quaRep.Value * monUniRep.Value + quaKil.Value * monUniKil.Value + montant1.Value + montant2.Value + montant3.Value + montant4.Value + montant5.Value;
            Modele3.modifFicheFrais(ficheCourante, total);
            try
            {
                Modele3.modifLigneForfait(Modele3.ligneFraisForfait("NUI", Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois), int.Parse(quaNui.Value.ToString()));
            }
            catch(Exception)
            {   
                Modele3.insertLigneForfait(Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois, "NUI", int.Parse(quaNui.Value.ToString()));
            }
            try
            {
                Modele3.modifLigneForfait(Modele3.ligneFraisForfait("KM ", Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois), int.Parse(quaKil.Value.ToString()));
            }
            catch(Exception)
            {
                Modele3.insertLigneForfait(Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois, "KM ", int.Parse(quaKil.Value.ToString()));
            }
            try
            {
                Modele3.modifLigneForfait(Modele3.ligneFraisForfait("REP", Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois), int.Parse(quaRep.Value.ToString()));
            }
            catch(Exception)
            {
                Modele3.insertLigneForfait(Modele3.VisiteurConnecte3.idVisiteur, ficheCourante.mois, "REP", int.Parse(quaRep.Value.ToString()));
            }
            //enregistrement/modification ligne hors forfait
            if (lfhf1.Text != "" && montant1.Value != 0)
            {
                try
                { 
                    Modele3.modifLigneHorsForfait(lesLignes[0], montant1.Value, lfhf1.Text, date1.Value, lesLignes[0].id);
                }
                catch (Exception)
                {
                    Modele3.insertLigneHorsForfait(Modele3.VisiteurConnecte3.idVisiteur, labMois.Text, lfhf1.Text, date1.Value, montant1.Value);
                }
            }
            if (lfhf2.Text != "" && montant1.Value != 0)
            {
                try
                {
                    Modele3.modifLigneHorsForfait(lesLignes[1], montant2.Value, lfhf2.Text, date2.Value, lesLignes[1].id);
                }
                catch (Exception)
                {
                    Modele3.insertLigneHorsForfait(Modele3.VisiteurConnecte3.idVisiteur, labMois.Text, lfhf2.Text, date2.Value, montant2.Value);
                }
            }
            if (lfhf3.Text != "" && montant3.Value != 0)
            {
                try
                {
                    Modele3.modifLigneHorsForfait(lesLignes[2], montant3.Value, lfhf3.Text, date3.Value, lesLignes[2].id);
                }
                catch (Exception)
                {
                    Modele3.insertLigneHorsForfait(Modele3.VisiteurConnecte3.idVisiteur, labMois.Text, lfhf3.Text, date3.Value, montant3.Value);
                }
            }
            if (lfhf4.Text != "" && montant4.Value != 0)
            {
                try
                {
                    Modele3.modifLigneHorsForfait(lesLignes[3], montant4.Value, lfhf4.Text, date4.Value, lesLignes[3].id);
                }
                catch (Exception)
                {
                    Modele3.insertLigneHorsForfait(Modele3.VisiteurConnecte3.idVisiteur, labMois.Text, lfhf4.Text, date4.Value, montant4.Value);
                }
            }
            if (lfhf5.Text != "" && montant5.Value != 0)
            {
                try
                {
                    Modele3.modifLigneHorsForfait(lesLignes[4], montant5.Value, lfhf5.Text, date5.Value, lesLignes[4].id);
                }
                catch (Exception)
                {
                    Modele3.insertLigneHorsForfait(Modele3.VisiteurConnecte3.idVisiteur, labMois.Text, lfhf5.Text, date5.Value, montant5.Value);
                }
            }
        }
    }
}
