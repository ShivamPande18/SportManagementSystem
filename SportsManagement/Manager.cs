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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SportsManagement
{
    public partial class Manager : Form
    {
        MySqlConnection conn;
        public Manager(MySqlConnection newCon)
        {
            InitializeComponent();
            conn = newCon;
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "manager";
            cmd.CommandText = "select * from " + selected;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "manager";
            cmd.CommandText = "select * from " + selected;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MySqlCommand cmd = conn.CreateCommand();
            String selected = "manager";
            cmd.CommandText = "SELECT manager.m_id, manager.name AS Manager_Name, Team.team_name, Team.ranking AS Team_Rank\r\nFROM manager\r\nINNER JOIN Team ON manager.team_name = Team.team_name;";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "manager";
            cmd.CommandText = "SELECT\r\n    manager.name AS Manager_Name,\r\n    Team.team_name AS Team_Name,\r\n    Team.ranking AS Team_Rank,\r\n    (SELECT COUNT(*) FROM Matches WHERE Matches.sport_name = Team.sport_name) AS Total_Matches_Played\r\nFROM\r\n    manager\r\nINNER JOIN\r\n    Team ON manager.team_name = Team.team_name;";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text;
            string team = textBox1.Text;
            string pl = "assign_manager_to_team";

            if (id == "" || team == "")
            {
                MessageBox.Show("Fill all the fields");
                return;
            }

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = pl;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@p_manager_id", MySqlDbType.Int64).Value = id;
            cmd.Parameters.Add("@p_team_name", MySqlDbType.VarChar).Value = team;
            //cmd.Parameters.Add("@ireturnvalue", MySqlDbType.Decimal);
            //cmd.Parameters["@ireturnvalue"].Direction = ParameterDirection.ReturnValue;

            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //adapter.SelectCommand = new MySqlCommand(pl, conn);
            //adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            //adapter.SelectCommand.Parameters.Add("@ireturnvalue", MySqlDbType.Decimal);
            //adapter.SelectCommand.Parameters
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Manager Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            String selected = "manager";
            cmd.CommandText = "SELECT * from " + selected;
            cmd.CommandType = CommandType.Text;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];

            //dr.Read();
            //try
            //{
            //    MessageBox.Show(dr.GetString(0).ToString());
            //}
            //catch (Exception ex) {
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    dr.Close();
            //}
            //DataSet ds = new DataSet();
            //adapter.Fill(ds, "manager");
            //dataGridView1.DataSource = ds.Tables[0];
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
