namespace SportsManagement
{
    partial class Manager
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(535, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(499, 571);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(11, 257);
            button1.Name = "button1";
            button1.Size = new Size(518, 50);
            button1.TabIndex = 1;
            button1.Text = "Get manager team info";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(11, 187);
            button2.Name = "button2";
            button2.Size = new Size(518, 49);
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
            button3.Location = new Point(11, 332);
            button3.Name = "button3";
            button3.Size = new Size(518, 74);
            button3.TabIndex = 4;
            button3.Text = "Total Matches managed by managers";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(11, 614);
            button4.Name = "button4";
            button4.Size = new Size(518, 58);
            button4.TabIndex = 5;
            button4.Text = "Assign manager to team";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Verdana", 50.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(378, 9);
            label5.Name = "label5";
            label5.Size = new Size(411, 80);
            label5.TabIndex = 12;
            label5.Text = "MANAGER";
            label5.Click += label5_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(11, 552);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(518, 40);
            textBox1.TabIndex = 13;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaptionText;
            textBox2.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox2.ForeColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(11, 506);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(518, 40);
            textBox2.TabIndex = 14;
            // 
            // Manager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back2;
            ClientSize = new Size(1046, 725);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Manager";
            Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label5;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox2;
    }
}