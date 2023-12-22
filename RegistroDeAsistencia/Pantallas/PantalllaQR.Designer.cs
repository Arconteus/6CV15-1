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
            IniciarButton = new Button();
            RegistroManualButton = new Button();
            WebcamButton = new Button();
            LectorQRButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            pictCamImagem = new PictureBox();
            cmbCameras = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictCamImagem).BeginInit();
            SuspendLayout();
            // 
            // IniciarButton
            // 
            IniciarButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            IniciarButton.Location = new Point(151, 327);
            IniciarButton.Name = "IniciarButton";
            IniciarButton.Size = new Size(212, 54);
            IniciarButton.TabIndex = 0;
            IniciarButton.Text = "Escanear";
            IniciarButton.UseVisualStyleBackColor = true;
            IniciarButton.Click += ScanButton_Click;
            // 
            // RegistroManualButton
            // 
            RegistroManualButton.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            RegistroManualButton.Location = new Point(151, 387);
            RegistroManualButton.Name = "RegistroManualButton";
            RegistroManualButton.Size = new Size(212, 39);
            RegistroManualButton.TabIndex = 1;
            RegistroManualButton.Text = "Registro Manual";
            RegistroManualButton.UseVisualStyleBackColor = true;
            // 
            // WebcamButton
            // 
            WebcamButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            WebcamButton.Location = new Point(45, 33);
            WebcamButton.Name = "WebcamButton";
            WebcamButton.Size = new Size(212, 33);
            WebcamButton.TabIndex = 2;
            WebcamButton.Text = "Webcam";
            WebcamButton.UseVisualStyleBackColor = true;
            // 
            // LectorQRButton
            // 
            LectorQRButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LectorQRButton.Location = new Point(252, 33);
            LectorQRButton.Name = "LectorQRButton";
            LectorQRButton.Size = new Size(212, 33);
            LectorQRButton.TabIndex = 3;
            LectorQRButton.Text = "Lectro QR";
            LectorQRButton.UseVisualStyleBackColor = true;
            // 
            // pictCamImagem
            // 
            pictCamImagem.Location = new Point(104, 119);
            pictCamImagem.Name = "pictCamImagem";
            pictCamImagem.Size = new Size(327, 194);
            pictCamImagem.SizeMode = PictureBoxSizeMode.Zoom;
            pictCamImagem.TabIndex = 4;
            pictCamImagem.TabStop = false;
            // 
            // cmbCameras
            // 
            cmbCameras.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCameras.FormattingEnabled = true;
            cmbCameras.Items.AddRange(new object[] { "Selecciona la Cámara" });
            cmbCameras.Location = new Point(310, 90);
            cmbCameras.Name = "cmbCameras";
            cmbCameras.Size = new Size(154, 23);
            cmbCameras.TabIndex = 5;
            cmbCameras.SelectedIndexChanged += cmbCameras_SelectedIndexChanged;
            // 
            // RegistroQR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(534, 450);
            Controls.Add(cmbCameras);
            Controls.Add(pictCamImagem);
            Controls.Add(LectorQRButton);
            Controls.Add(WebcamButton);
            Controls.Add(RegistroManualButton);
            Controls.Add(IniciarButton);
            Name = "RegistroQR";
            Text = "RegistroQR";
            ((System.ComponentModel.ISupportInitialize)pictCamImagem).EndInit();
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
    }
}