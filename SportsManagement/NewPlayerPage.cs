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
    public partial class NewPlayerPage : Form
    {
        MySqlConnection conn;
        public NewPlayerPage(MySqlConnection newConn)
        {
            InitializeComponent();
            conn = newConn;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from player";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText,conn);
            DataSet ds = new DataSet();
            da.Fill(ds,"player");
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string contact = textBox3.Text;
            string college = textBox4.Text;
            string rank = textBox5.Text;

            if (id == "" || name == "" || contact == "" || college == "" || rank == "")
            {
                MessageBox.Show("Fields can't be null");
                return;
            }

            foreach (char i in name) {
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

            if (contact.Length != 10) 
            {
                MessageBox.Show("Invalid contact");
                return;
            }

            try
            {
                double.Parse(contact);

            }
            catch (Exception)
            {
                MessageBox.Show("Invalid contact");
                return;
                
            }

            DateTime dateTime = dateTimePicker1.Value.Date;

            string dob = dateTime.Year.ToString() + "-" + dateTime.Month.ToString() + "-" + dateTime.Day.ToString(); 
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "insert into player values("+id+",'"+name+"','"+contact+"',"+rank+",'"+dob+"','"+college+"','unassigned','unassigned')";

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Insterted");
                cmd.CommandText = "select * from player";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "player");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
