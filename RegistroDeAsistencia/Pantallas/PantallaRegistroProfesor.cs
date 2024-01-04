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
    public partial class PantallaRegistroProfesor : Form
    {
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
                    RegistroPDGV.Rows.RemoveAt(e.RowIndex);

                    for (int i = 0; i < RegistroPDGV.Rows.Count; i++)
                    {
                        RegistroPDGV.Rows[i].Cells[0].Value = i + 1;
                    }
                }
            }
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

        private void AgregarPButton_Click(object sender, EventArgs e)
        {
            int numero = RegistroPDGV.Rows.Count + 1;  
            string nt = NTTextBox.Text;
            string nombre = NombreTextBox.Text;
            string ap = APTextBox.Text;
            string am = AMTextBox.Text;

            RegistroPDGV.Rows.Add(numero, nt, nombre, ap, am);

            for (int i = 0; i < RegistroPDGV.Rows.Count; i++)
            {
                RegistroPDGV.Rows[i].Cells[0].Value = i + 1;
            }

            NTTextBox.Text = "";
            NombreTextBox.Text = "";
            APTextBox.Text = "";
            AMTextBox.Text = "";
        }
    }
}
