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

namespace SportsManagement
{
    public partial class AddOfficial : Form
    {
        MySqlConnection conn;
        public AddOfficial(MySqlConnection myCon)
        {
            InitializeComponent();
            conn = myCon;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from official";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "official");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string sal = textBox3.Text;
            string mid = textBox4.Text;

            if (id == "" || name == "" || sal == "" || mid == "")
            {
                MessageBox.Show("Fill all the fields");
                return;
            }
            foreach (char i in name)
            {
                switch (i)
                {
                    case '1':
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                    case '0':
                        MessageBox.Show("invalid name");
                        return;
                    default:
                        break;
                }
            }

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO `official` (`o_id`, `name`, `salary`, `match_id`) VALUES ('"+id+"', '"+name+"', '"+sal+"', '"+mid+"') ";

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added");
                cmd.CommandText = "select * from official";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "official");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
