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
    public partial class otdelForm : Form
    {
        dataBase db = new dataBase();
        int lvl = 0;
        
        public otdelForm(int res)
        {
            InitializeComponent();
            lvl = res;
        }

        private void zapolnit()
        {
            dataGridView1.Rows.Clear();
            string query = "use otdel_kadrov select * from Отделы order by ID_Отдела";
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

        private void save_but_Click(object sender, EventArgs e)
        {
            if (lvl < 2)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                db.openConn();
                string query = $"use otdel_kadrov update Отделы set ID_Отдела = {id_tb.Text}, Название = '{name_tb.Text}', Руководитель = '{ruc_tb.Text}', Электронная_почта_отдела = '{email_tb.Text}' where ID_Отдела = {id_tb.Text}";
                SqlCommand command = new SqlCommand(query, db.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                
                dataGridView1.Rows.Clear();
                zapolnit();
            }
            else
                MessageBox.Show("у вас не достаточно прав", "ошибка");
        }

        private void del_but_Click(object sender, EventArgs e)
        {
            if (lvl < 2)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                db.openConn();
                string query = $"use otdel_kadrov delete Отделы where ID_Отдела = {id_tb.Text}";
                SqlCommand command = new SqlCommand(query, db.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                
                dataGridView1.Rows.Clear();
                zapolnit();
            }
            else
                MessageBox.Show("у вас не достаточно прав", "ошибка");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_tb.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            name_tb.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            ruc_tb.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            email_tb.Text = dataGridView1[3, e.RowIndex].Value.ToString();
        }

        private void otdelForm_Load(object sender, EventArgs e)
        {
            db.openConn();
            zapolnit();
        }

        private void add_but_Click(object sender, EventArgs e)
        {
            if (lvl < 2)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                db.openConn();
                string query = $"use otdel_kadrov insert into Отделы(ID_Отдела, Название, Руководитель, Электронная_почта_отдела) values({id_tb.Text}, '{name_tb.Text}', '{ruc_tb.Text}', '{email_tb.Text}')";
                SqlCommand command = new SqlCommand(query, db.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                
                dataGridView1.Rows.Clear();
                zapolnit();
            }
            else
                MessageBox.Show("у вас не достаточно прав", "ошибка");
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"use otdel_kadrov select * from Отделы where concat (ID_Отдела, Название, Руководитель, Электронная_почта_отдела) like '%" + textBox1.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, db.GetConnection());

            db.openConn();

            SqlDataReader read = com.ExecuteReader();
            List<string[]> list = new List<string[]>();
            while (read.Read())
            {
                dgw.Rows.Clear();
                list.Add(new string[4]);

                list[list.Count - 1][0] = read[0].ToString();
                list[list.Count - 1][1] = read[1].ToString();
                list[list.Count - 1][2] = read[2].ToString();
                list[list.Count - 1][3] = read[3].ToString();

                foreach (string[] s in list)
                    dataGridView1.Rows.Add(s);
            }

            read.Close();
            db.closeConn();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            { 
                db.openConn();
                zapolnit();
            }
            else
                Search(dataGridView1);
        }
    }
}