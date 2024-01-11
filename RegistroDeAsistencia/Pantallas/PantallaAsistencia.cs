using RegistroDeAsistencia.DataBase.Control;
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
        private System.Windows.Forms.Timer timer;
        public PantallaAsistencia()
        {
            InitializeComponent();
            Configuracion();
            LoadGrupos();
            CargarDatos();
        }
        private void Configuracion()
        {
            // Inicia un temporizador para actualizar la fecha y la hora cada segundo
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Intervalo en milisegundos (1 segundo)
            timer.Tick += Timer_Tick;
            timer.Start();

            // Llama al método para mostrar la fecha y la hora inicialmente
            MostrarFechaYHora();
        }
        private void QrBox_Click(object sender, EventArgs e)
        {
            PantallaQR temp = new PantallaQR();
            temp.Show();
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
        private void LoadGrupos()
        {
            List<String> _Elements = new List<String>();
            foreach (Grupo iteration in Ctl_Grupo.GetList())
            {
                string _anio = iteration.anio.ToString();
                string _periodo = iteration.periodo.ToString();
                CodigoGrupo _temoGrupo = Ctl_CodigoGrupo.GetList("where id_codigo = " + iteration.codigo_grupo).First();
                string _codigo = _temoGrupo.desc_grupo.ToString();
                _Elements.Add(_anio + "-" + _periodo + "-" + _codigo);
            }
            GrupoCB.DataSource = _Elements;
            GrupoCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GrupoCB.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void CargarDatos()
        {
            List<String> _temp = GrupoCB.Text.Split('-').ToList();
            CodigoGrupo _codigo = Ctl_CodigoGrupo.GetList("where desc_grupo = '" + _temp[2] + "'").First();
            string _whereClause = "where anio = " + _temp[0] + " and periodo = " + _temp[1] + " and codigo_grupo = " + _codigo.id_codigo;
            if (Ctl_Grupo.GetList(_whereClause).Count < 1)
            {
                ProfesorTextBox.Text = "- - Sin profesor";
                return;
            }
            Grupo _grupo = Ctl_Grupo.GetList(_whereClause).First();
            Profesor _profesor = Ctl_Profesor.GetList("where id_profesor = " + _grupo.id_profesor_grupo).First();
            ProfesorTextBox.Text = _profesor.apa_profesor.ToString() + " " + _profesor.ama_profesor.ToString() + " " + _profesor.nom_profesor;
            Materia _materia = Ctl_Materias.GetList("where id_materia = " + _grupo.id_materia_grupo).First();
            MateriaTB.Text = _materia.nom_materia;
        }

        private RegistroAsistencia GetRegistroAsistencia()
        {
            RegistroAsistencia _registroAssitencia = new RegistroAsistencia();

            int _id_grupo_registro = 0;
            string _hora_registro = " ";
            string _fecha_registro = " ";
            _registroAssitencia.id_grupo_registro = _id_grupo_registro;
            _registroAssitencia.hora_registro = _hora_registro;
            _registroAssitencia.fecha_registro = _fecha_registro;

            return _registroAssitencia;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PantallaAsistencia_Enter(object sender, EventArgs e)
        {
            LoadGrupos();
            CargarDatos();
        }

        private void GrupoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void GrupoCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MateriaTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
