using System.Windows.Forms;

namespace SportsManagement
{
    partial class AdminPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPage));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            addPlayerToolStripMenuItem = new ToolStripMenuItem();
            addSportToolStripMenuItem = new ToolStripMenuItem();
            addTeamToolStripMenuItem = new ToolStripMenuItem();
            addEquipmentsToolStripMenuItem = new ToolStripMenuItem();
            addOfficialToolStripMenuItem = new ToolStripMenuItem();
            addManagerToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton2 = new ToolStripDropDownButton();
            scheduleMatchToolStripMenuItem = new ToolStripMenuItem();
            toolStripDropDownButton3 = new ToolStripDropDownButton();
            playerToolStripMenuItem = new ToolStripMenuItem();
            sportToolStripMenuItem = new ToolStripMenuItem();
            matchesToolStripMenuItem = new ToolStripMenuItem();
            officialToolStripMenuItem = new ToolStripMenuItem();
            managerToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            comboBox1 = new ComboBox();
            label5 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(32, 32);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1, toolStripDropDownButton2, toolStripDropDownButton3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1058, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { addPlayerToolStripMenuItem, addSportToolStripMenuItem, addTeamToolStripMenuItem, addEquipmentsToolStripMenuItem, addOfficialToolStripMenuItem, addManagerToolStripMenuItem });
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(44, 22);
            toolStripDropDownButton1.Text = "ADD";
            toolStripDropDownButton1.Click += toolStripDropDownButton1_Click;
            // 
            // addPlayerToolStripMenuItem
            // 
            addPlayerToolStripMenuItem.Name = "addPlayerToolStripMenuItem";
            addPlayerToolStripMenuItem.Size = new Size(160, 22);
            addPlayerToolStripMenuItem.Text = "add player";
            addPlayerToolStripMenuItem.Click += addPlayerToolStripMenuItem_Click;
            // 
            // addSportToolStripMenuItem
            // 
            addSportToolStripMenuItem.Name = "addSportToolStripMenuItem";
            addSportToolStripMenuItem.Size = new Size(160, 22);
            addSportToolStripMenuItem.Text = "add sport";
            addSportToolStripMenuItem.Click += addSportToolStripMenuItem_Click;
            // 
            // addTeamToolStripMenuItem
            // 
            addTeamToolStripMenuItem.Name = "addTeamToolStripMenuItem";
            addTeamToolStripMenuItem.Size = new Size(160, 22);
            addTeamToolStripMenuItem.Text = "add team";
            addTeamToolStripMenuItem.Click += addTeamToolStripMenuItem_Click;
            // 
            // addEquipmentsToolStripMenuItem
            // 
            addEquipmentsToolStripMenuItem.Name = "addEquipmentsToolStripMenuItem";
            addEquipmentsToolStripMenuItem.Size = new Size(160, 22);
            addEquipmentsToolStripMenuItem.Text = "add equipments";
            addEquipmentsToolStripMenuItem.Click += addEquipmentsToolStripMenuItem_Click;
            // 
            // addOfficialToolStripMenuItem
            // 
            addOfficialToolStripMenuItem.Name = "addOfficialToolStripMenuItem";
            addOfficialToolStripMenuItem.Size = new Size(160, 22);
            addOfficialToolStripMenuItem.Text = "add official";
            addOfficialToolStripMenuItem.Click += addOfficialToolStripMenuItem_Click;
            // 
            // addManagerToolStripMenuItem
            // 
            addManagerToolStripMenuItem.Name = "addManagerToolStripMenuItem";
            addManagerToolStripMenuItem.Size = new Size(160, 22);
            addManagerToolStripMenuItem.Text = "add manager";
            addManagerToolStripMenuItem.Click += addManagerToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton2
            // 
            toolStripDropDownButton2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton2.DropDownItems.AddRange(new ToolStripItem[] { scheduleMatchToolStripMenuItem });
            toolStripDropDownButton2.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            toolStripDropDownButton2.Size = new Size(77, 22);
            toolStripDropDownButton2.Text = "SCHEDULE";
            // 
            // scheduleMatchToolStripMenuItem
            // 
            scheduleMatchToolStripMenuItem.Name = "scheduleMatchToolStripMenuItem";
            scheduleMatchToolStripMenuItem.Size = new Size(158, 22);
            scheduleMatchToolStripMenuItem.Text = "schedule match";
            scheduleMatchToolStripMenuItem.Click += scheduleMatchToolStripMenuItem_Click;
            // 
            // toolStripDropDownButton3
            // 
            toolStripDropDownButton3.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripDropDownButton3.DropDownItems.AddRange(new ToolStripItem[] { playerToolStripMenuItem, sportToolStripMenuItem, matchesToolStripMenuItem, officialToolStripMenuItem, managerToolStripMenuItem });
            toolStripDropDownButton3.Image = (Image)resources.GetObject("toolStripDropDownButton3.Image");
            toolStripDropDownButton3.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            toolStripDropDownButton3.Size = new Size(80, 22);
            toolStripDropDownButton3.Text = "CONTROLS";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(121, 22);
            playerToolStripMenuItem.Text = "Player";
            playerToolStripMenuItem.Click += playerToolStripMenuItem_Click;
            // 
            // sportToolStripMenuItem
            // 
            sportToolStripMenuItem.Name = "sportToolStripMenuItem";
            sportToolStripMenuItem.Size = new Size(121, 22);
            sportToolStripMenuItem.Text = "Sport";
            sportToolStripMenuItem.Click += sportToolStripMenuItem_Click;
            // 
            // matchesToolStripMenuItem
            // 
            matchesToolStripMenuItem.Name = "matchesToolStripMenuItem";
            matchesToolStripMenuItem.Size = new Size(121, 22);
            matchesToolStripMenuItem.Text = "Matches";
            matchesToolStripMenuItem.Click += matchesToolStripMenuItem_Click;
            // 
            // officialToolStripMenuItem
            // 
            officialToolStripMenuItem.Name = "officialToolStripMenuItem";
            officialToolStripMenuItem.Size = new Size(121, 22);
            officialToolStripMenuItem.Text = "Official";
            officialToolStripMenuItem.Click += officialToolStripMenuItem_Click;
            // 
            // managerToolStripMenuItem
            // 
            managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            managerToolStripMenuItem.Size = new Size(121, 22);
            managerToolStripMenuItem.Text = "Manager";
            managerToolStripMenuItem.Click += managerToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 144);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(755, 497);
            dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(31, 475);
            button1.Name = "button1";
            button1.Size = new Size(236, 43);
            button1.TabIndex = 2;
            button1.Text = "Show Table";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.ActiveCaptionText;
            comboBox1.Font = new Font("Verdana", 20.25F, FontStyle.Bold);
            comboBox1.ForeColor = SystemColors.ButtonHighlight;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "admin", "player", "sport", "team", "official", "manager", "matches", "equipment", "play", "spectator" });
            comboBox1.Location = new Point(31, 411);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(236, 40);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Verdana", 50.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(44, 34);
            label5.Name = "label5";
            label5.Size = new Size(524, 80);
            label5.TabIndex = 12;
            label5.Text = "ADMIN PAGE";
            // 
            // AdminPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.back2;
            ClientSize = new Size(1058, 654);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "AdminPage";
            Text = "Admin Page";
            Load += AdminAddPlayerPage_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripMenuItem addTeamToolStripMenuItem;
        private ToolStripMenuItem addSportToolStripMenuItem;
        private ToolStripMenuItem addPlayerToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem addEquipmentsToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem scheduleMatchToolStripMenuItem;
        private ToolStripMenuItem addOfficialToolStripMenuItem;
        private ToolStripMenuItem addManagerToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button button1;
        private ComboBox comboBox1;
        private ToolStripDropDownButton toolStripDropDownButton3;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem sportToolStripMenuItem;
        private ToolStripMenuItem matchesToolStripMenuItem;
        private ToolStripMenuItem officialToolStripMenuItem;
        private ToolStripMenuItem managerToolStripMenuItem;
        private Label label5;
    }
}