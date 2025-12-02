using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad2AppEscritorio
{
    public partial class FRMIngreso : Form
    {
        public FRMIngreso()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (textContrasena.Text == "")
            {
                MessageBox.Show("Debe ingresar Contraseña.");
            }
            else if (textContrasena.Text == "12345")
            {
                frmMenuP frmMenuP = new frmMenuP();
                frmMenuP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("contraseña incorrecta");
                textContrasena.Clear();
            }
        }
    }
}
