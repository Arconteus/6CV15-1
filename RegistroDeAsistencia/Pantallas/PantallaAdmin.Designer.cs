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
            label7 = new Label();
            button1 = new Button();
            AddProfesorButton = new Button();
            SemestreComboBox = new ComboBox();
            GrupoComboBox = new ComboBox();
            ProfesorComboBox = new ComboBox();
            MateriaComboBox = new ComboBox();
            RegistroDGV = new DataGridView();
            Anio = new DataGridViewTextBoxColumn();
            Periodo = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
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
            AddGroupGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            Materialabel3.Location = new Point(258, 26);
            Materialabel3.Name = "Materialabel3";
            Materialabel3.Size = new Size(47, 15);
            Materialabel3.TabIndex = 2;
            Materialabel3.Text = "Materia";
            Materialabel3.Click += Materialabel3_Click;
            // 
            // AddMateriaButton
            // 
            AddMateriaButton.BackColor = Color.FromArgb(86, 76, 149);
            AddMateriaButton.FlatAppearance.BorderSize = 0;
            AddMateriaButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AddMateriaButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AddMateriaButton.FlatStyle = FlatStyle.Flat;
            AddMateriaButton.ForeColor = SystemColors.Control;
            AddMateriaButton.Location = new Point(573, 22);
            AddMateriaButton.Margin = new Padding(0);
            AddMateriaButton.Name = "AddMateriaButton";
            AddMateriaButton.Size = new Size(23, 23);
            AddMateriaButton.TabIndex = 25;
            AddMateriaButton.Text = "+";
            AddMateriaButton.UseVisualStyleBackColor = false;
            AddMateriaButton.Click += AddMateriaButton_Click;
            // 
            // AddGroupGroupBox
            // 
            AddGroupGroupBox.Controls.Add(label7);
            AddGroupGroupBox.Controls.Add(button1);
            AddGroupGroupBox.Controls.Add(AddProfesorButton);
            AddGroupGroupBox.Controls.Add(AddMateriaButton);
            AddGroupGroupBox.Controls.Add(SemestreComboBox);
            AddGroupGroupBox.Controls.Add(GrupoComboBox);
            AddGroupGroupBox.Controls.Add(ProfesorComboBox);
            AddGroupGroupBox.Controls.Add(MateriaComboBox);
            AddGroupGroupBox.Controls.Add(Grupolabel1);
            AddGroupGroupBox.Controls.Add(Profesorlabel2);
            AddGroupGroupBox.Controls.Add(Materialabel3);
            AddGroupGroupBox.ForeColor = SystemColors.ControlLightLight;
            AddGroupGroupBox.Location = new Point(12, 12);
            AddGroupGroupBox.Name = "AddGroupGroupBox";
            AddGroupGroupBox.Size = new Size(681, 90);
            AddGroupGroupBox.TabIndex = 27;
            AddGroupGroupBox.TabStop = false;
            AddGroupGroupBox.Text = "Agregar Grupo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(161, 25);
            label7.Name = "label7";
            label7.Size = new Size(48, 15);
            label7.TabIndex = 36;
            label7.Text = "Periodo";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(86, 76, 149);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(616, 22);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(52, 52);
            button1.TabIndex = 35;
            button1.Text = "+";
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            // 
            // AddProfesorButton
            // 
            AddProfesorButton.BackColor = Color.FromArgb(86, 76, 149);
            AddProfesorButton.FlatAppearance.BorderSize = 0;
            AddProfesorButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AddProfesorButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AddProfesorButton.FlatStyle = FlatStyle.Flat;
            AddProfesorButton.ForeColor = SystemColors.Control;
            AddProfesorButton.Location = new Point(573, 51);
            AddProfesorButton.Margin = new Padding(0);
            AddProfesorButton.Name = "AddProfesorButton";
            AddProfesorButton.Size = new Size(23, 23);
            AddProfesorButton.TabIndex = 34;
            AddProfesorButton.Text = "+";
            AddProfesorButton.UseVisualStyleBackColor = false;
            AddProfesorButton.Click += AddProfesorButton_Click;
            // 
            // SemestreComboBox
            // 
            SemestreComboBox.BackColor = Color.FromArgb(63, 62, 70);
            SemestreComboBox.FlatStyle = FlatStyle.Flat;
            SemestreComboBox.ForeColor = SystemColors.Window;
            SemestreComboBox.FormattingEnabled = true;
            SemestreComboBox.Items.AddRange(new object[] { "1", "2" });
            SemestreComboBox.Location = new Point(215, 23);
            SemestreComboBox.Name = "SemestreComboBox";
            SemestreComboBox.Size = new Size(37, 23);
            SemestreComboBox.TabIndex = 8;
            SemestreComboBox.Text = "-";
            // 
            // GrupoComboBox
            // 
            GrupoComboBox.BackColor = Color.FromArgb(63, 62, 70);
            GrupoComboBox.FlatStyle = FlatStyle.Flat;
            GrupoComboBox.ForeColor = SystemColors.Window;
            GrupoComboBox.FormattingEnabled = true;
            GrupoComboBox.Location = new Point(67, 22);
            GrupoComboBox.Name = "GrupoComboBox";
            GrupoComboBox.Size = new Size(88, 23);
            GrupoComboBox.TabIndex = 7;
            GrupoComboBox.Text = "-";
            GrupoComboBox.SelectedIndexChanged += AñoComboBox_SelectedIndexChanged;
            // 
            // ProfesorComboBox
            // 
            ProfesorComboBox.BackColor = Color.FromArgb(63, 62, 70);
            ProfesorComboBox.FlatStyle = FlatStyle.Flat;
            ProfesorComboBox.ForeColor = SystemColors.Window;
            ProfesorComboBox.FormattingEnabled = true;
            ProfesorComboBox.Location = new Point(67, 51);
            ProfesorComboBox.Margin = new Padding(3, 3, 0, 3);
            ProfesorComboBox.Name = "ProfesorComboBox";
            ProfesorComboBox.Size = new Size(506, 23);
            ProfesorComboBox.TabIndex = 6;
            ProfesorComboBox.Text = "-";
            ProfesorComboBox.SelectedIndexChanged += ProfesorComboBox_SelectedIndexChanged;
            // 
            // MateriaComboBox
            // 
            MateriaComboBox.BackColor = Color.FromArgb(63, 62, 70);
            MateriaComboBox.FlatStyle = FlatStyle.Flat;
            MateriaComboBox.ForeColor = SystemColors.Window;
            MateriaComboBox.FormattingEnabled = true;
            MateriaComboBox.Location = new Point(311, 22);
            MateriaComboBox.Margin = new Padding(3, 3, 0, 3);
            MateriaComboBox.Name = "MateriaComboBox";
            MateriaComboBox.Size = new Size(262, 23);
            MateriaComboBox.TabIndex = 5;
            MateriaComboBox.Text = "-";
            MateriaComboBox.SelectedIndexChanged += MateriaComboBox_SelectedIndexChanged;
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
            RegistroDGV.Columns.AddRange(new DataGridViewColumn[] { Anio, Periodo, Grupo, Profesor, Materia, Horario, Eliminar });
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
            RegistroDGV.Size = new Size(610, 320);
            RegistroDGV.TabIndex = 33;
            RegistroDGV.CellContentClick += RegistroDGV_CellContentClick;
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
            // Horario
            // 
            Horario.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Horario.HeaderText = "Horario";
            Horario.Name = "Horario";
            Horario.ReadOnly = true;
            Horario.Width = 52;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 55;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Group_Icon;
            pictureBox1.Location = new Point(724, 12);
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
            groupBox1.Location = new Point(628, 118);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(212, 320);
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
            button2.Location = new Point(3, 284);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(206, 33);
            button2.TabIndex = 36;
            button2.Text = "Buscar";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = false;
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
            // PantallaAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(852, 450);
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
            ResumeLayout(false);
        }

        #endregion

        private Label Grupolabel1;
        private Label Profesorlabel2;
        private Label Materialabel3;
        private Button AddMateriaButton;
        private GroupBox AddGroupGroupBox;
        private ComboBox MateriaComboBox;
        private ComboBox ProfesorComboBox;
        private DataGridView RegistroDGV;
        private ComboBox SemestreComboBox;
        private ComboBox GrupoComboBox;
        private Button AddProfesorButton;
        private Button button1;
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
        private DataGridViewTextBoxColumn Anio;
        private DataGridViewTextBoxColumn Periodo;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn Profesor;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewButtonColumn Horario;
        private DataGridViewButtonColumn Eliminar;
    }
}