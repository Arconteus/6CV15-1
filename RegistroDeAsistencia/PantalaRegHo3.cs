using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RegistroDeAsistencia
{
    public partial class PantalaRegHo3 : Form
    {
        public PantalaRegHo3()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PantalaRegHo3_Load(object sender, EventArgs e)
        {
            // Definir los datos para la primera columna
            List<string> horarios = new List<string>
            {
                "07:00",
                "08:30",
                "10:00",
                "11:30",
                "13:00",
                "14:30",
                "16:00",
                "17:30",
                "19:00",
                "20:30",
            };

            // Agregar los datos al DataGridView
            foreach (var horario in horarios)
            {
                RegistroHDGV.Rows.Add(horario); // Asumiendo que la primera columna es la predeterminada
            }
        }
    }
}
