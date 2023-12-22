namespace RegistroDeAsistencia
{
    partial class admin_profesores
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
            NombretextBox1 = new TextBox();
            PaternotextBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MaternotextBox3 = new TextBox();
            BoletatextBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox5 = new TextBox();
            profesorbutton = new Button();
            dataGridView1 = new DataGridView();
            Eliminarbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // NombretextBox1
            // 
            NombretextBox1.Location = new Point(210, 37);
            NombretextBox1.Name = "NombretextBox1";
            NombretextBox1.Size = new Size(100, 23);
            NombretextBox1.TabIndex = 0;
            // 
            // PaternotextBox2
            // 
            PaternotextBox2.Location = new Point(210, 90);
            PaternotextBox2.Name = "PaternotextBox2";
            PaternotextBox2.Size = new Size(100, 23);
            PaternotextBox2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 45);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(80, 93);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido paterno";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 150);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 4;
            label3.Text = "Apellido materno ";
            // 
            // MaternotextBox3
            // 
            MaternotextBox3.Location = new Point(210, 142);
            MaternotextBox3.Name = "MaternotextBox3";
            MaternotextBox3.Size = new Size(100, 23);
            MaternotextBox3.TabIndex = 5;
            // 
            // BoletatextBox4
            // 
            BoletatextBox4.Location = new Point(513, 63);
            BoletatextBox4.Name = "BoletatextBox4";
            BoletatextBox4.Size = new Size(100, 23);
            BoletatextBox4.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(410, 66);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 7;
            label4.Text = "Boleta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(410, 126);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 8;
            label5.Text = "Grupo";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(513, 118);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 9;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // profesorbutton
            // 
            profesorbutton.BackColor = Color.FromArgb(30, 33, 36);
            profesorbutton.FlatAppearance.BorderSize = 0;
            profesorbutton.FlatStyle = FlatStyle.Flat;
            profesorbutton.ForeColor = SystemColors.ActiveCaption;
            profesorbutton.Location = new Point(263, 192);
            profesorbutton.Name = "profesorbutton";
            profesorbutton.Size = new Size(81, 29);
            profesorbutton.TabIndex = 10;
            profesorbutton.Text = "Agregar";
            profesorbutton.UseVisualStyleBackColor = false;
            profesorbutton.Click += profesorbutton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(138, 236);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(464, 187);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Eliminarbutton
            // 
            Eliminarbutton.BackColor = Color.FromArgb(30, 33, 36);
            Eliminarbutton.FlatAppearance.BorderSize = 0;
            Eliminarbutton.FlatStyle = FlatStyle.Flat;
            Eliminarbutton.ForeColor = SystemColors.ActiveCaption;
            Eliminarbutton.Location = new Point(385, 192);
            Eliminarbutton.Name = "Eliminarbutton";
            Eliminarbutton.Size = new Size(81, 29);
            Eliminarbutton.TabIndex = 12;
            Eliminarbutton.Text = "Eliminar";
            Eliminarbutton.UseVisualStyleBackColor = false;
            Eliminarbutton.Click += Eliminarbutton_Click;
            // 
            // admin_profesores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(54, 57, 62);
            ClientSize = new Size(852, 450);
            Controls.Add(Eliminarbutton);
            Controls.Add(dataGridView1);
            Controls.Add(profesorbutton);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(BoletatextBox4);
            Controls.Add(MaternotextBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PaternotextBox2);
            Controls.Add(NombretextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_profesores";
            Text = " admin_profesores";
            Load += admin_profesores_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NombretextBox1;
        private TextBox PaternotextBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox MaternotextBox3;
        private TextBox BoletatextBox4;
        private Label label4;
        private Label label5;
        private TextBox textBox5;
        private Button profesorbutton;
        private DataGridView dataGridView1;
        private Button Eliminarbutton;
    }
}