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
    public partial class PantallaReportes : Form
    {
        private DataTable dt;
        public PantallaReportes()
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("X");
            dt.Columns.Add("Folio");
            dt.Columns.Add("Fecha");
            dt.Columns.Add("Materia");
            dt.Columns.Add("Profesor");

            ReportesdataGridView.DataSource = dt;

            ReportesdataGridView.RowHeadersVisible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
