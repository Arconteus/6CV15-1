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
            pictureBox2 = new PictureBox();
            HorarioDGV = new DataGridView();
            Hora = new DataGridViewTextBoxColumn();
            Lunes = new DataGridViewTextBoxColumn();
            Martes = new DataGridViewTextBoxColumn();
            Miercoles = new DataGridViewTextBoxColumn();
            Jueves = new DataGridViewTextBoxColumn();
            Viernes = new DataGridViewTextBoxColumn();
            ActualGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HorarioDGV).BeginInit();
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
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Icono;
            pictureBox2.Location = new Point(1056, 112);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 232);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 92;
            pictureBox2.TabStop = false;
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
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
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
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            HorarioDGV.DefaultCellStyle = dataGridViewCellStyle2;
            HorarioDGV.EnableHeadersVisualStyles = false;
            HorarioDGV.GridColor = Color.White;
            HorarioDGV.Location = new Point(12, 112);
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
            HorarioDGV.Size = new Size(1038, 476);
            HorarioDGV.TabIndex = 93;
            // 
            // Hora
            // 
            Hora.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Hora.Frozen = true;
            Hora.HeaderText = "Horas";
            Hora.Name = "Hora";
            Hora.ReadOnly = true;
            Hora.Resizable = DataGridViewTriState.True;
            Hora.Width = 72;
            // 
            // Lunes
            // 
            Lunes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Lunes.Frozen = true;
            Lunes.HeaderText = "Lunes";
            Lunes.Name = "Lunes";
            Lunes.ReadOnly = true;
            Lunes.Resizable = DataGridViewTriState.True;
            Lunes.Width = 195;
            // 
            // Martes
            // 
            Martes.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Martes.Frozen = true;
            Martes.HeaderText = "Martes";
            Martes.Name = "Martes";
            Martes.ReadOnly = true;
            Martes.Resizable = DataGridViewTriState.True;
            Martes.Width = 195;
            // 
            // Miercoles
            // 
            Miercoles.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Miercoles.Frozen = true;
            Miercoles.HeaderText = "Miercoles";
            Miercoles.Name = "Miercoles";
            Miercoles.ReadOnly = true;
            Miercoles.Resizable = DataGridViewTriState.True;
            Miercoles.Width = 195;
            // 
            // Jueves
            // 
            Jueves.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Jueves.Frozen = true;
            Jueves.HeaderText = "Jueves";
            Jueves.MinimumWidth = 30;
            Jueves.Name = "Jueves";
            Jueves.ReadOnly = true;
            Jueves.Resizable = DataGridViewTriState.True;
            Jueves.Width = 195;
            // 
            // Viernes
            // 
            Viernes.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Viernes.HeaderText = "Viernes";
            Viernes.Name = "Viernes";
            Viernes.ReadOnly = true;
            Viernes.Resizable = DataGridViewTriState.True;
            // 
            // PantallaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(1300, 600);
            Controls.Add(HorarioDGV);
            Controls.Add(pictureBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(ActualGroupBox);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaInicio";
            Text = "PantallaInicio";
            ActualGroupBox.ResumeLayout(false);
            ActualGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)HorarioDGV).EndInit();
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
        private PictureBox pictureBox2;
        private DataGridView HorarioDGV;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewTextBoxColumn Lunes;
        private DataGridViewTextBoxColumn Martes;
        private DataGridViewTextBoxColumn Miercoles;
        private DataGridViewTextBoxColumn Jueves;
        private DataGridViewTextBoxColumn Viernes;
    }
}