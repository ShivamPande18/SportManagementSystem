using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SportsManagement
{
    public partial class AdminPage : Form
    {
        MySqlConnection conn;
        string adminId;
        public AdminPage(MySqlConnection newConn, string newId)
        {
            InitializeComponent();
            conn = newConn;
            adminId = newId;
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "admin";
            cmd.CommandText = "select * from " + selected;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AdminAddPlayerPage_Load(object sender, EventArgs e)
        {
        }

        private void addPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewPlayerPage form = new(conn);
            form.Show();
        }

        private void addSportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSport form = new(conn, adminId);
            form.Show();
        }

        private void addTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeam form = new(conn);
            form.Show();
        }

        private void addEquipmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEquipment form = new(conn, adminId);
            form.Show();
        }

        private void scheduleMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleMatch form = new(conn, adminId);
            form.Show();
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void addOfficialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddOfficial form = new(conn);
            form.Show();
        }

        private void addManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddManager form = new(conn);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.Text;

            if (selected == "")
            {
                MessageBox.Show("Fill all the fields");
                return;
            }

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from " + selected;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void matchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matches form = new(conn);
            form.Show();
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Player form = new(conn);
            form.Show();
        }

        private void officialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Official form = new(conn);
            form.Show();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager form = new(conn);
            form.Show();
        }

        private void sportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sport form = new(conn, adminId);
            form.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
