using AForge.Video;
using AForge.Video.DirectShow;
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

namespace RegistroDeAsistencia
{
    public partial class PantallaQR : Form
    {
        //==============================================================================================
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int sParam, int lParam);
        //==============================================================================================
        FilterInfoCollection _filterInfoCollection;
        VideoCaptureDevice _videoCaptureDevice;

        public PantallaQR()
        {
            InitializeComponent();

            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo filterInfo in _filterInfoCollection)
                cmbCameras.Items.Add(filterInfo.Name);

            cmbCameras.SelectedIndex = 0;
            _videoCaptureDevice = new VideoCaptureDevice();

            // Vincula el evento SelectedIndexChanged al método cmbCameras_SelectedIndexChanged
            cmbCameras.SelectedIndexChanged += cmbCameras_SelectedIndexChanged;
        }

        private void cmbCameras_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = cmbCameras.SelectedIndex;

            if (_filterInfoCollection != null && _filterInfoCollection.Count > selectedIndex)
            {
                _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[selectedIndex].MonikerString);
            }
            else
            {
                // Manejar el caso en el que _filterInfoCollection es nulo o no contiene suficientes elementos.
            }
        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            _videoCaptureDevice.NewFrame += _videoCaptureDevice_NewFrame;
            _videoCaptureDevice.Start();
        }

        private void _videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            pictCamImagem.Image = (System.Drawing.Image)e.Frame.Clone();
        }

        private void CloseButtonQR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0x0f012, 0);
        }

        private void PantallaQR_Load(object sender, EventArgs e)
        {

        }

        private void LectorQRButton_Click(object sender, EventArgs e)
        {

        }
    }
}