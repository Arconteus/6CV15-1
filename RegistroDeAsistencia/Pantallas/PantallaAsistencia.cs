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
            string url = "https://servicios.dae.ipn.mx/vcred/?h=2aa29dad59808777158131aed7734a20da8ba093366db3a6163b5d17df6e88d&fbclid=IwAR0X9yI7oK1QIY0FAR-5D0AW87ik02eFYr-zWtbKmkHdf-eoC4SLsjCdLtE";
            List<String> tempAlumno = WSLib.GetAlumnoFrom(url);
            int i = RegistroDGV.Rows.Add();
            // Inicia un temporizador para actualizar la fecha y la hora cada segundo
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Intervalo en milisegundos (1 segundo)
            timer.Tick += Timer_Tick;
            timer.Start();

            // Llama al método para mostrar la fecha y la hora inicialmente
            MostrarFechaYHora();
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
        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void HelpButton_Click(object sender, EventArgs e)
        {

        }

        private void PantallaAsistencia_Load(object sender, EventArgs e)
        {
            // Cargar las materias al ComboBox
            CargarMaterias();
            // Cargar los profesores al ComboBox
            CargarProfesores();
            // Cargar los grupos al ComboBox
            CargarGrupos();
        }
        private void CargarMaterias()
        {
            // Obtener la lista de materias desde la base de datos
            List<Materia> materias = Ctl_Materias.GetList();

            // Asignar la lista de materias al DataSource del ComboBox
            MateriaComboBox.DataSource = materias;

            // Especificar qué propiedad de la clase Materia se mostrará en el ComboBox
            MateriaComboBox.DisplayMember = "nom_materia";

            // Opcional: Puedes especificar qué propiedad de la clase Materia se utilizará como valor
            // MateriaComboBox.ValueMember = "id_materia";

            // Habilitar la funcionalidad de búsqueda
            MateriaComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            MateriaComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CargarProfesores()
        {
            // Obtener la lista de profesores desde la base de datos
            List<Profesor> profesores = Ctl_Profesor.GetList();

            // Ordenar la lista de profesores según los criterios mencionados
            profesores.Sort((x, y) => string.Compare(x.NombreCompleto, y.NombreCompleto, StringComparison.Ordinal));

            // Asignar la lista de profesores al DataSource del ComboBox
            ProfesorComboBox.DataSource = profesores;

            // Especificar qué propiedad de la clase Profesor se mostrará en el ComboBox
            ProfesorComboBox.DisplayMember = "NombreCompleto";

            // Habilitar la funcionalidad de búsqueda
            ProfesorComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ProfesorComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CargarGrupos()
        {
            // Obtener la lista de grupos desde la base de datos
            List<CodigoGrupo> grupos = Ctl_CodigoGrupo.GetList();

            // Asignar la lista de grupos al DataSource del ComboBox
            GrupoComboBox.DataSource = grupos;

            // Especificar qué propiedad de la clase CodigoGrupo se mostrará en el ComboBox
            GrupoComboBox.DisplayMember = "desc_grupo";

            // Habilitar la funcionalidad de búsqueda
            GrupoComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GrupoComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void SearchComboBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
