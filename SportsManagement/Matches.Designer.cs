namespace SportsManagement
{
    partial class Matches
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
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            textBox1 = new TextBox();
            label5 = new Label();
            button7 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(620, 123);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(955, 687);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(12, 254);
            button1.Name = "button1";
            button1.Size = new Size(490, 66);
            button1.TabIndex = 1;
            button1.Text = "Get matches with sports type";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(12, 182);
            button2.Name = "button2";
            button2.Size = new Size(490, 66);
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
            button3.Location = new Point(12, 332);
            button3.Name = "button3";
            button3.Size = new Size(490, 61);
            button3.TabIndex = 4;
            button3.Text = "Equipments used in a match";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(12, 399);
            button4.Name = "button4";
            button4.Size = new Size(490, 61);
            button4.TabIndex = 5;
            button4.Text = "Teams with no recent matches";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(12, 480);
            button5.Name = "button5";
            button5.Size = new Size(490, 61);
            button5.TabIndex = 6;
            button5.Text = "GetMatchesWithSport";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(12, 672);
            button6.Name = "button6";
            button6.Size = new Size(490, 61);
            button6.TabIndex = 7;
            button6.Text = "GetEquipmentForMatch";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(12, 626);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(490, 40);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Verdana", 50.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(443, 9);
            label5.Name = "label5";
            label5.Size = new Size(394, 80);
            label5.TabIndex = 12;
            label5.Text = "MATCHES";
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(12, 760);
            button7.Name = "button7";
            button7.Size = new Size(490, 61);
            button7.TabIndex = 13;
            button7.Text = "Max Spectators";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // Matches
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back2;
            ClientSize = new Size(1587, 861);
            Controls.Add(button7);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Matches";
            Text = "Matches";
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
        private Button button5;
        private Button button6;
        private TextBox textBox1;
        private Label label5;
        private Button button7;
    }
}