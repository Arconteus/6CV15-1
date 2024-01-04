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
        private bool eventSubscribed = false;
        private int numeroFilaActual = 1;

        public PantallaRegistroMateria()
        {
            InitializeComponent();
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Eliminar";
            buttonColumn.Name = "EliminarButtonColumn";
            buttonColumn.Text = "Eliminar";
            buttonColumn.UseColumnTextForButtonValue = true;
            RegistroMDGV.Columns.Add(buttonColumn);

            AddMateriaButton.Click += AddMateriaButton_Click;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddMateriaButton_Click(object sender, EventArgs e)
        {
            string materia = MateriaTextBox.Text;

            RegistroMDGV.Rows.Add(numeroFilaActual, materia, "");
            MateriaTextBox.Clear();

            numeroFilaActual++;
        }

        private void RegistroMDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == RegistroMDGV.Columns["EliminarButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar esta materia?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int numeroFila = (int)RegistroMDGV.Rows[e.RowIndex].Cells[0].Value;

                    RegistroMDGV.Rows.RemoveAt(e.RowIndex);

                    for (int i = 0; i < RegistroMDGV.Rows.Count; i++)
                    {
                        RegistroMDGV.Rows[i].Cells[0].Value = i + 1;
                    }

                    numeroFilaActual = RegistroMDGV.Rows.Count + 1;
                }
            }
        }

        private void PantallaRegistroMateria_Load(object sender, EventArgs e)
        {
            if (!eventSubscribed)
            {
                RegistroMDGV.CellContentClick += RegistroMDGV_CellContentClick;
                eventSubscribed = true;
            }
        }
    }
}