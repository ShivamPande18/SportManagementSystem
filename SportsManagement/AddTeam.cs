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
    public partial class AddTeam : Form
    {
        MySqlConnection conn;
        public AddTeam(MySqlConnection myCon)
        {
            InitializeComponent();
            conn = myCon;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from team";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "team");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AddTeam_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Add_Click(object sender, EventArgs e)
        {
            string team = textBox1.Text;
            string sport = comboBox1.Text;
            string noPlayer = textBox2.Text;
            string rank = textBox3.Text;

            if (team == "" || sport == "" || noPlayer == "" || rank == "")
            {
                MessageBox.Show("Fill all the fields");
                return;
            }


            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO `team` (`team_name`, `sport_name`, `no_of_players`, `ranking`) VALUES ('" + team + "', '" + sport + "', '" + noPlayer + "', '" + rank + "') ";

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added");
                cmd.CommandText = "select * from team";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "team");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
