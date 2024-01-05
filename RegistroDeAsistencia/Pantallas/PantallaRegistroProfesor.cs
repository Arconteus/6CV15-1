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

        private void RegistroPDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == RegistroPDGV.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                      "Confirmar eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string num_trabajador = RegistroPDGV.Rows[e.RowIndex].Cells[1].Value.ToString();

                    // Llamar al método Delete de Ctl_Profesor
                    bool deleteSuccess = Ctl_Profesor.Delete(num_trabajador);

                    if (deleteSuccess)
                    {
                        // Actualizar la lista de profesores después de eliminar uno
                        listaProfesores = Ctl_Profesor.GetList();
                        CargarDatosAlDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void AgregarPButton_Click(object sender, EventArgs e)
        {
            string nt = NTTextBox.Text;
            string nombre = NombreTextBox.Text;
            string ap = APTextBox.Text;
            string am = AMTextBox.Text;

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

        private void RegistroMDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NTTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
