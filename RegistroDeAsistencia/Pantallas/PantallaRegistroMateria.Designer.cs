namespace RegistroDeAsistencia
{
    partial class PantallaRegistroMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaRegistroMateria));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Header = new Panel();
            pictureBox1 = new PictureBox();
            RestoreButton = new PictureBox();
            CloseButtonQR = new PictureBox();
            TittleLabel = new Label();
            MaximixeButton = new PictureBox();
            MinimizeButton = new PictureBox();
            CloseButton = new PictureBox();
            RegistroMDGV = new DataGridView();
            ActualGroupBox = new GroupBox();
            MateriaTextBox = new TextBox();
            AddMateriaButton = new Button();
            label3 = new Label();
            CodigoDGV = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            CodigoGrupo = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            CodigoTB = new TextBox();
            AddCodigoButton = new Button();
            label1 = new Label();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RegistroMDGV).BeginInit();
            ActualGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CodigoDGV).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(86, 76, 149);
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
            Header.Size = new Size(818, 25);
            Header.TabIndex = 7;
            Header.MouseDown += Header_MouseDown;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Close_Icon;
            pictureBox1.Location = new Point(790, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RestoreButton
            // 
            RestoreButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RestoreButton.BackColor = Color.FromArgb(74, 97, 178);
            RestoreButton.Cursor = Cursors.Hand;
            RestoreButton.Image = (Image)resources.GetObject("RestoreButton.Image");
            RestoreButton.Location = new Point(1664, 0);
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
            CloseButtonQR.Location = new Point(1040, 0);
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
            TittleLabel.Size = new Size(109, 15);
            TittleLabel.TabIndex = 5;
            TittleLabel.Text = "Registro de Materia";
            TittleLabel.MouseDown += Header_MouseDown;
            // 
            // MaximixeButton
            // 
            MaximixeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximixeButton.BackColor = Color.FromArgb(74, 97, 178);
            MaximixeButton.Cursor = Cursors.Hand;
            MaximixeButton.Image = (Image)resources.GetObject("MaximixeButton.Image");
            MaximixeButton.Location = new Point(1664, 0);
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
            MinimizeButton.Location = new Point(1633, 0);
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
            CloseButton.Location = new Point(1695, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 1;
            CloseButton.TabStop = false;
            // 
            // RegistroMDGV
            // 
            RegistroMDGV.AllowUserToAddRows = false;
            RegistroMDGV.AllowUserToDeleteRows = false;
            RegistroMDGV.AllowUserToOrderColumns = true;
            RegistroMDGV.BackgroundColor = Color.FromArgb(63, 62, 70);
            RegistroMDGV.BorderStyle = BorderStyle.None;
            RegistroMDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            RegistroMDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            RegistroMDGV.ColumnHeadersHeight = 30;
            RegistroMDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 62, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            RegistroMDGV.DefaultCellStyle = dataGridViewCellStyle2;
            RegistroMDGV.EnableHeadersVisualStyles = false;
            RegistroMDGV.GridColor = Color.White;
            RegistroMDGV.Location = new Point(12, 88);
            RegistroMDGV.Name = "RegistroMDGV";
            RegistroMDGV.ReadOnly = true;
            RegistroMDGV.RightToLeft = RightToLeft.No;
            RegistroMDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            RegistroMDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            RegistroMDGV.RowHeadersVisible = false;
            RegistroMDGV.RowTemplate.Height = 25;
            RegistroMDGV.Size = new Size(426, 350);
            RegistroMDGV.TabIndex = 35;
            RegistroMDGV.CellContentClick += RegistroMDGV_CellContentClick;
            // 
            // ActualGroupBox
            // 
            ActualGroupBox.Anchor = AnchorStyles.Top;
            ActualGroupBox.Controls.Add(MateriaTextBox);
            ActualGroupBox.Controls.Add(AddMateriaButton);
            ActualGroupBox.Controls.Add(label3);
            ActualGroupBox.ForeColor = Color.White;
            ActualGroupBox.Location = new Point(12, 28);
            ActualGroupBox.Name = "ActualGroupBox";
            ActualGroupBox.Size = new Size(426, 54);
            ActualGroupBox.TabIndex = 36;
            ActualGroupBox.TabStop = false;
            ActualGroupBox.Text = "Registro de Materia";
            // 
            // MateriaTextBox
            // 
            MateriaTextBox.BackColor = Color.FromArgb(63, 62, 70);
            MateriaTextBox.ForeColor = SystemColors.ControlLightLight;
            MateriaTextBox.Location = new Point(65, 19);
            MateriaTextBox.Name = "MateriaTextBox";
            MateriaTextBox.Size = new Size(273, 23);
            MateriaTextBox.TabIndex = 49;
            // 
            // AddMateriaButton
            // 
            AddMateriaButton.BackColor = Color.FromArgb(86, 76, 149);
            AddMateriaButton.FlatAppearance.BorderSize = 0;
            AddMateriaButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AddMateriaButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AddMateriaButton.FlatStyle = FlatStyle.Flat;
            AddMateriaButton.ForeColor = SystemColors.Control;
            AddMateriaButton.Location = new Point(333, 19);
            AddMateriaButton.Margin = new Padding(0, 0, 3, 0);
            AddMateriaButton.Name = "AddMateriaButton";
            AddMateriaButton.Size = new Size(87, 23);
            AddMateriaButton.TabIndex = 35;
            AddMateriaButton.Text = "Agregar";
            AddMateriaButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Materia:";
            // 
            // CodigoDGV
            // 
            CodigoDGV.AllowUserToAddRows = false;
            CodigoDGV.AllowUserToDeleteRows = false;
            CodigoDGV.AllowUserToOrderColumns = true;
            CodigoDGV.BackgroundColor = Color.FromArgb(63, 62, 70);
            CodigoDGV.BorderStyle = BorderStyle.None;
            CodigoDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.Window;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            CodigoDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            CodigoDGV.ColumnHeadersHeight = 30;
            CodigoDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            CodigoDGV.Columns.AddRange(new DataGridViewColumn[] { ID, CodigoGrupo });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(63, 62, 70);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            CodigoDGV.DefaultCellStyle = dataGridViewCellStyle5;
            CodigoDGV.EnableHeadersVisualStyles = false;
            CodigoDGV.GridColor = Color.White;
            CodigoDGV.Location = new Point(444, 88);
            CodigoDGV.Name = "CodigoDGV";
            CodigoDGV.ReadOnly = true;
            CodigoDGV.RightToLeft = RightToLeft.No;
            CodigoDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            CodigoDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            CodigoDGV.RowHeadersVisible = false;
            CodigoDGV.RowTemplate.Height = 25;
            CodigoDGV.Size = new Size(362, 350);
            CodigoDGV.TabIndex = 37;
            CodigoDGV.CellContentClick += CodigoDGV_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 42;
            // 
            // CodigoGrupo
            // 
            CodigoGrupo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CodigoGrupo.HeaderText = "Codigo de Grupo";
            CodigoGrupo.Name = "CodigoGrupo";
            CodigoGrupo.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top;
            groupBox1.Controls.Add(CodigoTB);
            groupBox1.Controls.Add(AddCodigoButton);
            groupBox1.Controls.Add(label1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(444, 28);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(362, 54);
            groupBox1.TabIndex = 50;
            groupBox1.TabStop = false;
            groupBox1.Text = "Registro de Materia";
            // 
            // CodigoTB
            // 
            CodigoTB.BackColor = Color.FromArgb(63, 62, 70);
            CodigoTB.ForeColor = SystemColors.ControlLightLight;
            CodigoTB.Location = new Point(114, 19);
            CodigoTB.Margin = new Padding(3, 3, 0, 3);
            CodigoTB.Name = "CodigoTB";
            CodigoTB.Size = new Size(138, 23);
            CodigoTB.TabIndex = 49;
            // 
            // AddCodigoButton
            // 
            AddCodigoButton.BackColor = Color.FromArgb(86, 76, 149);
            AddCodigoButton.FlatAppearance.BorderSize = 0;
            AddCodigoButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AddCodigoButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AddCodigoButton.FlatStyle = FlatStyle.Flat;
            AddCodigoButton.ForeColor = SystemColors.Control;
            AddCodigoButton.Location = new Point(252, 18);
            AddCodigoButton.Margin = new Padding(0, 0, 3, 0);
            AddCodigoButton.Name = "AddCodigoButton";
            AddCodigoButton.Size = new Size(104, 23);
            AddCodigoButton.TabIndex = 35;
            AddCodigoButton.Text = "Agregar Codigo";
            AddCodigoButton.UseVisualStyleBackColor = false;
            AddCodigoButton.Click += AddCodigoButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 2;
            label1.Text = "Codigo de grupo:";
            // 
            // PantallaRegistroMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(818, 450);
            Controls.Add(groupBox1);
            Controls.Add(CodigoDGV);
            Controls.Add(ActualGroupBox);
            Controls.Add(RegistroMDGV);
            Controls.Add(Header);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaRegistroMateria";
            Text = "PantallaRegistroMateria";
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)RegistroMDGV).EndInit();
            ActualGroupBox.ResumeLayout(false);
            ActualGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CodigoDGV).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Header;
        private PictureBox RestoreButton;
        private PictureBox CloseButtonQR;
        private Label TittleLabel;
        private PictureBox MaximixeButton;
        private PictureBox MinimizeButton;
        private PictureBox CloseButton;
        private PictureBox pictureBox1;
        private DataGridView RegistroMDGV;
        private GroupBox ActualGroupBox;
        private Label label3;
        private Button AddMateriaButton;
        private TextBox MateriaTextBox;
        private DataGridView CodigoDGV;
        private GroupBox groupBox1;
        private TextBox CodigoTB;
        private Button AddCodigoButton;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn CodigoGrupo;
    }
}