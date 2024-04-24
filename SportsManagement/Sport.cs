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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace SportsManagement
{
    public partial class Sport : Form
    {
        MySqlConnection conn;
        String adminId;
        public Sport(MySqlConnection newCon, string newId)
        {
            InitializeComponent();
            conn = newCon;
            adminId = newId;
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "sport";
            cmd.CommandText = "select * from " + selected;
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "sport";
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
            cmd.CommandText = "SELECT s.sport_name, s.type\r\nFROM sport s\r\nINNER JOIN admin a ON s.admin_id = a.admin_id\r\nWHERE a.admin_id = " + adminId + ";";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = conn.CreateCommand();
            String selected = "manager";
            cmd.CommandText = "SELECT Sport.sport_name, Sport.type, Admin.name AS Admin_Name\r\nFROM Sport\r\nINNER JOIN Admin ON Sport.admin_id = Admin.admin_id;";
            MySqlDataAdapter da = new MySqlDataAdapter(cmd.CommandText, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, selected);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Sport_Load(object sender, EventArgs e)
        {

        }
    }
}
