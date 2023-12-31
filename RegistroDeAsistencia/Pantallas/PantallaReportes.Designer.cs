﻿namespace RegistroDeAsistencia
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            FiltroGrupocomboBox = new ComboBox();
            Materialabel3 = new Label();
            Profesorlabel2 = new Label();
            Grupolabel1 = new Label();
            Semestrelabel4 = new Label();
            Fechainferiorlabel5 = new Label();
            Fechasuperiorlabel6 = new Label();
            FiltroPeriodoComboBox = new ComboBox();
            backupbutton1 = new Button();
            FechaInferiorDTP = new DateTimePicker();
            FechaSuperiorDTP = new DateTimePicker();
            FormatodereportecheckBox1 = new CheckBox();
            excelxmlcheckBox2 = new CheckBox();
            excelxlsxcheckBox3 = new CheckBox();
            groupBox1 = new GroupBox();
            BuscarButton = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            FiltroMateriaComboBox = new ComboBox();
            FiltroProfesorComboBox = new ComboBox();
            groupBox2 = new GroupBox();
            ReporteExportButton = new Button();
            ReporteExportInButton = new Button();
            RegistroDGV = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            Semestre = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            Materia = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewButtonColumn();
            Eliminar = new DataGridViewButtonColumn();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            DBExport = new Button();
            DBExportButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // FiltroGrupocomboBox
            // 
            FiltroGrupocomboBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroGrupocomboBox.FlatStyle = FlatStyle.Flat;
            FiltroGrupocomboBox.ForeColor = SystemColors.ControlLightLight;
            FiltroGrupocomboBox.FormattingEnabled = true;
            FiltroGrupocomboBox.Location = new Point(93, 22);
            FiltroGrupocomboBox.Name = "FiltroGrupocomboBox";
            FiltroGrupocomboBox.Size = new Size(121, 23);
            FiltroGrupocomboBox.TabIndex = 10;
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
            Semestrelabel4.Location = new Point(220, 25);
            Semestrelabel4.Name = "Semestrelabel4";
            Semestrelabel4.Size = new Size(29, 15);
            Semestrelabel4.TabIndex = 12;
            Semestrelabel4.Text = "Año";
            // 
            // Fechainferiorlabel5
            // 
            Fechainferiorlabel5.AutoSize = true;
            Fechainferiorlabel5.ForeColor = SystemColors.Control;
            Fechainferiorlabel5.Location = new Point(412, 54);
            Fechainferiorlabel5.Name = "Fechainferiorlabel5";
            Fechainferiorlabel5.Size = new Size(79, 15);
            Fechainferiorlabel5.TabIndex = 13;
            Fechainferiorlabel5.Text = "Fecha Inferior";
            // 
            // Fechasuperiorlabel6
            // 
            Fechasuperiorlabel6.AutoSize = true;
            Fechasuperiorlabel6.ForeColor = SystemColors.Control;
            Fechasuperiorlabel6.Location = new Point(412, 25);
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
            FiltroPeriodoComboBox.Location = new Point(364, 22);
            FiltroPeriodoComboBox.Name = "FiltroPeriodoComboBox";
            FiltroPeriodoComboBox.Size = new Size(42, 23);
            FiltroPeriodoComboBox.TabIndex = 15;
            // 
            // backupbutton1
            // 
            backupbutton1.Location = new Point(105, 473);
            backupbutton1.Name = "backupbutton1";
            backupbutton1.Size = new Size(238, 23);
            backupbutton1.TabIndex = 21;
            backupbutton1.Text = "HACER BACKUP EN LA BASE DE DATOS";
            backupbutton1.UseVisualStyleBackColor = true;
            // 
            // FechaInferiorDTP
            // 
            FechaInferiorDTP.CalendarForeColor = Color.FromArgb(30, 33, 36);
            FechaInferiorDTP.CalendarMonthBackground = Color.FromArgb(30, 33, 36);
            FechaInferiorDTP.CalendarTitleBackColor = Color.FromArgb(30, 33, 36);
            FechaInferiorDTP.CalendarTitleForeColor = Color.FromArgb(30, 33, 36);
            FechaInferiorDTP.CalendarTrailingForeColor = Color.FromArgb(30, 33, 36);
            FechaInferiorDTP.Format = DateTimePickerFormat.Short;
            FechaInferiorDTP.Location = new Point(503, 22);
            FechaInferiorDTP.Name = "FechaInferiorDTP";
            FechaInferiorDTP.Size = new Size(96, 23);
            FechaInferiorDTP.TabIndex = 22;
            // 
            // FechaSuperiorDTP
            // 
            FechaSuperiorDTP.Format = DateTimePickerFormat.Short;
            FechaSuperiorDTP.Location = new Point(503, 51);
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
            groupBox1.Controls.Add(BuscarButton);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(FiltroMateriaComboBox);
            groupBox1.Controls.Add(FiltroProfesorComboBox);
            groupBox1.Controls.Add(FiltroGrupocomboBox);
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
            groupBox1.Size = new Size(610, 121);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros";
            // 
            // BuscarButton
            // 
            BuscarButton.BackColor = Color.FromArgb(86, 76, 149);
            BuscarButton.Cursor = Cursors.Hand;
            BuscarButton.FlatAppearance.BorderSize = 0;
            BuscarButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            BuscarButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            BuscarButton.FlatStyle = FlatStyle.Flat;
            BuscarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BuscarButton.ForeColor = SystemColors.Control;
            BuscarButton.Location = new Point(412, 80);
            BuscarButton.Margin = new Padding(0);
            BuscarButton.Name = "BuscarButton";
            BuscarButton.Size = new Size(187, 23);
            BuscarButton.TabIndex = 36;
            BuscarButton.Text = "Buscar";
            BuscarButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(310, 25);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 34;
            label1.Text = "Periodo";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(63, 62, 70);
            textBox1.ForeColor = SystemColors.ControlLightLight;
            textBox1.Location = new Point(255, 22);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(49, 23);
            textBox1.TabIndex = 33;
            // 
            // FiltroMateriaComboBox
            // 
            FiltroMateriaComboBox.BackColor = Color.FromArgb(63, 62, 70);
            FiltroMateriaComboBox.FlatStyle = FlatStyle.Flat;
            FiltroMateriaComboBox.ForeColor = SystemColors.ControlLightLight;
            FiltroMateriaComboBox.FormattingEnabled = true;
            FiltroMateriaComboBox.Location = new Point(93, 80);
            FiltroMateriaComboBox.Name = "FiltroMateriaComboBox";
            FiltroMateriaComboBox.Size = new Size(313, 23);
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
            FiltroProfesorComboBox.Size = new Size(313, 23);
            FiltroProfesorComboBox.TabIndex = 33;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ReporteExportButton);
            groupBox2.Controls.Add(ReporteExportInButton);
            groupBox2.Controls.Add(FormatodereportecheckBox1);
            groupBox2.Controls.Add(excelxmlcheckBox2);
            groupBox2.Controls.Add(excelxlsxcheckBox3);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(628, 149);
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
            ReporteExportInButton.BackColor = Color.FromArgb(17, 16, 19);
            ReporteExportInButton.Cursor = Cursors.Hand;
            ReporteExportInButton.Dock = DockStyle.Bottom;
            ReporteExportInButton.FlatAppearance.BorderSize = 0;
            ReporteExportInButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            ReporteExportInButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
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
            RegistroDGV.AllowUserToDeleteRows = false;
            RegistroDGV.AllowUserToOrderColumns = true;
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
            RegistroDGV.Columns.AddRange(new DataGridViewColumn[] { Select, Semestre, Grupo, Profesor, Materia, Horario, Eliminar });
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
            RegistroDGV.Location = new Point(12, 149);
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
            RegistroDGV.Size = new Size(610, 289);
            RegistroDGV.TabIndex = 34;
            // 
            // Select
            // 
            Select.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Select.HeaderText = "S";
            Select.Name = "Select";
            Select.ReadOnly = true;
            Select.Width = 18;
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
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Report_Icon;
            pictureBox1.Location = new Point(662, 12);
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
            groupBox3.Location = new Point(628, 317);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(212, 121);
            groupBox3.TabIndex = 38;
            groupBox3.TabStop = false;
            groupBox3.Text = "Base de datos";
            // 
            // DBExport
            // 
            DBExport.BackColor = Color.FromArgb(17, 16, 19);
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
            // PantallaReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(852, 450);
            Controls.Add(groupBox3);
            Controls.Add(pictureBox1);
            Controls.Add(RegistroDGV);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(backupbutton1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaReportes";
            Text = "Pantalla_reportes";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ComboBox FiltroGrupocomboBox;
        private Label Materialabel3;
        private Label Profesorlabel2;
        private Label Grupolabel1;
        private Label Semestrelabel4;
        private Label Fechainferiorlabel5;
        private Label Fechasuperiorlabel6;
        private ComboBox FiltroPeriodoComboBox;
        private Button backupbutton1;
        private DateTimePicker FechaInferiorDTP;
        private DateTimePicker FechaSuperiorDTP;
        private CheckBox FormatodereportecheckBox1;
        private CheckBox excelxmlcheckBox2;
        private CheckBox excelxlsxcheckBox3;
        private GroupBox groupBox1;
        private ComboBox FiltroProfesorComboBox;
        private ComboBox FiltroMateriaComboBox;
        private Label label1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private DataGridView RegistroDGV;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn Semestre;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn Profesor;
        private DataGridViewTextBoxColumn Materia;
        private DataGridViewButtonColumn Horario;
        private DataGridViewButtonColumn Eliminar;
        private Button BuscarButton;
        private Button ReporteExportInButton;
        private Button ReporteExportButton;
        private PictureBox pictureBox1;
        private GroupBox groupBox3;
        private Button DBExportButton;
        private Button DBExport;
    }
}