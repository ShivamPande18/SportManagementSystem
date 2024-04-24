using System.Windows.Forms;

namespace SportsManagement
{
    partial class Player
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
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            button3 = new Button();
            button4 = new Button();
            label5 = new Label();
            button5 = new Button();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(611, 119);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(955, 679);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Verdana", 12.75F);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(54, 319);
            button1.Name = "button1";
            button1.Size = new Size(517, 66);
            button1.TabIndex = 1;
            button1.Text = "Get player with with dob and sport type";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(53, 119);
            button2.Name = "button2";
            button2.Size = new Size(517, 53);
            button2.TabIndex = 2;
            button2.Text = "Get all";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Verdana", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(55, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(516, 40);
            dateTimePicker1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaptionText;
            comboBox1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            comboBox1.ForeColor = SystemColors.ButtonHighlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "outdoor", "indoor" });
            comboBox1.Location = new Point(53, 277);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(517, 40);
            comboBox1.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Verdana", 12.75F);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(53, 403);
            button3.Name = "button3";
            button3.Size = new Size(516, 65);
            button3.TabIndex = 6;
            button3.Text = "get players and the total number of matches played by the team";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.Font = new Font("Verdana", 12.75F);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(54, 487);
            button4.Name = "button4";
            button4.Size = new Size(516, 71);
            button4.TabIndex = 7;
            button4.Text = "players who haven't played in any matches for a specific sport";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Verdana", 50.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(511, 18);
            label5.Name = "label5";
            label5.Size = new Size(373, 80);
            label5.TabIndex = 12;
            label5.Text = "PLAYERS";
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.Font = new Font("Verdana", 12.75F);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(53, 634);
            button5.Name = "button5";
            button5.Size = new Size(516, 46);
            button5.TabIndex = 13;
            button5.Text = "Players in a team";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.ActiveCaptionText;
            comboBox2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            comboBox2.ForeColor = SystemColors.ButtonHighlight;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" });
            comboBox2.Location = new Point(54, 588);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(517, 40);
            comboBox2.TabIndex = 14;
            // 
            // Player
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back2;
            ClientSize = new Size(1578, 826);
            Controls.Add(comboBox2);
            Controls.Add(button5);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Player";
            Text = "Players";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Button button3;
        private Button button4;
        private Label label5;
        private Button button5;
        private ComboBox comboBox2;
    }
}