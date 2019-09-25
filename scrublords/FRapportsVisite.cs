using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scrublords
{
    public partial class FRapportsVisite : Form
    {
        public FRapportsVisite()
        {
            InitializeComponent();
            bsRapVis.DataSource = Modele.listeRapVis();
            dgvRapVis.DataSource = bsRapVis.DataSource;
            dgvRapVis.Colums[0].Visible = false;
    }
}