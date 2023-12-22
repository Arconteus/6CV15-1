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
            MateriacomboBox2 = new ComboBox();
            GrupocomboBox1 = new ComboBox();
            ProfesortextBox1 = new TextBox();
            Materialabel3 = new Label();
            Profesorlabel2 = new Label();
            Grupolabel1 = new Label();
            Semestrelabel4 = new Label();
            Fechainferiorlabel5 = new Label();
            Fechasuperiorlabel6 = new Label();
            SemestrecomboBox3 = new ComboBox();
            busquedatextBox6 = new TextBox();
            dataGridView1 = new DataGridView();
            Column2 = new DataGridViewCheckBoxColumn();
            Folio = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            backupbutton1 = new Button();
            FechainferiordateTimePicker1 = new DateTimePicker();
            FechasuperiordateTimePicker2 = new DateTimePicker();
            FormatodereportecheckBox1 = new CheckBox();
            excelxmlcheckBox2 = new CheckBox();
            excelxlsxcheckBox3 = new CheckBox();
            exportarbutton2 = new Button();
            exportarenbutton3 = new Button();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // MateriacomboBox2
            // 
            MateriacomboBox2.FormattingEnabled = true;
            MateriacomboBox2.Location = new Point(105, 148);
            MateriacomboBox2.Name = "MateriacomboBox2";
            MateriacomboBox2.Size = new Size(407, 23);
            MateriacomboBox2.TabIndex = 11;
            // 
            // GrupocomboBox1
            // 
            GrupocomboBox1.FormattingEnabled = true;
            GrupocomboBox1.Location = new Point(105, 65);
            GrupocomboBox1.Name = "GrupocomboBox1";
            GrupocomboBox1.Size = new Size(121, 23);
            GrupocomboBox1.TabIndex = 10;
            // 
            // ProfesortextBox1
            // 
            ProfesortextBox1.Location = new Point(105, 108);
            ProfesortextBox1.Name = "ProfesortextBox1";
            ProfesortextBox1.Size = new Size(407, 23);
            ProfesortextBox1.TabIndex = 9;
            // 
            // Materialabel3
            // 
            Materialabel3.AutoSize = true;
            Materialabel3.Location = new Point(20, 151);
            Materialabel3.Name = "Materialabel3";
            Materialabel3.Size = new Size(47, 15);
            Materialabel3.TabIndex = 8;
            Materialabel3.Text = "Materia";
            // 
            // Profesorlabel2
            // 
            Profesorlabel2.AutoSize = true;
            Profesorlabel2.Location = new Point(20, 111);
            Profesorlabel2.Name = "Profesorlabel2";
            Profesorlabel2.Size = new Size(51, 15);
            Profesorlabel2.TabIndex = 7;
            Profesorlabel2.Text = "Profesor";
            // 
            // Grupolabel1
            // 
            Grupolabel1.AutoSize = true;
            Grupolabel1.Location = new Point(27, 73);
            Grupolabel1.Name = "Grupolabel1";
            Grupolabel1.Size = new Size(40, 15);
            Grupolabel1.TabIndex = 6;
            Grupolabel1.Text = "Grupo";
            Grupolabel1.Click += label1_Click;
            // 
            // Semestrelabel4
            // 
            Semestrelabel4.AutoSize = true;
            Semestrelabel4.Location = new Point(551, 73);
            Semestrelabel4.Name = "Semestrelabel4";
            Semestrelabel4.Size = new Size(55, 15);
            Semestrelabel4.TabIndex = 12;
            Semestrelabel4.Text = "Semestre";
            // 
            // Fechainferiorlabel5
            // 
            Fechainferiorlabel5.AutoSize = true;
            Fechainferiorlabel5.Location = new Point(551, 114);
            Fechainferiorlabel5.Name = "Fechainferiorlabel5";
            Fechainferiorlabel5.Size = new Size(79, 15);
            Fechainferiorlabel5.TabIndex = 13;
            Fechainferiorlabel5.Text = "Fecha Inferior";
            // 
            // Fechasuperiorlabel6
            // 
            Fechasuperiorlabel6.AutoSize = true;
            Fechasuperiorlabel6.Location = new Point(551, 154);
            Fechasuperiorlabel6.Name = "Fechasuperiorlabel6";
            Fechasuperiorlabel6.Size = new Size(85, 15);
            Fechasuperiorlabel6.TabIndex = 14;
            Fechasuperiorlabel6.Text = "Fecha Superior";
            // 
            // SemestrecomboBox3
            // 
            SemestrecomboBox3.FormattingEnabled = true;
            SemestrecomboBox3.Location = new Point(640, 65);
            SemestrecomboBox3.Name = "SemestrecomboBox3";
            SemestrecomboBox3.Size = new Size(121, 23);
            SemestrecomboBox3.TabIndex = 15;
            // 
            // busquedatextBox6
            // 
            busquedatextBox6.Location = new Point(105, 189);
            busquedatextBox6.Name = "busquedatextBox6";
            busquedatextBox6.Size = new Size(407, 23);
            busquedatextBox6.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Folio, Fecha, Column1, Profesor });
            dataGridView1.Location = new Point(12, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(500, 214);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column2
            // 
            Column2.HeaderText = "X";
            Column2.Name = "Column2";
            // 
            // Folio
            // 
            Folio.HeaderText = "Folio";
            Folio.Name = "Folio";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.Name = "Fecha";
            // 
            // Column1
            // 
            Column1.HeaderText = "Materia";
            Column1.Name = "Column1";
            // 
            // Profesor
            // 
            Profesor.HeaderText = "Profesor";
            Profesor.Name = "Profesor";
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
            // FechainferiordateTimePicker1
            // 
            FechainferiordateTimePicker1.Location = new Point(640, 108);
            FechainferiordateTimePicker1.Name = "FechainferiordateTimePicker1";
            FechainferiordateTimePicker1.Size = new Size(200, 23);
            FechainferiordateTimePicker1.TabIndex = 22;
            // 
            // FechasuperiordateTimePicker2
            // 
            FechasuperiordateTimePicker2.Location = new Point(640, 146);
            FechasuperiordateTimePicker2.Name = "FechasuperiordateTimePicker2";
            FechasuperiordateTimePicker2.Size = new Size(200, 23);
            FechasuperiordateTimePicker2.TabIndex = 23;
            FechasuperiordateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // FormatodereportecheckBox1
            // 
            FormatodereportecheckBox1.AutoSize = true;
            FormatodereportecheckBox1.Location = new Point(605, 254);
            FormatodereportecheckBox1.Name = "FormatodereportecheckBox1";
            FormatodereportecheckBox1.Size = new Size(173, 19);
            FormatodereportecheckBox1.TabIndex = 25;
            FormatodereportecheckBox1.Text = "Formato de Reporte(s)(PDF)";
            FormatodereportecheckBox1.UseVisualStyleBackColor = true;
            // 
            // excelxmlcheckBox2
            // 
            excelxmlcheckBox2.AutoSize = true;
            excelxmlcheckBox2.Location = new Point(605, 279);
            excelxmlcheckBox2.Name = "excelxmlcheckBox2";
            excelxmlcheckBox2.Size = new Size(148, 19);
            excelxmlcheckBox2.TabIndex = 26;
            excelxmlcheckBox2.Text = "Archivo de Excel (XML)";
            excelxmlcheckBox2.UseVisualStyleBackColor = true;
            // 
            // excelxlsxcheckBox3
            // 
            excelxlsxcheckBox3.AutoSize = true;
            excelxlsxcheckBox3.Location = new Point(605, 304);
            excelxlsxcheckBox3.Name = "excelxlsxcheckBox3";
            excelxlsxcheckBox3.Size = new Size(150, 19);
            excelxlsxcheckBox3.TabIndex = 27;
            excelxlsxcheckBox3.Text = "Archivo de Excel (XLSX)";
            excelxlsxcheckBox3.UseVisualStyleBackColor = true;
            // 
            // exportarbutton2
            // 
            exportarbutton2.Location = new Point(605, 350);
            exportarbutton2.Name = "exportarbutton2";
            exportarbutton2.Size = new Size(173, 29);
            exportarbutton2.TabIndex = 28;
            exportarbutton2.Text = "Exportar";
            exportarbutton2.UseVisualStyleBackColor = true;
            // 
            // exportarenbutton3
            // 
            exportarenbutton3.Location = new Point(605, 396);
            exportarenbutton3.Name = "exportarenbutton3";
            exportarenbutton3.Size = new Size(173, 29);
            exportarenbutton3.TabIndex = 29;
            exportarenbutton3.Text = "Exportar en";
            exportarenbutton3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(603, 222);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 30;
            label7.Text = "Exportar en";
            // 
            // PantallaReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 450);
            Controls.Add(label7);
            Controls.Add(exportarenbutton3);
            Controls.Add(exportarbutton2);
            Controls.Add(excelxlsxcheckBox3);
            Controls.Add(excelxmlcheckBox2);
            Controls.Add(FormatodereportecheckBox1);
            Controls.Add(FechasuperiordateTimePicker2);
            Controls.Add(FechainferiordateTimePicker1);
            Controls.Add(backupbutton1);
            Controls.Add(busquedatextBox6);
            Controls.Add(dataGridView1);
            Controls.Add(SemestrecomboBox3);
            Controls.Add(Fechasuperiorlabel6);
            Controls.Add(Fechainferiorlabel5);
            Controls.Add(Semestrelabel4);
            Controls.Add(MateriacomboBox2);
            Controls.Add(GrupocomboBox1);
            Controls.Add(ProfesortextBox1);
            Controls.Add(Materialabel3);
            Controls.Add(Profesorlabel2);
            Controls.Add(Grupolabel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaReportes";
            Text = "Pantalla_reportes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox MateriacomboBox2;
        private ComboBox GrupocomboBox1;
        private TextBox ProfesortextBox1;
        private Label Materialabel3;
        private Label Profesorlabel2;
        private Label Grupolabel1;
        private Label Semestrelabel4;
        private Label Fechainferiorlabel5;
        private Label Fechasuperiorlabel6;
        private ComboBox SemestrecomboBox3;
        private TextBox busquedatextBox6;
        private DataGridView dataGridView1;
        private Button backupbutton1;
        private DataGridViewCheckBoxColumn Column2;
        private DataGridViewTextBoxColumn Folio;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Profesor;
        private DateTimePicker FechainferiordateTimePicker1;
        private DateTimePicker FechasuperiordateTimePicker2;
        private CheckBox FormatodereportecheckBox1;
        private CheckBox excelxmlcheckBox2;
        private CheckBox excelxlsxcheckBox3;
        private Button exportarbutton2;
        private Button exportarenbutton3;
        private Label label7;
    }
}