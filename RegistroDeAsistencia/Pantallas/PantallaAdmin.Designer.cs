namespace RegistroDeAsistencia
{
    partial class PantallaAdmin
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Grupolabel1 = new Label();
            Profesorlabel2 = new Label();
            Materialabel3 = new Label();
            AddMateriaButton = new Button();
            AddGroupGroupBox = new GroupBox();
            AddGrupoButton = new Button();
            AnioTB = new TextBox();
            AddProfesorButton = new Button();
            Semestrelabel4 = new Label();
            label7 = new Label();
            PeriodoCB = new ComboBox();
            CodigoGrupoCB = new ComboBox();
            ProfesorCB = new ComboBox();
            MateriaCB = new ComboBox();
            RegistroDGV = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            Anio = new DataGridViewTextBoxColumn();
            Periodo = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button2 = new Button();
            panel4 = new Panel();
            FiltroCodigoComboBox = new ComboBox();
            label5 = new Label();
            panel3 = new Panel();
            FiltroProfesorComboBox = new ComboBox();
            label4 = new Label();
            panel2 = new Panel();
            FiltroMateriaComboBox = new ComboBox();
            label6 = new Label();
            panel1 = new Panel();
            FiltroPeriodoComboBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            FiltroAñoTextBox = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            FechaLabel = new Label();
            HoraLabel = new Label();
            AddGroupGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Grupolabel1
            // 
            Grupolabel1.AutoSize = true;
            Grupolabel1.ForeColor = SystemColors.ControlLightLight;
            Grupolabel1.Location = new Point(10, 25);
            Grupolabel1.Name = "Grupolabel1";
            Grupolabel1.Size = new Size(40, 15);
            Grupolabel1.TabIndex = 0;
            Grupolabel1.Text = "Grupo";
            // 
            // Profesorlabel2
            // 
            Profesorlabel2.AutoSize = true;
            Profesorlabel2.ForeColor = SystemColors.ControlLightLight;
            Profesorlabel2.Location = new Point(10, 54);
            Profesorlabel2.Name = "Profesorlabel2";
            Profesorlabel2.Size = new Size(51, 15);
            Profesorlabel2.TabIndex = 1;
            Profesorlabel2.Text = "Profesor";
            // 
            // Materialabel3
            // 
            Materialabel3.AutoSize = true;
            Materialabel3.ForeColor = SystemColors.ControlLightLight;
            Materialabel3.Location = new Point(402, 27);
            Materialabel3.Name = "Materialabel3";
            Materialabel3.Size = new Size(47, 15);
            Materialabel3.TabIndex = 2;
            Materialabel3.Text = "Materia";
            // 
            // AddMateriaButton
            // 
            AddMateriaButton.BackColor = Color.FromArgb(86, 76, 149);
            AddMateriaButton.FlatAppearance.BorderSize = 0;
            AddMateriaButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AddMateriaButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AddMateriaButton.FlatStyle = FlatStyle.Flat;
            AddMateriaButton.ForeColor = SystemColors.Control;
            AddMateriaButton.Location = new Point(711, 22);
            AddMateriaButton.Margin = new Padding(0, 0, 3, 0);
            AddMateriaButton.Name = "AddMateriaButton";
            AddMateriaButton.Size = new Size(114, 24);
            AddMateriaButton.TabIndex = 25;
            AddMateriaButton.Text = "Agregar Materia";
            AddMateriaButton.UseVisualStyleBackColor = false;
            AddMateriaButton.Click += AddMateriaButton_Click;
            // 
            // AddGroupGroupBox
            // 
            AddGroupGroupBox.Controls.Add(AddGrupoButton);
            AddGroupGroupBox.Controls.Add(AddMateriaButton);
            AddGroupGroupBox.Controls.Add(AnioTB);
            AddGroupGroupBox.Controls.Add(AddProfesorButton);
            AddGroupGroupBox.Controls.Add(Semestrelabel4);
            AddGroupGroupBox.Controls.Add(label7);
            AddGroupGroupBox.Controls.Add(PeriodoCB);
            AddGroupGroupBox.Controls.Add(CodigoGrupoCB);
            AddGroupGroupBox.Controls.Add(ProfesorCB);
            AddGroupGroupBox.Controls.Add(MateriaCB);
            AddGroupGroupBox.Controls.Add(Grupolabel1);
            AddGroupGroupBox.Controls.Add(Profesorlabel2);
            AddGroupGroupBox.Controls.Add(Materialabel3);
            AddGroupGroupBox.ForeColor = SystemColors.ControlLightLight;
            AddGroupGroupBox.Location = new Point(12, 12);
            AddGroupGroupBox.Name = "AddGroupGroupBox";
            AddGroupGroupBox.Size = new Size(942, 90);
            AddGroupGroupBox.TabIndex = 27;
            AddGroupGroupBox.TabStop = false;
            AddGroupGroupBox.Text = "Agregar Grupo";
            // 
            // AddGrupoButton
            // 
            AddGrupoButton.BackColor = Color.FromArgb(86, 76, 149);
            AddGrupoButton.FlatAppearance.BorderSize = 0;
            AddGrupoButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AddGrupoButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AddGrupoButton.FlatStyle = FlatStyle.Flat;
            AddGrupoButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            AddGrupoButton.ForeColor = SystemColors.Control;
            AddGrupoButton.Location = new Point(831, 22);
            AddGrupoButton.Name = "AddGrupoButton";
            AddGrupoButton.Size = new Size(105, 52);
            AddGrupoButton.TabIndex = 35;
            AddGrupoButton.Text = "Agregar grupo";
            AddGrupoButton.UseVisualStyleBackColor = false;
            AddGrupoButton.Click += AddGrupoButton_Click;
            // 
            // AnioTB
            // 
            AnioTB.BackColor = Color.FromArgb(63, 62, 70);
            AnioTB.ForeColor = SystemColors.ControlLightLight;
            AnioTB.Location = new Point(347, 22);
            AnioTB.Name = "AnioTB";
            AnioTB.Size = new Size(49, 23);
            AnioTB.TabIndex = 38;
            // 
            // AddProfesorButton
            // 
            AddProfesorButton.BackColor = Color.FromArgb(86, 76, 149);
            AddProfesorButton.FlatAppearance.BorderSize = 0;
            AddProfesorButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AddProfesorButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AddProfesorButton.FlatStyle = FlatStyle.Flat;
            AddProfesorButton.ForeColor = SystemColors.Control;
            AddProfesorButton.Location = new Point(711, 51);
            AddProfesorButton.Margin = new Padding(0);
            AddProfesorButton.Name = "AddProfesorButton";
            AddProfesorButton.Size = new Size(114, 23);
            AddProfesorButton.TabIndex = 34;
            AddProfesorButton.Text = "Agregar profesor";
            AddProfesorButton.UseVisualStyleBackColor = false;
            AddProfesorButton.Click += AddProfesorButton_Click;
            // 
            // Semestrelabel4
            // 
            Semestrelabel4.AutoSize = true;
            Semestrelabel4.ForeColor = SystemColors.Control;
            Semestrelabel4.Location = new Point(312, 26);
            Semestrelabel4.Name = "Semestrelabel4";
            Semestrelabel4.Size = new Size(29, 15);
            Semestrelabel4.TabIndex = 37;
            Semestrelabel4.Text = "Año";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(215, 27);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 36;
            label7.Text = "Periodo";
            // 
            // PeriodoCB
            // 
            PeriodoCB.BackColor = Color.FromArgb(63, 62, 70);
            PeriodoCB.FlatStyle = FlatStyle.Flat;
            PeriodoCB.ForeColor = SystemColors.Window;
            PeriodoCB.FormattingEnabled = true;
            PeriodoCB.Items.AddRange(new object[] { "1", "2" });
            PeriodoCB.Location = new Point(269, 23);
            PeriodoCB.Name = "PeriodoCB";
            PeriodoCB.Size = new Size(37, 23);
            PeriodoCB.TabIndex = 8;
            PeriodoCB.Text = "-";
            // 
            // CodigoGrupoCB
            // 
            CodigoGrupoCB.BackColor = Color.FromArgb(63, 62, 70);
            CodigoGrupoCB.FlatStyle = FlatStyle.Flat;
            CodigoGrupoCB.ForeColor = SystemColors.Window;
            CodigoGrupoCB.FormattingEnabled = true;
            CodigoGrupoCB.Location = new Point(67, 22);
            CodigoGrupoCB.Name = "CodigoGrupoCB";
            CodigoGrupoCB.Size = new Size(142, 23);
            CodigoGrupoCB.TabIndex = 7;
            CodigoGrupoCB.Text = "-";
            // 
            // ProfesorCB
            // 
            ProfesorCB.BackColor = Color.FromArgb(63, 62, 70);
            ProfesorCB.FlatStyle = FlatStyle.Flat;
            ProfesorCB.ForeColor = SystemColors.Window;
            ProfesorCB.FormattingEnabled = true;
            ProfesorCB.Location = new Point(67, 51);
            ProfesorCB.Margin = new Padding(3, 3, 0, 3);
            ProfesorCB.Name = "ProfesorCB";
            ProfesorCB.Size = new Size(644, 23);
            ProfesorCB.TabIndex = 6;
            ProfesorCB.Text = "-";
            ProfesorCB.DropDown += ProfesorCB_DropDown;
            // 
            // MateriaCB
            // 
            MateriaCB.BackColor = Color.FromArgb(63, 62, 70);
            MateriaCB.FlatStyle = FlatStyle.Flat;
            MateriaCB.ForeColor = SystemColors.Window;
            MateriaCB.FormattingEnabled = true;
            MateriaCB.Location = new Point(455, 23);
            MateriaCB.Margin = new Padding(3, 3, 0, 3);
            MateriaCB.Name = "MateriaCB";
            MateriaCB.Size = new Size(256, 23);
            MateriaCB.TabIndex = 5;
            MateriaCB.Text = "-";
            // 
            // RegistroDGV
            // 
            RegistroDGV.AllowUserToDeleteRows = false;
            RegistroDGV.AllowUserToOrderColumns = true;
            RegistroDGV.BackgroundColor = Color.FromArgb(63, 62, 70);
            RegistroDGV.BorderStyle = BorderStyle.None;
            RegistroDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            RegistroDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            RegistroDGV.ColumnHeadersHeight = 30;
            RegistroDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RegistroDGV.Columns.AddRange(new DataGridViewColumn[] { id, Anio, Periodo, Grupo, Profesor, Materia });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 62, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            RegistroDGV.DefaultCellStyle = dataGridViewCellStyle2;
            RegistroDGV.EnableHeadersVisualStyles = false;
            RegistroDGV.GridColor = Color.White;
            RegistroDGV.Location = new Point(12, 118);
            RegistroDGV.Margin = new Padding(3, 0, 3, 3);
            RegistroDGV.Name = "RegistroDGV";
            RegistroDGV.ReadOnly = true;
            RegistroDGV.RightToLeft = RightToLeft.No;
            RegistroDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            RegistroDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            RegistroDGV.RowHeadersVisible = false;
            RegistroDGV.RowTemplate.Height = 25;
            RegistroDGV.Size = new Size(1058, 467);
            RegistroDGV.TabIndex = 33;
            RegistroDGV.CellContentClick += RegistroDGV_CellContentClick;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 42;
            // 
            // Anio
            // 
            Anio.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Anio.HeaderText = "Año";
            Anio.Name = "Anio";
            Anio.ReadOnly = true;
            Anio.Resizable = DataGridViewTriState.True;
            Anio.SortMode = DataGridViewColumnSortMode.NotSortable;
            Anio.Width = 34;
            // 
            // Periodo
            // 
            Periodo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Periodo.HeaderText = "Periodo";
            Periodo.Name = "Periodo";
            Periodo.ReadOnly = true;
            Periodo.Width = 72;
            // 
            // Grupo
            // 
            Grupo.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Grupo.HeaderText = "Grupo";
            Grupo.Name = "Grupo";
            Grupo.ReadOnly = true;
            Grupo.Width = 64;
            // 
            // Profesor
            // 
            Profesor.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Profesor.HeaderText = "Profesor";
            Profesor.Name = "Profesor";
            Profesor.ReadOnly = true;
            // 
            // Materia
            // 
            Materia.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Materia.HeaderText = "Materia";
            Materia.Name = "Materia";
            Materia.ReadOnly = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Group_Icon;
            pictureBox1.Location = new Point(960, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 34;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(panel4);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(1076, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 470);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtro";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(86, 76, 149);
            button2.Dock = DockStyle.Bottom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(3, 434);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(206, 33);
            button2.TabIndex = 36;
            button2.Text = "Buscar";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(FiltroCodigoComboBox);
            panel4.Controls.Add(label5);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(3, 217);
            panel4.Name = "panel4";
            panel4.Size = new Size(206, 68);
            panel4.TabIndex = 5;
            // 
            // FiltroCodigoComboBox
            // 
            FiltroCodigoComboBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroCodigoComboBox.FlatStyle = FlatStyle.Flat;
            FiltroCodigoComboBox.ForeColor = SystemColors.Window;
            FiltroCodigoComboBox.FormattingEnabled = true;
            FiltroCodigoComboBox.Location = new Point(3, 18);
            FiltroCodigoComboBox.Name = "FiltroCodigoComboBox";
            FiltroCodigoComboBox.Size = new Size(200, 23);
            FiltroCodigoComboBox.TabIndex = 36;
            FiltroCodigoComboBox.Text = "-";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(206, 15);
            label5.TabIndex = 1;
            label5.Text = "Codigo Grupo";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(FiltroProfesorComboBox);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(206, 66);
            panel3.TabIndex = 6;
            // 
            // FiltroProfesorComboBox
            // 
            FiltroProfesorComboBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroProfesorComboBox.FlatStyle = FlatStyle.Flat;
            FiltroProfesorComboBox.ForeColor = SystemColors.Window;
            FiltroProfesorComboBox.FormattingEnabled = true;
            FiltroProfesorComboBox.Location = new Point(3, 18);
            FiltroProfesorComboBox.Name = "FiltroProfesorComboBox";
            FiltroProfesorComboBox.Size = new Size(200, 23);
            FiltroProfesorComboBox.TabIndex = 36;
            FiltroProfesorComboBox.Text = "-";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(206, 15);
            label4.TabIndex = 1;
            label4.Text = "Profesor";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(FiltroMateriaComboBox);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(206, 66);
            panel2.TabIndex = 4;
            // 
            // FiltroMateriaComboBox
            // 
            FiltroMateriaComboBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroMateriaComboBox.FlatStyle = FlatStyle.Flat;
            FiltroMateriaComboBox.ForeColor = SystemColors.Window;
            FiltroMateriaComboBox.FormattingEnabled = true;
            FiltroMateriaComboBox.Location = new Point(3, 18);
            FiltroMateriaComboBox.Name = "FiltroMateriaComboBox";
            FiltroMateriaComboBox.Size = new Size(200, 23);
            FiltroMateriaComboBox.TabIndex = 36;
            FiltroMateriaComboBox.Text = "-";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(0, 0);
            label6.Name = "label6";
            label6.Size = new Size(206, 15);
            label6.TabIndex = 1;
            label6.Text = "Materia";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(FiltroPeriodoComboBox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(FiltroAñoTextBox);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(206, 66);
            panel1.TabIndex = 3;
            // 
            // FiltroPeriodoComboBox
            // 
            FiltroPeriodoComboBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroPeriodoComboBox.FlatStyle = FlatStyle.Flat;
            FiltroPeriodoComboBox.ForeColor = SystemColors.Window;
            FiltroPeriodoComboBox.FormattingEnabled = true;
            FiltroPeriodoComboBox.Location = new Point(158, 18);
            FiltroPeriodoComboBox.Margin = new Padding(3, 3, 0, 3);
            FiltroPeriodoComboBox.Name = "FiltroPeriodoComboBox";
            FiltroPeriodoComboBox.Size = new Size(45, 23);
            FiltroPeriodoComboBox.TabIndex = 36;
            FiltroPeriodoComboBox.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 21);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 4;
            label3.Text = "Periodo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 21);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 3;
            label2.Text = "Año";
            // 
            // FiltroAñoTextBox
            // 
            FiltroAñoTextBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroAñoTextBox.ForeColor = SystemColors.ControlLightLight;
            FiltroAñoTextBox.Location = new Point(35, 18);
            FiltroAñoTextBox.Name = "FiltroAñoTextBox";
            FiltroAñoTextBox.Size = new Size(46, 23);
            FiltroAñoTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(206, 15);
            label1.TabIndex = 1;
            label1.Text = "Semestre";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top;
            groupBox2.Controls.Add(FechaLabel);
            groupBox2.Controls.Add(HoraLabel);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(1056, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(232, 90);
            groupBox2.TabIndex = 91;
            groupBox2.TabStop = false;
            groupBox2.Text = "Reloj";
            // 
            // FechaLabel
            // 
            FechaLabel.Dock = DockStyle.Fill;
            FechaLabel.Location = new Point(3, 66);
            FechaLabel.Name = "FechaLabel";
            FechaLabel.Size = new Size(226, 21);
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
            HoraLabel.Click += HoraLabel_Click;
            // 
            // PantallaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(1300, 600);
            Controls.Add(groupBox2);
            Controls.Add(pictureBox1);
            Controls.Add(RegistroDGV);
            Controls.Add(AddGroupGroupBox);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaAdmin";
            Text = "Pantalla_admin";
            Load += PantallaAdmin_Load;
            AddGroupGroupBox.ResumeLayout(false);
            AddGroupGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Grupolabel1;
        private Label Profesorlabel2;
        private Label Materialabel3;
        private Button AddMateriaButton;
        private GroupBox AddGroupGroupBox;
        private ComboBox MateriaCB;
        private ComboBox ProfesorCB;
        private DataGridView RegistroDGV;
        private ComboBox PeriodoCB;
        private ComboBox CodigoGrupoCB;
        private Button AddProfesorButton;
        private Button AddGrupoButton;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label1;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private TextBox FiltroAñoTextBox;
        private Panel panel3;
        private ComboBox FiltroProfesorComboBox;
        private Label label4;
        private Panel panel2;
        private ComboBox FiltroMateriaComboBox;
        private Label label6;
        private ComboBox FiltroPeriodoComboBox;
        private Button button2;
        private Panel panel4;
        private ComboBox FiltroCodigoComboBox;
        private Label label5;
        private Label label7;
        private TextBox AnioTB;
        private Label Semestrelabel4;
        private GroupBox groupBox2;
        private Label FechaLabel;
        private Label HoraLabel;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Anio;
        private DataGridViewTextBoxColumn Periodo;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn Profesor;
        private DataGridViewTextBoxColumn Materia;
    }
}