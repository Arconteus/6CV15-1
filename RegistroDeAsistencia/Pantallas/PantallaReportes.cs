﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;

namespace RegistroDeAsistencia
{
    public partial class PantallaReportes : Form
    {
        private DataTable dt;
        private List<CodigoGrupo> listaGrupos;
        private System.Windows.Forms.Timer timer;

        public PantallaReportes()
        {
            InitializeComponent();
            ActualizarDGV();
            dt = new DataTable();
            // Inicia un temporizador para actualizar la fecha y la hora cada segundo
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000; // Intervalo en milisegundos (1 segundo)
            timer.Tick += Timer_Tick;
            timer.Start();

            // Llama al método para mostrar la fecha y la hora inicialmente
            MostrarFechaYHora();
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PantallaReportes_Load(object sender, EventArgs e)
        {
            // Cargar la lista de grupos desde la base de datos
            listaGrupos = Ctl_CodigoGrupo.GetList();
            CargarProfesores();
            CargarMaterias();

            // Configurar el ComboBox
            FiltroCodigoComboBox.DisplayMember = "desc_grupo";
            FiltroCodigoComboBox.ValueMember = "id_codigo";
            FiltroCodigoComboBox.DataSource = listaGrupos;
        }
        public void FillDGV(List<RegistroAsistencia> Temp)
        {
            
        }
        private void CargarMaterias()
        {
            // Obtener la lista de materias desde la base de datos
            List<Materia> materias = Ctl_Materias.GetList();

            // Asignar la lista de materias al DataSource del ComboBox
            FiltroMateriaComboBox.DataSource = materias;

            // Especificar qué propiedad de la clase Materia se mostrará en el ComboBox
            FiltroMateriaComboBox.DisplayMember = "nom_materia";

            // Opcional: Puedes especificar qué propiedad de la clase Materia se utilizará como valor
            // MateriaComboBox.ValueMember = "id_materia";

            // Habilitar la funcionalidad de búsqueda
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
            FiltroProfesorComboBox.DataSource = profesores;

            // Especificar qué propiedad de la clase Profesor se mostrará en el ComboBox
            FiltroProfesorComboBox.DisplayMember = "NombreCompleto";

            // Habilitar la funcionalidad de búsqueda
            FiltroProfesorComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            FiltroProfesorComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void FiltroProfesorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> fullname = FiltroProfesorComboBox.Text.Split(' ').ToList();
            if (fullname.Count < 3) return;
            string apa_profesor = fullname[0];
            string ama_profesor = fullname[1];
            string nom_profesor = fullname[2];
            if (fullname.Count == 4) nom_profesor += " " + fullname[3];
            Profesor _profesor = Ctl_Profesor.GetList("where apa_profesor = '" + apa_profesor + "' " +
                "and ama_profesor = '" + ama_profesor + "' " +
                "and nom_profesor = '" + nom_profesor + "' ").First();
        }

        private void FiltroMateriaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void ActualizarDGV()
        {
            RegistroDGV.Rows.Clear();
            //FillDGV(Ctl_Grupo.GetList());
        }
        public void ActualizarDGV(string input)
        {
            RegistroDGV.Rows.Clear();
            //FillDGV(Ctl_Grupo.GetList(input));
        }

        private void BuscarButton_Click(object sender, EventArgs e)
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
                string _whereClause = "where desc_grupo = '" + FiltroCodigoComboBox.Text + "'";
                if (Ctl_CodigoGrupo.GetList(_whereClause).Count > 0)
                {
                    CodigoGrupo _codigoGrupo = Ctl_CodigoGrupo.GetList(_whereClause).First();
                    if (whereClause != "where ") whereClause += "and ";
                    whereClause += "codigo_grupo = " + _codigoGrupo.id_codigo;
                }
            }
            if (FiltroMateriaComboBox.Text != "HORA LIBRE" && FiltroMateriaComboBox.Text.Trim() != "-" && FiltroMateriaComboBox.Text.Trim() != "")
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
                if (fullname.Count > 2)
                {
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
    }
}
