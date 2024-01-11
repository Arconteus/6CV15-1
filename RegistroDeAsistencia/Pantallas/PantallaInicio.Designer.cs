namespace RegistroDeAsistencia.Pantallas
{
    partial class PantallaInicio
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
            ActualGroupBox = new GroupBox();
            MateriaActualLabel = new Label();
            ProfesorActualLabel = new Label();
            GrupoActualLabel = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            FechaLabel = new Label();
            HoraLabel = new Label();
            VisualDGV = new DataGridView();
            Hora = new DataGridViewTextBoxColumn();
            Dia1 = new DataGridViewTextBoxColumn();
            Dia2 = new DataGridViewTextBoxColumn();
            Dia3 = new DataGridViewTextBoxColumn();
            Dia4 = new DataGridViewTextBoxColumn();
            Dia5 = new DataGridViewTextBoxColumn();
            ActualGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)VisualDGV).BeginInit();
            SuspendLayout();
            // 
            // ActualGroupBox
            // 
            ActualGroupBox.Anchor = AnchorStyles.Top;
            ActualGroupBox.Controls.Add(MateriaActualLabel);
            ActualGroupBox.Controls.Add(ProfesorActualLabel);
            ActualGroupBox.Controls.Add(GrupoActualLabel);
            ActualGroupBox.Controls.Add(label3);
            ActualGroupBox.Controls.Add(label2);
            ActualGroupBox.Controls.Add(label1);
            ActualGroupBox.ForeColor = Color.White;
            ActualGroupBox.Location = new Point(12, 12);
            ActualGroupBox.Name = "ActualGroupBox";
            ActualGroupBox.Size = new Size(942, 90);
            ActualGroupBox.TabIndex = 3;
            ActualGroupBox.TabStop = false;
            ActualGroupBox.Text = "Hora Actual";
            // 
            // MateriaActualLabel
            // 
            MateriaActualLabel.AutoSize = true;
            MateriaActualLabel.Location = new Point(96, 62);
            MateriaActualLabel.Name = "MateriaActualLabel";
            MateriaActualLabel.Size = new Size(12, 15);
            MateriaActualLabel.TabIndex = 5;
            MateriaActualLabel.Text = "-";
            // 
            // ProfesorActualLabel
            // 
            ProfesorActualLabel.AutoSize = true;
            ProfesorActualLabel.Location = new Point(96, 40);
            ProfesorActualLabel.Name = "ProfesorActualLabel";
            ProfesorActualLabel.Size = new Size(12, 15);
            ProfesorActualLabel.TabIndex = 4;
            ProfesorActualLabel.Text = "-";
            // 
            // GrupoActualLabel
            // 
            GrupoActualLabel.AutoSize = true;
            GrupoActualLabel.Location = new Point(96, 19);
            GrupoActualLabel.Name = "GrupoActualLabel";
            GrupoActualLabel.Size = new Size(12, 15);
            GrupoActualLabel.TabIndex = 3;
            GrupoActualLabel.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 62);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Profesor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Grupo:";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.List_Icon;
            pictureBox1.Location = new Point(960, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(FechaLabel);
            groupBox1.Controls.Add(HoraLabel);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(1056, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 90);
            groupBox1.TabIndex = 90;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reloj";
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
            // VisualDGV
            // 
            VisualDGV.AllowUserToAddRows = false;
            VisualDGV.AllowUserToDeleteRows = false;
            VisualDGV.AllowUserToOrderColumns = true;
            VisualDGV.Anchor = AnchorStyles.Top;
            VisualDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            VisualDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            VisualDGV.BackgroundColor = Color.FromArgb(63, 62, 70);
            VisualDGV.BorderStyle = BorderStyle.None;
            VisualDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            VisualDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            VisualDGV.ColumnHeadersHeight = 30;
            VisualDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            VisualDGV.Columns.AddRange(new DataGridViewColumn[] { Hora, Dia1, Dia2, Dia3, Dia4, Dia5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 62, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(54, 57, 62);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            VisualDGV.DefaultCellStyle = dataGridViewCellStyle2;
            VisualDGV.EnableHeadersVisualStyles = false;
            VisualDGV.GridColor = Color.White;
            VisualDGV.Location = new Point(12, 112);
            VisualDGV.Margin = new Padding(3, 0, 3, 3);
            VisualDGV.Name = "VisualDGV";
            VisualDGV.ReadOnly = true;
            VisualDGV.RightToLeft = RightToLeft.No;
            VisualDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            VisualDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            VisualDGV.RowHeadersVisible = false;
            VisualDGV.RowTemplate.Height = 25;
            VisualDGV.Size = new Size(1038, 476);
            VisualDGV.TabIndex = 91;
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
            // PantallaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(1300, 600);
            Controls.Add(VisualDGV);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(ActualGroupBox);
            ForeColor = Color.FromArgb(54, 57, 62);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaInicio";
            Text = "PantallaInicio";
            Load += PantallaInicio_Load;
            ActualGroupBox.ResumeLayout(false);
            ActualGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)VisualDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox ActualGroupBox;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label GrupoActualLabel;
        private Label MateriaActualLabel;
        private Label ProfesorActualLabel;
        private GroupBox groupBox1;
        private Label HoraLabel;
        private Label FechaLabel;
        private DataGridView VisualDGV;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Dia1;
        private DataGridViewTextBoxColumn Dia2;
        private DataGridViewTextBoxColumn Dia3;
        private DataGridViewTextBoxColumn Dia4;
        private DataGridViewTextBoxColumn Dia5;
    }
}