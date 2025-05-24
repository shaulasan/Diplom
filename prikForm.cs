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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace demo_proj
{
    public partial class prikForm : Form
    {
        dataBase db = new dataBase();
        int lvl = 0;
        public prikForm(int res)
        {
            InitializeComponent();
            lvl = res;
        }

        private void zapolnit()
        {
            dataGridView1.Rows.Clear();
            string query = "use otdel_kadrov select * from Приказы order by ID_Приказа";
            SqlCommand command = new SqlCommand(query, db.GetConnection());

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }

            reader.Close();
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
            db.closeConn();
        }

        private void prikForm_Load(object sender, EventArgs e)
        {
            db.openConn();
            zapolnit();
        }

        private void save_but_Click(object sender, EventArgs e)
        {
            if (lvl < 2)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                db.openConn();
                string query = $"use otdel_kadrov update Приказы set НомерПриказа = '{nom_tb.Text}', ДатаПриказа = '{date_tb.Text}', ТипПриказа = '{type_tb.Text}', Описание = '{desc_tb.Text}', ID_Сотрудника = {id_tb.Text} where ID_Приказа = {idPrik_tb.Text}";
                SqlCommand command = new SqlCommand(query, db.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                
                dataGridView1.Rows.Clear();
                zapolnit();
                db.closeConn();
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
                string query = $"use otdel_kadrov delete Приказы where ID_Приказа = {idPrik_tb.Text}";
                SqlCommand command = new SqlCommand(query, db.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dt);

                dataGridView1.Rows.Clear();
                zapolnit();
                db.closeConn();
            }
            else
                MessageBox.Show("у вас не достаточно прав", "ошибка");
        }

        private void add_but_Click(object sender, EventArgs e)
        {
            if (lvl < 2)
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable dt = new DataTable();
                db.openConn();
                string query = $"use otdel_kadrov insert into Приказы(НомерПриказа, ДатаПриказа, ТипПриказа, Описание, ID_Сотрудника) values({nom_tb.Text}, '{date_tb.Text}', '{type_tb.Text}', '{desc_tb.Text}', '{id_tb.Text}')";
                SqlCommand command = new SqlCommand(query, db.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dt);
          
                dataGridView1.Rows.Clear();
                zapolnit();
                db.closeConn();
            }
            else
                MessageBox.Show("у вас не достаточно прав", "ошибка");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idPrik_tb.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            nom_tb.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            date_tb.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            type_tb.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            desc_tb.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            id_tb.Text = dataGridView1[5, e.RowIndex].Value.ToString();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchString = $"use otdel_kadrov select * from Приказы where concat (ID_Приказа, НомерПриказа, ДатаПриказа, ТипПриказа, Описание, ID_Сотрудника) like '%" + textBox1.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, db.GetConnection());

            db.openConn();

            SqlDataReader read = com.ExecuteReader();
            List<string[]> list = new List<string[]>();
            while (read.Read())
            {
                dgw.Rows.Clear();
                list.Add(new string[6]);

                list[list.Count - 1][0] = read[0].ToString();
                list[list.Count - 1][1] = read[1].ToString();
                list[list.Count - 1][2] = read[2].ToString();
                list[list.Count - 1][3] = read[3].ToString();
                list[list.Count - 1][4] = read[4].ToString();
                list[list.Count - 1][5] = read[5].ToString();

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
