using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;
using RegistroDeAsistencia.Libraries;
using RegistroDeAsistencia.Pantallas;
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
            CargarHoras();
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
            if (_temp.Count > 2)
            {
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
        }
        private RegistroAsistencia GetRegistroAsistencia()
        {
            RegistroAsistencia _registroAssitencia = new RegistroAsistencia();

            int _hora_registro = Ctl_Hora.GetList("where desc_horas = '"+HoraComboBox.Text+"'").First().id_horas;

            List<string> grupo = GrupoCB.Text.Split('-').ToList();

            if (grupo.Count < 2) return null;

            CodigoGrupo _codigo = Ctl_CodigoGrupo.GetList("where desc_grupo = '" + grupo[2]+"'").First();

            Grupo _grupo = Ctl_Grupo.GetList("where anio = " + grupo[0] +
                " and periodo = " + grupo[1] + " and codigo_grupo = " + _codigo.id_codigo).First();

            _registroAssitencia.id_grupo_registro = _grupo.id_grupo;
            _registroAssitencia.id_hora_registro = _hora_registro;
            string _anio = DateTime.Now.Year.ToString();
            string _mes = "";
            if(DateTime.Now.Month<10) _mes+="0";
            _mes += DateTime.Now.Month.ToString();
            string _dia = "";
            if(DateTime.Now.Day<10)_dia+="0";
            _dia += DateTime.Now.Day.ToString();
            _registroAssitencia.fecha_registro = _anio+"-"+_mes+"-"+_dia;

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
            CargarHoras();
        }
        private void GrupoCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarDatos();
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
        private void CargarHoras()
        {
            List<String> _hora = new List<string>();
            foreach (Hora iteration in Ctl_Hora.GetList())
            {
                _hora.Add(iteration.desc_horas);
            }
            HoraComboBox.DataSource = _hora;
            HoraComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            HoraComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            if (DateTime.Now.Hour <= 7 && DateTime.Now.Minute > 0)
            {
                HoraComboBox.Text = _hora[0];
            }
            if (DateTime.Now.Hour == 8 && DateTime.Now.Minute > 30)
            {
                HoraComboBox.Text = _hora[1];
            }
            if (DateTime.Now.Hour == 10 && DateTime.Now.Minute > 0)
            {
                HoraComboBox.Text = _hora[2];
            }
            if (DateTime.Now.Hour == 11 && DateTime.Now.Minute > 30)
            {
                HoraComboBox.Text = _hora[3];
            }
            if (DateTime.Now.Hour == 13 && DateTime.Now.Minute > 0)
            {
                HoraComboBox.Text = _hora[4];
            }
            if (DateTime.Now.Hour == 14 && DateTime.Now.Minute > 30)
            {
                HoraComboBox.Text = _hora[5];
            }
            if (DateTime.Now.Hour == 16 && DateTime.Now.Minute > 0)
            {
                HoraComboBox.Text = _hora[6];
            }
            if (DateTime.Now.Hour == 17 && DateTime.Now.Minute > 30)
            {
                HoraComboBox.Text = _hora[7];
            }
            if (DateTime.Now.Hour == 19 && DateTime.Now.Minute > 0)
            {
                HoraComboBox.Text = _hora[8];
            }
            if (DateTime.Now.Hour == 20 && DateTime.Now.Minute > 30)
            {
                HoraComboBox.Text = _hora[9];
            }
            if (DateTime.Now.Hour >= 22 && DateTime.Now.Minute > 0)
            {
                HoraComboBox.Text = _hora[10];
            }
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
                if (BoletaTextBox.Text.Length < 10)
                {
                    MessageBox.Show("La boleta debe contener al menos 10 digitos.");
                }
                DialogResult answer = MessageBox.Show("El alumno con la boleta " + BoletaTextBox.Text + " No esta dado de alta", "¿Deseas registrarlo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            foreach (string iteration in Boletas)
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
            _alumno.boleta = BoletaTextBox.Text.ToUpper().Trim();
            _alumno.apa_alumno = ApaTextBox.Text.ToUpper().Trim();
            _alumno.ama_alumno = AmaTextBox.Text.ToUpper().Trim();
            _alumno.nom_alumno = NomTextBox.Text.ToUpper().Trim();
            Escuela _escuela = Ctl_Escuela.GetList("where nom_escuela = '" + EscuelaCB.Text + "'").First();
            _alumno.escuela_alumno = _escuela.id_escuela;
            Carrera _carrera = Ctl_Carrera.GetList("where nom_carrera = '" + CarreraCB.Text + "'").First();
            _alumno.carrera_alumno = _carrera.id_carrera;
            return _alumno;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Al entrar al registro de alumnos se limpiara el registro actual", "¿Deseas continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes) return;
            Boletas.Clear();
            UpdateDGV();
            PantallaAdministrarAlumnos temp = new PantallaAdministrarAlumnos();
            temp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("¿Estas seguro que deseas eliminar la lista de asistencia actual?", "Confirma tu respuesta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes) return;
            Boletas.Clear();
            UpdateDGV();
        }

        private void HoraComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FinalizarButton_Click(object sender, EventArgs e)
        {
            if (Boletas.Count < 1)
            {
                MessageBox.Show("Para generar un registro deben haber asistido alumnos.");
                return;
            }
            if (GetRegistroAsistencia == null)
            {
                MessageBox.Show("Es necesario que exista al menos un grupo seleccionado.");
                return;
            }
            RegistroAsistencia _reg = GetRegistroAsistencia();
            Tbl_RegistroAsistencia.Add(_reg);
            foreach(string iteration in Boletas)
            {
                Alumno _alumno = Ctl_Alumno.GetList("where boleta = " + iteration).First();
                Tbl_RelacionRegistroAlumno.Add(new RelacionRegistroAlumno()
                {
                    id_alumno_registro = _alumno.id_alumno,
                    id_registro_relacion = _reg.id_registro
                });
            }
            if (ObservacionRTB.Text.Trim() != "")
            {
                Tbl_ObservacionRegistro.Add(new ObservacionRegistro() 
                { 
                    id_registro_observacion = _reg.id_registro,
                    observacion = ObservacionRTB.Text.Trim()
                });
            }
        }
    }
}
