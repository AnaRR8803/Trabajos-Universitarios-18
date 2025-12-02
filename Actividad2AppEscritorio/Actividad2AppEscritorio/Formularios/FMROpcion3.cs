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
    public partial class FMROpcion3 : Form
    {
        public FMROpcion3()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int resultado;
            Clases.clsOpcion3 clsOpcion3 = new Clases.clsOpcion3();
            resultado = clsOpcion3.Suma(int.Parse(textNum1.Text), int.Parse(textNum2.Text));
            textResultado.Text = resultado.ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            int resultado;
            Clases.clsOpcion3 clsOpcion3 = new Clases.clsOpcion3();
            resultado = clsOpcion3.Resta(int.Parse(textNum1.Text), int.Parse(textNum2.Text));
            textResultado.Text = resultado.ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            int resultado;
            Clases.clsOpcion3 clsOpcion3 = new Clases.clsOpcion3();
            resultado = clsOpcion3.Multiplicacion(int.Parse(textNum1.Text),int.Parse(textNum2.Text));
            textResultado.Text = resultado.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNum1.Clear();
            textNum2.Clear();
            textResultado.Clear();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenuP frmMenuP = new frmMenuP();
            frmMenuP.Show();
            this.Hide();
        }
    }
}
