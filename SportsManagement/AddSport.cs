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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SportsManagement
{
    public partial class AddSport : Form
    {
        MySqlConnection conn;
        string adminId;
        public AddSport(MySqlConnection myCon, string aid)
        {
            InitializeComponent();
            conn = myCon;
            adminId = aid;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from sport";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "sport");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = comboBox1.Text;
            string type = "outdoor";

            if (radioButton1.Checked) type = "indoor";

            if (name == "")
            {
                MessageBox.Show("Fill all the fields");
                return;
            }

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO sport VALUES ('" + name + "', '" + adminId + "', '" + type + "') ";

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added");
                cmd.CommandText = "select * from sport";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "sport");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddSport_Load(object sender, EventArgs e)
        {

        }
    }
}
