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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            Form Visiteurs = new FGestionVisiteur();
            Visiteurs.Show();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            FRemboursements Remboursements = new FRemboursements();
            Remboursements.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form RapportsVisite = new FRapportsVisite();
            RapportsVisite.Show();
        }
    }
}
