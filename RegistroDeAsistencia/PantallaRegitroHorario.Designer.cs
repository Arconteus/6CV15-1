namespace RegistroDeAsistencia
{
    partial class PantallaRegitroHorario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegitroHorario));
            DataGridViewCellStyle dataGridViewCellStyle19 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle20 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle21 = new DataGridViewCellStyle();
            HorarioGroupBox = new GroupBox();
            label3 = new Label();
            Header = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            RestoreButton = new PictureBox();
            CloseButtonQR = new PictureBox();
            TittleLabel = new Label();
            MaximixeButton = new PictureBox();
            MinimizeButton = new PictureBox();
            CloseButton = new PictureBox();
            MateriaComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            RegistroPDGV = new DataGridView();
            Hora = new DataGridViewTextBoxColumn();
            Dia1 = new DataGridViewTextBoxColumn();
            Dia2 = new DataGridViewTextBoxColumn();
            Dia3 = new DataGridViewTextBoxColumn();
            Dia4 = new DataGridViewTextBoxColumn();
            Dia5 = new DataGridViewTextBoxColumn();
            AgregarPButton = new Button();
            HorarioGroupBox.SuspendLayout();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RegistroPDGV).BeginInit();
            SuspendLayout();
            // 
            // HorarioGroupBox
            // 
            HorarioGroupBox.Anchor = AnchorStyles.Top;
            HorarioGroupBox.Controls.Add(AgregarPButton);
            HorarioGroupBox.Controls.Add(comboBox2);
            HorarioGroupBox.Controls.Add(comboBox1);
            HorarioGroupBox.Controls.Add(label2);
            HorarioGroupBox.Controls.Add(label1);
            HorarioGroupBox.Controls.Add(MateriaComboBox);
            HorarioGroupBox.Controls.Add(label3);
            HorarioGroupBox.ForeColor = Color.White;
            HorarioGroupBox.Location = new Point(12, 28);
            HorarioGroupBox.Name = "HorarioGroupBox";
            HorarioGroupBox.Size = new Size(626, 99);
            HorarioGroupBox.TabIndex = 37;
            HorarioGroupBox.TabStop = false;
            HorarioGroupBox.Text = "Registro de Hora";
            HorarioGroupBox.Enter += HorarioGroupBox_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Materia";
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
            Header.Size = new Size(650, 25);
            Header.TabIndex = 38;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Close_Icon;
            pictureBox2.Location = new Point(622, 0);
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
            pictureBox1.Location = new Point(872, 0);
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
            RestoreButton.Location = new Point(1746, 0);
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
            CloseButtonQR.Location = new Point(1122, 0);
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
            TittleLabel.Size = new Size(130, 15);
            TittleLabel.TabIndex = 5;
            TittleLabel.Text = "Asignación de Horarios";
            // 
            // MaximixeButton
            // 
            MaximixeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximixeButton.BackColor = Color.FromArgb(74, 97, 178);
            MaximixeButton.Cursor = Cursors.Hand;
            MaximixeButton.Image = (Image)resources.GetObject("MaximixeButton.Image");
            MaximixeButton.Location = new Point(1746, 0);
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
            MinimizeButton.Location = new Point(1715, 0);
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
            CloseButton.Location = new Point(1777, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 1;
            CloseButton.TabStop = false;
            // 
            // MateriaComboBox
            // 
            MateriaComboBox.BackColor = Color.FromArgb(63, 62, 70);
            MateriaComboBox.FlatStyle = FlatStyle.Flat;
            MateriaComboBox.ForeColor = SystemColors.Window;
            MateriaComboBox.FormattingEnabled = true;
            MateriaComboBox.Location = new Point(62, 19);
            MateriaComboBox.Margin = new Padding(3, 3, 0, 3);
            MateriaComboBox.Name = "MateriaComboBox";
            MateriaComboBox.Size = new Size(389, 23);
            MateriaComboBox.TabIndex = 36;
            MateriaComboBox.Text = "-";
            MateriaComboBox.SelectedIndexChanged += MateriaComboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 37;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(454, 22);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 38;
            label2.Text = "Hora";
            label2.Click += label2_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(63, 62, 70);
            comboBox1.FlatStyle = FlatStyle.Flat;
            comboBox1.ForeColor = SystemColors.Window;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(62, 58);
            comboBox1.Margin = new Padding(3, 3, 0, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(389, 23);
            comboBox1.TabIndex = 39;
            comboBox1.Text = "-";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(63, 62, 70);
            comboBox2.FlatStyle = FlatStyle.Flat;
            comboBox2.ForeColor = SystemColors.Window;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(494, 19);
            comboBox2.Margin = new Padding(3, 3, 0, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(118, 23);
            comboBox2.TabIndex = 40;
            comboBox2.Text = "-";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
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
            dataGridViewCellStyle19.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle19.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle19.ForeColor = SystemColors.Window;
            dataGridViewCellStyle19.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle19.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = DataGridViewTriState.True;
            RegistroPDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            RegistroPDGV.ColumnHeadersHeight = 30;
            RegistroPDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RegistroPDGV.Columns.AddRange(new DataGridViewColumn[] { Hora, Dia1, Dia2, Dia3, Dia4, Dia5 });
            dataGridViewCellStyle20.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = Color.FromArgb(63, 62, 70);
            dataGridViewCellStyle20.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle20.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle20.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle20.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = DataGridViewTriState.False;
            RegistroPDGV.DefaultCellStyle = dataGridViewCellStyle20;
            RegistroPDGV.EnableHeadersVisualStyles = false;
            RegistroPDGV.GridColor = Color.White;
            RegistroPDGV.Location = new Point(12, 130);
            RegistroPDGV.Margin = new Padding(3, 0, 3, 3);
            RegistroPDGV.Name = "RegistroPDGV";
            RegistroPDGV.ReadOnly = true;
            RegistroPDGV.RightToLeft = RightToLeft.No;
            RegistroPDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle21.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle21.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle21.ForeColor = SystemColors.Window;
            dataGridViewCellStyle21.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = DataGridViewTriState.True;
            RegistroPDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            RegistroPDGV.RowHeadersVisible = false;
            RegistroPDGV.RowTemplate.Height = 25;
            RegistroPDGV.Size = new Size(626, 308);
            RegistroPDGV.TabIndex = 39;
            RegistroPDGV.CellContentClick += RegistroPDGV_CellContentClick;
            // 
            // Hora
            // 
            Hora.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Hora.HeaderText = "Horas";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            Hora.Width = 62;
            // 
            // Dia1
            // 
            Dia1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dia1.HeaderText = "Lunes";
            Dia1.Name = "Dia1";
            Dia1.ReadOnly = true;
            // 
            // Dia2
            // 
            Dia2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dia2.HeaderText = "Martes";
            Dia2.Name = "Dia2";
            Dia2.ReadOnly = true;
            // 
            // Dia3
            // 
            Dia3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dia3.HeaderText = "Miercoles";
            Dia3.Name = "Dia3";
            Dia3.ReadOnly = true;
            // 
            // Dia4
            // 
            Dia4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dia4.HeaderText = "Jueves";
            Dia4.Name = "Dia4";
            Dia4.ReadOnly = true;
            // 
            // Dia5
            // 
            Dia5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dia5.HeaderText = "Viernes";
            Dia5.Name = "Dia5";
            Dia5.ReadOnly = true;
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
            AgregarPButton.Location = new Point(454, 58);
            AgregarPButton.Margin = new Padding(0);
            AgregarPButton.Name = "AgregarPButton";
            AgregarPButton.Size = new Size(158, 23);
            AgregarPButton.TabIndex = 45;
            AgregarPButton.Text = "Agregar";
            AgregarPButton.UseVisualStyleBackColor = false;
            AgregarPButton.Click += AgregarPButton_Click;
            // 
            // PantallaRegitroHorario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(650, 450);
            Controls.Add(RegistroPDGV);
            Controls.Add(Header);
            Controls.Add(HorarioGroupBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaRegitroHorario";
            Text = "PantallaRegitroHorario";
            HorarioGroupBox.ResumeLayout(false);
            HorarioGroupBox.PerformLayout();
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RegistroPDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox HorarioGroupBox;
        private Label label3;
        private Panel Header;
        private PictureBox pictureBox1;
        private PictureBox RestoreButton;
        private PictureBox CloseButtonQR;
        private Label TittleLabel;
        private PictureBox MaximixeButton;
        private PictureBox MinimizeButton;
        private PictureBox CloseButton;
        private PictureBox pictureBox2;
        private ComboBox MateriaComboBox;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private DataGridView RegistroPDGV;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Dia1;
        private DataGridViewTextBoxColumn Dia2;
        private DataGridViewTextBoxColumn Dia3;
        private DataGridViewTextBoxColumn Dia4;
        private DataGridViewTextBoxColumn Dia5;
        private Button AgregarPButton;
    }
}