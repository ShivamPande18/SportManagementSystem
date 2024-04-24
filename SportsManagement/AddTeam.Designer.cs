namespace SportsManagement
{
    partial class AddTeam
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
            label4 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            Add = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(25, 319);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 32);
            label1.TabIndex = 0;
            label1.Text = "Team Name: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(25, 393);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 1;
            label2.Text = "Sport: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(25, 452);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(246, 32);
            label3.TabIndex = 2;
            label3.Text = "No. of Players: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(25, 527);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(202, 32);
            label4.TabIndex = 3;
            label4.Text = "Team Rank: ";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(291, 319);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 40);
            textBox1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaptionText;
            comboBox1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            comboBox1.ForeColor = SystemColors.ButtonHighlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "football", "badminton", "cricket", "basketball" });
            comboBox1.Location = new Point(291, 385);
            comboBox1.Margin = new Padding(2, 1, 2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 40);
            comboBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaptionText;
            textBox2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            textBox2.ForeColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(291, 452);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(206, 40);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaptionText;
            textBox3.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            textBox3.ForeColor = SystemColors.ButtonHighlight;
            textBox3.Location = new Point(291, 519);
            textBox3.Margin = new Padding(2, 1, 2, 1);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 40);
            textBox3.TabIndex = 7;
            // 
            // Add
            // 
            Add.BackColor = SystemColors.ActiveCaptionText;
            Add.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            Add.ForeColor = SystemColors.ButtonHighlight;
            Add.Location = new Point(187, 634);
            Add.Name = "Add";
            Add.Size = new Size(127, 42);
            Add.TabIndex = 8;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(519, 149);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(746, 686);
            dataGridView1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Verdana", 50.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(386, 24);
            label5.Name = "label5";
            label5.Size = new Size(429, 80);
            label5.TabIndex = 12;
            label5.Text = "ADD TEAM";
            // 
            // AddTeam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back2;
            ClientSize = new Size(1277, 847);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(Add);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AddTeam";
            Text = "Add Team";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button Add;
        private DataGridView dataGridView1;
        private Label label5;
    }
}