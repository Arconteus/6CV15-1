using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeAsistencia
{
    public partial class PantallaRegistro : Form
    {
        private DataTable dt;
        public PantallaRegistro()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Boleta");
            dt.Columns.Add("Apellido P");
            dt.Columns.Add("Apellido A");
            dt.Columns.Add("Nombre(s)");
            dt.Columns.Add("Carrera");
            dt.Columns.Add("Escuela");
            dt.Columns.Add("Validacion");

            RegistroDataGridView.DataSource = dt;
            RegistroDataGridView.RowHeadersVisible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void QrBox_Click(object sender, EventArgs e)
        {
            PantalllaQR temp = new PantalllaQR();
            temp.Show();
        }
    }
}
