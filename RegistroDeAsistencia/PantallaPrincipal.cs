using RegistroDeAsistencia.Pantallas;
using System.Runtime.InteropServices;

namespace RegistroDeAsistencia
{
    public partial class PantallaPrincipal : Form
    {
        //==============================================================================================
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int sParam, int lParam);
        //==============================================================================================
        public PantallaPrincipal()
        {
            InitializeComponent();
            this.OpenFormInPanel(new PantallaInicio());
        }
        //==============================================================================================
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MaximizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MaximixeButton.Visible = false;
            this.RestoreButton.Visible = true;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void RestoreButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.MaximixeButton.Visible = true;
            this.RestoreButton.Visible = false;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        //==============================================================================================
        // Funciones Custom
        //==============================================================================================
        private void OpenFormInPanel(object FormToOpen)
        {
            if (this.PanelPrime.Controls.Count > 0) this.PanelPrime.Controls.RemoveAt(0);
            Form ToOpen = FormToOpen as Form;
            ToOpen.TopLevel = false;
            ToOpen.Dock = DockStyle.Fill;
            this.PanelPrime.Controls.Add(ToOpen);
            this.PanelPrime.Tag = ToOpen;
            ToOpen.Show();
        }

    }
}
