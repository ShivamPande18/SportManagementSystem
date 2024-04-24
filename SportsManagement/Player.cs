using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SportsManagement
{
    public partial class Player : Form
    {
        MySqlConnection conn;
        public Player(MySqlConnection newCon)
        {
            InitializeComponent();
            conn = newCon;
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "player";
            cmd.CommandText = "select * from " + selected;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "player";
            cmd.CommandText = "SELECT * from " + selected;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            DateTime dateTime = dateTimePicker1.Value.Date;
            string dob = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString();
            string type = comboBox1.Text;
            if (type == "")
            {
                MessageBox.Show("Fields can't be null");
                return;
            }
            String selected = "player";
            cmd.CommandText = "SELECT p.player_name, s.type FROM player p INNER JOIN team t ON p.team_name = t.team_name INNER JOIN sport s ON t.sport_name = s.sport_name WHERE p.dob = '" + dob + "' AND s.type = '" + type + "'; ";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = conn.CreateCommand();
            DateTime dateTime = dateTimePicker1.Value.Date;
            string dob = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString();
            string type = comboBox1.Text;
            if (type == "")
            {
                MessageBox.Show("Fields can't be null");
                return;
            }
            String selected = "player";
            cmd.CommandText = "SELECT\r\n    P.player_id,\r\n    P.player_name AS Player_Name,\r\n    T.team_name AS Team_Name,\r\n    T.ranking AS Team_Rank,\r\n    (SELECT COUNT(*) FROM Matches M WHERE M.sport_name = T.sport_name) AS Total_Matches_Played\r\nFROM\r\n    Player P\r\nINNER JOIN\r\n    Team T ON P.team_name = T.team_name;";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = conn.CreateCommand();
            DateTime dateTime = dateTimePicker1.Value.Date;
            string dob = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString();
            string type = comboBox1.Text;
            if (type == "")
            {
                MessageBox.Show("Fields can't be null");
                return;
            }
            String selected = "player";
            cmd.CommandText = "WITH player_matches AS(\r\n  SELECT player_id, p.sport_name\r\n  FROM player p\r\n  INNER JOIN matches m ON p.sport_name = m.sport_name\r\n            )\r\nSELECT p.player_name, s.sport_name\r\nFROM player p\r\nINNER JOIN sport s ON p.sport_name = s.sport_name\r\nWHERE p.player_id NOT IN(\r\n  SELECT player_id\r\n  FROM player_matches\r\n);";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string pl = "find_players_in_teams";

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(pl, conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            //adapter.SelectCommand.Parameters.Add("@match_id", MySqlDbType.Int64).Value = matchId;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "player");

            string index = comboBox2.Text;
            if (index == "A") index = "0";
            else if (index == "B") index = "1";
            else if (index == "C") index = "2";
            else if (index == "D") index = "3";
            else if (index == "E") index = "4";
            else if (index == "F") index = "5";
            else if (index == "G") index = "6";
            else if (index == "H") index = "7";
            else if (index == "I") index = "8";
            else if (index == "J") index = "9";
            else index = "0";
            try
            {
                dataGridView1.DataSource = ds.Tables[int.Parse(index)];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string pl = "get_youngest_player_in_team";
            string team  =  comboBox2.Text;

            if (team == "")
            {
                MessageBox.Show("Fields can't be null");
                return;
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(pl, conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            adapter.SelectCommand.Parameters.Add("@teamName", MySqlDbType.VarChar).Value = team;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "player");
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
