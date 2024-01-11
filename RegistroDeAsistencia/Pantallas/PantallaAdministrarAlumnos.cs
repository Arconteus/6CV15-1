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

namespace RegistroDeAsistencia.Pantallas
{
    public partial class PantallaAdministrarAlumnos : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public PantallaAdministrarAlumnos()
        {
            InitializeComponent();
            ConfigurarDGV();
            UpdateDGV();
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void ConfigurarDGV()
        {
            //Configuracion del estilo del boton de eliminacion
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            buttonColumn.HeaderText = "Eliminar";
            buttonColumn.Name = "EliminarButtonColumn";
            buttonColumn.Text = "Eliminar";
            buttonColumn.UseColumnTextForButtonValue = true;
            AlumnosDGV.Columns.Add(buttonColumn);
            AlumnosDGV.Columns["EliminarButtonColumn"].DisplayIndex = AlumnosDGV.Columns.Count - 1;
            AlumnosDGV.Columns["EliminarButtonColumn"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            AlumnosDGV.Columns["EliminarButtonColumn"].HeaderText = "Eliminar";
        }

        private void RegistroDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex != AlumnosDGV.Columns["EliminarButtonColumn"].Index && e.RowIndex >= 0) return;
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar a este alumno?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes) return;
            string _boleta_alumno = AlumnosDGV.Rows[e.RowIndex].Cells["Boleta"].Value.ToString();
            Alumno _alumno = Ctl_Alumno.GetList("where boleta = " + _boleta_alumno).First();
            if (Tbl_RelacionRegistroAlumno.GetList("where id_alumno_registro = " + _alumno.id_alumno).Count > 0)
            {
                MessageBox.Show("No se puede eliminar este alumno debido a que hay un registro vinculado");
                return;
            }
            bool DeleteSuccess = Ctl_Alumno.Delete(_alumno);

            if (DeleteSuccess)
            {
                UpdateDGV();
            }
            else
            {
                UpdateDGV();
                MessageBox.Show("Error al eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdateDGV()
        {
            AlumnosDGV.Rows.Clear();
            foreach (Alumno iteration in Ctl_Alumno.GetList())
            {
                int i = AlumnosDGV.Rows.Add();
                AlumnosDGV.Rows[i].Cells["Boleta"].Value = iteration.boleta;
                AlumnosDGV.Rows[i].Cells["Nombre"].Value = iteration.nom_alumno;
                AlumnosDGV.Rows[i].Cells["Apa"].Value = iteration.apa_alumno;
                AlumnosDGV.Rows[i].Cells["Ama"].Value = iteration.ama_alumno;
                Escuela _escuela = Ctl_Escuela.GetList("where id_escuela = " + iteration.escuela_alumno).First();
                AlumnosDGV.Rows[i].Cells["Escuela"].Value = _escuela.nom_escuela;
                Carrera _carrera = Ctl_Carrera.GetList("where id_carrera = " + iteration.carrera_alumno).First();
                AlumnosDGV.Rows[i].Cells["Carrera"].Value = _carrera.nom_carrera;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
