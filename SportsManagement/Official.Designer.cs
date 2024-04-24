namespace SportsManagement
{
    partial class Official
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(479, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(955, 716);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(27, 306);
            button1.Name = "button1";
            button1.Size = new Size(419, 60);
            button1.TabIndex = 1;
            button1.Text = "Get officials with matches";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(27, 246);
            button2.Name = "button2";
            button2.Size = new Size(419, 59);
            button2.TabIndex = 2;
            button2.Text = "Get all";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(27, 473);
            button3.Name = "button3";
            button3.Size = new Size(419, 62);
            button3.TabIndex = 4;
            button3.Text = "Official for entered team";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(27, 427);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(419, 40);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Verdana", 50.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(392, 9);
            label5.Name = "label5";
            label5.Size = new Size(444, 80);
            label5.TabIndex = 12;
            label5.Text = "OFFICIALS";
            // 
            // Official
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back2;
            ClientSize = new Size(1446, 846);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Official";
            Text = "Official";
            Load += Official_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private Label label5;
    }
}