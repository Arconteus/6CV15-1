namespace RegistroDeAsistencia
{
    partial class Test
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
            ContainCheckBox = new CheckBox();
            label1 = new Label();
            AddButton = new Button();
            IdTextBox = new TextBox();
            GrupoTextBox = new TextBox();
            label2 = new Label();
            ContainButton = new Button();
            dataGridView1 = new DataGridView();
            UpdateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ContainCheckBox
            // 
            ContainCheckBox.AutoSize = true;
            ContainCheckBox.Location = new Point(333, 17);
            ContainCheckBox.Name = "ContainCheckBox";
            ContainCheckBox.Size = new Size(55, 19);
            ContainCheckBox.TabIndex = 0;
            ContainCheckBox.Text = "exist?";
            ContainCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // AddButton
            // 
            AddButton.Location = new Point(252, 41);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 23);
            AddButton.TabIndex = 2;
            AddButton.Text = "Agregar";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(12, 42);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(100, 23);
            IdTextBox.TabIndex = 3;
            // 
            // GrupoTextBox
            // 
            GrupoTextBox.Location = new Point(118, 42);
            GrupoTextBox.Name = "GrupoTextBox";
            GrupoTextBox.Size = new Size(100, 23);
            GrupoTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 24);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Grupo";
            // 
            // ContainButton
            // 
            ContainButton.Location = new Point(333, 42);
            ContainButton.Name = "ContainButton";
            ContainButton.Size = new Size(75, 23);
            ContainButton.TabIndex = 6;
            ContainButton.Text = "Contain";
            ContainButton.UseVisualStyleBackColor = true;
            ContainButton.Click += ContainButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(396, 150);
            dataGridView1.TabIndex = 7;
            // 
            // UpdateButton
            // 
            UpdateButton.Location = new Point(334, 76);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(75, 23);
            UpdateButton.TabIndex = 8;
            UpdateButton.Text = "Actualizar";
            UpdateButton.UseVisualStyleBackColor = true;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 271);
            Controls.Add(UpdateButton);
            Controls.Add(dataGridView1);
            Controls.Add(ContainButton);
            Controls.Add(GrupoTextBox);
            Controls.Add(label2);
            Controls.Add(IdTextBox);
            Controls.Add(AddButton);
            Controls.Add(label1);
            Controls.Add(ContainCheckBox);
            Name = "Test";
            Text = "Test";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ContainCheckBox;
        private Label label1;
        private Button AddButton;
        private TextBox IdTextBox;
        private TextBox GrupoTextBox;
        private Label label2;
        private Button ContainButton;
        private DataGridView dataGridView1;
        private Button UpdateButton;
    }
}