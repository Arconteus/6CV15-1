using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeAsistencia
{
    public partial class PantallaRegitroHorario : Form
    {
        public PantallaRegitroHorario()
        {
            InitializeComponent();
            CargarGruposEnComboBox();
            CargarHorasEnDataGridView();

            // Configura AllowUserToAddRows a false para evitar la fila adicional sin información
            RegistroPDGV.AllowUserToAddRows = false;

            // Agrega el evento de clic al botón "AgregarHButton"
            AgregarHButton.Click += AgregarHButton_Click;
        }

        private void AgregarHButton_Click(object sender, EventArgs e)
        {
            // Obtiene el grupo seleccionado
            CodigoGrupo grupoSeleccionado = (CodigoGrupo)MateriaComboBox.SelectedItem;

            // Verifica si se ha seleccionado una celda en el DataGridView
            if (RegistroPDGV.SelectedCells.Count > 0)
            {
                // Obtiene la celda seleccionada
                DataGridViewCell cell = RegistroPDGV.SelectedCells[0];

                // Verifica si la celda está en blanco o contiene "Libre"
                if (cell.Value == null || cell.Value.ToString() == "Libre")
                {
                    // Actualiza el valor de la celda con el nuevo grupo si la celda está en blanco o contiene "Libre"
                    cell.Value = grupoSeleccionado.desc_grupo;
                }
                else
                {
                    // Verifica si la celda contiene un grupo existente
                    if (cell.Value.ToString() != grupoSeleccionado.desc_grupo)
                    {
                        // Pregunta al usuario si desea reemplazar el grupo existente
                        DialogResult result = MessageBox.Show($"¿Estás seguro de que deseas reemplazar al grupo '{cell.Value}' por '{grupoSeleccionado.desc_grupo}'?", "Reemplazo de grupo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // Realiza la acción correspondiente según la respuesta del usuario
                        if (result == DialogResult.Yes)
                        {
                            // Actualiza el valor de la celda con el nuevo grupo
                            cell.Value = grupoSeleccionado.desc_grupo;
                        }
                    }
                }
            }
            else
            {
                // Muestra un mensaje si no se ha seleccionado ninguna celda
                MessageBox.Show("Por favor, seleccione una celda vacía en el horario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MateriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistroPDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HorarioGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AgregarPButton_Click(object sender, EventArgs e)
        {

        }
        private void CargarHorasEnDataGridView()
        {
            List<Hora> horas = Ctl_Hora.GetList();
            foreach (Hora hora in horas)
            {
                RegistroPDGV.Rows.Add(hora.desc_horas, "Libre", "Libre", "Libre", "Libre", "Libre");
            }
        }

        private void CargarGruposEnComboBox()
        {
            List<CodigoGrupo> grupos = Ctl_CodigoGrupo.GetList();
            MateriaComboBox.DataSource = grupos;
            MateriaComboBox.DisplayMember = "desc_grupo";
            // MateriaComboBox.ValueMember = "id_codigo"; // Opcional, si tienes un valor asociado
        }

        private void PantallaRegitroHorario_Load(object sender, EventArgs e)
        {

        }
    }
}
