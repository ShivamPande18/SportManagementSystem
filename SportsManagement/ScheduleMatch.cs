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
using System.Xml.Linq;

namespace SportsManagement
{
    public partial class ScheduleMatch : Form
    {
        MySqlConnection conn;
        string adminId;

        public ScheduleMatch(MySqlConnection myCon, string newId)
        {
            InitializeComponent();
            conn = myCon;
            adminId = newId;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from matches";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "matches");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void ScheduleMatch_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sport = comboBox1.Text;
            string id = textBox1.Text;
            DateTime dateTime = dateTimePicker1.Value.Date;

            string dob = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString();
            string venue = textBox2.Text;

            if (id == "" || venue == "" || sport == "")
            {
                MessageBox.Show("Fields can't be null");
                return;
            }

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO `matches` (`match_id`, `date`, `venue`, `sport_name`, `admin_id`) VALUES ('" + id + "', '" + dob + "', '" + venue + "', '" + sport + "', '" + adminId + "') ";

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Scheduled");
                cmd.CommandText = "select * from matches";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "matches");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
