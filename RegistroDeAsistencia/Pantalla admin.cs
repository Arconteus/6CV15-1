using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;
namespace RegistroDeAsistencia
{


    public partial class Pantalla_admin : Form
    {
        private string nom_materia;

        public Pantalla_admin()
        {
            InitializeComponent();



        }
        private void Agregargrupobutton1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(SemestretextBox2.Text, out int periodo) &&
                int.TryParse(GrupotextBox3.Text, out int codigoGrupo) &&
                int.TryParse(MateriatextBox4.Text, out int idMateriaGrupo) &&
                int.TryParse(ProfesortextBox5.Text, out int idProfesorGrupo))
            {
                Grupo grupo = new Grupo()
                {
                    codigo_grupo = codigoGrupo,
                    id_materia_grupo = idMateriaGrupo,
                    id_profesor_grupo = idProfesorGrupo
                };

                Ctl_Grupo.Add(grupo);
                {
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = Ctl_Grupo.GetList();
                }
            }
            else
            {
                MessageBox.Show("Ingresa valores numéricos válidos en los campos.", "Error de entrada");
            }
        }



    }

}
