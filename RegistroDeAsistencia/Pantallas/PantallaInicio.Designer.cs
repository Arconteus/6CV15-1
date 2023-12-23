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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaInicio));
            HorariodataGridView1 = new DataGridView();
            DíaDataGridView2 = new DataGridView();
            ActualgroupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)HorariodataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DíaDataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // HorariodataGridView1
            // 
            HorariodataGridView1.BackgroundColor = Color.FromArgb(54, 57, 62);
            HorariodataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HorariodataGridView1.Location = new Point(201, 163);
            HorariodataGridView1.Name = "HorariodataGridView1";
            HorariodataGridView1.RowTemplate.Height = 25;
            HorariodataGridView1.Size = new Size(513, 275);
            HorariodataGridView1.TabIndex = 0;
            HorariodataGridView1.CellContentClick += HorariodataGridView1_CellContentClick;
            // 
            // DíaDataGridView2
            // 
            DíaDataGridView2.BackgroundColor = Color.FromArgb(54, 57, 62);
            DíaDataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DíaDataGridView2.Location = new Point(50, 163);
            DíaDataGridView2.Name = "DíaDataGridView2";
            DíaDataGridView2.RowTemplate.Height = 25;
            DíaDataGridView2.Size = new Size(108, 275);
            DíaDataGridView2.TabIndex = 1;
            DíaDataGridView2.CellContentClick += DíaDataGridView2_CellContentClick;
            // 
            // ActualgroupBox1
            // 
            ActualgroupBox1.ForeColor = Color.White;
            ActualgroupBox1.Location = new Point(50, 24);
            ActualgroupBox1.Name = "ActualgroupBox1";
            ActualgroupBox1.Size = new Size(365, 121);
            ActualgroupBox1.TabIndex = 3;
            ActualgroupBox1.TabStop = false;
            ActualgroupBox1.Text = "Hora Actual";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(588, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(135, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(548, 130);
            label1.Name = "label1";
            label1.Size = new Size(210, 15);
            label1.TabIndex = 23;
            label1.Text = "COMENZAR REGISTRO DE ASISTENCIA";
            // 
            // PantallaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(852, 450);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(ActualgroupBox1);
            Controls.Add(DíaDataGridView2);
            Controls.Add(HorariodataGridView1);
            ForeColor = Color.FromArgb(54, 57, 62);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaInicio";
            Text = "PantallaInicio";
            ((System.ComponentModel.ISupportInitialize)HorariodataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DíaDataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView HorariodataGridView1;
        private DataGridView DíaDataGridView2;
        private GroupBox ActualgroupBox1;
        private PictureBox pictureBox1;
        private Label label1;
    }
}