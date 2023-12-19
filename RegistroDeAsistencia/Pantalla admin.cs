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
            Grupo grupo = new Grupo()
            {
                id_grupo=int.Parse(GrupotextBox3.Text)
            };
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Ctl_Grupo.GetList();
        }

    }

}
