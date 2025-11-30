using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad1appEscritorio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = textNombre.Text;
            MessageBox.Show("Bienvenid@ " + nombre + " a UMI/Universidad Coppel");
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {
            DUDEstado.Items.Add("Aguascalientes");
            DUDEstado.Items.Add("Baja California");
            DUDEstado.Items.Add("Baja California Sur");
            DUDEstado.Items.Add("Campeche");
            DUDEstado.Items.Add("Chiapas");
            DUDEstado.Items.Add("Chihuahua");
            DUDEstado.Items.Add("Ciudad de Mexico");
            DUDEstado.Items.Add("Coahuila de Zaragoza");
            DUDEstado.Items.Add("Colima");
            DUDEstado.Items.Add("Durango");
            DUDEstado.Items.Add("Guanajuato");
            DUDEstado.Items.Add("Guerrero");
            DUDEstado.Items.Add("Hidalgo");
            DUDEstado.Items.Add("Jalico");
            DUDEstado.Items.Add("Estado de Mexico");
            DUDEstado.Items.Add("Michoacan de Ocampo");
            DUDEstado.Items.Add("Morelos");
            DUDEstado.Items.Add("Nayarit");
            DUDEstado.Items.Add("Nuevo Leon");
            DUDEstado.Items.Add("Oaxaca");
            DUDEstado.Items.Add("Puebla");
            DUDEstado.Items.Add("Queretaro");
            DUDEstado.Items.Add("Quintana Roo");
            DUDEstado.Items.Add("San Luis Potosi");
            DUDEstado.Items.Add("Sinaloa");
            DUDEstado.Items.Add("Sonara");
            DUDEstado.Items.Add("Tabasco");
            DUDEstado.Items.Add("Tamaulipas");
            DUDEstado.Items.Add("Tlaxcala");
            DUDEstado.Items.Add("Veracruz");
            DUDEstado.Items.Add("Yucatan");
            DUDEstado.Items.Add("Zacatecas");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
