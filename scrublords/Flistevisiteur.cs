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
    public partial class Flistevisiteur: Form
    {
        public Flistevisiteur()
        {
            InitializeComponent();
            bsvisiteur.DataSource = Modele1.listeVisiteur();
            dgvvisiteur.DataSource = bsvisiteur.DataSource;
            dgvvisiteur.Columns[2].Visible = false;
            dgvvisiteur.Columns[5].Visible = false;
            dgvvisiteur.Columns[6].Visible = false;
            dgvvisiteur.Columns[7].Visible = false;
            dgvvisiteur.Columns[8].Visible = false;
            dgvvisiteur.Columns[9].Visible = false;
            dgvvisiteur.Columns[10].Visible = false;
            dgvvisiteur.Columns[11].Visible = false;
            dgvvisiteur.Columns[12].Visible = false;
            dgvvisiteur.Columns[13].Visible = false;
            dgvvisiteur.Columns[14].Visible = false;
            dgvvisiteur.Columns[15].Visible = false;



        }
    }
}
