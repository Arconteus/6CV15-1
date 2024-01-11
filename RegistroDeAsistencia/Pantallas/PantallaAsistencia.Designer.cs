namespace RegistroDeAsistencia
{
    partial class PantallaAsistencia
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            FinalizarButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            GrupoCB = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            GroupBox = new GroupBox();
            FolioLabel = new Label();
            pictureBox2 = new PictureBox();
            QrBox = new PictureBox();
            DetallesGroupBox = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            HoraComboBox = new ComboBox();
            Horario = new Label();
            MateriaTB = new TextBox();
            ProfesorTextBox = new TextBox();
            ObservacionRTB = new RichTextBox();
            label2 = new Label();
            RegistroDGV = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            Boleta = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apa = new DataGridViewTextBoxColumn();
            Ama = new DataGridViewTextBoxColumn();
            Escuela = new DataGridViewTextBoxColumn();
            Carrera = new DataGridViewTextBoxColumn();
            Observacion = new DataGridViewButtonColumn();
            groupBox1 = new GroupBox();
            FechaLabel = new Label();
            HoraLabel = new Label();
            groupBox2 = new GroupBox();
            button1 = new Button();
            AddAlumnoButton = new Button();
            label12 = new Label();
            EscuelaCB = new ComboBox();
            CarreraCB = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            AmaTextBox = new TextBox();
            ApaTextBox = new TextBox();
            NomTextBox = new TextBox();
            BoletaTextBox = new TextBox();
            label6 = new Label();
            button2 = new Button();
            label13 = new Label();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QrBox).BeginInit();
            DetallesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // FinalizarButton
            // 
            FinalizarButton.Anchor = AnchorStyles.Top;
            FinalizarButton.BackColor = Color.FromArgb(86, 76, 149);
            FinalizarButton.Cursor = Cursors.Hand;
            FinalizarButton.FlatAppearance.BorderSize = 0;
            FinalizarButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            FinalizarButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            FinalizarButton.FlatStyle = FlatStyle.Flat;
            FinalizarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FinalizarButton.ForeColor = SystemColors.Control;
            FinalizarButton.Location = new Point(1194, 555);
            FinalizarButton.Margin = new Padding(0);
            FinalizarButton.Name = "FinalizarButton";
            FinalizarButton.Size = new Size(97, 33);
            FinalizarButton.TabIndex = 14;
            FinalizarButton.Text = "Finalizar";
            FinalizarButton.UseVisualStyleBackColor = false;
            FinalizarButton.Click += FinalizarButton_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(22, 384);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 8;
            label1.Text = " ";
            // 
            // GrupoCB
            // 
            GrupoCB.BackColor = Color.FromArgb(63, 62, 70);
            GrupoCB.FlatStyle = FlatStyle.Flat;
            GrupoCB.ForeColor = SystemColors.Window;
            GrupoCB.FormattingEnabled = true;
            GrupoCB.Location = new Point(66, 22);
            GrupoCB.Name = "GrupoCB";
            GrupoCB.RightToLeft = RightToLeft.No;
            GrupoCB.Size = new Size(117, 23);
            GrupoCB.TabIndex = 0;
            GrupoCB.Text = "-";
            GrupoCB.SelectedIndexChanged += GrupoCB_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(334, 26);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "Materia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(6, 60);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 12;
            label4.Text = "Profesor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 13;
            label5.Text = "Grupo:";
            // 
            // GroupBox
            // 
            GroupBox.Anchor = AnchorStyles.Top;
            GroupBox.Controls.Add(FolioLabel);
            GroupBox.ForeColor = SystemColors.Control;
            GroupBox.Location = new Point(927, 15);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(123, 87);
            GroupBox.TabIndex = 21;
            GroupBox.TabStop = false;
            GroupBox.Text = "Folio";
            // 
            // FolioLabel
            // 
            FolioLabel.Dock = DockStyle.Fill;
            FolioLabel.Location = new Point(3, 19);
            FolioLabel.Name = "FolioLabel";
            FolioLabel.Size = new Size(117, 65);
            FolioLabel.TabIndex = 22;
            FolioLabel.Text = "000001";
            FolioLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.Eye_Icon;
            pictureBox2.Location = new Point(12, 555);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // QrBox
            // 
            QrBox.Anchor = AnchorStyles.Top;
            QrBox.Cursor = Cursors.Hand;
            QrBox.Image = Properties.Resources.ID_Icon;
            QrBox.Location = new Point(12, 12);
            QrBox.Name = "QrBox";
            QrBox.Size = new Size(90, 71);
            QrBox.SizeMode = PictureBoxSizeMode.Zoom;
            QrBox.TabIndex = 28;
            QrBox.TabStop = false;
            QrBox.Click += QrBox_Click;
            // 
            // DetallesGroupBox
            // 
            DetallesGroupBox.Anchor = AnchorStyles.Top;
            DetallesGroupBox.Controls.Add(dateTimePicker1);
            DetallesGroupBox.Controls.Add(label7);
            DetallesGroupBox.Controls.Add(HoraComboBox);
            DetallesGroupBox.Controls.Add(Horario);
            DetallesGroupBox.Controls.Add(MateriaTB);
            DetallesGroupBox.Controls.Add(ProfesorTextBox);
            DetallesGroupBox.Controls.Add(GrupoCB);
            DetallesGroupBox.Controls.Add(label5);
            DetallesGroupBox.Controls.Add(label4);
            DetallesGroupBox.Controls.Add(label3);
            DetallesGroupBox.ForeColor = SystemColors.ControlLightLight;
            DetallesGroupBox.Location = new Point(108, 12);
            DetallesGroupBox.Name = "DetallesGroupBox";
            DetallesGroupBox.Size = new Size(813, 90);
            DetallesGroupBox.TabIndex = 29;
            DetallesGroupBox.TabStop = false;
            DetallesGroupBox.Text = "Detalles";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(233, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(95, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(189, 26);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 20;
            label7.Text = "Fecha";
            // 
            // HoraComboBox
            // 
            HoraComboBox.BackColor = Color.FromArgb(63, 62, 70);
            HoraComboBox.FlatStyle = FlatStyle.Flat;
            HoraComboBox.ForeColor = SystemColors.Window;
            HoraComboBox.FormattingEnabled = true;
            HoraComboBox.Location = new Point(701, 22);
            HoraComboBox.Name = "HoraComboBox";
            HoraComboBox.RightToLeft = RightToLeft.No;
            HoraComboBox.Size = new Size(106, 23);
            HoraComboBox.TabIndex = 3;
            HoraComboBox.Text = "-";
            HoraComboBox.KeyPress += HoraComboBox_KeyPress;
            // 
            // Horario
            // 
            Horario.AutoSize = true;
            Horario.ForeColor = SystemColors.Control;
            Horario.Location = new Point(653, 26);
            Horario.Name = "Horario";
            Horario.Size = new Size(36, 15);
            Horario.TabIndex = 18;
            Horario.Text = "Hora:";
            // 
            // MateriaTB
            // 
            MateriaTB.BackColor = Color.FromArgb(63, 62, 70);
            MateriaTB.ForeColor = SystemColors.ControlLightLight;
            MateriaTB.Location = new Point(390, 22);
            MateriaTB.Name = "MateriaTB";
            MateriaTB.Size = new Size(257, 23);
            MateriaTB.TabIndex = 2;
            MateriaTB.KeyPress += MateriaTB_KeyPress;
            // 
            // ProfesorTextBox
            // 
            ProfesorTextBox.BackColor = Color.FromArgb(63, 62, 70);
            ProfesorTextBox.ForeColor = SystemColors.ControlLightLight;
            ProfesorTextBox.Location = new Point(66, 57);
            ProfesorTextBox.Name = "ProfesorTextBox";
            ProfesorTextBox.Size = new Size(741, 23);
            ProfesorTextBox.TabIndex = 4;
            ProfesorTextBox.KeyPress += textBox1_KeyPress;
            // 
            // ObservacionRTB
            // 
            ObservacionRTB.Anchor = AnchorStyles.Top;
            ObservacionRTB.BackColor = Color.FromArgb(63, 62, 70);
            ObservacionRTB.BorderStyle = BorderStyle.None;
            ObservacionRTB.ForeColor = SystemColors.ControlLightLight;
            ObservacionRTB.Location = new Point(48, 555);
            ObservacionRTB.Margin = new Padding(0);
            ObservacionRTB.Name = "ObservacionRTB";
            ObservacionRTB.Size = new Size(1146, 33);
            ObservacionRTB.TabIndex = 13;
            ObservacionRTB.Text = "";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 31;
            label2.Text = "Registro QR";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistroDGV
            // 
            RegistroDGV.AllowUserToAddRows = false;
            RegistroDGV.AllowUserToDeleteRows = false;
            RegistroDGV.AllowUserToOrderColumns = true;
            RegistroDGV.Anchor = AnchorStyles.Top;
            RegistroDGV.BackgroundColor = Color.FromArgb(63, 62, 70);
            RegistroDGV.BorderStyle = BorderStyle.None;
            RegistroDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            RegistroDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            RegistroDGV.ColumnHeadersHeight = 30;
            RegistroDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RegistroDGV.Columns.AddRange(new DataGridViewColumn[] { Select, Boleta, Nombre, Apa, Ama, Escuela, Carrera, Observacion });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(63, 62, 70);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            RegistroDGV.DefaultCellStyle = dataGridViewCellStyle5;
            RegistroDGV.EnableHeadersVisualStyles = false;
            RegistroDGV.GridColor = Color.White;
            RegistroDGV.Location = new Point(12, 118);
            RegistroDGV.Margin = new Padding(3, 0, 3, 3);
            RegistroDGV.Name = "RegistroDGV";
            RegistroDGV.ReadOnly = true;
            RegistroDGV.RightToLeft = RightToLeft.No;
            RegistroDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            RegistroDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            RegistroDGV.RowHeadersVisible = false;
            RegistroDGV.RowTemplate.Height = 25;
            RegistroDGV.Size = new Size(1276, 342);
            RegistroDGV.TabIndex = 5;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Select.HeaderText = "S";
            Select.Name = "Select";
            Select.ReadOnly = true;
            Select.Width = 18;
            // 
            // Boleta
            // 
            Boleta.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Boleta.HeaderText = "Boleta";
            Boleta.Name = "Boleta";
            Boleta.ReadOnly = true;
            Boleta.Width = 64;
            // 
            // Nombre
            // 
            Nombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 75;
            // 
            // Apa
            // 
            Apa.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Apa.HeaderText = "Apellido P.";
            Apa.Name = "Apa";
            Apa.ReadOnly = true;
            Apa.Width = 88;
            // 
            // Ama
            // 
            Ama.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Ama.HeaderText = "Apellido M.";
            Ama.Name = "Ama";
            Ama.ReadOnly = true;
            Ama.Width = 92;
            // 
            // Escuela
            // 
            Escuela.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Escuela.HeaderText = "Escuela";
            Escuela.Name = "Escuela";
            Escuela.ReadOnly = true;
            // 
            // Carrera
            // 
            Carrera.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Carrera.HeaderText = "Carrera";
            Carrera.Name = "Carrera";
            Carrera.ReadOnly = true;
            // 
            // Observacion
            // 
            Observacion.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            Observacion.HeaderText = "+Obs";
            Observacion.Name = "Observacion";
            Observacion.ReadOnly = true;
            Observacion.Width = 41;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(FechaLabel);
            groupBox1.Controls.Add(HoraLabel);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(1056, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 89);
            groupBox1.TabIndex = 91;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reloj";
            // 
            // FechaLabel
            // 
            FechaLabel.Dock = DockStyle.Fill;
            FechaLabel.Location = new Point(3, 66);
            FechaLabel.Name = "FechaLabel";
            FechaLabel.Size = new Size(226, 20);
            FechaLabel.TabIndex = 1;
            FechaLabel.Text = "27/12/2023";
            FechaLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HoraLabel
            // 
            HoraLabel.Dock = DockStyle.Top;
            HoraLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            HoraLabel.Location = new Point(3, 19);
            HoraLabel.Name = "HoraLabel";
            HoraLabel.Size = new Size(226, 47);
            HoraLabel.TabIndex = 0;
            HoraLabel.Text = "XX:XX P.M.";
            HoraLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(AddAlumnoButton);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(EscuelaCB);
            groupBox2.Controls.Add(CarreraCB);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(AmaTextBox);
            groupBox2.Controls.Add(ApaTextBox);
            groupBox2.Controls.Add(NomTextBox);
            groupBox2.Controls.Add(BoletaTextBox);
            groupBox2.Controls.Add(label6);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(12, 466);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1173, 83);
            groupBox2.TabIndex = 92;
            groupBox2.TabStop = false;
            groupBox2.Text = "Agregar alumno manualmente";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(62, 124, 185);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 124, 185);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 170, 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(1096, 42);
            button1.Name = "button1";
            button1.Size = new Size(71, 23);
            button1.TabIndex = 15;
            button1.Text = "Editar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // AddAlumnoButton
            // 
            AddAlumnoButton.Anchor = AnchorStyles.Left;
            AddAlumnoButton.BackColor = Color.FromArgb(86, 76, 149);
            AddAlumnoButton.Cursor = Cursors.Hand;
            AddAlumnoButton.FlatAppearance.BorderSize = 0;
            AddAlumnoButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AddAlumnoButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AddAlumnoButton.FlatStyle = FlatStyle.Flat;
            AddAlumnoButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddAlumnoButton.ForeColor = SystemColors.Control;
            AddAlumnoButton.Location = new Point(1003, 42);
            AddAlumnoButton.Margin = new Padding(0);
            AddAlumnoButton.Name = "AddAlumnoButton";
            AddAlumnoButton.Size = new Size(90, 23);
            AddAlumnoButton.TabIndex = 12;
            AddAlumnoButton.Text = "Agregar";
            AddAlumnoButton.UseVisualStyleBackColor = false;
            AddAlumnoButton.Click += AddAlumnoButton_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left;
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.Control;
            label12.Location = new Point(820, 19);
            label12.Name = "label12";
            label12.Size = new Size(46, 15);
            label12.TabIndex = 104;
            label12.Text = "Escuela";
            // 
            // EscuelaCB
            // 
            EscuelaCB.Anchor = AnchorStyles.Left;
            EscuelaCB.BackColor = Color.FromArgb(63, 62, 70);
            EscuelaCB.FlatStyle = FlatStyle.Flat;
            EscuelaCB.ForeColor = SystemColors.Window;
            EscuelaCB.FormattingEnabled = true;
            EscuelaCB.Location = new Point(820, 42);
            EscuelaCB.Name = "EscuelaCB";
            EscuelaCB.RightToLeft = RightToLeft.No;
            EscuelaCB.Size = new Size(180, 23);
            EscuelaCB.TabIndex = 11;
            EscuelaCB.KeyPress += comboBox2_KeyPress;
            // 
            // CarreraCB
            // 
            CarreraCB.Anchor = AnchorStyles.Left;
            CarreraCB.BackColor = Color.FromArgb(63, 62, 70);
            CarreraCB.FlatStyle = FlatStyle.Flat;
            CarreraCB.ForeColor = SystemColors.Window;
            CarreraCB.FormattingEnabled = true;
            CarreraCB.Location = new Point(634, 42);
            CarreraCB.Name = "CarreraCB";
            CarreraCB.RightToLeft = RightToLeft.No;
            CarreraCB.Size = new Size(180, 23);
            CarreraCB.TabIndex = 10;
            CarreraCB.KeyPress += comboBox1_KeyPress;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left;
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(634, 19);
            label11.Name = "label11";
            label11.Size = new Size(45, 15);
            label11.TabIndex = 102;
            label11.Text = "Carrera";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left;
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(378, 19);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 101;
            label10.Text = "Nombre(s)";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left;
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(247, 19);
            label9.Name = "label9";
            label9.Size = new Size(99, 15);
            label9.TabIndex = 100;
            label9.Text = "Apellido materno";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left;
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(116, 19);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 99;
            label8.Text = "Apellido paterno";
            // 
            // AmaTextBox
            // 
            AmaTextBox.Anchor = AnchorStyles.Left;
            AmaTextBox.BackColor = Color.FromArgb(63, 62, 70);
            AmaTextBox.ForeColor = SystemColors.ControlLightLight;
            AmaTextBox.Location = new Point(247, 42);
            AmaTextBox.Name = "AmaTextBox";
            AmaTextBox.Size = new Size(125, 23);
            AmaTextBox.TabIndex = 8;
            AmaTextBox.KeyPress += OnlyLetters;
            // 
            // ApaTextBox
            // 
            ApaTextBox.Anchor = AnchorStyles.Left;
            ApaTextBox.BackColor = Color.FromArgb(63, 62, 70);
            ApaTextBox.ForeColor = SystemColors.ControlLightLight;
            ApaTextBox.Location = new Point(116, 42);
            ApaTextBox.Name = "ApaTextBox";
            ApaTextBox.Size = new Size(125, 23);
            ApaTextBox.TabIndex = 7;
            ApaTextBox.KeyPress += OnlyLetters;
            // 
            // NomTextBox
            // 
            NomTextBox.Anchor = AnchorStyles.Left;
            NomTextBox.BackColor = Color.FromArgb(63, 62, 70);
            NomTextBox.ForeColor = SystemColors.ControlLightLight;
            NomTextBox.Location = new Point(378, 42);
            NomTextBox.Name = "NomTextBox";
            NomTextBox.Size = new Size(250, 23);
            NomTextBox.TabIndex = 9;
            NomTextBox.KeyPress += OnlyLetters;
            // 
            // BoletaTextBox
            // 
            BoletaTextBox.Anchor = AnchorStyles.Left;
            BoletaTextBox.BackColor = Color.FromArgb(63, 62, 70);
            BoletaTextBox.ForeColor = SystemColors.ControlLightLight;
            BoletaTextBox.Location = new Point(10, 42);
            BoletaTextBox.Name = "BoletaTextBox";
            BoletaTextBox.Size = new Size(100, 23);
            BoletaTextBox.TabIndex = 6;
            BoletaTextBox.TextChanged += BoletaTextBox_TextChanged;
            BoletaTextBox.KeyPress += OnlyNumbers;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left;
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(10, 19);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 14;
            label6.Text = "Boleta";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.FromArgb(193, 71, 71);
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(193, 71, 71);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 88, 88);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(1191, 466);
            button2.Name = "button2";
            button2.Size = new Size(97, 34);
            button2.TabIndex = 16;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left;
            label13.ForeColor = SystemColors.Control;
            label13.Location = new Point(1191, 508);
            label13.Name = "label13";
            label13.Size = new Size(97, 41);
            label13.TabIndex = 107;
            label13.Text = "\\(^w^)/";
            label13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PantallaAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(1300, 600);
            Controls.Add(label13);
            Controls.Add(button2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(RegistroDGV);
            Controls.Add(label2);
            Controls.Add(ObservacionRTB);
            Controls.Add(DetallesGroupBox);
            Controls.Add(QrBox);
            Controls.Add(pictureBox2);
            Controls.Add(GroupBox);
            Controls.Add(label1);
            Controls.Add(FinalizarButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaAsistencia";
            Text = " ";
            Enter += PantallaAsistencia_Enter;
            GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)QrBox).EndInit();
            DetallesGroupBox.ResumeLayout(false);
            DetallesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FinalizarButton;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private ComboBox GrupoCB;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox GroupBox;
        private Label FolioLabel;
        private PictureBox pictureBox2;
        private PictureBox QrBox;
        private GroupBox DetallesGroupBox;
        private RichTextBox ObservacionRTB;
        private Label label2;
        private DataGridView RegistroDGV;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn Boleta;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apa;
        private DataGridViewTextBoxColumn Ama;
        private DataGridViewTextBoxColumn Escuela;
        private DataGridViewTextBoxColumn Carrera;
        private DataGridViewButtonColumn Observacion;
        private GroupBox groupBox1;
        private Label FechaLabel;
        private Label HoraLabel;
        private TextBox ProfesorTextBox;
        private TextBox MateriaTB;
        private GroupBox groupBox2;
        private Label label6;
        private TextBox BoletaTextBox;
        private TextBox AmaTextBox;
        private TextBox ApaTextBox;
        private TextBox NomTextBox;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private ComboBox EscuelaCB;
        private ComboBox CarreraCB;
        private Label label12;
        private Button AddAlumnoButton;
        private Button button2;
        private Label label13;
        private Button button1;
        private ComboBox HoraComboBox;
        private Label Horario;
        private DateTimePicker dateTimePicker1;
        private Label label7;
    }
}