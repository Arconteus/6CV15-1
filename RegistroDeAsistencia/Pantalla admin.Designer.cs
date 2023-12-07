namespace RegistroDeAsistencia
{
    partial class Pantalla_admin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox6 = new TextBox();
            Column2 = new DataGridViewCheckBoxColumn();
            Semestre = new DataGridViewTextBoxColumn();
            Grupo = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 71);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 0;
            label1.Text = "Semestre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 109);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Profesor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 149);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 2;
            label3.Text = "Materia";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(108, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(407, 23);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(108, 63);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(108, 146);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(407, 23);
            comboBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(660, 185);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 7;
            label4.Text = "Registrar grupo\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(624, 224);
            label5.Name = "label5";
            label5.Size = new Size(55, 15);
            label5.TabIndex = 8;
            label5.Text = "Semestre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(624, 352);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 9;
            label6.Text = "Profesor";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(624, 307);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 10;
            label7.Text = "Materia";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(624, 262);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 11;
            label8.Text = "Grupo";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(704, 216);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(704, 254);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(704, 299);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 14;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(704, 344);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(771, 391);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 16;
            button1.Text = "Agregar Grupo";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column2, Semestre, Grupo, Column1, Profesor });
            dataGridView1.Location = new Point(70, 224);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(548, 214);
            dataGridView1.TabIndex = 17;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(70, 189);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(445, 23);
            textBox6.TabIndex = 18;
            // 
            // Column2
            // 
            Column2.HeaderText = "X";
            Column2.Name = "Column2";
            // 
            // Semestre
            // 
            Semestre.HeaderText = "Semestre";
            Semestre.Name = "Semestre";
            // 
            // Grupo
            // 
            Grupo.HeaderText = "Grupo";
            Grupo.Name = "Grupo";
            // 
            // Column1
            // 
            Column1.HeaderText = "Materia";
            Column1.Name = "Column1";
            // 
            // Profesor
            // 
            Profesor.HeaderText = "Profesor";
            Profesor.Name = "Profesor";
            // 
            // Pantalla_admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 450);
            Controls.Add(textBox6);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Pantalla_admin";
            Text = "Pantalla_admin";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox6;
        private DataGridViewCheckBoxColumn Column2;
        private DataGridViewTextBoxColumn Semestre;
        private DataGridViewTextBoxColumn Grupo;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Profesor;
    }
}