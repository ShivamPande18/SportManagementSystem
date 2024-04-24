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
    public partial class NewAdminPage : Form
    {
        MySqlConnection conn = new();
        public NewAdminPage(MySqlConnection newCon)
        {
            InitializeComponent();
            conn = newCon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string name = textBox2.Text;
            string pass = textBox3.Text;

            if (id == "" || name == "" || pass == "") {
                MessageBox.Show("Fields can't be null");
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

            cmd.CommandText = "Insert into admin values("+id+",'"+name+"','"+pass+"')";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
                AdminPage form = new(conn,id);
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
