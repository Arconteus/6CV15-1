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
        HashSet<string> Boletas = new HashSet<string>();
        private System.Windows.Forms.Timer timer;
        public PantallaAsistencia()
        {
            InitializeComponent();
            Configuracion();
            LoadGrupos();
            CargarDatos();
            CargarCarreras();
            CargarEscuela();
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
            CargarCarreras();
            CargarEscuela();
            UpdateDGV();
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
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void OnlyLetters(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void BoletaTextBox_TextChanged(object sender, EventArgs e)
        {
            SetDatos();
        }
        private void CargarCarreras()
        {
            List<string> List = new List<string>();
            foreach (Carrera iteration in Ctl_Carrera.GetList())
            {
                List.Add(iteration.nom_carrera);
            }
            CarreraCB.DataSource = List;
            CarreraCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CarreraCB.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void CargarEscuela()
        {
            List<string> list = new List<string>();
            foreach (Escuela iteration in Ctl_Escuela.GetList())
            {
                list.Add(iteration.nom_escuela);
            }
            EscuelaCB.DataSource = list;
            EscuelaCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EscuelaCB.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void AddAlumnoButton_Click(object sender, EventArgs e)
        {
            if (NomTextBox.Text.Trim(' ') == "")
            {
                MessageBox.Show("El alumno necesita un nombre.");
                return;
            }
            if (ApaTextBox.Text.Trim(' ') == "")
            {
                MessageBox.Show("El alumno necesita un apellido paterno.");
                return;
            }
            if (AmaTextBox.Text.Trim(' ') == "")
            {
                MessageBox.Show("El alumno necesita un apellido materno.");
                return;
            }
            if (!Ctl_Alumno.Contain(new Alumno() { boleta = BoletaTextBox.Text }))
            {
                if(BoletaTextBox.Text.Length < 10)
                {
                    MessageBox.Show("La boleta debe contener al menos 10 digitos.");
                }
                DialogResult answer = MessageBox.Show("El alumno con la boleta "+BoletaTextBox.Text+" No esta dado de alta", "¿Deseas registrarlo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    Ctl_Alumno.Add(GetAlumno());
                }
            }
            SetDatos();
            int i = RegistroDGV.Rows.Add();
            Boletas.Add(BoletaTextBox.Text);
            UpdateDGV();
        }

        private void UpdateDGV()
        {
            RegistroDGV.Rows.Clear();
            foreach(string iteration in Boletas)
            {
                Alumno _alumno = Ctl_Alumno.GetList("where boleta = " + iteration).First();
                int i = RegistroDGV.Rows.Add();
                RegistroDGV.Rows[i].Cells["Boleta"].Value = _alumno.boleta;
                RegistroDGV.Rows[i].Cells["Nombre"].Value = _alumno.nom_alumno;
                RegistroDGV.Rows[i].Cells["Apa"].Value = _alumno.apa_alumno;
                RegistroDGV.Rows[i].Cells["Ama"].Value = _alumno.ama_alumno;
                Escuela _escuela = Ctl_Escuela.GetList("where id_escuela = " + _alumno.escuela_alumno).First();
                RegistroDGV.Rows[i].Cells["Escuela"].Value = _escuela.nom_escuela;
                Carrera _carrera = Ctl_Carrera.GetList("where id_carrera = " + _alumno.carrera_alumno).First();
                RegistroDGV.Rows[i].Cells["Carrera"].Value = _carrera.nom_carrera;
            }
        }

        private void SetDatos()
        {
            if (!Ctl_Alumno.Contain(new Alumno() { boleta = BoletaTextBox.Text })) return;
            Alumno _alumno = Ctl_Alumno.GetList("where boleta = " + BoletaTextBox.Text).First();
            ApaTextBox.Text = _alumno.apa_alumno;
            AmaTextBox.Text = _alumno.ama_alumno;
            NomTextBox.Text = _alumno.nom_alumno;
            Escuela _escuela = Ctl_Escuela.GetList("where id_escuela = " + _alumno.escuela_alumno).First();
            EscuelaCB.Text = _escuela.nom_escuela;
            Carrera _carrera = Ctl_Carrera.GetList("where id_carrera = " + _alumno.carrera_alumno).First();
            CarreraCB.Text = _carrera.nom_carrera;
        }

        public Alumno GetAlumno()
        {
            Alumno _alumno = new Alumno();
            _alumno.boleta = BoletaTextBox.Text.ToUpper();
            _alumno.apa_alumno = ApaTextBox.Text.ToUpper();
            _alumno.ama_alumno = AmaTextBox.Text.ToUpper();
            _alumno.nom_alumno = NomTextBox.Text.ToUpper();
            Escuela _escuela = Ctl_Escuela.GetList("where nom_escuela = '" + EscuelaCB.Text + "'").First();
            _alumno.escuela_alumno = _escuela.id_escuela;
            Carrera _carrera = Ctl_Carrera.GetList("where nom_carrera = '" + CarreraCB.Text + "'").First();
            _alumno.carrera_alumno = _carrera.id_carrera;
            return _alumno;
        }

    }
}