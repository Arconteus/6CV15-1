using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using RegistroDeAsistencia.Pantallas;

namespace RegistroDeAsistencia
{
    public partial class PantallaPrincipal : Form
    {
        //=================================================================
        // Funcion de contruccion
        //=================================================================
        public PantallaPrincipal()
        {
            InitializeComponent();
            this.RestoreButton.Visible = false;
            this.OpenForm<PantallaInicio>();
            this.ChangeSelectedButton("inicio");
        }
        //==================================================================
        // Funciones custom
        //==================================================================
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ChangeSelectedButton(string button)
        {
            Color SelectedColor = Color.FromArgb(86, 76, 149);
            Color DefaultColor = Color.FromArgb(17, 16, 19);
            this.InicioButton.BackColor = DefaultColor;
            this.AsistenciaButton.BackColor = DefaultColor;
            this.ReportesButton.BackColor = DefaultColor;
            this.AdministrarButton.BackColor = DefaultColor;
            switch (button)
            {
                case "inicio":
                    this.InicioButton.BackColor = SelectedColor;
                    break;
                case "asistencia":
                    this.AsistenciaButton.BackColor = SelectedColor;
                    break;
                case "reportes":
                    this.ReportesButton.BackColor = SelectedColor;
                    break;
                case "administracion":
                    this.AdministrarButton.BackColor = SelectedColor;
                    break;
            }
        }

        private void OpenForm<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            //Busca en la colecion el formulario
            formulario = MainPanel.Controls.OfType<MiForm>().FirstOrDefault();
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                MainPanel.Controls.Add(formulario);
                MainPanel.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        //==================================================================
        // Funciones de forms
        //==================================================================

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeButton.Visible = false;
            this.RestoreButton.Visible = true;
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeButton.Visible = true;
            this.RestoreButton.Visible = false;
        }

        private void InicioButton_Click(object sender, EventArgs e)
        {
            this.OpenForm<PantallaInicio>();
            this.ChangeSelectedButton("inicio");
        }

        private void AsistenciaButton_Click(object sender, EventArgs e)
        {
            this.OpenForm<PantallaAsistencia>();
            this.ChangeSelectedButton("asistencia");
        }

        private void AdministrarButton_Click(object sender, EventArgs e)
        {
            this.OpenForm<PantallaAdmin>();
            this.ChangeSelectedButton("administracion");
        }

        private void ReportesButton_Click(object sender, EventArgs e)
        {
            this.OpenForm<PantallaReportes>();
            this.ChangeSelectedButton("reportes");
        }
    }
}
