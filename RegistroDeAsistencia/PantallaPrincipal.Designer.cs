namespace RegistroDeAsistencia
{
    partial class PantallaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaPrincipal));
            Header = new Panel();
            TittleLabel = new Label();
            RestoreButton = new PictureBox();
            MaximixeButton = new PictureBox();
            MinimizeButton = new PictureBox();
            CloseButton = new PictureBox();
            InicioButton = new Button();
            AsistenciaButton = new Button();
            ReportesButton = new Button();
            AdministrarButton = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ButtonsPanel = new Panel();
            PanelPrime = new Panel();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(30, 33, 36);
            Header.Controls.Add(TittleLabel);
            Header.Controls.Add(RestoreButton);
            Header.Controls.Add(MaximixeButton);
            Header.Controls.Add(MinimizeButton);
            Header.Controls.Add(CloseButton);
            Header.Dock = DockStyle.Top;
            Header.ForeColor = SystemColors.ControlText;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(852, 25);
            Header.TabIndex = 0;
            Header.MouseDown += Header_MouseDown;
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
            // RestoreButton
            // 
            RestoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RestoreButton.BackColor = Color.FromArgb(30, 33, 36);
            RestoreButton.Cursor = Cursors.Hand;
            RestoreButton.Image = (Image)resources.GetObject("RestoreButton.Image");
            RestoreButton.Location = new Point(796, 0);
            RestoreButton.Name = "RestoreButton";
            RestoreButton.Size = new Size(25, 25);
            RestoreButton.SizeMode = PictureBoxSizeMode.Zoom;
            RestoreButton.TabIndex = 4;
            RestoreButton.TabStop = false;
            RestoreButton.Visible = false;
            RestoreButton.Click += RestoreButton_Click;
            // 
            // MaximixeButton
            // 
            MaximixeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximixeButton.BackColor = Color.FromArgb(30, 33, 36);
            MaximixeButton.Cursor = Cursors.Hand;
            MaximixeButton.Image = (Image)resources.GetObject("MaximixeButton.Image");
            MaximixeButton.Location = new Point(796, 0);
            MaximixeButton.Name = "MaximixeButton";
            MaximixeButton.Size = new Size(25, 25);
            MaximixeButton.SizeMode = PictureBoxSizeMode.Zoom;
            MaximixeButton.TabIndex = 3;
            MaximixeButton.TabStop = false;
            MaximixeButton.Click += MaximizeButton_Click;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeButton.BackColor = Color.FromArgb(30, 33, 36);
            MinimizeButton.Cursor = Cursors.Hand;
            MinimizeButton.Image = (Image)resources.GetObject("MinimizeButton.Image");
            MinimizeButton.Location = new Point(765, 0);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(25, 25);
            MinimizeButton.SizeMode = PictureBoxSizeMode.Zoom;
            MinimizeButton.TabIndex = 2;
            MinimizeButton.TabStop = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.FromArgb(30, 33, 36);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(827, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 1;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // InicioButton
            // 
            InicioButton.Anchor = AnchorStyles.Top;
            InicioButton.AutoSize = true;
            InicioButton.BackColor = Color.FromArgb(40, 43, 48);
            InicioButton.FlatAppearance.BorderSize = 0;
            InicioButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 97, 178);
            InicioButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 137, 218);
            InicioButton.FlatStyle = FlatStyle.Flat;
            InicioButton.ForeColor = SystemColors.ControlLightLight;
            InicioButton.Location = new Point(0, 0);
            InicioButton.Margin = new Padding(0);
            InicioButton.Name = "InicioButton";
            InicioButton.Size = new Size(213, 25);
            InicioButton.TabIndex = 1;
            InicioButton.Text = "Inicio";
            InicioButton.UseVisualStyleBackColor = false;
            // 
            // AsistenciaButton
            // 
            AsistenciaButton.Anchor = AnchorStyles.Top;
            AsistenciaButton.AutoSize = true;
            AsistenciaButton.BackColor = Color.FromArgb(40, 43, 48);
            AsistenciaButton.FlatAppearance.BorderSize = 0;
            AsistenciaButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 97, 178);
            AsistenciaButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 137, 218);
            AsistenciaButton.FlatStyle = FlatStyle.Flat;
            AsistenciaButton.ForeColor = SystemColors.ControlLightLight;
            AsistenciaButton.Location = new Point(213, 0);
            AsistenciaButton.Margin = new Padding(0);
            AsistenciaButton.Name = "AsistenciaButton";
            AsistenciaButton.Size = new Size(213, 25);
            AsistenciaButton.TabIndex = 2;
            AsistenciaButton.Text = "Asistencia";
            AsistenciaButton.UseVisualStyleBackColor = false;
            // 
            // ReportesButton
            // 
            ReportesButton.Anchor = AnchorStyles.Top;
            ReportesButton.AutoSize = true;
            ReportesButton.BackColor = Color.FromArgb(40, 43, 48);
            ReportesButton.FlatAppearance.BorderSize = 0;
            ReportesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 97, 178);
            ReportesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 137, 218);
            ReportesButton.FlatStyle = FlatStyle.Flat;
            ReportesButton.ForeColor = SystemColors.ControlLightLight;
            ReportesButton.Location = new Point(426, 0);
            ReportesButton.Margin = new Padding(0);
            ReportesButton.Name = "ReportesButton";
            ReportesButton.Size = new Size(213, 25);
            ReportesButton.TabIndex = 3;
            ReportesButton.Text = "Reportes";
            ReportesButton.UseVisualStyleBackColor = false;
            // 
            // AdministrarButton
            // 
            AdministrarButton.Anchor = AnchorStyles.Top;
            AdministrarButton.AutoSize = true;
            AdministrarButton.BackColor = Color.FromArgb(40, 43, 48);
            AdministrarButton.FlatAppearance.BorderSize = 0;
            AdministrarButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 97, 178);
            AdministrarButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(114, 137, 218);
            AdministrarButton.FlatStyle = FlatStyle.Flat;
            AdministrarButton.ForeColor = SystemColors.ControlLightLight;
            AdministrarButton.Location = new Point(639, 0);
            AdministrarButton.Margin = new Padding(0);
            AdministrarButton.Name = "AdministrarButton";
            AdministrarButton.Size = new Size(213, 25);
            AdministrarButton.TabIndex = 4;
            AdministrarButton.Text = "Administrar";
            AdministrarButton.UseVisualStyleBackColor = false;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.BackColor = Color.FromArgb(40, 43, 48);
            ButtonsPanel.Controls.Add(AdministrarButton);
            ButtonsPanel.Controls.Add(InicioButton);
            ButtonsPanel.Controls.Add(ReportesButton);
            ButtonsPanel.Controls.Add(AsistenciaButton);
            ButtonsPanel.Dock = DockStyle.Top;
            ButtonsPanel.Location = new Point(0, 25);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(852, 25);
            ButtonsPanel.TabIndex = 6;
            // 
            // PanelPrime
            // 
            PanelPrime.Dock = DockStyle.Fill;
            PanelPrime.Location = new Point(0, 50);
            PanelPrime.Name = "PanelPrime";
            PanelPrime.Size = new Size(852, 450);
            PanelPrime.TabIndex = 7;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(852, 500);
            Controls.Add(PanelPrime);
            Controls.Add(ButtonsPanel);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaPrincipal";
            Text = "Registro de asistencia";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ButtonsPanel.ResumeLayout(false);
            ButtonsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private PictureBox MaximixeButton;
        private PictureBox MinimizeButton;
        private PictureBox CloseButton;
        private PictureBox RestoreButton;
        private Button InicioButton;
        private Button AsistenciaButton;
        private Button ReportesButton;
        private Button AdministrarButton;
        private Label TittleLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel ButtonsPanel;
        private Panel PanelPrime;
    }
}