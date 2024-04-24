namespace SportsManagement
{
    partial class AddEquipment
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(164, 523);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 0;
            label1.Text = "equipment id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(164, 589);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 32);
            label2.TabIndex = 1;
            label2.Text = "match id";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(448, 520);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 40);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaptionText;
            textBox2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            textBox2.ForeColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(448, 581);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 40);
            textBox2.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(358, 674);
            button1.Name = "button1";
            button1.Size = new Size(149, 40);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 158);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(873, 315);
            dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 50.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(79, 31);
            label3.Name = "label3";
            label3.Size = new Size(725, 80);
            label3.TabIndex = 9;
            label3.Text = "ADD EQUIPMENTS";
            // 
            // AddEquipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back2;
            ClientSize = new Size(897, 761);
            Controls.Add(label3);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AddEquipment";
            Text = "Form8";
            Load += AddEquipment_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label3;
    }
}