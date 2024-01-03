namespace RegistroDeAsistencia
{
    partial class PantallaRegistroProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistroProfesor));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Header = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            RestoreButton = new PictureBox();
            CloseButtonQR = new PictureBox();
            TittleLabel = new Label();
            MaximixeButton = new PictureBox();
            MinimizeButton = new PictureBox();
            CloseButton = new PictureBox();
            ActualGroupBox = new GroupBox();
            FinalizarButton = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            RegistroMDGV = new DataGridView();
            ID2 = new DataGridViewTextBoxColumn();
            Numero = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            ApellidoP = new DataGridViewTextBoxColumn();
            ApellidoM = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            SearchPanel = new Panel();
            SearchComboBox = new TextBox();
            SearchIcon = new PictureBox();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ActualGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroMDGV).BeginInit();
            SearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).BeginInit();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(86, 76, 149);
            Header.Controls.Add(pictureBox2);
            Header.Controls.Add(pictureBox1);
            Header.Controls.Add(RestoreButton);
            Header.Controls.Add(CloseButtonQR);
            Header.Controls.Add(TittleLabel);
            Header.Controls.Add(MaximixeButton);
            Header.Controls.Add(MinimizeButton);
            Header.Controls.Add(CloseButton);
            Header.Dock = DockStyle.Top;
            Header.ForeColor = SystemColors.ControlText;
            Header.Location = new Point(0, 0);
            Header.Margin = new Padding(0);
            Header.Name = "Header";
            Header.Size = new Size(600, 25);
            Header.TabIndex = 8;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Close_Icon;
            pictureBox2.Location = new Point(572, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Close_Icon;
            pictureBox1.Location = new Point(822, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // RestoreButton
            // 
            RestoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RestoreButton.BackColor = Color.FromArgb(74, 97, 178);
            RestoreButton.Cursor = Cursors.Hand;
            RestoreButton.Image = (Image)resources.GetObject("RestoreButton.Image");
            RestoreButton.Location = new Point(1696, 0);
            RestoreButton.Name = "RestoreButton";
            RestoreButton.Size = new Size(25, 25);
            RestoreButton.SizeMode = PictureBoxSizeMode.Zoom;
            RestoreButton.TabIndex = 4;
            RestoreButton.TabStop = false;
            RestoreButton.Visible = false;
            // 
            // CloseButtonQR
            // 
            CloseButtonQR.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButtonQR.Cursor = Cursors.Hand;
            CloseButtonQR.Image = Properties.Resources.Close_Icon;
            CloseButtonQR.Location = new Point(1072, 0);
            CloseButtonQR.Name = "CloseButtonQR";
            CloseButtonQR.Size = new Size(25, 25);
            CloseButtonQR.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButtonQR.TabIndex = 7;
            CloseButtonQR.TabStop = false;
            // 
            // TittleLabel
            // 
            TittleLabel.AutoSize = true;
            TittleLabel.ForeColor = SystemColors.ControlLightLight;
            TittleLabel.Location = new Point(25, 5);
            TittleLabel.Name = "TittleLabel";
            TittleLabel.Size = new Size(124, 15);
            TittleLabel.TabIndex = 5;
            TittleLabel.Text = "Registro de Profesores";
            // 
            // MaximixeButton
            // 
            MaximixeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximixeButton.BackColor = Color.FromArgb(74, 97, 178);
            MaximixeButton.Cursor = Cursors.Hand;
            MaximixeButton.Image = (Image)resources.GetObject("MaximixeButton.Image");
            MaximixeButton.Location = new Point(1696, 0);
            MaximixeButton.Name = "MaximixeButton";
            MaximixeButton.Size = new Size(25, 25);
            MaximixeButton.SizeMode = PictureBoxSizeMode.Zoom;
            MaximixeButton.TabIndex = 3;
            MaximixeButton.TabStop = false;
            // 
            // MinimizeButton
            // 
            MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MinimizeButton.BackColor = Color.FromArgb(74, 97, 178);
            MinimizeButton.Cursor = Cursors.Hand;
            MinimizeButton.Image = (Image)resources.GetObject("MinimizeButton.Image");
            MinimizeButton.Location = new Point(1665, 0);
            MinimizeButton.Name = "MinimizeButton";
            MinimizeButton.Size = new Size(25, 25);
            MinimizeButton.SizeMode = PictureBoxSizeMode.Zoom;
            MinimizeButton.TabIndex = 2;
            MinimizeButton.TabStop = false;
            // 
            // CloseButton
            // 
            CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            CloseButton.BackColor = Color.FromArgb(74, 97, 178);
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Image = (Image)resources.GetObject("CloseButton.Image");
            CloseButton.Location = new Point(1727, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 1;
            CloseButton.TabStop = false;
            // 
            // ActualGroupBox
            // 
            ActualGroupBox.Anchor = AnchorStyles.Top;
            ActualGroupBox.Controls.Add(textBox4);
            ActualGroupBox.Controls.Add(FinalizarButton);
            ActualGroupBox.Controls.Add(textBox3);
            ActualGroupBox.Controls.Add(label4);
            ActualGroupBox.Controls.Add(label1);
            ActualGroupBox.Controls.Add(textBox2);
            ActualGroupBox.Controls.Add(label3);
            ActualGroupBox.Controls.Add(textBox1);
            ActualGroupBox.Controls.Add(label2);
            ActualGroupBox.ForeColor = Color.White;
            ActualGroupBox.Location = new Point(12, 31);
            ActualGroupBox.Name = "ActualGroupBox";
            ActualGroupBox.Size = new Size(576, 106);
            ActualGroupBox.TabIndex = 37;
            ActualGroupBox.TabStop = false;
            ActualGroupBox.Text = "Datos del profesor";
            ActualGroupBox.Enter += ActualGroupBox_Enter;
            // 
            // FinalizarButton
            // 
            FinalizarButton.BackColor = Color.FromArgb(86, 76, 149);
            FinalizarButton.Cursor = Cursors.Hand;
            FinalizarButton.FlatAppearance.BorderSize = 0;
            FinalizarButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            FinalizarButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            FinalizarButton.FlatStyle = FlatStyle.Flat;
            FinalizarButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            FinalizarButton.ForeColor = SystemColors.Control;
            FinalizarButton.Location = new Point(431, 69);
            FinalizarButton.Margin = new Padding(0);
            FinalizarButton.Name = "FinalizarButton";
            FinalizarButton.Size = new Size(140, 23);
            FinalizarButton.TabIndex = 44;
            FinalizarButton.Text = "Agregar";
            FinalizarButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 72);
            label4.Name = "label4";
            label4.Size = new Size(125, 15);
            label4.TabIndex = 42;
            label4.Text = "Numero de Trabajador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(286, 22);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 37;
            label1.Text = "Apellido Materno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 22);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 39;
            label2.Text = "Nombres:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(432, 22);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno";
            // 
            // RegistroMDGV
            // 
            RegistroMDGV.AllowUserToDeleteRows = false;
            RegistroMDGV.AllowUserToOrderColumns = true;
            RegistroMDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RegistroMDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RegistroMDGV.BackgroundColor = Color.FromArgb(63, 62, 70);
            RegistroMDGV.BorderStyle = BorderStyle.None;
            RegistroMDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            RegistroMDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            RegistroMDGV.ColumnHeadersHeight = 30;
            RegistroMDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RegistroMDGV.Columns.AddRange(new DataGridViewColumn[] { ID2, Numero, Nombre, ApellidoP, ApellidoM, Eliminar });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(63, 62, 70);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            RegistroMDGV.DefaultCellStyle = dataGridViewCellStyle5;
            RegistroMDGV.EnableHeadersVisualStyles = false;
            RegistroMDGV.GridColor = Color.White;
            RegistroMDGV.Location = new Point(12, 161);
            RegistroMDGV.Margin = new Padding(3, 0, 3, 3);
            RegistroMDGV.Name = "RegistroMDGV";
            RegistroMDGV.ReadOnly = true;
            RegistroMDGV.RightToLeft = RightToLeft.No;
            RegistroMDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            RegistroMDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            RegistroMDGV.RowHeadersVisible = false;
            RegistroMDGV.RowTemplate.Height = 25;
            RegistroMDGV.Size = new Size(576, 277);
            RegistroMDGV.TabIndex = 38;
            // 
            // ID2
            // 
            ID2.HeaderText = "ID de Profesor";
            ID2.Name = "ID2";
            ID2.ReadOnly = true;
            // 
            // Numero
            // 
            Numero.HeaderText = "N. de Trabajador";
            Numero.Name = "Numero";
            Numero.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // ApellidoP
            // 
            ApellidoP.HeaderText = "Apellido (P)";
            ApellidoP.Name = "ApellidoP";
            ApellidoP.ReadOnly = true;
            // 
            // ApellidoM
            // 
            ApellidoM.HeaderText = "Apellido (M)";
            ApellidoM.Name = "ApellidoM";
            ApellidoM.ReadOnly = true;
            // 
            // Eliminar
            // 
            Eliminar.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 55;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(63, 62, 70);
            textBox1.Location = new Point(6, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(274, 23);
            textBox1.TabIndex = 45;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(63, 62, 70);
            textBox2.Location = new Point(286, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(63, 62, 70);
            textBox3.Location = new Point(431, 40);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 23);
            textBox3.TabIndex = 47;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(63, 62, 70);
            textBox4.Location = new Point(137, 69);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(288, 23);
            textBox4.TabIndex = 48;
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.FromArgb(63, 62, 70);
            SearchPanel.Controls.Add(SearchComboBox);
            SearchPanel.Controls.Add(SearchIcon);
            SearchPanel.Location = new Point(12, 146);
            SearchPanel.Margin = new Padding(0, 6, 0, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(576, 15);
            SearchPanel.TabIndex = 39;
            // 
            // SearchComboBox
            // 
            SearchComboBox.BackColor = Color.FromArgb(63, 62, 70);
            SearchComboBox.BorderStyle = BorderStyle.None;
            SearchComboBox.ForeColor = SystemColors.Window;
            SearchComboBox.Location = new Point(29, 0);
            SearchComboBox.Margin = new Padding(0);
            SearchComboBox.Name = "SearchComboBox";
            SearchComboBox.Size = new Size(547, 16);
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
            // PantallaRegistroProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(600, 450);
            Controls.Add(SearchPanel);
            Controls.Add(RegistroMDGV);
            Controls.Add(ActualGroupBox);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaRegistroProfesor";
            Text = "PantallaRegistroProfesor";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ActualGroupBox.ResumeLayout(false);
            ActualGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroMDGV).EndInit();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SearchIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private PictureBox pictureBox1;
        private PictureBox RestoreButton;
        private PictureBox CloseButtonQR;
        private Label TittleLabel;
        private PictureBox MaximixeButton;
        private PictureBox MinimizeButton;
        private PictureBox CloseButton;
        private PictureBox pictureBox2;
        private GroupBox ActualGroupBox;
        private Label label2;
        private Label label1;
        private Button AddProfesorButton;
        private Label label3;
        private DataGridView RegistroMDGV;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ApellidoP;
        private DataGridViewTextBoxColumn ApellidoM;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewButtonColumn Eliminar;
        private Label label4;
        private Button button1;
        private DataGridViewTextBoxColumn ID2;
        private DataGridViewTextBoxColumn Numero;
        private Button FinalizarButton;
        private TextBox textBox1;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Panel SearchPanel;
        private TextBox SearchComboBox;
        private PictureBox SearchIcon;
    }
}