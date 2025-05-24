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
    public partial class Form1 : Form
    {
        dataBase db = new dataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void reg_but_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            db.openConn();
            if(logtb.Text.Length > 0 && passtb.Text.Length > 0)
            {
                string query = $"use demo select * from users where user_login = '{logtb.Text}'";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("такой акканут уже есть", "ашибка");
                }
                else
                {
                    query = $"use demo select max(user_id) from users";
                    cmd.CommandText = query;
                    adapter.SelectCommand = cmd;
                    object res = cmd.ExecuteScalar();
                    int tempId = Convert.ToInt32(res);

                    query = $"insert into users(user_id, user_login, user_password, user_permissions) values({tempId+1}, '{logtb.Text}', '{passtb.Text}', 2)";
                    cmd.CommandText = query;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(dt);

                    MessageBox.Show("вы успешно зарегались, " + logtb.Text, "успех");

                    logtb.Text = string.Empty;
                    passtb.Text = string.Empty;
                }
                
            }
            db.closeConn();
        }

        private void log_but_Click(object sender, EventArgs e)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();

            if (logtb.Text.Length > 0 && passtb.Text.Length > 0)
            {
                string query = $"select * from users where user_login = '{logtb.Text}' and user_password = '{passtb.Text}'";
                SqlCommand cmd = new SqlCommand(query, db.GetConnection());

                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("привет " + logtb.Text + "!", "вы успешно вошли");
                    adminForm admFrm = new adminForm(logtb.Text);
                    this.Hide();
                    admFrm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("ошибка");
                }

            }
            db.closeConn();
        }

        private void cls_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
