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
            HorariodataGridView1 = new DataGridView();
            DíaDataGridView2 = new DataGridView();
            button1 = new Button();
            ActualgroupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)HorariodataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DíaDataGridView2).BeginInit();
            SuspendLayout();
            // 
            // HorariodataGridView1
            // 
            HorariodataGridView1.BackgroundColor = Color.FromArgb(54, 57, 62);
            HorariodataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            HorariodataGridView1.Location = new Point(201, 163);
            HorariodataGridView1.Name = "HorariodataGridView1";
            HorariodataGridView1.RowTemplate.Height = 25;
            HorariodataGridView1.Size = new Size(502, 275);
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(30, 33, 36);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(584, 31);
            button1.Name = "button1";
            button1.Size = new Size(195, 114);
            button1.TabIndex = 2;
            button1.Text = "COMENZAR REGISTRO DE ASISTENCIA";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
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
            // PantallaInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(852, 450);
            Controls.Add(button1);
            Controls.Add(ActualgroupBox1);
            Controls.Add(DíaDataGridView2);
            Controls.Add(HorariodataGridView1);
            ForeColor = Color.FromArgb(54, 57, 62);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PantallaInicio";
            Text = "PantallaInicio";
            ((System.ComponentModel.ISupportInitialize)HorariodataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)DíaDataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView HorariodataGridView1;
        private DataGridView DíaDataGridView2;
        private Button button1;
        private GroupBox ActualgroupBox1;
    }
}