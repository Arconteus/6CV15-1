using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
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
using ZXing.QrCode;
using ZXing.Windows.Compatibility;

namespace RegistroDeAsistencia
{
    public partial class PantallaQR : Form
    {
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int sParam, int lParam);

        private FilterInfoCollection _filterInfoCollection;
        private VideoCaptureDevice _videoCaptureDevice;
        private Bitmap capturedImage;

        public PantallaQR()
        {
            InitializeComponent();

            RefreshCamerasList();

            cmbCameras.SelectedIndexChanged += cmbCameras_SelectedIndexChanged;
        }

        private void RefreshCamerasList()
        {
            _filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            cmbCameras.Items.Clear();

            if (_filterInfoCollection.Count == 0)
            {
                cmbCameras.Items.Add("No se ha encontrado ninguna cámara en el sistema");
                cmbCameras.Enabled = false;
            }
            else
            {
                foreach (FilterInfo filterInfo in _filterInfoCollection)
                    cmbCameras.Items.Add(filterInfo.Name);

                cmbCameras.Enabled = true;
                cmbCameras.SelectedIndex = 0;
                _videoCaptureDevice = new VideoCaptureDevice();
            }
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

        private void _videoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            pictCamImagem.Image = (System.Drawing.Image)e.Frame.Clone();
            capturedImage = (Bitmap)e.Frame.Clone();
        }

        private void CloseButtonQR_Click(object sender, EventArgs e)
        {
            if (_videoCaptureDevice != null && _videoCaptureDevice.IsRunning)
            {
                _videoCaptureDevice.SignalToStop();
                _videoCaptureDevice.WaitForStop();
            }

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

        private void CamPB_Click(object sender, EventArgs e)
        {
            if (_videoCaptureDevice != null && _videoCaptureDevice.IsRunning)
            {
                MessageBox.Show("La cámara ya está activada.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int selectedIndex = cmbCameras.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < _filterInfoCollection.Count)
            {
                _videoCaptureDevice = new VideoCaptureDevice(_filterInfoCollection[selectedIndex].MonikerString);
                _videoCaptureDevice.NewFrame += _videoCaptureDevice_NewFrame;
                _videoCaptureDevice.Start();
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una cámara válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Scan_Click(object sender, EventArgs e)
        {
            if (capturedImage != null)
            {
                var barcodeReader = new BarcodeReader();
                var result = barcodeReader.Decode(capturedImage);

                if (result != null)
                {
                    MessageBox.Show($"Código QR capturado: {result.Text}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se ha capturado un código QR legible.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No hay ninguna imagen capturada.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}