using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.Field;

namespace SportsManagement
{
    public partial class LoginPage : Form
    {
        MySqlConnection conn = new();
        string adminId;
        public LoginPage()
        {
            InitializeComponent();
            ConnectDB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            string type = comboBox1.Text;

            if (type == "" || user == "" || password == "")
            {
                MessageBox.Show("Fields can't be empty");
                return;
            }
            //AdminPage form = new(conn, adminId);
            //form.Show();

            //MySqlCommand cmd = conn.CreateCommand();
            //MySqlDataReader dr;

            //cmd.CommandText = "select * from admin where name = '" + user + "' and password = '" + password + "'";
            //dr = cmd.ExecuteReader();

            //try
            //{
            //    if (dr.HasRows)
            //    {
            //        dr.Read();
            //        adminId = dr.GetInt32(0).ToString();
            //        dr.Close();
            //        MessageBox.Show("Admin Authenticated");
            //        AdminPage form = new(conn, adminId);
            //        form.Show();

            //    }
            //    else
            //    {
            //        MessageBox.Show("No rows");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    dr.Close();
            //}


            MySqlCommand cmd = conn.CreateCommand();
            MySqlDataReader dr;


            if (type == "admin")
            {
                cmd.CommandText = "select * from admin where name = '" + user + "' and password = '" + password + "'";
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dr.Read();
                    adminId = dr.GetInt32(0).ToString();
                    dr.Close();
                    MessageBox.Show("Admin Authenticated");
                    AdminPage form = new(conn, adminId);
                    form.Show();

                }
                else MessageBox.Show("Fail");
            }
            else
            {
                cmd.CommandText = "select * from player where player_name = '" + user + "'";


                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    MessageBox.Show("Player Authenticated");
                    dr.Close();
                    Player player = new(conn);
                    player.Show();
                }
                else MessageBox.Show("Fail");
                dr.Close();
            }

            dr.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            NewPlayerPage newPlayer = new(conn);
            newPlayer.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NewAdminPage newAdmin = new(conn);
            newAdmin.Show();
            //test form = new test(conn);
            //form.Show();
        }

        void ConnectDB()
        {
            string mysqlConn = "server=127.0.0.1; user=root; port=3310; database=sportsdb; password=";
            conn = new MySqlConnection(mysqlConn);

            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
