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
    public partial class FMROpcion1 : Form
    {
        public FMROpcion1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            Clases.clsOpcion1 opcion1 = new Clases.clsOpcion1();
            string misaludo = opcion1.saludar(txtNombre.Text);
            MessageBox.Show(misaludo);
        }
    }
}
