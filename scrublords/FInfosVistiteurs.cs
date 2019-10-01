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
            //lesvisiteurs
            bsvisiteur.DataSource = Modele1.VisiteurConnecte;
            bssecteur.DataSource = Modele1.VisiteurConnecte;
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
            modifvisiteur.Show();
        }
    }
}
