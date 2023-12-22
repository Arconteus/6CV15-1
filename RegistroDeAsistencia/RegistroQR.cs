using AForge.Video;
using AForge.Video.DirectShow;

namespace RegistroDeAsistencia
{
    public partial class RegistroQR : Form
    {
        FilterInfoCollection _filterInfoCollection;
        VideoCaptureDevice _videoCaptureDevice;

        public RegistroQR()
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
    }
}