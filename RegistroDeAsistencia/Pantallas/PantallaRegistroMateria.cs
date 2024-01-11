using Microsoft.FSharp.Core;
using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;
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

namespace RegistroDeAsistencia
{
    public partial class PantallaRegistroMateria : Form
    {
        private int numeroFilaActual = 1;

        public PantallaRegistroMateria()
        {
            InitializeComponent();
            Configurar();
        }
        //==================================================================
        // Funciones custom
        //==================================================================
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Configurar()
        {
            List<Materia> materias = Ctl_Materias.GetList();
            RegistroMDGV.DataSource = materias;

            //Configuracion del estilo del boton de eliminacion
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Eliminar";
            buttonColumn.Name = "EliminarButtonColumn";
            buttonColumn.Text = "Eliminar";
            buttonColumn.UseColumnTextForButtonValue = true;
            //Configuracion del estilo del boton de eliminacion
            DataGridViewButtonColumn buttonColumn1 = new DataGridViewButtonColumn();
            buttonColumn1.HeaderText = "Eliminar";
            buttonColumn1.Name = "EliminarButtonColumn";
            buttonColumn1.Text = "Eliminar";
            buttonColumn1.UseColumnTextForButtonValue = true;
            //Agregar el boton de aliminacion
            RegistroMDGV.Columns.Add(buttonColumn);
            CodigoDGV.Columns.Add(buttonColumn1);

            RegistroMDGV.Columns["EliminarButtonColumn"].DisplayIndex = RegistroMDGV.Columns.Count - 1;
            CodigoDGV.Columns["EliminarButtonColumn"].DisplayIndex = RegistroMDGV.Columns.Count - 1;

            AddMateriaButton.Click += AddMateriaButton_Click;
            RegistroMDGV.Columns["id_materia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            RegistroMDGV.Columns["nom_materia"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RegistroMDGV.Columns["EliminarButtonColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            RegistroMDGV.Columns["EliminarButtonColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            RegistroMDGV.Columns["id_materia"].HeaderText = "ID";
            RegistroMDGV.Columns["nom_materia"].HeaderText = "Materia";
            RegistroMDGV.Columns["EliminarButtonColumn"].HeaderText = "Eliminar";
            CodigoDGV.Columns["EliminarButtonColumn"].HeaderText = "Eliminar";

            // Establece AutoSizeColumnsMode a None para evitar ajustes automáticos de tamaño de columna
            RegistroMDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            CodigoDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            ActualizarCodigos();
        }

        private void ActualizarCodigos()
        {
            CodigoDGV.Rows.Clear();
            List<CodigoGrupo> _codigos = Ctl_CodigoGrupo.GetList();
            foreach (CodigoGrupo iteration in _codigos)
            {
                int i = CodigoDGV.Rows.Add();
                CodigoDGV.Rows[i].Cells["ID"].Value = iteration.id_codigo;
                CodigoDGV.Rows[i].Cells["CodigoGrupo"].Value = iteration.desc_grupo;
            }
        }

        //==================================================================
        // Funciones de forms
        //==================================================================

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void AddMateriaButton_Click(object sender, EventArgs e)
        {
            // Obtén el nombre de la materia desde el TextBox
            string materiaNombre = MateriaTextBox.Text.ToUpper();

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
            if (e.ColumnIndex != RegistroMDGV.Columns["EliminarButtonColumn"].Index && e.RowIndex >= 0) return;

            DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar esta materia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            string _id_materia = RegistroMDGV.Rows[e.RowIndex].Cells["id_materia"].Value.ToString();

            if (Ctl_Grupo.GetList("where id_materia_grupo = " + _id_materia).Count > 0)
            {
                MessageBox.Show("No se puede eliminar esta materia debido a que hay un grupo vinculado");
                return;
            }

            Materia _materia = new Materia() { id = int.Parse(_id_materia) };
            bool DeleteSuccess = Ctl_Materias.Delete(_materia);

            if (DeleteSuccess)
            {
                ActualizarMDGV();
            }
            else
            {
                ActualizarMDGV();
                MessageBox.Show("Error al eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ActualizarMDGV()
        {
            throw new NotImplementedException();
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

        private void AddCodigoButton_Click(object sender, EventArgs e)
        {
            if(CodigoTB.Text.Length>=6)
            {
                Ctl_CodigoGrupo.Add(new CodigoGrupo() { desc_grupo = CodigoTB.Text.ToUpper() });
            }
            ActualizarCodigos();
        }

        private void CodigoDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == CodigoDGV.Columns["EliminarButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta materia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int _idCodigo = (int)CodigoDGV.Rows[e.RowIndex].Cells["ID"].Value;

                    bool exito = Ctl_CodigoGrupo.Delete(new CodigoGrupo() { id_codigo = _idCodigo });

                    if (exito)
                    {
                        ActualizarCodigos();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el codigo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
