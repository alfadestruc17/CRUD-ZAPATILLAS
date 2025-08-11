using Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmRegistros : Form
    {
        private ComboBox cmbMarca;

        public frmRegistros()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        void LlenarCmbMarcas()
        {
            try
            {
                DataTable retornarProducto;
                retornarProducto = ControllerProductos.CargarMarcas();
                cmbMarca.DataSource = retornarProducto;
                cmbMarca.DisplayMember = "Marca";
                cmbMarca.ValueMember = "IdMarca";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar registros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
