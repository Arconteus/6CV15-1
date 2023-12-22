using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeAsistencia.Pantallas
{
    public partial class PantallaInicio : Form
    {
        private DataTable dt;
        public PantallaInicio()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("Lunes");
            dt.Columns.Add("Martes");
            dt.Columns.Add("Miercoles");
            dt.Columns.Add("Jueves");
            dt.Columns.Add("Viernes");

            HorariodataGridView1.DataSource = dt;

            dt = new DataTable();
            dt.Columns.Add("Día");

            DíaDataGridView2.DataSource = dt;
        }

        private void HorariodataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DíaDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
