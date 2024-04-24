using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SportsManagement
{
    public partial class Official : Form
    {
        MySqlConnection conn;
        public Official(MySqlConnection newCon)
        {
            InitializeComponent();
            conn = newCon;
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "official";
            cmd.CommandText = "select * from " + selected;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "official";
            cmd.CommandText = "select * from " + selected;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "official";
            cmd.CommandText = "SELECT Official.o_id, Official.name AS Official_Name, Matches.match_id\r\nFROM Official\r\nINNER JOIN Matches ON Official.match_id = Matches.match_id;";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            if (name == "")
            {
                MessageBox.Show("Fields can't be null");
                return;
            }

            MySqlCommand cmd = conn.CreateCommand();
            String selected = "official";
            cmd.CommandText = "SELECT o.name, m.date, m.venue\r\nFROM official o\r\nINNER JOIN matches m ON o.match_id = m.match_id\r\nINNER JOIN team t ON m.sport_name = t.sport_name\r\nWHERE t.team_name = '" + name + "';";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Official_Load(object sender, EventArgs e)
        {

        }
    }
}
