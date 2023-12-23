namespace RegistroDeAsistencia
{
    partial class PantalllaQR
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantalllaQR));
            IniciarButton = new Button();
            RegistroManualButton = new Button();
            WebcamButton = new Button();
            LectorQRButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            pictCamImagem = new PictureBox();
            cmbCameras = new ComboBox();
            Header = new Panel();
            RestoreButton = new PictureBox();
            CloseButtonQR = new PictureBox();
            TittleLabel = new Label();
            MaximixeButton = new PictureBox();
            MinimizeButton = new PictureBox();
            CloseButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictCamImagem).BeginInit();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            SuspendLayout();
            // 
            // IniciarButton
            // 
            IniciarButton.BackColor = Color.FromArgb(114, 137, 218);
            IniciarButton.FlatAppearance.BorderSize = 0;
            IniciarButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 97, 178);
            IniciarButton.FlatStyle = FlatStyle.Flat;
            IniciarButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            IniciarButton.ForeColor = SystemColors.ControlLightLight;
            IniciarButton.Location = new Point(0, 356);
            IniciarButton.Margin = new Padding(0);
            IniciarButton.Name = "IniciarButton";
            IniciarButton.Size = new Size(450, 54);
            IniciarButton.TabIndex = 0;
            IniciarButton.Text = "Escanear";
            IniciarButton.UseVisualStyleBackColor = false;
            IniciarButton.Click += ScanButton_Click;
            // 
            // RegistroManualButton
            // 
            RegistroManualButton.BackColor = Color.FromArgb(30, 33, 36);
            RegistroManualButton.FlatAppearance.BorderSize = 0;
            RegistroManualButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 97, 178);
            RegistroManualButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 137, 218);
            RegistroManualButton.FlatStyle = FlatStyle.Flat;
            RegistroManualButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RegistroManualButton.ForeColor = SystemColors.ControlLightLight;
            RegistroManualButton.Location = new Point(0, 410);
            RegistroManualButton.Margin = new Padding(0);
            RegistroManualButton.Name = "RegistroManualButton";
            RegistroManualButton.Size = new Size(450, 31);
            RegistroManualButton.TabIndex = 1;
            RegistroManualButton.Text = "Registro Manual";
            RegistroManualButton.UseVisualStyleBackColor = false;
            // 
            // WebcamButton
            // 
            WebcamButton.BackColor = Color.FromArgb(30, 33, 36);
            WebcamButton.FlatAppearance.BorderColor = Color.FromArgb(30, 33, 36);
            WebcamButton.FlatAppearance.BorderSize = 0;
            WebcamButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 97, 178);
            WebcamButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 137, 218);
            WebcamButton.FlatStyle = FlatStyle.Flat;
            WebcamButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            WebcamButton.ForeColor = SystemColors.ControlLightLight;
            WebcamButton.Location = new Point(0, 25);
            WebcamButton.Margin = new Padding(0);
            WebcamButton.Name = "WebcamButton";
            WebcamButton.Size = new Size(225, 25);
            WebcamButton.TabIndex = 2;
            WebcamButton.Text = "Webcam";
            WebcamButton.UseVisualStyleBackColor = false;
            // 
            // LectorQRButton
            // 
            LectorQRButton.BackColor = Color.FromArgb(30, 33, 36);
            LectorQRButton.FlatAppearance.BorderSize = 0;
            LectorQRButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 97, 178);
            LectorQRButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 137, 218);
            LectorQRButton.FlatStyle = FlatStyle.Flat;
            LectorQRButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LectorQRButton.ForeColor = SystemColors.ControlLightLight;
            LectorQRButton.Location = new Point(225, 25);
            LectorQRButton.Margin = new Padding(0);
            LectorQRButton.Name = "LectorQRButton";
            LectorQRButton.Size = new Size(225, 25);
            LectorQRButton.TabIndex = 3;
            LectorQRButton.Text = "Lectro QR";
            LectorQRButton.UseVisualStyleBackColor = false;
            // 
            // pictCamImagem
            // 
            pictCamImagem.Location = new Point(58, 119);
            pictCamImagem.Name = "pictCamImagem";
            pictCamImagem.Size = new Size(327, 194);
            pictCamImagem.SizeMode = PictureBoxSizeMode.Zoom;
            pictCamImagem.TabIndex = 4;
            pictCamImagem.TabStop = false;
            // 
            // cmbCameras
            // 
            cmbCameras.BackColor = Color.FromArgb(66, 69, 73);
            cmbCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCameras.FormattingEnabled = true;
            cmbCameras.Items.AddRange(new object[] { "Selecciona la Cámara" });
            cmbCameras.Location = new Point(58, 319);
            cmbCameras.Name = "cmbCameras";
            cmbCameras.Size = new Size(327, 23);
            cmbCameras.TabIndex = 5;
            cmbCameras.SelectedIndexChanged += cmbCameras_SelectedIndexChanged;
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(74, 97, 178);
            Header.Controls.Add(RestoreButton);
            Header.Controls.Add(CloseButtonQR);
            Header.Controls.Add(TittleLabel);
            Header.Controls.Add(MaximixeButton);
            Header.Controls.Add(MinimizeButton);
            Header.Controls.Add(CloseButton);
            Header.Dock = DockStyle.Top;
            Header.ForeColor = SystemColors.ControlText;
            Header.Location = new Point(0, 0);
            Header.Margin = new Padding(0);
            Header.Name = "Header";
            Header.Size = new Size(450, 25);
            Header.TabIndex = 6;
            Header.MouseDown += Header_MouseDown;
            // 
            // RestoreButton
            // 
            RestoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RestoreButton.BackColor = Color.FromArgb(74, 97, 178);
            RestoreButton.Cursor = Cursors.Hand;
            RestoreButton.Image = (Image)resources.GetObject("RestoreButton.Image");
            RestoreButton.Location = new Point(1046, 0);
            RestoreButton.Name = "RestoreButton";
            RestoreButton.Size = new Size(25, 25);
            RestoreButton.SizeMode = PictureBoxSizeMode.Zoom;
            RestoreButton.TabIndex = 4;
            RestoreButton.TabStop = false;
            RestoreButton.Visible = false;
            // 
            // CloseButtonQR
            // 
            CloseButtonQR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButtonQR.BackColor = Color.FromArgb(74, 97, 178);
            CloseButtonQR.Cursor = Cursors.Hand;
            CloseButtonQR.Image = (Image)resources.GetObject("CloseButtonQR.Image");
            CloseButtonQR.Location = new Point(422, 0);
            CloseButtonQR.Name = "CloseButtonQR";
            CloseButtonQR.Size = new Size(25, 25);
            CloseButtonQR.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButtonQR.TabIndex = 7;
            CloseButtonQR.TabStop = false;
            CloseButtonQR.Click += CloseButtonQR_Click;
            // 
            // TittleLabel
            // 
            TittleLabel.AutoSize = true;
            TittleLabel.ForeColor = SystemColors.ControlLightLight;
            TittleLabel.Location = new Point(25, 5);
            TittleLabel.Name = "TittleLabel";
            TittleLabel.Size = new Size(120, 15);
            TittleLabel.TabIndex = 5;
            TittleLabel.Text = "Registro de asistencia";
            // 
            // MaximixeButton
            // 
            MaximixeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximixeButton.BackColor = Color.FromArgb(74, 97, 178);
            MaximixeButton.Cursor = Cursors.Hand;
            MaximixeButton.Image = (Image)resources.GetObject("MaximixeButton.Image");
            MaximixeButton.Location = new Point(1046, 0);
            MaximixeButton.Name = "MaximixeButton";
            MaximixeButton.Size = new Size(25, 25);
            MaximixeButton.SizeMode = PictureBoxSizeMode.Zoom;
            MaximixeButton.TabIndex = 3;
            MaximixeButton.TabStop = false;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeButton.BackColor = Color.FromArgb(74, 97, 178);
            MinimizeButton.Cursor = Cursors.Hand;
            MinimizeButton.Image = (Image)resources.GetObject("MinimizeButton.Image");
            MinimizeButton.Location = new Point(1015, 0);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(25, 25);
            MinimizeButton.SizeMode = PictureBoxSizeMode.Zoom;
            MinimizeButton.TabIndex = 2;
            MinimizeButton.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.FromArgb(74, 97, 178);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(1077, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 1;
            CloseButton.TabStop = false;
            // 
            // PantalllaQR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 43, 48);
            ClientSize = new Size(450, 450);
            Controls.Add(Header);
            Controls.Add(cmbCameras);
            Controls.Add(pictCamImagem);
            Controls.Add(LectorQRButton);
            Controls.Add(WebcamButton);
            Controls.Add(RegistroManualButton);
            Controls.Add(IniciarButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantalllaQR";
            Text = "RegistroQR";
            ((System.ComponentModel.ISupportInitialize)pictCamImagem).EndInit();
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button IniciarButton;
        private Button RegistroManualButton;
        private Button WebcamButton;
        private Button LectorQRButton;
        private FolderBrowserDialog folderBrowserDialog1;
        private PictureBox pictCamImagem;
        private ComboBox cmbCameras;
        private Button ScanButton;
        private PictureBox ImagenEscaneada;
        private Panel Header;
        private PictureBox RestoreButton;
        private Label TittleLabel;
        private PictureBox MaximixeButton;
        private PictureBox MinimizeButton;
        private PictureBox CloseButton;
        private PictureBox CloseButtonQR;
    }
}