using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;

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

        private void MateriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Materialabel3_Click(object sender, EventArgs e)
        {

        }

        private void PantallaAdmin_Load(object sender, EventArgs e)
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

        private void AñoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ProfesorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
