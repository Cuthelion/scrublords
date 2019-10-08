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
    public partial class Fmodifvisiteur : Form
    {
        public Fmodifvisiteur()
        {
            InitializeComponent();
            bsvisiteur.DataSource = Modele1.VisiteurConnecte;
        }

        private void Fmodifvisiteur_Load(object sender, EventArgs e)
        {

        }
    }
}