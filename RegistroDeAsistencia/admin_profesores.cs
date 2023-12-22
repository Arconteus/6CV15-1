using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RegistroDeAsistencia
{   
    public partial class admin_profesores : Form
    {   

        public admin_profesores()
        {
           
            InitializeComponent();

            

            // Agregar el evento Click al botón
  
        }

        private void admin_profesores_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridView1.Columns["id_profesor"].Index)
            {
                // Obtener el id_profesor de la fila clicada
                int idProfesorToDelete = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id_profesor"].Value);

                // Llamar al método ForceDelete para eliminar al profesor
                bool deleteResult = Ctl_Profesor.ForceDelete(idProfesorToDelete);

                if (deleteResult)
                {
                    Console.WriteLine($"Profesor con ID {idProfesorToDelete} eliminado correctamente.");
                    // Actualizar el DataGridView con la lista actualizada desde la base de datos
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Ctl_Profesor.GetList();
                }
                else
                {
                    Console.WriteLine($"No se pudo eliminar el profesor con ID {idProfesorToDelete}.");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void profesorbutton_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor()
            {
                nom_profesor = NombretextBox1.Text.ToString(),
                apa_profesor = PaternotextBox2.Text.ToString(),
                ama_profesor = MaternotextBox3.Text.ToString(),
                num_trabajador = BoletatextBox4.Text.ToString()
            };

            Ctl_Profesor.Add(profesor);// Agregar el profesor a la base de datos
            
            {
                // Actualizar el DataGridView con la lista actualizada desde la base de datos
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = Ctl_Profesor.GetList();
            }
        }




        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            EliminarProfesor();
        }

        private void EliminarProfesor()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Obtener el id_profesor de la fila seleccionada
                int idProfesorToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id_profesor"].Value);

                // Llamar al método ForceDelete para eliminar al profesor
                bool deleteResult = Ctl_Profesor.ForceDelete(idProfesorToDelete);

                if (deleteResult)
                {
                    Console.WriteLine("Profesor eliminado correctamente.");
                    // Actualizar el DataGridView con la lista actualizada desde la base de datos
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Ctl_Profesor.GetList();
                }
                else
                {
                    Console.WriteLine("No se pudo eliminar el profesor.");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un profesor antes de intentar eliminar.", "Aviso");
            }
        }



    }


}
    

