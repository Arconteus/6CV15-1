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
    public partial class Pantalla_admin : Form
    {
        private DataTable dt;
        public Pantalla_admin()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("X");
            dt.Columns.Add("Semestre");
            dt.Columns.Add("Grupo");
            dt.Columns.Add("Materia");
            dt.Columns.Add("Profesor");

            GruposDataGridView3.DataSource = dt;
            GruposDataGridView3.RowHeadersVisible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
