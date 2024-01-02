using RegistroDeAsistencia.DataBase.Modelo;
using RegistroDeAsistencia.Libraries;
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
    public partial class PantallaAsistencia : Form
    {
        public PantallaAsistencia()
        {
            InitializeComponent();
            string url = "https://servicios.dae.ipn.mx/vcred/?h=2aa29dad59808777158131aed7734a20da8ba093366db3a6163b5d17df6e88d&fbclid=IwAR0X9yI7oK1QIY0FAR-5D0AW87ik02eFYr-zWtbKmkHdf-eoC4SLsjCdLtE";
            List<String> tempAlumno = WSLib.GetAlumnoFrom(url);
            int i = RegistroDGV.Rows.Add();
            /**
            RegistroDGV.Rows[i].Cells[1].Value = 1; Boleta
            RegistroDGV.Rows[i].Cells[2].Value = 2; Nombre
            RegistroDGV.Rows[i].Cells[3].Value = 3; Apellido Paterno
            RegistroDGV.Rows[i].Cells[4].Value = 4; Apellido Materno
            RegistroDGV.Rows[i].Cells[5].Value = 5; Escuela.
            RegistroDGV.Rows[i].Cells[5].Value = 6; Carrera.
            **/
            RegistroDGV.Rows[i].Cells[1].Value = tempAlumno[0];
            RegistroDGV.Rows[i].Cells[2].Value = tempAlumno[1];
            RegistroDGV.Rows[i].Cells[3].Value = tempAlumno[2];
            RegistroDGV.Rows[i].Cells[4].Value = tempAlumno[3];
            RegistroDGV.Rows[i].Cells[5].Value = tempAlumno[4];
            RegistroDGV.Rows[i].Cells[6].Value = tempAlumno[5];
        }

        private void QrBox_Click(object sender, EventArgs e)
        {
            PantallaQR temp = new PantallaQR();
            temp.Show();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {

        }
    }
}
