namespace RegistroDeAsistencia
{
    partial class Registro
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
            FinalizarButton = new Button();
            ObservacionesTextBox = new TextBox();
            vScrollBar1 = new VScrollBar();
            MateriaTextBox = new TextBox();
            ProfesorTextBox = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            GrupoComboBox = new ComboBox();
            ObservacionesLabel = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SemestreComboBox = new ComboBox();
            label7 = new Label();
            FechaComboBox = new ComboBox();
            DataGridView = new DataGridView();
            Validación = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Boleta = new DataGridViewTextBoxColumn();
            GroupBox = new GroupBox();
            FolioLabel = new Label();
            QRButton = new Button();
            AyudaButton = new Button();
            label9 = new Label();
            Search = new TextBox();
            ((System.ComponentModel.ISupportInitialize)DataGridView).BeginInit();
            GroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // FinalizarButton
            // 
            FinalizarButton.Location = new Point(691, 406);
            FinalizarButton.Name = "FinalizarButton";
            FinalizarButton.Size = new Size(97, 35);
            FinalizarButton.TabIndex = 0;
            FinalizarButton.Text = "Finalizar";
            FinalizarButton.UseVisualStyleBackColor = true;
            FinalizarButton.Click += button1_Click;
            // 
            // ObservacionesTextBox
            // 
            ObservacionesTextBox.Location = new Point(118, 413);
            ObservacionesTextBox.Name = "ObservacionesTextBox";
            ObservacionesTextBox.Size = new Size(567, 23);
            ObservacionesTextBox.TabIndex = 2;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(0, 0);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(17, 20);
            vScrollBar1.TabIndex = 3;
            // 
            // MateriaTextBox
            // 
            MateriaTextBox.Location = new Point(175, 128);
            MateriaTextBox.Name = "MateriaTextBox";
            MateriaTextBox.Size = new Size(368, 23);
            MateriaTextBox.TabIndex = 5;
            // 
            // ProfesorTextBox
            // 
            ProfesorTextBox.Location = new Point(175, 99);
            ProfesorTextBox.Name = "ProfesorTextBox";
            ProfesorTextBox.Size = new Size(368, 23);
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
            label1.Location = new Point(25, 426);
            label1.Name = "label1";
            label1.Size = new Size(10, 15);
            label1.TabIndex = 8;
            label1.Text = " ";
            // 
            // GrupoComboBox
            // 
            GrupoComboBox.FormattingEnabled = true;
            GrupoComboBox.Items.AddRange(new object[] { "6CM11", "6CM12", "6CM13", "6CM14", "6CM15", "6CM16", "6CV11", "6CV12", "6CV13", "6CV14", "6CV15", "6CV16" });
            GrupoComboBox.Location = new Point(175, 70);
            GrupoComboBox.Name = "GrupoComboBox";
            GrupoComboBox.RightToLeft = RightToLeft.No;
            GrupoComboBox.Size = new Size(68, 23);
            GrupoComboBox.TabIndex = 9;
            GrupoComboBox.Text = "6CM11";
            GrupoComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            // 
            // ObservacionesLabel
            // 
            ObservacionesLabel.AutoSize = true;
            ObservacionesLabel.Location = new Point(25, 416);
            ObservacionesLabel.Name = "ObservacionesLabel";
            ObservacionesLabel.Size = new Size(87, 15);
            ObservacionesLabel.TabIndex = 10;
            ObservacionesLabel.Text = "Observaciones:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 131);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 11;
            label3.Text = "Materia:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(120, 103);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 12;
            label4.Text = "Profesor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(120, 73);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 13;
            label5.Text = "Grupo:    ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(249, 73);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 15;
            label6.Text = "Semestre:";
            label6.Click += label6_Click;
            // 
            // SemestreComboBox
            // 
            SemestreComboBox.FormattingEnabled = true;
            SemestreComboBox.Items.AddRange(new object[] { "2020-1", "2020-2", "2021-1", "2021-2", "2022-1", "2022-2", "2023-1", "2023-2" });
            SemestreComboBox.Location = new Point(313, 70);
            SemestreComboBox.Name = "SemestreComboBox";
            SemestreComboBox.Size = new Size(58, 23);
            SemestreComboBox.TabIndex = 14;
            SemestreComboBox.Text = "2023-1";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(381, 72);
            label7.Name = "label7";
            label7.Size = new Size(41, 15);
            label7.TabIndex = 17;
            label7.Text = "Fecha:";
            // 
            // FechaComboBox
            // 
            FechaComboBox.AccessibleDescription = "DD/MM/YY";
            FechaComboBox.AccessibleName = "DD/MM/YY";
            FechaComboBox.FormattingEnabled = true;
            FechaComboBox.Items.AddRange(new object[] { "DD/MM/YY", "DD/MM/YY" });
            FechaComboBox.Location = new Point(428, 69);
            FechaComboBox.Name = "FechaComboBox";
            FechaComboBox.Size = new Size(88, 23);
            FechaComboBox.TabIndex = 16;
            FechaComboBox.Text = "DD/MM/YY";
            // 
            // DataGridView
            // 
            DataGridView.AllowUserToOrderColumns = true;
            DataGridView.BackgroundColor = SystemColors.Control;
            DataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
            DataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView.Columns.AddRange(new DataGridViewColumn[] { Validación, Column2, Column3, Column4, Apellido, Boleta });
            DataGridView.GridColor = Color.BlueViolet;
            DataGridView.Location = new Point(25, 204);
            DataGridView.Name = "DataGridView";
            DataGridView.RightToLeft = RightToLeft.Yes;
            DataGridView.RowTemplate.Height = 25;
            DataGridView.Size = new Size(763, 196);
            DataGridView.StandardTab = true;
            DataGridView.TabIndex = 20;
            // 
            // Validación
            // 
            Validación.Frozen = true;
            Validación.HeaderText = "Validación";
            Validación.MaxInputLength = 330000;
            Validación.Name = "Validación";
            Validación.Width = 115;
            // 
            // Column2
            // 
            Column2.HeaderText = "Escuela";
            Column2.Name = "Column2";
            Column2.Width = 115;
            // 
            // Column3
            // 
            Column3.HeaderText = "Nombre(s)";
            Column3.Name = "Column3";
            Column3.Width = 115;
            // 
            // Column4
            // 
            Column4.HeaderText = "Apellido M";
            Column4.Name = "Column4";
            Column4.Width = 115;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido P";
            Apellido.Name = "Apellido";
            Apellido.Width = 115;
            // 
            // Boleta
            // 
            Boleta.HeaderText = "Boleta";
            Boleta.Name = "Boleta";
            Boleta.Width = 115;
            // 
            // GroupBox
            // 
            GroupBox.Controls.Add(FolioLabel);
            GroupBox.Location = new Point(549, 66);
            GroupBox.Name = "GroupBox";
            GroupBox.Size = new Size(91, 85);
            GroupBox.TabIndex = 21;
            GroupBox.TabStop = false;
            GroupBox.Text = "        Folio";
            // 
            // FolioLabel
            // 
            FolioLabel.AutoSize = true;
            FolioLabel.Location = new Point(24, 62);
            FolioLabel.Name = "FolioLabel";
            FolioLabel.Size = new Size(43, 15);
            FolioLabel.TabIndex = 22;
            FolioLabel.Text = "000001";
            FolioLabel.Click += label8_Click;
            // 
            // QRButton
            // 
            QRButton.Location = new Point(24, 66);
            QRButton.Name = "QRButton";
            QRButton.Size = new Size(88, 77);
            QRButton.TabIndex = 22;
            QRButton.Text = "Asistencia QR";
            QRButton.UseVisualStyleBackColor = true;
            // 
            // AyudaButton
            // 
            AyudaButton.Location = new Point(646, 69);
            AyudaButton.Name = "AyudaButton";
            AyudaButton.Size = new Size(128, 82);
            AyudaButton.TabIndex = 23;
            AyudaButton.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(691, 128);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 23;
            label9.Text = "Ayuda";
            // 
            // Search
            // 
            Search.Location = new Point(25, 175);
            Search.Name = "Search";
            Search.Size = new Size(763, 23);
            Search.TabIndex = 24;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Search);
            Controls.Add(label9);
            Controls.Add(AyudaButton);
            Controls.Add(QRButton);
            Controls.Add(GroupBox);
            Controls.Add(DataGridView);
            Controls.Add(label7);
            Controls.Add(FechaComboBox);
            Controls.Add(label6);
            Controls.Add(SemestreComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ObservacionesLabel);
            Controls.Add(GrupoComboBox);
            Controls.Add(label1);
            Controls.Add(ProfesorTextBox);
            Controls.Add(MateriaTextBox);
            Controls.Add(vScrollBar1);
            Controls.Add(ObservacionesTextBox);
            Controls.Add(FinalizarButton);
            Name = "Registro";
            Text = "Registro de Asistencia";
            ((System.ComponentModel.ISupportInitialize)DataGridView).EndInit();
            GroupBox.ResumeLayout(false);
            GroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button FinalizarButton;
        private TextBox ObservacionesTextBox;
        private VScrollBar vScrollBar1;
        private TextBox MateriaTextBox;
        private TextBox ProfesorTextBox;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private ComboBox GrupoComboBox;
        private Label ObservacionesLabel;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox SemestreComboBox;
        private Label label7;
        private ComboBox FechaComboBox;
        private DataGridView DataGridView;
        private GroupBox GroupBox;
        private Label FolioLabel;
        private Button QRButton;
        private Button AyudaButton;
        private Label label9;
        private DataGridViewTextBoxColumn Validación;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Boleta;
        private TextBox Search;
    }
}