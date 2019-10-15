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
    public partial class FDetails : Form
    {
        public FDetails()
        {
            InitializeComponent();
        }

        private void FDetails_Load(object sender, EventArgs e)
        {
            MEDECIN medecintemp = Modele2.leMedecinChoisi;
            tbId.Text = (medecintemp.idMedecin).ToString();
        }
    }
}