using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsManagement
{
    public partial class test : Form
    {
        MySqlConnection conn;
        public test(MySqlConnection newCon)
        {
            InitializeComponent();
            conn = newCon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();

            string pl = "GetMatchesWithSports";

            cmd.CommandText = "SELECT Matches.match_id, Matches.date, Matches.venue, Sport.type FROM Matches INNER JOIN Sport ON Matches.sport_name = Sport.sport_name";
            cmd.CommandText = "SELECT Official.o_id, Official.name AS Official_Name, Matches.match_id FROM Official INNER JOIN Matches ON Official.match_id = Matches.match_id;";
            cmd.CommandText = "SELECT Equipment.equip_id, Equipment.match_id, Matches.date, Matches.venue\r\nFROM Equipment\r\nINNER JOIN Matches ON Equipment.match_id = Matches.match_id;";

            MySqlCommand cmd2 = new MySqlCommand(pl, conn);
            cmd2.CommandType = CommandType.StoredProcedure;
            //MySqlDataReader dr = cmd2.ExecuteReader();  
            //dr.Read();
            //MessageBox.Show(dr.GetString(2));

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand(pl, conn);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            adapter.Fill(ds, "matches");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void test_Load(object sender, EventArgs e)
        {

        }
    }
}
