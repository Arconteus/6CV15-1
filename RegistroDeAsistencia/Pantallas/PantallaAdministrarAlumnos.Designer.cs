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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            CloseButton = new PictureBox();
            label1 = new Label();
            RegistroDGV = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            Boleta = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apa = new DataGridViewTextBoxColumn();
            Ama = new DataGridViewTextBoxColumn();
            Escuela = new DataGridViewTextBoxColumn();
            Carrera = new DataGridViewTextBoxColumn();
            Observacion = new DataGridViewButtonColumn();
            SearchPanel = new Panel();
            SearchComboBox = new TextBox();
            SearchIcon = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).BeginInit();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).BeginInit();
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
            RegistroDGV.Location = new Point(12, 77);
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
            RegistroDGV.Size = new Size(776, 361);
            RegistroDGV.TabIndex = 33;
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
            // SearchPanel
            // 
            SearchPanel.Anchor = AnchorStyles.Top;
            SearchPanel.BackColor = Color.FromArgb(63, 62, 70);
            SearchPanel.Controls.Add(SearchComboBox);
            SearchPanel.Controls.Add(SearchIcon);
            SearchPanel.Location = new Point(12, 58);
            SearchPanel.Margin = new Padding(0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(776, 15);
            SearchPanel.TabIndex = 37;
            // 
            // SearchComboBox
            // 
            SearchComboBox.BackColor = Color.FromArgb(63, 62, 70);
            SearchComboBox.BorderStyle = BorderStyle.None;
            SearchComboBox.ForeColor = SystemColors.Window;
            SearchComboBox.Location = new Point(29, 0);
            SearchComboBox.Margin = new Padding(0);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(747, 16);
            SearchComboBox.TabIndex = 24;
            SearchComboBox.Tag = "sdvsdvsd";
            // 
            // SearchIcon
            // 
            SearchIcon.BackColor = Color.FromArgb(63, 62, 70);
            SearchIcon.Image = Properties.Resources.Search_Icon;
            SearchIcon.Location = new Point(0, 0);
            SearchIcon.Margin = new Padding(0);
            SearchIcon.Name = "SearchIcon";
            SearchIcon.Size = new Size(16, 16);
            SearchIcon.SizeMode = PictureBoxSizeMode.Zoom;
            SearchIcon.TabIndex = 35;
            SearchIcon.TabStop = false;
            // 
            // PantallaAdministrarAlumnos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(800, 450);
            Controls.Add(SearchPanel);
            Controls.Add(RegistroDGV);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaAdministrarAlumnos";
            Text = "PantallaAdministrarAlumnos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).EndInit();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox CloseButton;
        private DataGridView RegistroDGV;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn Boleta;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apa;
        private DataGridViewTextBoxColumn Ama;
        private DataGridViewTextBoxColumn Escuela;
        private DataGridViewTextBoxColumn Carrera;
        private DataGridViewButtonColumn Observacion;
        private Panel SearchPanel;
        private TextBox SearchComboBox;
        private PictureBox SearchIcon;
    }
}