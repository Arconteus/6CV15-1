using HtmlAgilityPack;
using Microsoft.VisualBasic;
using RegistroDeAsistencia.DataBase.Control;
using RegistroDeAsistencia.DataBase.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroDeAsistencia.Pantallas
{
    public partial class PantallaAdministracionHorarios : Form
    {
        //==================================================================
        // Funciones custom
        //==================================================================
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public PantallaAdministracionHorarios()
        {
            InitializeComponent();
            ConfigurarDGV();
            AnioTB.Text = DateTime.Now.Year.ToString();
            PeriodoCB.Text = "1";
            CargarHorario();
        }
        private void ConfigurarDGV()
        {
            UpdateGrupos();
            foreach (Hora iteration in Ctl_Hora.GetList())
            {
                int i = HorarioDGV.Rows.Add();
                HorarioDGV.Rows[i].Cells["Hora"].Value = iteration.desc_horas;
                if (i != 0)
                {
                    HorarioDGV.Rows[i - 1].Cells["Hora"].Value += "-" + iteration.desc_horas;
                }
            }
            HorarioDGV.Rows.RemoveAt(HorarioDGV.Rows.Count - 1);
        }

        private void UpdateGrupos()
        {
            if (AnioTB.Text.Length > 4) return;
            if (PeriodoCB.Text.Trim() == "-") return;
            List<String> _Elements = new List<String>();
            _Elements.Add("Hora libre");
            foreach (Grupo iteration in Ctl_Grupo.GetList("where anio = " + AnioTB.Text.Trim() + " AND periodo = " + PeriodoCB.Text.Trim()))
            {
                string _anio = iteration.anio.ToString();
                string _periodo = iteration.periodo.ToString();
                CodigoGrupo _temoGrupo = Ctl_CodigoGrupo.GetList("where id_codigo = " + iteration.codigo_grupo).First();
                string _codigo = _temoGrupo.desc_grupo.ToString();
                _Elements.Add(_anio + "-" + _periodo + "-" + _codigo);
            }
            GrupoCB.DataSource = _Elements;
            GrupoCB.AutoCompleteMode = AutoCompleteMode.Suggest;
            GrupoCB.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HoraCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DiaCB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void AnioTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (HorarioDGV.CurrentCell.ColumnIndex == 0)
            {
                MessageBox.Show("No puedes cambiar una columna de horario.");
                return;
            }
            if (HorarioDGV.SelectedCells.Count < 1)
            {
                MessageBox.Show("Debes seleccionar una celda de la tabla.");
                return;
            }
            DialogResult _answer = MessageBox.Show("Esta accion remplazara la celda seleccionada",
                "¿Estas seguro que quieres hacerlo?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (_answer != DialogResult.Yes) return;
            HorarioDGV.SelectedCells[0].Value = GrupoCB.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateGrupos();
            CargarHorario();
        }

        private void CargarHorario()
        {
            //Limpiar la tabla
            HorarioDGV.Rows.Clear();
            foreach (Hora iteration in Ctl_Hora.GetList())
            {
                int i = HorarioDGV.Rows.Add();
                HorarioDGV.Rows[i].Cells["Hora"].Value = iteration.desc_horas;
                if (i != 0)
                {
                    HorarioDGV.Rows[i - 1].Cells["Hora"].Value += "-" + iteration.desc_horas;
                }
            }
            HorarioDGV.Rows.RemoveAt(HorarioDGV.Rows.Count - 1);
            //Filtros momento
            if (AnioTB.Text.Length > 4) return;
            if (PeriodoCB.Text.Trim() == "-") return;
            List<Horario> _horario = new List<Horario>();
            foreach (Grupo iteration in Ctl_Grupo.GetList("where anio = " + AnioTB.Text + " and periodo = " + PeriodoCB.Text))
            {
                foreach (Horario _Temp in Ctl_Horario.GetList("where grupo_horario = " + iteration.id_grupo))
                {
                    _horario.Add(_Temp);
                }
            }
            foreach (Horario iteration in _horario)
            {
                Dia _dia = Ctl_Dia.GetList("and id_diaSemena = " + iteration.dia_horario).First();
                Grupo _grupo = Ctl_Grupo.GetList("where id_grupo = " + iteration.grupo_horario).First();
                CodigoGrupo _codigo = Ctl_CodigoGrupo.GetList("where id_codigo = " + _grupo.codigo_grupo).First();
                string grupoLabel = _grupo.anio + "-" + _grupo.periodo + "-" + _codigo.desc_grupo;
                HorarioDGV.Rows[iteration.dia_horario - 1].Cells[_dia.desc_dia].Value = grupoLabel;
            }
            for (int i = 0; i < HorarioDGV.Rows.Count; i++)
            {
                foreach (Dia iteration in Ctl_Dia.GetList())
                {
                    if (HorarioDGV.Rows[i].Cells[iteration.desc_dia].Value == null)
                    {
                        HorarioDGV.Rows[i].Cells[iteration.desc_dia].Value = "Hora Libre";
                    }
                }
            }
        }

        private void FinalizarButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < HorarioDGV.Rows.Count; i++)
            {
                foreach (Dia iteration in Ctl_Dia.GetList())
                {
                    if (HorarioDGV.Rows[i].Cells[iteration.desc_dia].Value != "Hora Libre")
                    {
                        List<string> grupo = HorarioDGV.Rows[i].Cells[iteration.desc_dia].Value.ToString().Split('-').ToList();
                        CodigoGrupo _codigo = Ctl_CodigoGrupo.GetList("where desc_grupo = '" + grupo[2] + "'").First();
                        Grupo _grupo = Ctl_Grupo.GetList("where anio = " + grupo[0] +
                            " and periodo = " + grupo[1] +
                            " and codigo_grupo = " + _codigo.id_codigo).First();
                        Ctl_Horario.Add(new Horario()
                        {
                            dia_horario = iteration.id_diaSemena,
                            hora_horario = i + 1,
                            grupo_horario = _grupo.id_grupo,
                        });
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Esta accion borrara todos los horarios",
                "¿Deseas continuar?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (answer != DialogResult.Yes) return;
            foreach(Grupo iteration in Ctl_Grupo.GetList("where anio = "+AnioTB.Text+" and periodo = " + PeriodoCB.Text))
            {
                Ctl_Horario.Remove("where grupo_horario = "+iteration.id_grupo);
            }
            CargarHorario();
        }
    }
}
