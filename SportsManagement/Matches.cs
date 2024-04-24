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
    public partial class Matches : Form
    {
        MySqlConnection conn;
        public Matches(MySqlConnection newCon)
        {
            InitializeComponent();
            conn = newCon;
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "matches";
            cmd.CommandText = "select * from " + selected;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "matches";
            cmd.CommandText = "SELECT Matches.match_id, Matches.date, Matches.venue, Sport.type FROM Matches INNER JOIN Sport ON Matches.sport_name = Sport.sport_name";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "matches";
            cmd.CommandText = "SELECT * from " + selected;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "matches";
            cmd.CommandText = "SELECT Equipment.equip_id, Equipment.match_id, Matches.date, Matches.venue\r\nFROM Equipment\r\nINNER JOIN Matches ON Equipment.match_id = Matches.match_id;";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "matches";
            cmd.CommandText = "WITH recent_matches AS(\r\n  SELECT match_id\r\n  FROM matches\r\n  WHERE date >= '2025-01-04'\r\n)\r\nSELECT p.match_id, p.team_name\r\nFROM play p\r\nLEFT JOIN recent_matches rm ON p.match_id = rm.match_id\r\nWHERE p.team_name LIKE 'mit fc'\r\n  AND rm.match_id IS NULL;";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {

            string pl = "GetMatchesWithSports";

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(pl, conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "matches");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string pl = "GetEquipmentForMatch";
            if (textBox1.Text == "")
            {
                MessageBox.Show("Fill all the fields");
                return;
            }
            int matchId = 10;
            try
            {

            matchId = int.Parse(textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(pl, conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@match_id", MySqlDbType.Int64).Value = matchId;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "matches");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            string pl = "GetMatchesWithSports";

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(pl, conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            //adapter.SelectCommand.Parameters.Add("@match_id", MySqlDbType.Int64).Value = matchId;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "matches");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "spectator";
            cmd.CommandText = "SELECT match_id, MAX(spectator_count) AS max_spectators\r\nFROM (SELECT match_id, COUNT(*) AS spectator_count FROM spectator GROUP BY match_id) AS match_spectators;";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
