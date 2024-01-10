namespace RegistroDeAsistencia
{
    partial class PantallaAsistencia
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            FinalizarButton = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            GrupoComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            GroupBox = new GroupBox();
            FolioLabel = new Label();
            SearchComboBox = new TextBox();
            pictureBox2 = new PictureBox();
            QrBox = new PictureBox();
            DetallesGroupBox = new GroupBox();
            ProfesorComboBox = new ComboBox();
            MateriaComboBox = new ComboBox();
            FechaDTP = new DateTimePicker();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            RegistroDGV = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            Boleta = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apa = new DataGridViewTextBoxColumn();
            Ama = new DataGridViewTextBoxColumn();
            Escuela = new DataGridViewTextBoxColumn();
            Carrera = new DataGridViewTextBoxColumn();
            Observacion = new DataGridViewButtonColumn();
            ClearButton = new Button();
            SearchIcon = new PictureBox();
            SearchPanel = new Panel();
            groupBox1 = new GroupBox();
            FechaLabel = new Label();
            HoraLabel = new Label();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)QrBox).BeginInit();
            DetallesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).BeginInit();
            SearchPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
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
            FinalizarButton.Location = new Point(1194, 555);
            FinalizarButton.Margin = new Padding(0);
            FinalizarButton.Name = "FinalizarButton";
            FinalizarButton.Size = new Size(97, 33);
            FinalizarButton.TabIndex = 0;
            FinalizarButton.Text = "Finalizar";
            FinalizarButton.UseVisualStyleBackColor = false;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(22, 384);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 8;
            label1.Text = " ";
            // 
            // GrupoComboBox
            // 
            GrupoComboBox.BackColor = Color.FromArgb(63, 62, 70);
            GrupoComboBox.FlatStyle = FlatStyle.Flat;
            GrupoComboBox.ForeColor = SystemColors.Window;
            GrupoComboBox.FormattingEnabled = true;
            GrupoComboBox.Location = new Point(66, 22);
            GrupoComboBox.Name = "GrupoComboBox";
            GrupoComboBox.RightToLeft = RightToLeft.No;
            GrupoComboBox.Size = new Size(68, 23);
            GrupoComboBox.TabIndex = 9;
            GrupoComboBox.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(290, 25);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "Materia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(6, 56);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 12;
            label4.Text = "Profesor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(6, 25);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 13;
            label5.Text = "Grupo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(142, 25);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 17;
            label7.Text = "Fecha:";
            // 
            // GroupBox
            // 
            GroupBox.Anchor = AnchorStyles.Top;
            GroupBox.Controls.Add(FolioLabel);
            GroupBox.ForeColor = SystemColors.Control;
            GroupBox.Location = new Point(927, 15);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(123, 45);
            GroupBox.TabIndex = 21;
            GroupBox.TabStop = false;
            GroupBox.Text = "Folio";
            // 
            // FolioLabel
            // 
            FolioLabel.Dock = DockStyle.Fill;
            FolioLabel.Location = new Point(3, 19);
            FolioLabel.Name = "FolioLabel";
            FolioLabel.Size = new Size(117, 23);
            FolioLabel.TabIndex = 22;
            FolioLabel.Text = "000001";
            FolioLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SearchComboBox
            // 
            SearchComboBox.BackColor = Color.FromArgb(63, 62, 70);
            SearchComboBox.BorderStyle = BorderStyle.None;
            SearchComboBox.ForeColor = SystemColors.Window;
            SearchComboBox.Location = new Point(29, 0);
            SearchComboBox.Margin = new Padding(0);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(1247, 16);
            SearchComboBox.TabIndex = 24;
            SearchComboBox.Tag = "sdvsdvsd";
            SearchComboBox.TextChanged += SearchComboBox_TextChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = Properties.Resources.Eye_Icon;
            pictureBox2.Location = new Point(12, 555);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(33, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // QrBox
            // 
            QrBox.Anchor = AnchorStyles.Top;
            QrBox.Cursor = Cursors.Hand;
            QrBox.Image = Properties.Resources.ID_Icon;
            QrBox.Location = new Point(12, 12);
            QrBox.Name = "QrBox";
            QrBox.Size = new Size(90, 71);
            QrBox.SizeMode = PictureBoxSizeMode.Zoom;
            QrBox.TabIndex = 28;
            QrBox.TabStop = false;
            QrBox.Click += QrBox_Click;
            // 
            // DetallesGroupBox
            // 
            DetallesGroupBox.Anchor = AnchorStyles.Top;
            DetallesGroupBox.Controls.Add(ProfesorComboBox);
            DetallesGroupBox.Controls.Add(MateriaComboBox);
            DetallesGroupBox.Controls.Add(FechaDTP);
            DetallesGroupBox.Controls.Add(GrupoComboBox);
            DetallesGroupBox.Controls.Add(label7);
            DetallesGroupBox.Controls.Add(label5);
            DetallesGroupBox.Controls.Add(label4);
            DetallesGroupBox.Controls.Add(label3);
            DetallesGroupBox.ForeColor = SystemColors.ControlLightLight;
            DetallesGroupBox.Location = new Point(108, 12);
            DetallesGroupBox.Name = "DetallesGroupBox";
            DetallesGroupBox.Size = new Size(813, 90);
            DetallesGroupBox.TabIndex = 29;
            DetallesGroupBox.TabStop = false;
            DetallesGroupBox.Text = "Detalles";
            // 
            // ProfesorComboBox
            // 
            ProfesorComboBox.BackColor = Color.FromArgb(63, 62, 70);
            ProfesorComboBox.FlatStyle = FlatStyle.Flat;
            ProfesorComboBox.ForeColor = SystemColors.Window;
            ProfesorComboBox.FormattingEnabled = true;
            ProfesorComboBox.Location = new Point(66, 56);
            ProfesorComboBox.Name = "ProfesorComboBox";
            ProfesorComboBox.Size = new Size(741, 23);
            ProfesorComboBox.TabIndex = 20;
            ProfesorComboBox.Text = "-";
            // 
            // MateriaComboBox
            // 
            MateriaComboBox.BackColor = Color.FromArgb(63, 62, 70);
            MateriaComboBox.FlatStyle = FlatStyle.Flat;
            MateriaComboBox.ForeColor = SystemColors.Window;
            MateriaComboBox.FormattingEnabled = true;
            MateriaComboBox.Location = new Point(346, 22);
            MateriaComboBox.Name = "MateriaComboBox";
            MateriaComboBox.Size = new Size(461, 23);
            MateriaComboBox.TabIndex = 19;
            MateriaComboBox.Text = "-";
            // 
            // FechaDTP
            // 
            FechaDTP.CalendarForeColor = Color.FromArgb(63, 62, 70);
            FechaDTP.CalendarMonthBackground = Color.Gray;
            FechaDTP.Format = DateTimePickerFormat.Short;
            FechaDTP.Location = new Point(189, 22);
            FechaDTP.Name = "FechaDTP";
            FechaDTP.Size = new Size(95, 23);
            FechaDTP.TabIndex = 18;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top;
            richTextBox1.BackColor = Color.FromArgb(63, 62, 70);
            richTextBox1.BorderStyle = BorderStyle.None;
            richTextBox1.ForeColor = SystemColors.ControlLightLight;
            richTextBox1.Location = new Point(48, 555);
            richTextBox1.Margin = new Padding(0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1146, 33);
            richTextBox1.TabIndex = 30;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 31;
            label2.Text = "Registro QR";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // RegistroDGV
            // 
            RegistroDGV.AllowUserToDeleteRows = false;
            RegistroDGV.AllowUserToOrderColumns = true;
            RegistroDGV.Anchor = AnchorStyles.Top;
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
            RegistroDGV.Columns.AddRange(new DataGridViewColumn[] { Select, Boleta, Nombre, Apa, Ama, Escuela, Carrera, Observacion });
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
            RegistroDGV.Location = new Point(12, 131);
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
            RegistroDGV.Size = new Size(1276, 418);
            RegistroDGV.TabIndex = 32;
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
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Top;
            ClearButton.BackColor = Color.FromArgb(17, 16, 19);
            ClearButton.Cursor = Cursors.Hand;
            ClearButton.FlatAppearance.BorderSize = 0;
            ClearButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(193, 71, 71);
            ClearButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(239, 88, 88);
            ClearButton.FlatStyle = FlatStyle.Flat;
            ClearButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClearButton.ForeColor = SystemColors.Control;
            ClearButton.Location = new Point(927, 66);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(123, 35);
            ClearButton.TabIndex = 33;
            ClearButton.Text = "Limpiar";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
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
            // SearchPanel
            // 
            SearchPanel.Anchor = AnchorStyles.Top;
            SearchPanel.BackColor = Color.FromArgb(63, 62, 70);
            SearchPanel.Controls.Add(SearchComboBox);
            SearchPanel.Controls.Add(SearchIcon);
            SearchPanel.Location = new Point(12, 115);
            SearchPanel.Margin = new Padding(0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(1276, 15);
            SearchPanel.TabIndex = 36;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(FechaLabel);
            groupBox1.Controls.Add(HoraLabel);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(1056, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(232, 89);
            groupBox1.TabIndex = 91;
            groupBox1.TabStop = false;
            groupBox1.Text = "Reloj";
            // 
            // FechaLabel
            // 
            FechaLabel.Dock = DockStyle.Fill;
            FechaLabel.Location = new Point(3, 66);
            FechaLabel.Name = "FechaLabel";
            FechaLabel.Size = new Size(226, 20);
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
            // PantallaAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(1300, 600);
            Controls.Add(groupBox1);
            Controls.Add(SearchPanel);
            Controls.Add(ClearButton);
            Controls.Add(RegistroDGV);
            Controls.Add(label2);
            Controls.Add(richTextBox1);
            Controls.Add(DetallesGroupBox);
            Controls.Add(QrBox);
            Controls.Add(pictureBox2);
            Controls.Add(GroupBox);
            Controls.Add(label1);
            Controls.Add(FinalizarButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaAsistencia";
            Text = " ";
            Load += PantallaAsistencia_Load;
            GroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)QrBox).EndInit();
            DetallesGroupBox.ResumeLayout(false);
            DetallesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).EndInit();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FinalizarButton;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private ComboBox GrupoComboBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private GroupBox GroupBox;
        private Label FolioLabel;
        private TextBox SearchComboBox;
        private PictureBox pictureBox2;
        private PictureBox QrBox;
        private GroupBox DetallesGroupBox;
        private DateTimePicker FechaDTP;
        private RichTextBox richTextBox1;
        private ComboBox MateriaComboBox;
        private ComboBox ProfesorComboBox;
        private Label label2;
        private DataGridView RegistroDGV;
        private Button ClearButton;
        private PictureBox SearchIcon;
        private Panel SearchPanel;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn Boleta;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apa;
        private DataGridViewTextBoxColumn Ama;
        private DataGridViewTextBoxColumn Escuela;
        private DataGridViewTextBoxColumn Carrera;
        private DataGridViewButtonColumn Observacion;
        private GroupBox groupBox1;
        private Label FechaLabel;
        private Label HoraLabel;
    }
}