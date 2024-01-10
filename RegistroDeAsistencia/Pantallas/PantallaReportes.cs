using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;

namespace RegistroDeAsistencia
{
    public partial class PantallaReportes : Form
    {
        private DataTable dt;
        private List<CodigoGrupo> listaGrupos;
        private System.Windows.Forms.Timer timer;

        public PantallaReportes()
        {
            InitializeComponent();
            dt = new DataTable();
            // Inicia un temporizador para actualizar la fecha y la hora cada segundo
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Intervalo en milisegundos (1 segundo)
            timer.Tick += Timer_Tick;
            timer.Start();

            // Llama al método para mostrar la fecha y la hora inicialmente
            MostrarFechaYHora();
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

        }

        private void RegistroDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PantallaReportes_Load(object sender, EventArgs e)
        {
            // Cargar la lista de grupos desde la base de datos
            listaGrupos = Ctl_CodigoGrupo.GetList();
            CargarProfesores();
            CargarMaterias();

            // Configurar el ComboBox
            FiltroGrupocomboBox.DisplayMember = "desc_grupo";
            FiltroGrupocomboBox.ValueMember = "id_codigo";
            FiltroGrupocomboBox.DataSource = listaGrupos;
        }
        private void CargarMaterias()
        {
            // Obtener la lista de materias desde la base de datos
            List<Materia> materias = Ctl_Materias.GetList();

            // Asignar la lista de materias al DataSource del ComboBox
            FiltroMateriaComboBox.DataSource = materias;

            // Especificar qué propiedad de la clase Materia se mostrará en el ComboBox
            FiltroMateriaComboBox.DisplayMember = "nom_materia";

            // Opcional: Puedes especificar qué propiedad de la clase Materia se utilizará como valor
            // MateriaComboBox.ValueMember = "id_materia";

            // Habilitar la funcionalidad de búsqueda
            FiltroMateriaComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FiltroMateriaComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void CargarProfesores()
        {
            // Obtener la lista de profesores desde la base de datos
            List<Profesor> profesores = Ctl_Profesor.GetList();

            // Ordenar la lista de profesores según los criterios mencionados
            profesores.Sort((x, y) => string.Compare(x.NombreCompleto, y.NombreCompleto, StringComparison.Ordinal));

            // Asignar la lista de profesores al DataSource del ComboBox
            FiltroProfesorComboBox.DataSource = profesores;

            // Especificar qué propiedad de la clase Profesor se mostrará en el ComboBox
            FiltroProfesorComboBox.DisplayMember = "NombreCompleto";

            // Habilitar la funcionalidad de búsqueda
            FiltroProfesorComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FiltroProfesorComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

    }
}
