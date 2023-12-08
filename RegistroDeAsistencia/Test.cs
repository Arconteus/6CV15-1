using RegistroDeAsistencia.DataBase.Control;

namespace RegistroDeAsistencia
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Ctl_codigoGrupo.GetList();
            Ctl_codigoGrupo.Contain("6CV15");
        }
    }
}