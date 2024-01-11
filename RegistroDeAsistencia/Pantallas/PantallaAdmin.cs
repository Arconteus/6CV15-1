using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;
using System.Data;
using Timer = System.Windows.Forms.Timer;

namespace RegistroDeAsistencia
{
    public partial class PantallaAdmin : Form
    {
        private DataTable dt;
        private Timer timer;
        public PantallaAdmin()
        {
            InitializeComponent();
            ActualizarDGV();
            configuracion();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Este evento se ejecutará cada segundo
            MostrarFechaYHora();
        }
        private void MostrarFechaYHora()
        {
            // Obtén la fecha y la hora actuales
            DateTime ahora = DateTime.Now;

            // Actualiza el texto de los Labels con la fecha y la hora
            FechaLabel.Text = ahora.ToString("dd-MM-yyyy"); // Formato de fecha personalizado
            HoraLabel.Text = ahora.ToString("HH:mm:ss"); // Formato de hora personalizado
        }
        private void RegistroPDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == RegistroDGV.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                      "Confirmar eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string num_trabajador = RegistroDGV.Rows[e.RowIndex].Cells[1].Value.ToString();

                    // Llamar al método Delete de Ctl_Profesor
                    bool deleteSuccess = Ctl_Profesor.Delete(num_trabajador);

                    if (deleteSuccess)
                    {
                        ActualizarDGV();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public void configuracion()
        {
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButtonColumn";
            deleteButtonColumn.HeaderText = "Eliminar";
            deleteButtonColumn.Text = "Eliminar";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            RegistroDGV.Columns.Add(deleteButtonColumn);


            // Inicia un temporizador para actualizar la fecha y la hora cada segundo
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Intervalo en milisegundos (1 segundo)
            timer.Tick += Timer_Tick;
            timer.Start();

            // Llama al método para mostrar la fecha y la hora inicialmente
            MostrarFechaYHora();
        }
        public void FillDGV(List<Grupo> Temp)
        {
            foreach (Grupo iteration in Temp)
            {
                int i = RegistroDGV.Rows.Add();
                RegistroDGV.Rows[i].Cells["id"].Value = iteration.id_grupo;
                RegistroDGV.Rows[i].Cells["anio"].Value = iteration.anio;
                RegistroDGV.Rows[i].Cells["periodo"].Value = iteration.periodo;
                CodigoGrupo _codigoGrupo = Ctl_CodigoGrupo.GetList("where id_codigo = " + iteration.codigo_grupo).First();
                RegistroDGV.Rows[i].Cells["Grupo"].Value = _codigoGrupo.desc_grupo;
                Profesor _profesor = Ctl_Profesor.GetList("where id_profesor = " + iteration.id_profesor_grupo).First();
                RegistroDGV.Rows[i].Cells["Profesor"].Value = _profesor.NombreCompleto;
                Materia _materia = Ctl_Materias.GetList("where id_materia = " + iteration.id_materia_grupo).First();
                RegistroDGV.Rows[i].Cells["Materia"].Value = _materia.nom_materia;
            }
        }
        private void AddMateriaButton_Click(object sender, EventArgs e)
        {
            PantallaRegistroMateria temp = new PantallaRegistroMateria();
            temp.Show();
        }
        private void AddProfesorButton_Click(object sender, EventArgs e)
        {
            PantallaRegistroProfesor temp = new PantallaRegistroProfesor();
            temp.Show();
        }
        private void PantallaAdmin_Load(object sender, EventArgs e)
        {
            // Cargar las materias al ComboBox
            CargarMaterias();
            // Cargar los profesores al ComboBox
            CargarProfesores();
            // Cargar los grupos al ComboBox
            CargarGrupos();
        }
        private void CargarMaterias()
        {
            List<Materia> _materias = Ctl_Materias.GetList();

            /**
            // Asignar la lista de materias al DataSource del ComboBox
            MateriaCB.DataSource = materias;
            FiltroMateriaComboBox.DataSource = materias;
            // Especificar qué propiedad de la clase Materia se mostrará en el ComboBox
            // Opcional: Puedes especificar qué propiedad de la clase Materia se utilizará como valor
            // MateriaComboBox.ValueMember = "id_materia";
            **/

            MateriaCB.Items.Clear();
            FiltroMateriaComboBox.Items.Clear();
            foreach (Materia iteration in _materias)
            {
                MateriaCB.Items.Add(iteration);
                FiltroMateriaComboBox.Items.Add(iteration);
            }

            MateriaCB.DisplayMember = "nom_materia";
            FiltroMateriaComboBox.DisplayMember = "nom_materia";

            // Habilitar la funcionalidad de búsqueda
            MateriaCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            MateriaCB.AutoCompleteSource = AutoCompleteSource.ListItems;
            FiltroMateriaComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FiltroMateriaComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void CargarProfesores()
        {
            // Obtener la lista de profesores desde la base de datos
            List<Profesor> profesores = Ctl_Profesor.GetList();

            // Ordenar la lista de profesores según los criterios mencionados
            profesores.Sort((x, y) => string.Compare(x.NombreCompleto, y.NombreCompleto, StringComparison.Ordinal));

            // Asignar la lista de profesores al DataSource del ComboBox
            ProfesorCB.DataSource = profesores;
            FiltroProfesorComboBox.DataSource = profesores;
            // Especificar qué propiedad de la clase Profesor se mostrará en el ComboBox
            ProfesorCB.DisplayMember = "NombreCompleto";
            FiltroProfesorComboBox.DisplayMember = "NombreCompleto";
            // Habilitar la funcionalidad de búsqueda
            ProfesorCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            ProfesorCB.AutoCompleteSource = AutoCompleteSource.ListItems;
            FiltroProfesorComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FiltroProfesorComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        public void CargarGrupos()
        {
            // Obtener la lista de grupos desde la base de datos
            List<CodigoGrupo> grupos = Ctl_CodigoGrupo.GetList();

            // Asignar la lista de grupos al DataSource del ComboBox
            CodigoGrupoCB.DataSource = grupos;
            FiltroCodigoComboBox.DataSource = grupos;
            // Especificar qué propiedad de la clase CodigoGrupo se mostrará en el ComboBox
            CodigoGrupoCB.DisplayMember = "desc_grupo";
            FiltroCodigoComboBox.DisplayMember = "desc_grupo";
            // Habilitar la funcionalidad de búsqueda
            CodigoGrupoCB.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            CodigoGrupoCB.AutoCompleteSource = AutoCompleteSource.ListItems;
            FiltroCodigoComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FiltroCodigoComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void AddGrupoButton_Click(object sender, EventArgs e)
        {
            bool output = true;
            if (AnioTB.Text == null) output = false;
            if (PeriodoCB.Text == null) output = false;
            if (CodigoGrupoCB.Text == null) output = false;
            if (Materia == null) output = false;
            if (ProfesorCB.Text == null) output = false;
            if (output)
            {
                CodigoGrupo _codigoGrupo = Ctl_CodigoGrupo.GetList("where desc_grupo = '" + CodigoGrupoCB.Text.Trim() + "'").First();
                Materia _materia = Ctl_Materias.GetList("where nom_materia = '" + MateriaCB.Text.Trim() + "'").First();
                List<String> fullname = ProfesorCB.Text.Split(' ').ToList();
                string apa_profesor = fullname[0];
                string ama_profesor = fullname[1];
                string nom_profesor = fullname[2];
                if (fullname.Count == 4) nom_profesor += " " + fullname[3];
                Profesor _profesor = Ctl_Profesor.GetList("where apa_profesor = '" + apa_profesor + "' " +
                    "and ama_profesor = '" + ama_profesor + "' " +
                    "and nom_profesor = '" + nom_profesor + "' ").First();
                Ctl_Grupo.Add(new Grupo()
                {
                    anio = int.Parse(AnioTB.Text),
                    periodo = int.Parse(PeriodoCB.Text),
                    codigo_grupo = _codigoGrupo.id_codigo,
                    id_materia_grupo = _materia.id_materia,
                    id_profesor_grupo = _profesor.id_profesor
                });
            }
            ActualizarDGV();
        }
        public void ActualizarDGV()
        {
            RegistroDGV.Rows.Clear();
            FillDGV(Ctl_Grupo.GetList());
        }
        public void ActualizarDGV(string input)
        {
            RegistroDGV.Rows.Clear();
            FillDGV(Ctl_Grupo.GetList(input));
        }
        private void RegistroDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == RegistroDGV.Columns["DeleteButtonColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                      "Confirmar eliminación",
                                                      MessageBoxButtons.YesNo,
                                                      MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string _id_grupo = RegistroDGV.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    Grupo _grupo = new Grupo() { id_grupo = int.Parse(_id_grupo) };

                    // Llamar al método Delete de Ctl_Profesor
                    bool deleteSuccess = Ctl_Grupo.Delete(_grupo);

                    if (deleteSuccess)
                    {
                        ActualizarDGV();
                    }
                    else
                    {
                        ActualizarDGV();
                        MessageBox.Show("Error al eliminar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Grupo Temo = new Grupo();
            Temo.id_profesor_grupo = 0;
            string whereClause = "where ";
            if (FiltroAñoTextBox.Text.Trim() != "")
            {
                whereClause += "anio = " + FiltroAñoTextBox.Text;
            }
            if (FiltroCodigoComboBox.Text != "Sin codigo" && FiltroCodigoComboBox.Text.Trim() != "")
            {
                CodigoGrupo _codigoGrupo = Ctl_CodigoGrupo.GetList("where desc_grupo = '" + FiltroCodigoComboBox.Text + "'").First();
                if (whereClause != "where ") whereClause += "and ";
                whereClause += "codigo_grupo = " + _codigoGrupo.id_codigo;
            }
            if (FiltroMateriaComboBox.Text != "HORA LIBRE" && FiltroMateriaComboBox.Text.Trim() != "")
            {
                Materia _materia = Ctl_Materias.GetList("where nom_materia = '" + FiltroMateriaComboBox.Text + "'").First();
                if (whereClause != "where ") whereClause += "and ";
                whereClause += "id_materia_grupo = " + _materia.id_materia;
            }
            if (FiltroPeriodoComboBox.Text != "-" && FiltroPeriodoComboBox.Text.Trim() != "")
            {
                if (whereClause != "where ") whereClause += "and ";
                whereClause += "periodo = " + FiltroPeriodoComboBox.Text;
            }
            if (FiltroProfesorComboBox.Text != "- - Sin profesor" && FiltroProfesorComboBox.Text.Trim() != "")
            {
                List<String> fullname = FiltroProfesorComboBox.Text.Split(' ').ToList();
                string apa_profesor = fullname[0];
                string ama_profesor = fullname[1];
                string nom_profesor = fullname[2];
                if (fullname.Count == 4) nom_profesor += " " + fullname[3];
                Profesor _profesor = Ctl_Profesor.GetList(
                    "where apa_profesor = '" + apa_profesor + "' " +
                    "and ama_profesor = '" + ama_profesor + "' " +
                    "and nom_profesor = '" + nom_profesor + "' ").First();
                if (whereClause != "where ") whereClause += "and ";
                whereClause += "id_profesor_grupo = " + _profesor.id_profesor;
            }
            if (whereClause != "where ")
            {
                ActualizarDGV(whereClause);
            }
            else
            {
                ActualizarDGV();
            }
        }
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void PantallaAdmin_Enter(object sender, EventArgs e)
        {
            CargarMaterias();
            CargarGrupos();
            CargarProfesores();
        }
    }
}
