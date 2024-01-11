using RegistroDeAsistencia.DataBase.Control;
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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
            Codigo_DGV.DataSource = Ctl_CodigoGrupo.GetList();
            Materia_DGV.DataSource = Ctl_Materias.GetList();
            Profesor_DGV.DataSource = Ctl_Profesor.GetList();
            Escuela_DGV.DataSource = Ctl_Escuela.GetList();
            Carrera_DGV.DataSource = Ctl_Carrera.GetList();
            Hora_DGV.DataSource = Ctl_Hora.GetList();
            Alumno_DGV.DataSource = Ctl_Alumno.GetList();
            Grupo_DGV.DataSource = Ctl_Grupo.GetList();
            Horario_DGV.DataSource = Ctl_Horario.GetList();
            Registro_DGV.DataSource = Tbl_RegistroAsistencia.GetList();
            ObservacionRegistro_DGV.DataSource = Tbl_ObservacionRegistro.GetList();
            RelacionAlumno_DGV.DataSource = Tbl_RelacionRegistroAlumno.GetList();
            ObservacionAlumno_DGV.DataSource = Tbl_ObservacionAlumno.GetList();
        }

        private void pictCamImagem_Click(object sender, EventArgs e)
        {

        }
    }
}
