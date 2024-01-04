namespace RegistroDeAsistencia
{
    partial class PantallaRegistroProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistroProfesor));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Header = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            RestoreButton = new PictureBox();
            CloseButtonQR = new PictureBox();
            TittleLabel = new Label();
            MaximixeButton = new PictureBox();
            MinimizeButton = new PictureBox();
            CloseButton = new PictureBox();
            ActualGroupBox = new GroupBox();
            NTTextBox = new TextBox();
            AgregarPButton = new Button();
            AMTextBox = new TextBox();
            label4 = new Label();
            label1 = new Label();
            APTextBox = new TextBox();
            label3 = new Label();
            NombreTextBox = new TextBox();
            label2 = new Label();
            RegistroPDGV = new DataGridView();
            SearchPanel = new Panel();
            SearchComboBox = new TextBox();
            SearchIcon = new PictureBox();
            ID2 = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            ApellidoP = new DataGridViewTextBoxColumn();
            ApellidoM = new DataGridViewTextBoxColumn();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ActualGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroPDGV).BeginInit();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(86, 76, 149);
            Header.Controls.Add(pictureBox2);
            Header.Controls.Add(pictureBox1);
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
            Header.Size = new Size(600, 25);
            Header.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Close_Icon;
            pictureBox2.Location = new Point(572, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Close_Icon;
            pictureBox1.Location = new Point(822, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // RestoreButton
            // 
            RestoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RestoreButton.BackColor = Color.FromArgb(74, 97, 178);
            RestoreButton.Cursor = Cursors.Hand;
            RestoreButton.Image = (Image)resources.GetObject("RestoreButton.Image");
            RestoreButton.Location = new Point(1696, 0);
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
            CloseButtonQR.Cursor = Cursors.Hand;
            CloseButtonQR.Image = Properties.Resources.Close_Icon;
            CloseButtonQR.Location = new Point(1072, 0);
            CloseButtonQR.Name = "CloseButtonQR";
            CloseButtonQR.Size = new Size(25, 25);
            CloseButtonQR.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButtonQR.TabIndex = 7;
            CloseButtonQR.TabStop = false;
            // 
            // TittleLabel
            // 
            TittleLabel.AutoSize = true;
            TittleLabel.ForeColor = SystemColors.ControlLightLight;
            TittleLabel.Location = new Point(25, 5);
            TittleLabel.Name = "TittleLabel";
            TittleLabel.Size = new Size(124, 15);
            TittleLabel.TabIndex = 5;
            TittleLabel.Text = "Registro de Profesores";
            // 
            // MaximixeButton
            // 
            MaximixeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximixeButton.BackColor = Color.FromArgb(74, 97, 178);
            MaximixeButton.Cursor = Cursors.Hand;
            MaximixeButton.Image = (Image)resources.GetObject("MaximixeButton.Image");
            MaximixeButton.Location = new Point(1696, 0);
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
            MinimizeButton.Location = new Point(1665, 0);
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
            CloseButton.Location = new Point(1727, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 1;
            CloseButton.TabStop = false;
            // 
            // ActualGroupBox
            // 
            ActualGroupBox.Anchor = AnchorStyles.Top;
            ActualGroupBox.Controls.Add(NTTextBox);
            ActualGroupBox.Controls.Add(AgregarPButton);
            ActualGroupBox.Controls.Add(AMTextBox);
            ActualGroupBox.Controls.Add(label4);
            ActualGroupBox.Controls.Add(label1);
            ActualGroupBox.Controls.Add(APTextBox);
            ActualGroupBox.Controls.Add(label3);
            ActualGroupBox.Controls.Add(NombreTextBox);
            ActualGroupBox.Controls.Add(label2);
            ActualGroupBox.ForeColor = Color.White;
            ActualGroupBox.Location = new Point(12, 31);
            ActualGroupBox.Name = "ActualGroupBox";
            ActualGroupBox.Size = new Size(576, 106);
            ActualGroupBox.TabIndex = 37;
            ActualGroupBox.TabStop = false;
            ActualGroupBox.Text = "Datos del profesor";
            ActualGroupBox.Enter += ActualGroupBox_Enter;
            // 
            // NTTextBox
            // 
            NTTextBox.BackColor = Color.FromArgb(63, 62, 70);
            NTTextBox.Location = new Point(137, 69);
            NTTextBox.Name = "NTTextBox";
            NTTextBox.Size = new Size(288, 23);
            NTTextBox.TabIndex = 48;
            // 
            // AgregarPButton
            // 
            AgregarPButton.BackColor = Color.FromArgb(86, 76, 149);
            AgregarPButton.Cursor = Cursors.Hand;
            AgregarPButton.FlatAppearance.BorderSize = 0;
            AgregarPButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AgregarPButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AgregarPButton.FlatStyle = FlatStyle.Flat;
            AgregarPButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AgregarPButton.ForeColor = SystemColors.Control;
            AgregarPButton.Location = new Point(431, 69);
            AgregarPButton.Margin = new Padding(0);
            AgregarPButton.Name = "AgregarPButton";
            AgregarPButton.Size = new Size(140, 23);
            AgregarPButton.TabIndex = 44;
            AgregarPButton.Text = "Agregar";
            AgregarPButton.UseVisualStyleBackColor = false;
            // 
            // AMTextBox
            // 
            AMTextBox.BackColor = Color.FromArgb(63, 62, 70);
            AMTextBox.Location = new Point(431, 40);
            AMTextBox.Name = "AMTextBox";
            AMTextBox.Size = new Size(139, 23);
            AMTextBox.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 72);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 42;
            label4.Text = "Numero de Trabajador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(431, 19);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 37;
            label1.Text = "Apellido Materno";
            // 
            // APTextBox
            // 
            APTextBox.BackColor = Color.FromArgb(63, 62, 70);
            APTextBox.Location = new Point(286, 40);
            APTextBox.Name = "APTextBox";
            APTextBox.Size = new Size(139, 23);
            APTextBox.TabIndex = 46;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(286, 19);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno";
            // 
            // NombreTextBox
            // 
            NombreTextBox.BackColor = Color.FromArgb(63, 62, 70);
            NombreTextBox.Location = new Point(6, 40);
            NombreTextBox.Name = "NombreTextBox";
            NombreTextBox.Size = new Size(274, 23);
            NombreTextBox.TabIndex = 45;
            NombreTextBox.TextChanged += NombreTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 39;
            label2.Text = "Nombres:";
            // 
            // RegistroPDGV
            // 
            RegistroPDGV.AllowUserToDeleteRows = false;
            RegistroPDGV.AllowUserToOrderColumns = true;
            RegistroPDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RegistroPDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RegistroPDGV.BackgroundColor = Color.FromArgb(63, 62, 70);
            RegistroPDGV.BorderStyle = BorderStyle.None;
            RegistroPDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            RegistroPDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            RegistroPDGV.ColumnHeadersHeight = 30;
            RegistroPDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RegistroPDGV.Columns.AddRange(new DataGridViewColumn[] { ID2, Numero, Nombre, ApellidoP, ApellidoM });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 62, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            RegistroPDGV.DefaultCellStyle = dataGridViewCellStyle2;
            RegistroPDGV.EnableHeadersVisualStyles = false;
            RegistroPDGV.GridColor = Color.White;
            RegistroPDGV.Location = new Point(12, 161);
            RegistroPDGV.Margin = new Padding(3, 0, 3, 3);
            RegistroPDGV.Name = "RegistroPDGV";
            RegistroPDGV.ReadOnly = true;
            RegistroPDGV.RightToLeft = RightToLeft.No;
            RegistroPDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            RegistroPDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            RegistroPDGV.RowHeadersVisible = false;
            RegistroPDGV.RowTemplate.Height = 25;
            RegistroPDGV.Size = new Size(576, 277);
            RegistroPDGV.TabIndex = 38;
            RegistroPDGV.CellContentClick += RegistroMDGV_CellContentClick;
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.FromArgb(63, 62, 70);
            SearchPanel.Controls.Add(SearchComboBox);
            SearchPanel.Controls.Add(SearchIcon);
            SearchPanel.Location = new Point(12, 146);
            SearchPanel.Margin = new Padding(0, 6, 0, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(576, 15);
            SearchPanel.TabIndex = 39;
            // 
            // SearchComboBox
            // 
            SearchComboBox.BackColor = Color.FromArgb(63, 62, 70);
            SearchComboBox.BorderStyle = BorderStyle.None;
            SearchComboBox.ForeColor = SystemColors.Window;
            SearchComboBox.Location = new Point(29, 0);
            SearchComboBox.Margin = new Padding(0);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(547, 16);
            SearchComboBox.TabIndex = 24;
            SearchComboBox.Tag = "sdvsdvsd";
            // 
            // SearchIcon
            // 
            SearchIcon.BackColor = Color.FromArgb(63, 62, 70);
            SearchIcon.Image = Properties.Resources.Search_Icon;
            SearchIcon.Location = new Point(0, 0);
            SearchIcon.Margin = new Padding(0);
            SearchIcon.Name = "SearchIcon";
            SearchIcon.Size = new Size(16, 16);
            SearchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            SearchIcon.TabIndex = 35;
            SearchIcon.TabStop = false;
            // 
            // ID2
            // 
            ID2.HeaderText = "ID de Profesor";
            ID2.Name = "ID2";
            ID2.ReadOnly = true;
            // 
            // Numero
            // 
            Numero.HeaderText = "N. de Trabajador";
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // ApellidoP
            // 
            ApellidoP.HeaderText = "Apellido (P)";
            ApellidoP.Name = "ApellidoP";
            ApellidoP.ReadOnly = true;
            // 
            // ApellidoM
            // 
            ApellidoM.HeaderText = "Apellido (M)";
            ApellidoM.Name = "ApellidoM";
            ApellidoM.ReadOnly = true;
            // 
            // PantallaRegistroProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(600, 450);
            Controls.Add(SearchPanel);
            Controls.Add(RegistroPDGV);
            Controls.Add(ActualGroupBox);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaRegistroProfesor";
            Text = "PantallaRegistroProfesor";
            Load += PantallaRegistroProfesor_Load;
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ActualGroupBox.ResumeLayout(false);
            ActualGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroPDGV).EndInit();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private PictureBox pictureBox1;
        private PictureBox RestoreButton;
        private PictureBox CloseButtonQR;
        private Label TittleLabel;
        private PictureBox MaximixeButton;
        private PictureBox MinimizeButton;
        private PictureBox CloseButton;
        private PictureBox pictureBox2;
        private GroupBox ActualGroupBox;
        private Label label2;
        private Label label1;
        private Button AddProfesorButton;
        private Label label3;
        private DataGridView RegistroPDGV;
        private DataGridViewTextBoxColumn ID;
        private Label label4;
        private Button button1;
        private Button AgregarPButton;
        private TextBox NombreTextBox;
        private TextBox NTTextBox;
        private TextBox AMTextBox;
        private TextBox APTextBox;
        private Panel SearchPanel;
        private TextBox SearchComboBox;
        private PictureBox SearchIcon;
        private DataGridViewTextBoxColumn ID2;
        private DataGridViewTextBoxColumn Numero;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn ApellidoP;
        private DataGridViewTextBoxColumn ApellidoM;
    }
}