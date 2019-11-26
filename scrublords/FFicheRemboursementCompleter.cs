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
            bsHorsForfait.DataSource = Modele3.ligneFraisHorsForfait(ficheCourante.idVisiteur, ficheCourante.mois);
            dataGridView1.DataSource = bsHorsForfait;
            int i = 0;
            do
            {
                if (i < 3 || i > 5)
                {
                    dataGridView1.Columns[i].Visible = false;
                }
                i++;
            } while (i <= 6);
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
            //enregistrement dans la base de donnée
            decimal totHF = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 5)
                    {
                        try
                        {
                            totHF += Decimal.Parse(cell.Value.ToString());
                        }
                        catch(Exception)
                        {

                        }
                    }
                }
            }
            decimal total = quaNui.Value * monUniNui.Value + quaRep.Value * monUniRep.Value + quaKil.Value * monUniKil.Value + totHF;
            Modele3.modifFicheFrais(ficheCourante, total);
            foreach(DataGridViewRow d in dataGridView1.Rows)
            {
                try
                {
                   Modele3.insertLigneHorsForfait(d.Cells[0],ficheCourante.mois,d.Cells[3],)
                }
                catch(Exception)
                {

                }
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
           int l = 0;
           l = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
           Modele3.deleteLigneHorsForfait(l);
           dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }
    }
}
