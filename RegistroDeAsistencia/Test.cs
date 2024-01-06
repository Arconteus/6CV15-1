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
            DGV1.DataSource = Ctl_Carrera.GetList();
            DGV2.DataSource = Ctl_Escuela.GetList();
            DGV3.DataSource = Ctl_CodigoGrupo.GetList();
            DGV4.DataSource = Ctl_Profesor.GetList();
            DGV5.DataSource = Ctl_Materias.GetList();
            DGV6.DataSource = Ctl_Dia.GetList();
            DGV7.DataSource = Ctl_Hora.GetList();
            DGV8.DataSource = Ctl_Horario.GetList();
            DGV9.DataSource = Ctl_Grupo.GetList();
        }

        private void pictCamImagem_Click(object sender, EventArgs e)
        {

        }
    }
}
