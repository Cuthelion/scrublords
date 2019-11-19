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
    public partial class FInfosVistiteurs : Form
    {

        public FInfosVistiteurs()
        {
            InitializeComponent();
            MessageBox.Show(Modele1.listeLabo().ToString());
            idVisiteurTextBox.Text = Modele1.VisiteurConnecte.idVisiteur;
            nomTextBox.Text = Modele1.VisiteurConnecte.nom;
            prenomTextBox.Text = Modele1.VisiteurConnecte.prenom;
            nomLaboTextBox.Text = Modele1.VisiteurConnecte.Laboratoire.nomLabo;
            rueTextBox.Text = Modele1.VisiteurConnecte.rue;
            villeTextBox.Text = Modele1.VisiteurConnecte.ville;
           // montantValideTextBox.Text = Modele1.VisiteurConnecte.fichefrais.montantvalide;
            dateEmbaucheTextBox.Text = Modele1.VisiteurConnecte.dateEmbauche;


            try 
            {
                if (Modele1.unLabo(Modele1.VisiteurConnecte) != null)
                {
                    idVisiteurTextBox.Text = "lasagne";
                }
                if (Modele1.unLabo(Modele1.VisiteurConnecte) != null)
                {
                    Form fmodif = new Fmodifinfossecteur();
                    Form Factif = new Factifvisiteur();
                }
            }
            catch (Exception )
            {

            }
            try
            {
                if (Modele1.unSecteur(Modele1.VisiteurConnecte) != null)
                {
                    idVisiteurTextBox.Text = "lasagne";
                }
                if (Modele1.unSecteur(Modele1.VisiteurConnecte) != null)
                {
                    Form Factif = new Factifvisiteur();
                }
            }
            catch (Exception)
            {

            }
            try
            {
                if (Modele1.uneRegion(Modele1.VisiteurConnecte) != null)
                {
                    idVisiteurTextBox.Text = "lasagne";
                }
            }
            catch (Exception)
            {

            }


        }
        private void Modif_Click(object sender, EventArgs e)
        {

            System.Type type = bsvisiteur.Current.GetType();
            var id = (string)type.GetProperty("idvisiteur").GetValue(bsvisiteur.Current, null);
            Modele1.trouvVisiteurId(id);
            Form fmodif = new Fmodifvisiteur();
            fmodif.ShowDialog();
        }

        private void Modif_click_Click(object sender, EventArgs e)
        {
            Form modifvisiteur = new Fmodifvisiteur();
            modifvisiteur.ShowDialog(); 
        }

        private void FInfosVistiteurs_Load(object sender, EventArgs e)
        {

        }
    }
}