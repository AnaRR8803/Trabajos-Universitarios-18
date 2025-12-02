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
    public partial class frmMenuP : Form
    {
        public frmMenuP()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void saludosToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Formularios.FMROpcion1 fMROpcion1 = new Formularios.FMROpcion1();
            fMROpcion1.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void informacionPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FMROpcion2A fMROpcion2A = new Formularios.FMROpcion2A();
            fMROpcion2A.Show();
        }

        private void datosClinicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FMROpcion2B fMROpcion2B = new Formularios.FMROpcion2B();
            fMROpcion2B.Show();
        }

        private void operacionesBasicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formularios.FMROpcion3 fMROpcion3 = new Formularios.FMROpcion3();
            fMROpcion3.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
