namespace SportsManagement
{
    partial class ScheduleMatch
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
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(23, 367);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 0;
            label1.Text = "match id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(23, 423);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 37);
            label2.TabIndex = 1;
            label2.Text = "date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(23, 480);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(94, 37);
            label3.TabIndex = 2;
            label3.Text = "venue";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(23, 313);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 37);
            label4.TabIndex = 3;
            label4.Text = "sport";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaptionText;
            comboBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            comboBox1.ForeColor = SystemColors.ButtonHighlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "cricket", "football", "volleyball", "badminton", "basketball", "gymnastics", "squash", "table tennis", "swimming" });
            comboBox1.Location = new Point(234, 305);
            comboBox1.Margin = new Padding(2, 1, 2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(239, 45);
            comboBox1.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(234, 361);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(239, 43);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaptionText;
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            textBox2.ForeColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(236, 474);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 43);
            textBox2.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(209, 423);
            dateTimePicker1.Margin = new Padding(2, 1, 2, 1);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(264, 33);
            dateTimePicker1.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(145, 602);
            button1.Name = "button1";
            button1.Size = new Size(147, 49);
            button1.TabIndex = 8;
            button1.Text = "Schedule";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(565, 135);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(554, 651);
            dataGridView1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Verdana", 50.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(145, 9);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(814, 80);
            label5.TabIndex = 12;
            label5.Text = "SCHEDULE MATCHES";
            // 
            // ScheduleMatch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.back2;
            ClientSize = new Size(1130, 799);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "ScheduleMatch";
            Text = "Schedule Match";
            Load += ScheduleMatch_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label5;
    }
}