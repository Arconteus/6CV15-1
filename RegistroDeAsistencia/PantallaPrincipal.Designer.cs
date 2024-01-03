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
            Header = new Panel();
            MaximizeButton = new PictureBox();
            TittleLabel = new Label();
            MinimizeButton = new PictureBox();
            RestoreButton = new PictureBox();
            CloseButton = new PictureBox();
            ButtonsPanel = new Panel();
            ReportesButton = new Button();
            InicioButton = new Button();
            AdministrarButton = new Button();
            AsistenciaButton = new Button();
            MainPanel = new Panel();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaximizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ButtonsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(49, 41, 100);
            Header.Controls.Add(MaximizeButton);
            Header.Controls.Add(TittleLabel);
            Header.Controls.Add(MinimizeButton);
            Header.Controls.Add(RestoreButton);
            Header.Controls.Add(CloseButton);
            Header.Dock = DockStyle.Top;
            Header.Location = new Point(0, 0);
            Header.Name = "Header";
            Header.Size = new Size(852, 25);
            Header.TabIndex = 0;
            Header.Paint += Header_Paint;
            Header.MouseDown += Header_MouseDown;
            // 
            // MaximizeButton
            // 
            MaximizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximizeButton.Cursor = Cursors.Hand;
            MaximizeButton.Image = Properties.Resources.Maximize_Icon;
            MaximizeButton.Location = new Point(802, 0);
            MaximizeButton.Margin = new Padding(0);
            MaximizeButton.Name = "MaximizeButton";
            MaximizeButton.Size = new Size(25, 25);
            MaximizeButton.SizeMode = PictureBoxSizeMode.Zoom;
            MaximizeButton.TabIndex = 3;
            MaximizeButton.TabStop = false;
            MaximizeButton.Click += MaximizeButton_Click;
            // 
            // TittleLabel
            // 
            TittleLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TittleLabel.AutoSize = true;
            TittleLabel.ForeColor = SystemColors.ControlLightLight;
            TittleLabel.Location = new Point(21, 7);
            TittleLabel.Name = "TittleLabel";
            TittleLabel.Size = new Size(117, 15);
            TittleLabel.TabIndex = 0;
            TittleLabel.Text = "Control de asistencia";
            TittleLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeButton.Cursor = Cursors.Hand;
            MinimizeButton.Image = Properties.Resources.Minimize_Icon;
            MinimizeButton.Location = new Point(777, 0);
            MinimizeButton.Margin = new Padding(0);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(25, 25);
            MinimizeButton.SizeMode = PictureBoxSizeMode.Zoom;
            MinimizeButton.TabIndex = 2;
            MinimizeButton.TabStop = false;
            MinimizeButton.Click += MinimizeButton_Click;
            // 
            // RestoreButton
            // 
            RestoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RestoreButton.Cursor = Cursors.Hand;
            RestoreButton.Image = Properties.Resources.Restore_Icon;
            RestoreButton.Location = new Point(802, 0);
            RestoreButton.Margin = new Padding(0);
            RestoreButton.Name = "RestoreButton";
            RestoreButton.Size = new Size(25, 25);
            RestoreButton.SizeMode = PictureBoxSizeMode.Zoom;
            RestoreButton.TabIndex = 1;
            RestoreButton.TabStop = false;
            RestoreButton.Click += RestoreButton_Click;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = Properties.Resources.Close_Icon;
            CloseButton.Location = new Point(827, 0);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 0;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // ButtonsPanel
            // 
            ButtonsPanel.BackColor = Color.FromArgb(17, 16, 19);
            ButtonsPanel.Controls.Add(ReportesButton);
            ButtonsPanel.Controls.Add(InicioButton);
            ButtonsPanel.Controls.Add(AdministrarButton);
            ButtonsPanel.Controls.Add(AsistenciaButton);
            ButtonsPanel.Dock = DockStyle.Top;
            ButtonsPanel.Location = new Point(0, 25);
            ButtonsPanel.Name = "ButtonsPanel";
            ButtonsPanel.Size = new Size(852, 25);
            ButtonsPanel.TabIndex = 1;
            // 
            // ReportesButton
            // 
            ReportesButton.Anchor = AnchorStyles.Top;
            ReportesButton.BackColor = Color.FromArgb(17, 16, 19);
            ReportesButton.FlatAppearance.BorderSize = 0;
            ReportesButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            ReportesButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            ReportesButton.FlatStyle = FlatStyle.Flat;
            ReportesButton.ForeColor = SystemColors.ControlLightLight;
            ReportesButton.Location = new Point(639, 0);
            ReportesButton.Margin = new Padding(0);
            ReportesButton.Name = "ReportesButton";
            ReportesButton.Size = new Size(213, 25);
            ReportesButton.TabIndex = 3;
            ReportesButton.Text = "Reportes";
            ReportesButton.UseVisualStyleBackColor = false;
            ReportesButton.Click += ReportesButton_Click;
            // 
            // InicioButton
            // 
            InicioButton.Anchor = AnchorStyles.Top;
            InicioButton.BackColor = Color.FromArgb(17, 16, 19);
            InicioButton.FlatAppearance.BorderSize = 0;
            InicioButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            InicioButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            InicioButton.FlatStyle = FlatStyle.Flat;
            InicioButton.ForeColor = SystemColors.ControlLightLight;
            InicioButton.Location = new Point(0, 0);
            InicioButton.Margin = new Padding(0);
            InicioButton.Name = "InicioButton";
            InicioButton.Size = new Size(213, 25);
            InicioButton.TabIndex = 0;
            InicioButton.Text = "Inicio";
            InicioButton.UseVisualStyleBackColor = false;
            InicioButton.Click += InicioButton_Click;
            // 
            // AdministrarButton
            // 
            AdministrarButton.Anchor = AnchorStyles.Top;
            AdministrarButton.BackColor = Color.FromArgb(17, 16, 19);
            AdministrarButton.FlatAppearance.BorderSize = 0;
            AdministrarButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AdministrarButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AdministrarButton.FlatStyle = FlatStyle.Flat;
            AdministrarButton.ForeColor = SystemColors.ControlLightLight;
            AdministrarButton.Location = new Point(426, 0);
            AdministrarButton.Margin = new Padding(0);
            AdministrarButton.Name = "AdministrarButton";
            AdministrarButton.Size = new Size(213, 25);
            AdministrarButton.TabIndex = 2;
            AdministrarButton.Text = "Administrar";
            AdministrarButton.UseVisualStyleBackColor = false;
            AdministrarButton.Click += AdministrarButton_Click;
            // 
            // AsistenciaButton
            // 
            AsistenciaButton.Anchor = AnchorStyles.Top;
            AsistenciaButton.BackColor = Color.FromArgb(17, 16, 19);
            AsistenciaButton.FlatAppearance.BorderSize = 0;
            AsistenciaButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AsistenciaButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AsistenciaButton.FlatStyle = FlatStyle.Flat;
            AsistenciaButton.ForeColor = SystemColors.ControlLightLight;
            AsistenciaButton.Location = new Point(213, 0);
            AsistenciaButton.Margin = new Padding(0);
            AsistenciaButton.Name = "AsistenciaButton";
            AsistenciaButton.Size = new Size(213, 25);
            AsistenciaButton.TabIndex = 1;
            AsistenciaButton.Text = "Asistencia";
            AsistenciaButton.UseVisualStyleBackColor = false;
            AsistenciaButton.Click += AsistenciaButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(31, 30, 36);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 50);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(852, 450);
            MainPanel.TabIndex = 2;
            // 
            // PantallaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 500);
            Controls.Add(MainPanel);
            Controls.Add(ButtonsPanel);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(852, 500);
            Name = "PantallaPrincipal";
            Text = "PantallaPrincipal";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaximizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ButtonsPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private Panel ButtonsPanel;
        private Panel MainPanel;
        private Button InicioButton;
        private Button ReportesButton;
        private Button AdministrarButton;
        private Button AsistenciaButton;
        private PictureBox MinimizeButton;
        private PictureBox RestoreButton;
        private PictureBox CloseButton;
        private PictureBox MaximizeButton;
        private Label TittleLabel;
    }
}