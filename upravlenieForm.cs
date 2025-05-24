using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_proj
{
    public partial class upravlenieForm : Form
    {
        dataBase db = new dataBase();
        public upravlenieForm()
        {
            InitializeComponent();
        }
        private void zapolnit()
        {
            string query = "use demo select * from users order by user_permissions";
            db.openConn();
            SqlCommand command = new SqlCommand(query, db.GetConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
            }

            reader.Close();
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
            db.closeConn();
        }
        private void upravlenieForm_Load(object sender, EventArgs e)
        {
            zapolnit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_tb.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            log_tb.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            pas_tb.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            per_tb.Text = dataGridView1[3, e.RowIndex].Value.ToString();
        }

        private void save_but_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            db.openConn();
            string query = $"use demo update users set user_id = {id_tb.Text}, user_login = '{log_tb.Text}', user_password = '{pas_tb.Text}', user_permissions = {per_tb.Text} where user_id = {id_tb.Text}";
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            db.closeConn();
            dataGridView1.Rows.Clear();
            zapolnit();
        }

        private void del_but_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            db.openConn();
            string query = $"use demo delete users where user_id = {id_tb.Text}";
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            db.closeConn();
            dataGridView1.Rows.Clear();
            zapolnit();
        }
    }
}
