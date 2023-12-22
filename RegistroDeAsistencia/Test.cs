using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;

namespace RegistroDeAsistencia
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CodigoGrupo codigo = new CodigoGrupo()
            {
                desc_grupo = GrupoTextBox.Text.ToString()
            };
            Ctl_CodigoGrupo.Add(codigo);
        }

        private void ContainButton_Click(object sender, EventArgs e)
        {
            CodigoGrupo codigo = new CodigoGrupo()
            {
                desc_grupo = GrupoTextBox.Text.ToString()
            };
            ContainCheckBox.Checked = Ctl_CodigoGrupo.Contain(codigo);

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Ctl_CodigoGrupo.GetList();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrupoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
