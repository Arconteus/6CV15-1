namespace RegistroDeAsistencia
{
    partial class PantallaRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistro));
            FinalizarButton = new Button();
            ObservacionesTextBox = new TextBox();
            MateriaTextBox = new TextBox();
            ProfesorTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            GrupoComboBox = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SemestreComboBox = new ComboBox();
            label7 = new Label();
            FechaComboBox = new ComboBox();
            RegistroDataGridView = new DataGridView();
            GroupBox = new GroupBox();
            FolioLabel = new Label();
            Search = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ObservacionesLabel = new Label();
            pictureBox3 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)RegistroDataGridView).BeginInit();
            GroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // FinalizarButton
            // 
            FinalizarButton.BackColor = Color.FromArgb(30, 33, 36);
            FinalizarButton.FlatAppearance.BorderSize = 0;
            FinalizarButton.FlatStyle = FlatStyle.Flat;
            FinalizarButton.ForeColor = SystemColors.Control;
            FinalizarButton.Location = new Point(721, 393);
            FinalizarButton.Name = "FinalizarButton";
            FinalizarButton.Size = new Size(97, 35);
            FinalizarButton.TabIndex = 0;
            FinalizarButton.Text = "Finalizar";
            FinalizarButton.UseVisualStyleBackColor = false;
            FinalizarButton.Click += button1_Click;
            // 
            // ObservacionesTextBox
            // 
            ObservacionesTextBox.BackColor = Color.FromArgb(30, 33, 36);
            ObservacionesTextBox.BorderStyle = BorderStyle.None;
            ObservacionesTextBox.Location = new Point(115, 412);
            ObservacionesTextBox.Name = "ObservacionesTextBox";
            ObservacionesTextBox.Size = new Size(567, 16);
            ObservacionesTextBox.TabIndex = 2;
            // 
            // MateriaTextBox
            // 
            MateriaTextBox.BackColor = Color.FromArgb(30, 33, 36);
            MateriaTextBox.BorderStyle = BorderStyle.None;
            MateriaTextBox.Location = new Point(172, 86);
            MateriaTextBox.Name = "MateriaTextBox";
            MateriaTextBox.Size = new Size(368, 16);
            MateriaTextBox.TabIndex = 5;
            // 
            // ProfesorTextBox
            // 
            ProfesorTextBox.BackColor = Color.FromArgb(30, 33, 36);
            ProfesorTextBox.BorderStyle = BorderStyle.None;
            ProfesorTextBox.Location = new Point(172, 57);
            ProfesorTextBox.Name = "ProfesorTextBox";
            ProfesorTextBox.Size = new Size(368, 16);
            ProfesorTextBox.TabIndex = 6;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 384);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 8;
            label1.Text = " ";
            // 
            // GrupoComboBox
            // 
            GrupoComboBox.BackColor = Color.FromArgb(30, 33, 36);
            GrupoComboBox.FlatStyle = FlatStyle.Flat;
            GrupoComboBox.ForeColor = SystemColors.Window;
            GrupoComboBox.FormattingEnabled = true;
            GrupoComboBox.Items.AddRange(new object[] { "6CM11", "6CM12", "6CM13", "6CM14", "6CM15", "6CM16", "6CV11", "6CV12", "6CV13", "6CV14", "6CV15", "6CV16" });
            GrupoComboBox.Location = new Point(172, 28);
            GrupoComboBox.Name = "GrupoComboBox";
            GrupoComboBox.RightToLeft = RightToLeft.No;
            GrupoComboBox.Size = new Size(68, 23);
            GrupoComboBox.TabIndex = 9;
            GrupoComboBox.Text = "6CM11";
            GrupoComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(116, 89);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "Materia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(117, 61);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 12;
            label4.Text = "Profesor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(117, 31);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 13;
            label5.Text = "Grupo:    ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(246, 31);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 15;
            label6.Text = "Semestre:";
            label6.Click += label6_Click;
            // 
            // SemestreComboBox
            // 
            SemestreComboBox.BackColor = Color.FromArgb(30, 33, 36);
            SemestreComboBox.FlatStyle = FlatStyle.Flat;
            SemestreComboBox.ForeColor = SystemColors.Window;
            SemestreComboBox.FormattingEnabled = true;
            SemestreComboBox.Items.AddRange(new object[] { "2020-1", "2020-2", "2021-1", "2021-2", "2022-1", "2022-2", "2023-1", "2023-2" });
            SemestreComboBox.Location = new Point(310, 28);
            SemestreComboBox.Name = "SemestreComboBox";
            SemestreComboBox.Size = new Size(58, 23);
            SemestreComboBox.TabIndex = 14;
            SemestreComboBox.Text = "2023-1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(378, 30);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 17;
            label7.Text = "Fecha:";
            // 
            // FechaComboBox
            // 
            FechaComboBox.AccessibleDescription = "DD/MM/YY";
            FechaComboBox.AccessibleName = "DD/MM/YY";
            FechaComboBox.BackColor = Color.FromArgb(30, 33, 36);
            FechaComboBox.FlatStyle = FlatStyle.Flat;
            FechaComboBox.ForeColor = SystemColors.Window;
            FechaComboBox.FormattingEnabled = true;
            FechaComboBox.Items.AddRange(new object[] { "DD/MM/YY", "DD/MM/YY" });
            FechaComboBox.Location = new Point(425, 27);
            FechaComboBox.Name = "FechaComboBox";
            FechaComboBox.Size = new Size(88, 23);
            FechaComboBox.TabIndex = 16;
            FechaComboBox.Text = "DD/MM/YY";
            // 
            // RegistroDataGridView
            // 
            RegistroDataGridView.AllowUserToOrderColumns = true;
            RegistroDataGridView.BackgroundColor = Color.FromArgb(54, 57, 62);
            RegistroDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            RegistroDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            RegistroDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RegistroDataGridView.GridColor = Color.BlueViolet;
            RegistroDataGridView.Location = new Point(22, 152);
            RegistroDataGridView.Name = "RegistroDataGridView";
            RegistroDataGridView.RightToLeft = RightToLeft.Yes;
            RegistroDataGridView.RowTemplate.Height = 25;
            RegistroDataGridView.Size = new Size(796, 229);
            RegistroDataGridView.StandardTab = true;
            RegistroDataGridView.TabIndex = 20;
            RegistroDataGridView.CellContentClick += DataGridView_CellContentClick;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(FolioLabel);
            GroupBox.ForeColor = SystemColors.Control;
            GroupBox.Location = new Point(556, 12);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(205, 92);
            GroupBox.TabIndex = 21;
            GroupBox.TabStop = false;
            GroupBox.Text = "        Folio";
            // 
            // FolioLabel
            // 
            FolioLabel.AutoSize = true;
            FolioLabel.Location = new Point(83, 63);
            FolioLabel.Name = "FolioLabel";
            FolioLabel.Size = new Size(43, 15);
            FolioLabel.TabIndex = 22;
            FolioLabel.Text = "000001";
            FolioLabel.Click += label8_Click;
            // 
            // Search
            // 
            Search.BackColor = Color.FromArgb(30, 33, 36);
            Search.BorderStyle = BorderStyle.None;
            Search.ForeColor = SystemColors.Window;
            Search.Location = new Point(22, 120);
            Search.Name = "Search";
            Search.Size = new Size(739, 16);
            Search.TabIndex = 24;
            Search.Tag = "sdvsdvsd";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(781, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 49);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 387);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(97, 57);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click_1;
            // 
            // ObservacionesLabel
            // 
            ObservacionesLabel.AutoSize = true;
            ObservacionesLabel.ForeColor = SystemColors.Control;
            ObservacionesLabel.Location = new Point(12, 426);
            ObservacionesLabel.Name = "ObservacionesLabel";
            ObservacionesLabel.Size = new Size(87, 15);
            ObservacionesLabel.TabIndex = 27;
            ObservacionesLabel.Text = "Observaciones:";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(14, 23);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(97, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(22, 102);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 29;
            label2.Text = "Asistencia QR";
            // 
            // PantallaRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(852, 450);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(ObservacionesLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(Search);
            Controls.Add(GroupBox);
            Controls.Add(RegistroDataGridView);
            Controls.Add(label7);
            Controls.Add(FechaComboBox);
            Controls.Add(label6);
            Controls.Add(SemestreComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(GrupoComboBox);
            Controls.Add(label1);
            Controls.Add(ProfesorTextBox);
            Controls.Add(MateriaTextBox);
            Controls.Add(ObservacionesTextBox);
            Controls.Add(FinalizarButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaRegistro";
            Text = "Registro de Asistencia";
            ((System.ComponentModel.ISupportInitialize)RegistroDataGridView).EndInit();
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FinalizarButton;
        private TextBox ObservacionesTextBox;
        private TextBox MateriaTextBox;
        private TextBox ProfesorTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private ComboBox GrupoComboBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox SemestreComboBox;
        private Label label7;
        private ComboBox FechaComboBox;
        private DataGridView RegistroDataGridView;
        private GroupBox GroupBox;
        private Label FolioLabel;
        private TextBox Search;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label ObservacionesLabel;
        private PictureBox pictureBox3;
        private Label label2;
    }
}