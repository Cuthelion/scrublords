using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace scrublords
{
    public partial class Fmodifvisiteur : Form
    {
        public Fmodifvisiteur()
        {
            InitializeComponent();
            bsvisiteur.DataSource = Modele1.VisiteurConnecte;





        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.None;

            Modele1.VisiteurConnecte.password = textboxmdp2.ToString();
            MessageBox.Show("mot de passe modifié");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.None;

            MessageBox.Show("Annulation de la modification du mot de passe");
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
        
        
        
        
    }
}