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
    }
}
