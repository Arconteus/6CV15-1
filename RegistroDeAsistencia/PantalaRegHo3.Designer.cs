namespace RegistroDeAsistencia
{
    partial class PantalaRegHo3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantalaRegHo3));
            RegistroHDGV = new DataGridView();
            Hora = new DataGridViewTextBoxColumn();
            Dia1 = new DataGridViewComboBoxColumn();
            Dia2 = new DataGridViewComboBoxColumn();
            Dia3 = new DataGridViewComboBoxColumn();
            Dia4 = new DataGridViewComboBoxColumn();
            Dia5 = new DataGridViewComboBoxColumn();
            AgregarHButton = new Button();
            Header = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            RestoreButton = new PictureBox();
            CloseButtonQR = new PictureBox();
            TittleLabel = new Label();
            MaximixeButton = new PictureBox();
            MinimizeButton = new PictureBox();
            CloseButton = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)RegistroHDGV).BeginInit();
            Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).BeginInit();
            SuspendLayout();
            // 
            // RegistroHDGV
            // 
            RegistroHDGV.AllowUserToAddRows = false;
            RegistroHDGV.AllowUserToDeleteRows = false;
            RegistroHDGV.AllowUserToOrderColumns = true;
            RegistroHDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            RegistroHDGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RegistroHDGV.BackgroundColor = Color.FromArgb(63, 62, 70);
            RegistroHDGV.BorderStyle = BorderStyle.None;
            RegistroHDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            RegistroHDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            RegistroHDGV.ColumnHeadersHeight = 30;
            RegistroHDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            RegistroHDGV.Columns.AddRange(new DataGridViewColumn[] { Hora, Dia1, Dia2, Dia3, Dia4, Dia5 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(63, 62, 70);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(162, 151, 240);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            RegistroHDGV.DefaultCellStyle = dataGridViewCellStyle2;
            RegistroHDGV.EnableHeadersVisualStyles = false;
            RegistroHDGV.GridColor = Color.White;
            RegistroHDGV.Location = new Point(12, 31);
            RegistroHDGV.Name = "RegistroHDGV";
            RegistroHDGV.ReadOnly = true;
            RegistroHDGV.RightToLeft = RightToLeft.No;
            RegistroHDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(86, 76, 149);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            RegistroHDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            RegistroHDGV.RowHeadersVisible = false;
            RegistroHDGV.RowTemplate.Height = 25;
            RegistroHDGV.Size = new Size(626, 272);
            RegistroHDGV.TabIndex = 40;
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
            Dia1.Resizable = DataGridViewTriState.True;
            Dia1.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Dia2
            // 
            Dia2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dia2.HeaderText = "Martes";
            Dia2.Name = "Dia2";
            Dia2.ReadOnly = true;
            Dia2.Resizable = DataGridViewTriState.True;
            Dia2.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Dia3
            // 
            Dia3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dia3.HeaderText = "Miercoles";
            Dia3.Name = "Dia3";
            Dia3.ReadOnly = true;
            Dia3.Resizable = DataGridViewTriState.True;
            Dia3.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Dia4
            // 
            Dia4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dia4.HeaderText = "Jueves";
            Dia4.Name = "Dia4";
            Dia4.ReadOnly = true;
            Dia4.Resizable = DataGridViewTriState.True;
            Dia4.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Dia5
            // 
            Dia5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Dia5.HeaderText = "Viernes";
            Dia5.Name = "Dia5";
            Dia5.ReadOnly = true;
            Dia5.Resizable = DataGridViewTriState.True;
            Dia5.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // AgregarHButton
            // 
            AgregarHButton.BackColor = Color.FromArgb(86, 76, 149);
            AgregarHButton.Cursor = Cursors.Hand;
            AgregarHButton.FlatAppearance.BorderSize = 0;
            AgregarHButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(86, 76, 149);
            AgregarHButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(140, 126, 236);
            AgregarHButton.FlatStyle = FlatStyle.Flat;
            AgregarHButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AgregarHButton.ForeColor = SystemColors.Control;
            AgregarHButton.Location = new Point(533, 309);
            AgregarHButton.Name = "AgregarHButton";
            AgregarHButton.Size = new Size(105, 52);
            AgregarHButton.TabIndex = 46;
            AgregarHButton.Text = "Aplicar";
            AgregarHButton.UseVisualStyleBackColor = false;
            // 
            // Header
            // 
            Header.BackColor = Color.FromArgb(86, 76, 149);
            Header.Controls.Add(pictureBox3);
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
            Header.Name = "Header";
            Header.Size = new Size(646, 25);
            Header.TabIndex = 47;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = Properties.Resources.Close_Icon;
            pictureBox3.Location = new Point(618, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.Close_Icon;
            pictureBox2.Location = new Point(1068, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.Close_Icon;
            pictureBox1.Location = new Point(1318, 0);
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
            RestoreButton.Location = new Point(2192, 0);
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
            CloseButtonQR.Location = new Point(1568, 0);
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
            TittleLabel.Size = new Size(130, 15);
            TittleLabel.TabIndex = 5;
            TittleLabel.Text = "Asignación de Horarios";
            // 
            // MaximixeButton
            // 
            MaximixeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            MaximixeButton.BackColor = Color.FromArgb(74, 97, 178);
            MaximixeButton.Cursor = Cursors.Hand;
            MaximixeButton.Image = (Image)resources.GetObject("MaximixeButton.Image");
            MaximixeButton.Location = new Point(2192, 0);
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
            MinimizeButton.Location = new Point(2161, 0);
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
            CloseButton.Location = new Point(2223, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(25, 25);
            CloseButton.SizeMode = PictureBoxSizeMode.Zoom;
            CloseButton.TabIndex = 1;
            CloseButton.TabStop = false;
            // 
            // PantalaRegHo3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 30, 36);
            ClientSize = new Size(646, 369);
            Controls.Add(Header);
            Controls.Add(AgregarHButton);
            Controls.Add(RegistroHDGV);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantalaRegHo3";
            Text = "PantalaRegHo3";
            Load += PantalaRegHo3_Load;
            ((System.ComponentModel.ISupportInitialize)RegistroHDGV).EndInit();
            Header.ResumeLayout(false);
            Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)RestoreButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButtonQR).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaximixeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinimizeButton).EndInit();
            ((System.ComponentModel.ISupportInitialize)CloseButton).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView RegistroHDGV;
        private Button AgregarHButton;
        private Panel Header;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox RestoreButton;
        private PictureBox CloseButtonQR;
        private Label TittleLabel;
        private PictureBox MaximixeButton;
        private PictureBox MinimizeButton;
        private PictureBox CloseButton;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn Hora;
        private DataGridViewComboBoxColumn Dia1;
        private DataGridViewComboBoxColumn Dia2;
        private DataGridViewComboBoxColumn Dia3;
        private DataGridViewComboBoxColumn Dia4;
        private DataGridViewComboBoxColumn Dia5;
    }
}