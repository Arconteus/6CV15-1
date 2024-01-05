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

namespace RegistroDeAsistencia
{
    public partial class PantallaRegistroMateria : Form
    {
        private int numeroFilaActual = 1;

        public PantallaRegistroMateria()
        {
            InitializeComponent();

            List<Materia> materias = Ctl_Materias.GetList();

            RegistroMDGV.DataSource = materias;

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Eliminar";
            buttonColumn.Name = "EliminarButtonColumn";
            buttonColumn.Text = "Eliminar";
            buttonColumn.UseColumnTextForButtonValue = true;
            RegistroMDGV.Columns.Add(buttonColumn);

            RegistroMDGV.Columns["EliminarButtonColumn"].DisplayIndex = RegistroMDGV.Columns.Count - 1;

            AddMateriaButton.Click += AddMateriaButton_Click;
            RegistroMDGV.Columns["id_materia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            RegistroMDGV.Columns["nom_materia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RegistroMDGV.Columns["EliminarButtonColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            // Establece AutoSizeColumnsMode a None para evitar ajustes automáticos de tamaño de columna
            RegistroMDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
        }

        private void AddMateriaButton_Click(object sender, EventArgs e)
        {
            // Obtén el nombre de la materia desde el TextBox
            string materiaNombre = MateriaTextBox.Text;

            // Verifica si el campo de texto está vacío
            if (string.IsNullOrWhiteSpace(materiaNombre))
            {
                MessageBox.Show("Por favor, ingresa el nombre de la materia.", "Campo Vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Detiene la ejecución si el campo está vacío
            }

            // Crea una nueva instancia de la clase Materia con el nombre ingresado
            Materia nuevaMateria = new Materia { nom_materia = materiaNombre };

            // Agrega la nueva materia a la base de datos
            bool exito = Ctl_Materias.Add(nuevaMateria);

            // Si la adición fue exitosa, actualiza el DataGridView
            if (exito)
            {
                // Refresca la lista de materias desde la base de datos
                List<Materia> materias = Ctl_Materias.GetList();

                // Asigna la lista actualizada al DataSource del DataGridView
                RegistroMDGV.DataSource = null;
                RegistroMDGV.DataSource = materias;

                RegistroMDGV.Columns["EliminarButtonColumn"].DisplayIndex = RegistroMDGV.Columns.Count - 1;

                // Establecer anchos específicos para las columnas
                RegistroMDGV.Columns["id_materia"].Width = 50;  // Ancho en píxeles
                RegistroMDGV.Columns["nom_materia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                RegistroMDGV.Columns["EliminarButtonColumn"].Width = 80;  // Ancho en píxeles
            }

            // Limpia el TextBox después de agregar la materia
            MateriaTextBox.Clear();
        }

        private void RegistroMDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == RegistroMDGV.Columns["EliminarButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta materia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idMateria = (int)RegistroMDGV.Rows[e.RowIndex].Cells["id_materia"].Value;

                    bool exito = Ctl_Materias.Delete(idMateria);

                    if (exito)
                    {
                        // Refresca la lista de materias desde la base de datos
                        List<Materia> materias = Ctl_Materias.GetList();

                        // Asigna la lista actualizada al DataSource del DataGridView
                        RegistroMDGV.DataSource = null;
                        RegistroMDGV.DataSource = materias;

                        RegistroMDGV.Columns["EliminarButtonColumn"].DisplayIndex = RegistroMDGV.Columns.Count - 1;

                        // Establecer anchos específicos para las columnas
                        RegistroMDGV.Columns["id_materia"].Width = 50;  // Ancho en píxeles
                        RegistroMDGV.Columns["nom_materia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        RegistroMDGV.Columns["EliminarButtonColumn"].Width = 80;  // Ancho en píxeles

                        // Actualiza los números de fila
                        for (int i = 0; i < RegistroMDGV.Rows.Count; i++)
                        {
                            RegistroMDGV.Rows[i].Cells[0].Value = i + 1;
                        }

                        numeroFilaActual = RegistroMDGV.Rows.Count + 1;
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la materia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PantallaRegistroMateria_Load(object sender, EventArgs e)
        {
            RegistroMDGV.CellContentClick += RegistroMDGV_CellContentClick;

            RegistroMDGV.Columns["EliminarButtonColumn"].DisplayIndex = RegistroMDGV.Columns.Count - 1;
        }

        private void ActualGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
