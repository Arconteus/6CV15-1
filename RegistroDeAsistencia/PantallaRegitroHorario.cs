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
            CargarDiasEnComboBox();
            CargarHorasEnComboBox();
            CargarGruposEnComboBox();  // Agrega esta línea para cargar los grupos en el ComboBox

            // Agrega esta línea para cargar los datos en la DataGridView
            CargarHorasEnDataGridView();

            // Configura AllowUserToAddRows a false para evitar la fila adicional sin información
            RegistroPDGV.AllowUserToAddRows = false;
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

        private void CargarDiasEnComboBox()
        {
            List<Dia> dias = Ctl_Dia.GetList();
            DiaComboBox.DataSource = dias;
            DiaComboBox.DisplayMember = "desc_dia";
            // DiaComboBox.ValueMember = "id_diaSemana"; // Opcional, si tienes un valor asociado
        }

        private void CargarHorasEnComboBox()
        {
            List<Hora> horas = Ctl_Hora.GetList();
            HoraComboBox.DataSource = horas;
            HoraComboBox.DisplayMember = "desc_horas";
            // HoraComboBox.ValueMember = "id_horas"; // Opcional, si tienes un valor asociado
        }

        private void CargarHorasEnDataGridView()
        {
            List<Hora> horas = Ctl_Hora.GetList();
            foreach (Hora hora in horas)
            {
                RegistroPDGV.Rows.Add(hora.desc_horas, "", "", "", "", "");
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
