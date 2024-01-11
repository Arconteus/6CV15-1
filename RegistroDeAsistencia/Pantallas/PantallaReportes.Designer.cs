namespace RegistroDeAsistencia
{
    partial class PantallaReportes
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
            FiltroCodigoComboBox = new ComboBox();
            Materialabel3 = new Label();
            Profesorlabel2 = new Label();
            Grupolabel1 = new Label();
            Semestrelabel4 = new Label();
            Fechainferiorlabel5 = new Label();
            Fechasuperiorlabel6 = new Label();
            FiltroPeriodoComboBox = new ComboBox();
            FechaInferiorDTP = new DateTimePicker();
            FechaSuperiorDTP = new DateTimePicker();
            FormatodereportecheckBox1 = new CheckBox();
            excelxmlcheckBox2 = new CheckBox();
            excelxlsxcheckBox3 = new CheckBox();
            groupBox1 = new GroupBox();
            BuscarFiltro = new Button();
            label1 = new Label();
            FiltroAñoTextBox = new TextBox();
            FiltroMateriaComboBox = new ComboBox();
            FiltroProfesorComboBox = new ComboBox();
            groupBox2 = new GroupBox();
            ReporteExportButton = new Button();
            ReporteExportInButton = new Button();
            RegistroDGV = new DataGridView();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            DBExport = new Button();
            DBExportButton = new Button();
            groupBox4 = new GroupBox();
            FechaLabel = new Label();
            HoraLabel = new Label();
            Select = new DataGridViewCheckBoxColumn();
            id = new DataGridViewTextBoxColumn();
            Semestre = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // FiltroCodigoComboBox
            // 
            FiltroCodigoComboBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroCodigoComboBox.FlatStyle = FlatStyle.Flat;
            FiltroCodigoComboBox.ForeColor = SystemColors.ControlLightLight;
            FiltroCodigoComboBox.FormattingEnabled = true;
            FiltroCodigoComboBox.Location = new Point(93, 22);
            FiltroCodigoComboBox.Name = "FiltroCodigoComboBox";
            FiltroCodigoComboBox.Size = new Size(396, 23);
            FiltroCodigoComboBox.TabIndex = 10;
            // 
            // Materialabel3
            // 
            Materialabel3.AutoSize = true;
            Materialabel3.ForeColor = SystemColors.Control;
            Materialabel3.Location = new Point(15, 83);
            Materialabel3.Name = "Materialabel3";
            Materialabel3.Size = new Size(47, 15);
            Materialabel3.TabIndex = 8;
            Materialabel3.Text = "Materia";
            // 
            // Profesorlabel2
            // 
            Profesorlabel2.AutoSize = true;
            Profesorlabel2.ForeColor = SystemColors.Control;
            Profesorlabel2.Location = new Point(15, 54);
            Profesorlabel2.Name = "Profesorlabel2";
            Profesorlabel2.Size = new Size(51, 15);
            Profesorlabel2.TabIndex = 7;
            Profesorlabel2.Text = "Profesor";
            // 
            // Grupolabel1
            // 
            Grupolabel1.AutoSize = true;
            Grupolabel1.ForeColor = SystemColors.Control;
            Grupolabel1.Location = new Point(15, 25);
            Grupolabel1.Name = "Grupolabel1";
            Grupolabel1.Size = new Size(40, 15);
            Grupolabel1.TabIndex = 6;
            Grupolabel1.Text = "Grupo";
            // 
            // Semestrelabel4
            // 
            Semestrelabel4.AutoSize = true;
            Semestrelabel4.ForeColor = SystemColors.Control;
            Semestrelabel4.Location = new Point(495, 25);
            Semestrelabel4.Name = "Semestrelabel4";
            Semestrelabel4.Size = new Size(29, 15);
            Semestrelabel4.TabIndex = 12;
            Semestrelabel4.Text = "Año";
            // 
            // Fechainferiorlabel5
            // 
            Fechainferiorlabel5.AutoSize = true;
            Fechainferiorlabel5.ForeColor = SystemColors.Control;
            Fechainferiorlabel5.Location = new Point(690, 59);
            Fechainferiorlabel5.Name = "Fechainferiorlabel5";
            Fechainferiorlabel5.Size = new Size(79, 15);
            Fechainferiorlabel5.TabIndex = 13;
            Fechainferiorlabel5.Text = "Fecha Inferior";
            // 
            // Fechasuperiorlabel6
            // 
            Fechasuperiorlabel6.AutoSize = true;
            Fechasuperiorlabel6.ForeColor = SystemColors.Control;
            Fechasuperiorlabel6.Location = new Point(684, 25);
            Fechasuperiorlabel6.Name = "Fechasuperiorlabel6";
            Fechasuperiorlabel6.Size = new Size(85, 15);
            Fechasuperiorlabel6.TabIndex = 14;
            Fechasuperiorlabel6.Text = "Fecha Superior";
            // 
            // FiltroPeriodoComboBox
            // 
            FiltroPeriodoComboBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroPeriodoComboBox.FlatStyle = FlatStyle.Flat;
            FiltroPeriodoComboBox.ForeColor = SystemColors.ControlLightLight;
            FiltroPeriodoComboBox.FormattingEnabled = true;
            FiltroPeriodoComboBox.Items.AddRange(new object[] { "1", "2" });
            FiltroPeriodoComboBox.Location = new Point(639, 22);
            FiltroPeriodoComboBox.Name = "FiltroPeriodoComboBox";
            FiltroPeriodoComboBox.Size = new Size(42, 23);
            FiltroPeriodoComboBox.TabIndex = 15;
            // 
            // FechaInferiorDTP
            // 
            FechaInferiorDTP.CalendarForeColor = Color.FromArgb(30, 33, 36);
            FechaInferiorDTP.CalendarMonthBackground = Color.FromArgb(30, 33, 36);
            FechaInferiorDTP.CalendarTitleBackColor = Color.FromArgb(30, 33, 36);
            FechaInferiorDTP.CalendarTitleForeColor = Color.FromArgb(30, 33, 36);
            FechaInferiorDTP.CalendarTrailingForeColor = Color.FromArgb(30, 33, 36);
            FechaInferiorDTP.Format = DateTimePickerFormat.Short;
            FechaInferiorDTP.Location = new Point(775, 22);
            FechaInferiorDTP.Name = "FechaInferiorDTP";
            FechaInferiorDTP.Size = new Size(96, 23);
            FechaInferiorDTP.TabIndex = 22;
            // 
            // FechaSuperiorDTP
            // 
            FechaSuperiorDTP.Format = DateTimePickerFormat.Short;
            FechaSuperiorDTP.Location = new Point(775, 54);
            FechaSuperiorDTP.Name = "FechaSuperiorDTP";
            FechaSuperiorDTP.Size = new Size(96, 23);
            FechaSuperiorDTP.TabIndex = 23;
            // 
            // FormatodereportecheckBox1
            // 
            FormatodereportecheckBox1.AutoSize = true;
            FormatodereportecheckBox1.FlatStyle = FlatStyle.Flat;
            FormatodereportecheckBox1.ForeColor = SystemColors.Control;
            FormatodereportecheckBox1.Location = new Point(6, 22);
            FormatodereportecheckBox1.Name = "FormatodereportecheckBox1";
            FormatodereportecheckBox1.Size = new Size(170, 19);
            FormatodereportecheckBox1.TabIndex = 25;
            FormatodereportecheckBox1.Text = "Formato de Reporte(s)(PDF)";
            FormatodereportecheckBox1.UseVisualStyleBackColor = true;
            // 
            // excelxmlcheckBox2
            // 
            excelxmlcheckBox2.AutoSize = true;
            excelxmlcheckBox2.FlatStyle = FlatStyle.Flat;
            excelxmlcheckBox2.ForeColor = SystemColors.Control;
            excelxmlcheckBox2.Location = new Point(6, 47);
            excelxmlcheckBox2.Name = "excelxmlcheckBox2";
            excelxmlcheckBox2.Size = new Size(145, 19);
            excelxmlcheckBox2.TabIndex = 26;
            excelxmlcheckBox2.Text = "Archivo de Excel (XML)";
            excelxmlcheckBox2.UseVisualStyleBackColor = true;
            // 
            // excelxlsxcheckBox3
            // 
            excelxlsxcheckBox3.AutoSize = true;
            excelxlsxcheckBox3.FlatStyle = FlatStyle.Flat;
            excelxlsxcheckBox3.ForeColor = SystemColors.Control;
            excelxlsxcheckBox3.Location = new Point(6, 72);
            excelxlsxcheckBox3.Name = "excelxlsxcheckBox3";
            excelxlsxcheckBox3.Size = new Size(147, 19);
            excelxlsxcheckBox3.TabIndex = 27;
            excelxlsxcheckBox3.Text = "Archivo de Excel (XLSX)";
            excelxlsxcheckBox3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(BuscarFiltro);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(FiltroAñoTextBox);
            groupBox1.Controls.Add(FiltroMateriaComboBox);
            groupBox1.Controls.Add(FiltroProfesorComboBox);
            groupBox1.Controls.Add(FiltroCodigoComboBox);
            groupBox1.Controls.Add(Grupolabel1);
            groupBox1.Controls.Add(Profesorlabel2);
            groupBox1.Controls.Add(FechaSuperiorDTP);
            groupBox1.Controls.Add(Materialabel3);
            groupBox1.Controls.Add(FechaInferiorDTP);
            groupBox1.Controls.Add(Semestrelabel4);
            groupBox1.Controls.Add(FiltroPeriodoComboBox);
            groupBox1.Controls.Add(Fechasuperiorlabel6);
            groupBox1.Controls.Add(Fechainferiorlabel5);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(877, 121);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // BuscarFiltro
            // 
            BuscarFiltro.BackColor = Color.FromArgb(86, 76, 149);
            BuscarFiltro.Cursor = Cursors.Hand;
            BuscarFiltro.FlatAppearance.BorderSize = 0;
            BuscarFiltro.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            BuscarFiltro.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            BuscarFiltro.FlatStyle = FlatStyle.Flat;
            BuscarFiltro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BuscarFiltro.ForeColor = SystemColors.Control;
            BuscarFiltro.Location = new Point(684, 80);
            BuscarFiltro.Margin = new Padding(0);
            BuscarFiltro.Name = "BuscarFiltro";
            BuscarFiltro.Size = new Size(187, 23);
            BuscarFiltro.TabIndex = 36;
            BuscarFiltro.Text = "Buscar";
            BuscarFiltro.UseVisualStyleBackColor = false;
            BuscarFiltro.Click += BuscarButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(585, 25);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 34;
            label1.Text = "Periodo";
            // 
            // FiltroAñoTextBox
            // 
            FiltroAñoTextBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroAñoTextBox.ForeColor = SystemColors.ControlLightLight;
            FiltroAñoTextBox.Location = new Point(530, 22);
            FiltroAñoTextBox.Name = "FiltroAñoTextBox";
            FiltroAñoTextBox.Size = new Size(49, 23);
            FiltroAñoTextBox.TabIndex = 33;
            // 
            // FiltroMateriaComboBox
            // 
            FiltroMateriaComboBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroMateriaComboBox.FlatStyle = FlatStyle.Flat;
            FiltroMateriaComboBox.ForeColor = SystemColors.ControlLightLight;
            FiltroMateriaComboBox.FormattingEnabled = true;
            FiltroMateriaComboBox.Location = new Point(93, 80);
            FiltroMateriaComboBox.Name = "FiltroMateriaComboBox";
            FiltroMateriaComboBox.Size = new Size(588, 23);
            FiltroMateriaComboBox.TabIndex = 33;
            // 
            // FiltroProfesorComboBox
            // 
            FiltroProfesorComboBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroProfesorComboBox.FlatStyle = FlatStyle.Flat;
            FiltroProfesorComboBox.ForeColor = SystemColors.ControlLightLight;
            FiltroProfesorComboBox.FormattingEnabled = true;
            FiltroProfesorComboBox.Location = new Point(93, 51);
            FiltroProfesorComboBox.Name = "FiltroProfesorComboBox";
            FiltroProfesorComboBox.Size = new Size(588, 23);
            FiltroProfesorComboBox.TabIndex = 33;
            FiltroProfesorComboBox.SelectedIndexChanged += FiltroProfesorComboBox_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ReporteExportButton);
            groupBox2.Controls.Add(ReporteExportInButton);
            groupBox2.Controls.Add(FormatodereportecheckBox1);
            groupBox2.Controls.Add(excelxmlcheckBox2);
            groupBox2.Controls.Add(excelxlsxcheckBox3);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(1082, 149);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(212, 162);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Exportar en";
            // 
            // ReporteExportButton
            // 
            ReporteExportButton.BackColor = Color.FromArgb(86, 76, 149);
            ReporteExportButton.Cursor = Cursors.Hand;
            ReporteExportButton.Dock = DockStyle.Bottom;
            ReporteExportButton.FlatAppearance.BorderSize = 0;
            ReporteExportButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            ReporteExportButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            ReporteExportButton.FlatStyle = FlatStyle.Flat;
            ReporteExportButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReporteExportButton.ForeColor = SystemColors.Control;
            ReporteExportButton.Location = new Point(3, 102);
            ReporteExportButton.Margin = new Padding(0);
            ReporteExportButton.Name = "ReporteExportButton";
            ReporteExportButton.Size = new Size(206, 33);
            ReporteExportButton.TabIndex = 36;
            ReporteExportButton.Text = "Exportar";
            ReporteExportButton.UseVisualStyleBackColor = false;
            // 
            // ReporteExportInButton
            // 
            ReporteExportInButton.BackColor = Color.FromArgb(62, 124, 185);
            ReporteExportInButton.Cursor = Cursors.Hand;
            ReporteExportInButton.Dock = DockStyle.Bottom;
            ReporteExportInButton.FlatAppearance.BorderSize = 0;
            ReporteExportInButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(62, 124, 185);
            ReporteExportInButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(85, 170, 255);
            ReporteExportInButton.FlatStyle = FlatStyle.Flat;
            ReporteExportInButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ReporteExportInButton.ForeColor = SystemColors.Control;
            ReporteExportInButton.Location = new Point(3, 135);
            ReporteExportInButton.Margin = new Padding(0);
            ReporteExportInButton.Name = "ReporteExportInButton";
            ReporteExportInButton.Size = new Size(206, 24);
            ReporteExportInButton.TabIndex = 35;
            ReporteExportInButton.Text = "Exportar en";
            ReporteExportInButton.UseVisualStyleBackColor = false;
            // 
            // RegistroDGV
            // 
            RegistroDGV.AllowUserToAddRows = false;
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
            RegistroDGV.Columns.AddRange(new DataGridViewColumn[] { Select, id, Semestre, Grupo, Profesor, Materia, Horario, Eliminar });
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
            RegistroDGV.Location = new Point(12, 149);
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
            RegistroDGV.Size = new Size(1058, 439);
            RegistroDGV.TabIndex = 34;
            RegistroDGV.CellContentClick += RegistroDGV_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Report_Icon;
            pictureBox1.Location = new Point(895, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(155, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 37;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(DBExport);
            groupBox3.Controls.Add(DBExportButton);
            groupBox3.ForeColor = SystemColors.ControlLightLight;
            groupBox3.Location = new Point(1082, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(212, 121);
            groupBox3.TabIndex = 38;
            groupBox3.TabStop = false;
            groupBox3.Text = "Base de datos";
            // 
            // DBExport
            // 
            DBExport.BackColor = Color.FromArgb(193, 71, 71);
            DBExport.Cursor = Cursors.Hand;
            DBExport.FlatAppearance.BorderSize = 0;
            DBExport.FlatAppearance.MouseDownBackColor = Color.FromArgb(193, 71, 71);
            DBExport.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 88, 88);
            DBExport.FlatStyle = FlatStyle.Flat;
            DBExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DBExport.ForeColor = SystemColors.Control;
            DBExport.Location = new Point(6, 80);
            DBExport.Name = "DBExport";
            DBExport.Size = new Size(200, 25);
            DBExport.TabIndex = 38;
            DBExport.Text = "Eliminar Base de Datos";
            DBExport.UseVisualStyleBackColor = false;
            // 
            // DBExportButton
            // 
            DBExportButton.BackColor = Color.FromArgb(86, 76, 149);
            DBExportButton.Cursor = Cursors.Hand;
            DBExportButton.FlatAppearance.BorderSize = 0;
            DBExportButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            DBExportButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            DBExportButton.FlatStyle = FlatStyle.Flat;
            DBExportButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DBExportButton.ForeColor = SystemColors.Control;
            DBExportButton.Location = new Point(6, 34);
            DBExportButton.Name = "DBExportButton";
            DBExportButton.Size = new Size(200, 40);
            DBExportButton.TabIndex = 37;
            DBExportButton.Text = "Exportar Base de Datos";
            DBExportButton.UseVisualStyleBackColor = false;
            // 
            // groupBox4
            // 
            groupBox4.Anchor = AnchorStyles.Top;
            groupBox4.Controls.Add(FechaLabel);
            groupBox4.Controls.Add(HoraLabel);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(1056, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(232, 90);
            groupBox4.TabIndex = 92;
            groupBox4.TabStop = false;
            groupBox4.Text = "Reloj";
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
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Select.HeaderText = "S";
            Select.Name = "Select";
            Select.ReadOnly = true;
            Select.Width = 18;
            // 
            // id
            // 
            id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 41;
            // 
            // Semestre
            // 
            Semestre.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Semestre.HeaderText = "Semestre";
            Semestre.Name = "Semestre";
            Semestre.ReadOnly = true;
            Semestre.Width = 79;
            // 
            // Grupo
            // 
            Grupo.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
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
            // PantallaReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(1300, 600);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(pictureBox1);
            Controls.Add(RegistroDGV);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaReportes";
            Text = "Pantalla_reportes";
            Load += PantallaReportes_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox FiltroCodigoComboBox;
        private Label Materialabel3;
        private Label Profesorlabel2;
        private Label Grupolabel1;
        private Label Semestrelabel4;
        private Label Fechainferiorlabel5;
        private Label Fechasuperiorlabel6;
        private ComboBox FiltroPeriodoComboBox;
        private DateTimePicker FechaInferiorDTP;
        private DateTimePicker FechaSuperiorDTP;
        private CheckBox FormatodereportecheckBox1;
        private CheckBox excelxmlcheckBox2;
        private CheckBox excelxlsxcheckBox3;
        private GroupBox groupBox1;
        private ComboBox FiltroProfesorComboBox;
        private ComboBox FiltroMateriaComboBox;
        private Label label1;
        private TextBox FiltroAñoTextBox;
        private GroupBox groupBox2;
        private DataGridView RegistroDGV;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn Semestre;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn Profesor;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewButtonColumn Horario;
        private DataGridViewButtonColumn Eliminar;
        private Button BuscarFiltro;
        private Button ReporteExportInButton;
        private Button ReporteExportButton;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private Button DBExportButton;
        private Button DBExport;
        private GroupBox groupBox4;
        private Label FechaLabel;
        private Label HoraLabel;
        private DataGridViewTextBoxColumn id;
    }
}