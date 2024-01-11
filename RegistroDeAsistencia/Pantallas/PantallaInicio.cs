using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;
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
        private System.Windows.Forms.Timer timer;  // Especifica que estás utilizando System.Windows.Forms.Timer
        public PantallaInicio()
        {
            InitializeComponent();

            // Inicia un temporizador para actualizar la fecha y la hora cada segundo
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Intervalo en milisegundos (1 segundo)
            timer.Tick += Timer_Tick;
            timer.Start();
            // Llama al método para mostrar la fecha y la hora inicialmente
            MostrarFechaYHora();
            CargarHorario();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Este evento se ejecutará cada segundo
            MostrarFechaYHora();
        }

        private void MostrarFechaYHora()
        {
            // Obtén la fecha y la hora actuales
            DateTime ahora = DateTime.Now;

            // Actualiza el texto de los Labels con la fecha y la hora
            FechaLabel.Text = ahora.ToString("dd-MM-yyyy"); // Formato de fecha personalizado
            HoraLabel.Text = ahora.ToString("HH:mm:ss"); // Formato de hora personalizado
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PantallaAdministracionHorarios temp = new PantallaAdministracionHorarios();
            temp.Show();
        }


        private void CargarHorario()
        {
            //Limpiar la tabla
            HorarioDGV.Rows.Clear();
            foreach (Hora iteration in Ctl_Hora.GetList())
            {
                int i = HorarioDGV.Rows.Add();
                HorarioDGV.Rows[i].Cells["Hora"].Value = iteration.desc_horas;
                if (i != 0)
                {
                    HorarioDGV.Rows[i - 1].Cells["Hora"].Value += "-" + iteration.desc_horas;
                }
            }
            HorarioDGV.Rows.RemoveAt(HorarioDGV.Rows.Count - 1);
            //Filtros momento
            List<Horario> _horario = new List<Horario>();
            string currentPeriodo;
            if (DateTime.Now.Month > 2 && DateTime.Now.Month < 8)
            {
                currentPeriodo = "1";
            }
            else
            {
                currentPeriodo = "2";
            }
            foreach (Grupo iteration in Ctl_Grupo.GetList("where anio = " + DateTime.Now.Year + " and periodo = " + currentPeriodo))
            {
                foreach (Horario _Temp in Ctl_Horario.GetList("where grupo_horario = " + iteration.id_grupo))
                {
                    _horario.Add(_Temp);
                }
            }
            foreach (Horario iteration in _horario)
            {
                Dia _dia = Ctl_Dia.GetList("and id_diaSemena = " + iteration.dia_horario).First();
                Grupo _grupo = Ctl_Grupo.GetList("where id_grupo = " + iteration.grupo_horario).First();
                CodigoGrupo _codigo = Ctl_CodigoGrupo.GetList("where id_codigo = " + _grupo.codigo_grupo).First();
                string grupoLabel = _grupo.anio + "-" + _grupo.periodo + "-" + _codigo.desc_grupo;
                HorarioDGV.Rows[iteration.dia_horario - 1].Cells[_dia.desc_dia].Value = grupoLabel;
            }
            for (int i = 0; i < HorarioDGV.Rows.Count; i++)
            {
                foreach (Dia iteration in Ctl_Dia.GetList())
                {
                    if (HorarioDGV.Rows[i].Cells[iteration.desc_dia].Value == null)
                    {
                        HorarioDGV.Rows[i].Cells[iteration.desc_dia].Value = "Hora Libre";
                    }
                }
            }
        }
    }
}
