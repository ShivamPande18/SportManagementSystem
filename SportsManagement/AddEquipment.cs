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
    public partial class AddEquipment : Form
    {
        MySqlConnection conn;
        string adminId;
        public AddEquipment(MySqlConnection myConn, string newId)
        {
            InitializeComponent();
            conn = myConn;
            adminId = newId;
            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from equipment";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "equipment");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void AddEquipment_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string eid = textBox1.Text;
            string mid = textBox2.Text;

            if (eid == "" || mid == "") {
                MessageBox.Show("Fill all the fields");
                return;
            }

            MySqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO `equipment` (`equip_id`, `match_id`, `admin_id`) VALUES ('"+eid+"', '"+mid+"', '"+adminId+"') ";
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserted");
                cmd.CommandText = "select * from equipment";
                MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "equipment");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
