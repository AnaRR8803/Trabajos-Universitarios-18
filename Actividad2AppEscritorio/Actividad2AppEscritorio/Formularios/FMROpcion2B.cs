using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2AppEscritorio.Formularios
{
    public partial class FMROpcion2B : Form
    {
        public FMROpcion2B()
        {
            InitializeComponent();
        }

        private void btnRegresar2_Click(object sender, EventArgs e)
        {
            frmMenuP frmMenuP = new frmMenuP();
            frmMenuP.Show();
            this.Hide();
        }

        private void txtP4_Click(object sender, EventArgs e)
        {

        }
    }
}
