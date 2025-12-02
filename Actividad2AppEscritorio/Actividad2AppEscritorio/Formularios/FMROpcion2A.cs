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
    public partial class FMROpcion2A : Form
    {
        public FMROpcion2A()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
         frmMenuP frmMenuP = new frmMenuP();
         frmMenuP.Show();
        this.Hide();
        }

        private void cbCivil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCivil.Items.Add("Soltero");
            cbCivil.Items.Add("Casado");
            cbCivil.Items.Add("Divorsiado");
            cbCivil.Items.Add("Viudo");
        }
    }
}
