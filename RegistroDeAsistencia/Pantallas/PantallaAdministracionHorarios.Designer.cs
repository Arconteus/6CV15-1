namespace RegistroDeAsistencia.Pantallas
{
    partial class PantallaAdministracionHorarios
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
            panel1 = new Panel();
            CloseButton = new PictureBox();
            label1 = new Label();
            HorarioDGV = new DataGridView();
            Hora = new DataGridViewTextBoxColumn();
            Lunes = new DataGridViewTextBoxColumn();
            Martes = new DataGridViewTextBoxColumn();
            Miercoles = new DataGridViewTextBoxColumn();
            Jueves = new DataGridViewTextBoxColumn();
            Viernes = new DataGridViewTextBoxColumn();
            button2 = new Button();
            FinalizarButton = new Button();
            groupBox1 = new GroupBox();
            AnioTB = new TextBox();
            PeriodoCB = new ComboBox();
            button1 = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            GrupoCB = new ComboBox();
            groupBox2 = new GroupBox();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HorarioDGV).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 41, 100);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 0;
            panel1.MouseDown += Header_MouseDown;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = Properties.Resources.Close_Icon;
            CloseButton.Location = new Point(775, 0);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 2;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(25, 6);
            label1.Name = "label1";
            label1.Size = new Size(150, 15);
            label1.TabIndex = 1;
            label1.Text = "Administracion de horarios";
            label1.MouseDown += Header_MouseDown;
            // 
            // HorarioDGV
            // 
            HorarioDGV.AllowUserToAddRows = false;
            HorarioDGV.AllowUserToDeleteRows = false;
            HorarioDGV.AllowUserToResizeColumns = false;
            HorarioDGV.AllowUserToResizeRows = false;
            HorarioDGV.Anchor = AnchorStyles.Top;
            HorarioDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            HorarioDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            HorarioDGV.BackgroundColor = Color.FromArgb(63, 62, 70);
            HorarioDGV.BorderStyle = BorderStyle.None;
            HorarioDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            HorarioDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            HorarioDGV.ColumnHeadersHeight = 30;
            HorarioDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            HorarioDGV.Columns.AddRange(new DataGridViewColumn[] { Hora, Lunes, Martes, Miercoles, Jueves, Viernes });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 62, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            HorarioDGV.DefaultCellStyle = dataGridViewCellStyle2;
            HorarioDGV.EnableHeadersVisualStyles = false;
            HorarioDGV.GridColor = Color.White;
            HorarioDGV.Location = new Point(12, 93);
            HorarioDGV.Margin = new Padding(3, 0, 3, 3);
            HorarioDGV.MultiSelect = false;
            HorarioDGV.Name = "HorarioDGV";
            HorarioDGV.ReadOnly = true;
            HorarioDGV.RightToLeft = RightToLeft.No;
            HorarioDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            HorarioDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            HorarioDGV.RowHeadersVisible = false;
            HorarioDGV.RowTemplate.Height = 25;
            HorarioDGV.Size = new Size(776, 247);
            HorarioDGV.TabIndex = 92;
            // 
            // Hora
            // 
            Hora.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Hora.HeaderText = "Horas";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            Hora.Resizable = DataGridViewTriState.True;
            Hora.Width = 62;
            // 
            // Lunes
            // 
            Lunes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Lunes.HeaderText = "Lunes";
            Lunes.Name = "Lunes";
            Lunes.ReadOnly = true;
            Lunes.Resizable = DataGridViewTriState.True;
            // 
            // Martes
            // 
            Martes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Martes.HeaderText = "Martes";
            Martes.Name = "Martes";
            Martes.ReadOnly = true;
            Martes.Resizable = DataGridViewTriState.True;
            // 
            // Miercoles
            // 
            Miercoles.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Miercoles.HeaderText = "Miercoles";
            Miercoles.Name = "Miercoles";
            Miercoles.ReadOnly = true;
            Miercoles.Resizable = DataGridViewTriState.True;
            // 
            // Jueves
            // 
            Jueves.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Jueves.HeaderText = "Jueves";
            Jueves.Name = "Jueves";
            Jueves.ReadOnly = true;
            Jueves.Resizable = DataGridViewTriState.True;
            // 
            // Viernes
            // 
            Viernes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Viernes.HeaderText = "Viernes";
            Viernes.Name = "Viernes";
            Viernes.ReadOnly = true;
            Viernes.Resizable = DataGridViewTriState.True;
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
            button2.Location = new Point(12, 346);
            button2.Name = "button2";
            button2.Size = new Size(384, 34);
            button2.TabIndex = 93;
            button2.Text = "Limpiar Horario";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
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
            FinalizarButton.Location = new Point(399, 346);
            FinalizarButton.Margin = new Padding(0);
            FinalizarButton.Name = "FinalizarButton";
            FinalizarButton.Size = new Size(389, 33);
            FinalizarButton.TabIndex = 94;
            FinalizarButton.Text = "Aplicar";
            FinalizarButton.UseVisualStyleBackColor = false;
            FinalizarButton.Click += FinalizarButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(AnioTB);
            groupBox1.Controls.Add(PeriodoCB);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(12, 31);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(381, 59);
            groupBox1.TabIndex = 95;
            groupBox1.TabStop = false;
            groupBox1.Text = "Selector";
            // 
            // AnioTB
            // 
            AnioTB.BackColor = Color.FromArgb(63, 62, 70);
            AnioTB.ForeColor = SystemColors.ControlLightLight;
            AnioTB.Location = new Point(47, 24);
            AnioTB.Name = "AnioTB";
            AnioTB.Size = new Size(49, 23);
            AnioTB.TabIndex = 97;
            AnioTB.KeyPress += AnioTB_KeyPress;
            // 
            // PeriodoCB
            // 
            PeriodoCB.BackColor = Color.FromArgb(63, 62, 70);
            PeriodoCB.FlatStyle = FlatStyle.Flat;
            PeriodoCB.ForeColor = SystemColors.Window;
            PeriodoCB.FormattingEnabled = true;
            PeriodoCB.Items.AddRange(new object[] { "1", "2" });
            PeriodoCB.Location = new Point(159, 24);
            PeriodoCB.Name = "PeriodoCB";
            PeriodoCB.RightToLeft = RightToLeft.No;
            PeriodoCB.Size = new Size(39, 23);
            PeriodoCB.TabIndex = 4;
            PeriodoCB.Text = "-";
            PeriodoCB.KeyPress += HoraCB_KeyPress;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(86, 76, 149);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(232, 24);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(122, 23);
            button1.TabIndex = 96;
            button1.Text = "Cargar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(102, 27);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Periodo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 26);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 0;
            label2.Text = "Año";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 28);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "Grupo:";
            // 
            // GrupoCB
            // 
            GrupoCB.BackColor = Color.FromArgb(63, 62, 70);
            GrupoCB.FlatStyle = FlatStyle.Flat;
            GrupoCB.ForeColor = SystemColors.Window;
            GrupoCB.FormattingEnabled = true;
            GrupoCB.Location = new Point(55, 23);
            GrupoCB.Name = "GrupoCB";
            GrupoCB.RightToLeft = RightToLeft.No;
            GrupoCB.Size = new Size(140, 23);
            GrupoCB.TabIndex = 5;
            GrupoCB.Text = "-";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(GrupoCB);
            groupBox2.ForeColor = SystemColors.ControlLightLight;
            groupBox2.Location = new Point(399, 31);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 59);
            groupBox2.TabIndex = 96;
            groupBox2.TabStop = false;
            groupBox2.Text = "Grupo";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top;
            button3.BackColor = Color.FromArgb(86, 76, 149);
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(198, 22);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(188, 23);
            button3.TabIndex = 98;
            button3.Text = "Cargar";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // PantallaAdministracionHorarios
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(800, 390);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(FinalizarButton);
            Controls.Add(button2);
            Controls.Add(HorarioDGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaAdministracionHorarios";
            Text = "PantallaAdministracionHorarios";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)HorarioDGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox CloseButton;
        private DataGridView HorarioDGV;
        private Button button2;
        private Button FinalizarButton;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private ComboBox GrupoCB;
        private ComboBox PeriodoCB;
        private Button button1;
        private TextBox AnioTB;
        private GroupBox groupBox2;
        private Button button3;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Lunes;
        private DataGridViewTextBoxColumn Martes;
        private DataGridViewTextBoxColumn Miercoles;
        private DataGridViewTextBoxColumn Jueves;
        private DataGridViewTextBoxColumn Viernes;
    }
}