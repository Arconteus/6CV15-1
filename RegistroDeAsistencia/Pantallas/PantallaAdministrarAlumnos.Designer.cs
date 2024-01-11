namespace RegistroDeAsistencia.Pantallas
{
    partial class PantallaAdministrarAlumnos
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
            label1 = new Label();
            CloseButton = new PictureBox();
            AlumnosDGV = new DataGridView();
            Boleta = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apa = new DataGridViewTextBoxColumn();
            Ama = new DataGridViewTextBoxColumn();
            Escuela = new DataGridViewTextBoxColumn();
            Carrera = new DataGridViewTextBoxColumn();
            Observacion = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AlumnosDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(49, 41, 100);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(CloseButton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 25);
            panel1.TabIndex = 0;
            panel1.MouseDown += Header_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(25, 5);
            label1.Name = "label1";
            label1.Size = new Size(153, 15);
            label1.TabIndex = 1;
            label1.Text = "Administracion de alumnos";
            label1.MouseDown += Header_MouseDown;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = Properties.Resources.Close_Icon;
            CloseButton.Location = new Point(766, 0);
            CloseButton.Margin = new Padding(0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 1;
            CloseButton.TabStop = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // AlumnosDGV
            // 
            AlumnosDGV.AllowUserToAddRows = false;
            AlumnosDGV.AllowUserToDeleteRows = false;
            AlumnosDGV.AllowUserToResizeColumns = false;
            AlumnosDGV.AllowUserToResizeRows = false;
            AlumnosDGV.Anchor = AnchorStyles.Top;
            AlumnosDGV.BackgroundColor = Color.FromArgb(63, 62, 70);
            AlumnosDGV.BorderStyle = BorderStyle.None;
            AlumnosDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            AlumnosDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            AlumnosDGV.ColumnHeadersHeight = 30;
            AlumnosDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            AlumnosDGV.Columns.AddRange(new DataGridViewColumn[] { Boleta, Nombre, Apa, Ama, Escuela, Carrera, Observacion });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 62, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            AlumnosDGV.DefaultCellStyle = dataGridViewCellStyle2;
            AlumnosDGV.EnableHeadersVisualStyles = false;
            AlumnosDGV.GridColor = Color.White;
            AlumnosDGV.Location = new Point(12, 41);
            AlumnosDGV.Name = "AlumnosDGV";
            AlumnosDGV.ReadOnly = true;
            AlumnosDGV.RightToLeft = RightToLeft.No;
            AlumnosDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            AlumnosDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            AlumnosDGV.RowHeadersVisible = false;
            AlumnosDGV.RowTemplate.Height = 25;
            AlumnosDGV.Size = new Size(776, 397);
            AlumnosDGV.TabIndex = 33;
            AlumnosDGV.CellContentClick += RegistroDGV_CellContentClick;
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
            // PantallaAdministrarAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(800, 450);
            Controls.Add(AlumnosDGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaAdministrarAlumnos";
            Text = "PantallaAdministrarAlumnos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)AlumnosDGV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox CloseButton;
        private DataGridView AlumnosDGV;
        private DataGridViewTextBoxColumn Boleta;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apa;
        private DataGridViewTextBoxColumn Ama;
        private DataGridViewTextBoxColumn Escuela;
        private DataGridViewTextBoxColumn Carrera;
        private DataGridViewButtonColumn Observacion;
    }
}