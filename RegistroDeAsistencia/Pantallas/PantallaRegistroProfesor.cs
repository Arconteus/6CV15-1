using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;

namespace RegistroDeAsistencia
{
    public partial class PantallaRegistroProfesor : Form
    {
        private List<Profesor> listaProfesores;

        public PantallaRegistroProfesor()
        {
            InitializeComponent();
            AgregarPButton.Click += AgregarPButton_Click;
            RegistroPDGV.CellContentClick += RegistroPDGV_CellContentClick;

            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButtonColumn";
            deleteButtonColumn.HeaderText = "Eliminar";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            RegistroPDGV.Columns.Add(deleteButtonColumn);

            // Evitar la fila vacía adicional al final del DataGridView
            RegistroPDGV.AllowUserToAddRows = false;

            // Cargar los datos almacenados localmente al iniciar la aplicación
            listaProfesores = Ctl_Profesor.GetList();
            CargarDatosAlDataGridView();

            // Añadir evento para el ComboBox
            SearchComboBox.TextChanged += SearchComboBox_SelectedIndexChanged;
            RegistroPDGV.Columns["DeleteButtonColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        //==================================================================
        // Funciones custom
        //==================================================================
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //==================================================================
        // Funciones de forms
        //==================================================================

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void RegistroPDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != RegistroPDGV.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0) return;

            DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar a este profesor?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            string _id_profesor = RegistroPDGV.Rows[e.RowIndex].Cells["ID2"].Value.ToString();

            if (Ctl_Grupo.GetList("where id_profesor_grupo = " + _id_profesor).Count > 0)
            {
                MessageBox.Show("No se puede eliminar esta materia debido a que hay un grupo vinculado");
                return;
            }

            Profesor _profesor = new Profesor() { id = int.Parse(_id_profesor) };
            bool DeleteSuccess = Ctl_Profesor.Delete(_profesor);

            if (DeleteSuccess)
            {
                ActualizarPDGV();
            }
            else
            {
                ActualizarPDGV();
                MessageBox.Show("Error al eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarPDGV()
        {
            throw new NotImplementedException();
        }

        private void AgregarPButton_Click(object sender, EventArgs e)
        {
            string nt = NTTextBox.Text.ToUpper();
            string nombre = NombreTextBox.Text.ToUpper();
            string ap = APTextBox.Text.ToUpper();
            string am = AMTextBox.Text.ToUpper();

            // Validar campos vacíos antes de agregar una nueva fila
            if (string.IsNullOrWhiteSpace(nt) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(ap) || string.IsNullOrWhiteSpace(am))
            {
                MessageBox.Show("No puede realizarse el registro con campos vacíos", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Llamar al método Add de Ctl_Profesor
            bool addSuccess = Ctl_Profesor.Add(new Profesor()
            {
                num_trabajador = nt,
                nom_profesor = nombre,
                apa_profesor = ap,
                ama_profesor = am
            });

            if (addSuccess)
            {
                // Actualizar la lista de profesores después de agregar uno
                listaProfesores = Ctl_Profesor.GetList();
                CargarDatosAlDataGridView();

                NTTextBox.Text = "";
                NombreTextBox.Text = "";
                APTextBox.Text = "";
                AMTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Error al agregar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarDatosAlDataGridView(List<Profesor> profesores = null)
        {
            // Limpiar DataGridView antes de cargar nuevos datos
            RegistroPDGV.Rows.Clear();

            List<Profesor> profesoresToShow = profesores ?? listaProfesores;

            // Crear una lista temporal para almacenar el mapeo entre el ID original y la posición en la lista
            Dictionary<int, int> idMapping = new Dictionary<int, int>();

            for (int i = 0; i < listaProfesores.Count; i++)
            {
                idMapping.Add(listaProfesores[i].id_profesor, i);
            }

            foreach (var profesor in profesoresToShow)
            {
                // Obtener la posición correcta del profesor en la lista original
                int originalIndex = idMapping[profesor.id_profesor];

                RegistroPDGV.Rows.Add(originalIndex + 1, profesor.num_trabajador, profesor.nom_profesor, profesor.apa_profesor, profesor.ama_profesor);
            }
        }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = SearchComboBox.Text.ToLower();

            // Filtrar la lista de profesores
            List<Profesor> profesoresFiltrados = listaProfesores
                .Where(p => p.num_trabajador.ToLower().Contains(filtro) ||
                            p.nom_profesor.ToLower().Contains(filtro) ||
                            p.apa_profesor.ToLower().Contains(filtro) ||
                            p.ama_profesor.ToLower().Contains(filtro))
                .ToList();

            // Actualizar el DataGridView con la lista filtrada
            CargarDatosAlDataGridView(profesoresFiltrados);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ActualGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PantallaRegistroProfesor_Load(object sender, EventArgs e)
        {

        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NTTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarPButton_Click_1(object sender, EventArgs e)
        {

        }
    }
}
