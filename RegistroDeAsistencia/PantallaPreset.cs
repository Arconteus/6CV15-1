using System.Runtime.InteropServices;

namespace RegistroDeAsistencia
{
    public partial class PantallaPreset : Form
    {
        public PantallaPreset()
        {
            InitializeComponent();
        }

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

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int sParam, int lParam);

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        private void AdministrarButton_Click(object sender, EventArgs e)
        {

        }


    }
}
