namespace SportsManagement
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(80, 219);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 0;
            label1.Text = "USERNAME";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.Font = new Font("Verdana", 20.25F);
            textBox1.ForeColor = SystemColors.ButtonHighlight;
            textBox1.Location = new Point(301, 211);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(189, 40);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(80, 287);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 32);
            label2.TabIndex = 2;
            label2.Text = "PASSWORD";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaptionText;
            comboBox1.Font = new Font("Verdana", 20.25F);
            comboBox1.ForeColor = SystemColors.ButtonHighlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "admin", "player" });
            comboBox1.Location = new Point(220, 159);
            comboBox1.Margin = new Padding(2, 1, 2, 1);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(211, 40);
            comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaptionText;
            textBox2.Font = new Font("Verdana", 20.25F);
            textBox2.ForeColor = SystemColors.ButtonHighlight;
            textBox2.Location = new Point(301, 279);
            textBox2.Margin = new Padding(2, 1, 2, 1);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(189, 40);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(230, 369);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(140, 53);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(78, 522);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(139, 73);
            button2.TabIndex = 6;
            button2.Text = "New Player";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(374, 521);
            button3.Name = "button3";
            button3.Size = new Size(144, 74);
            button3.TabIndex = 7;
            button3.Text = "New Admin";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 50.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.Location = new Point(52, 9);
            label3.Name = "label3";
            label3.Size = new Size(506, 80);
            label3.TabIndex = 8;
            label3.Text = "LOGIN PAGE";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(617, 653);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Margin = new Padding(2, 1, 2, 1);
            Name = "LoginPage";
            Text = "LoginPage";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label3;
    }
}
