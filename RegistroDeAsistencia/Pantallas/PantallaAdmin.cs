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
    public partial class PantallaAdmin : Form
    {
        private DataTable dt;
        public PantallaAdmin()
        {
            InitializeComponent();
        }

        private void AddMateriaButton_Click(object sender, EventArgs e)
        {
            PantallaRegistroMateria temp = new PantallaRegistroMateria();
            temp.Show();
        }

        private void AddProfesorButton_Click(object sender, EventArgs e)
        {
            PantallaRegistroProfesor temp = new PantallaRegistroProfesor();
            temp.Show();
        }

        private void RegistroDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
