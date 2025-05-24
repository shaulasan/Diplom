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
    public partial class adminForm : Form
    {
        dataBase db = new dataBase();
        public adminForm(string logtb)
        {
            InitializeComponent();
            acc_lab.Text = logtb;
        }

        private int res()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            db.openConn();
            string query = $"use demo select user_permissions from users where user_login = '{acc_lab.Text}'";
            SqlCommand command = new SqlCommand(query, db.GetConnection());
            adapter.SelectCommand = command;
            int result = Convert.ToInt32(command.ExecuteScalar());
            db.closeConn();
            return result;
        }

        private void cls_but_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void arc_but_Click(object sender, EventArgs e)
        {
            archiveForm arcFrm = new archiveForm(res());
            arcFrm.ShowDialog();
        }
        
        private void upr_but_Click(object sender, EventArgs e)
        {
            if (res() == 0)
            {
                upravlenieForm uprFrm = new upravlenieForm();
                uprFrm.ShowDialog();
            }
            else
                MessageBox.Show("у вас не достаточно прав", "ошибка");
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
            Close();
        }

        private void otd_but_Click(object sender, EventArgs e)
        {
            otdelForm otdFrm = new otdelForm(res());
            otdFrm.ShowDialog();
        }

        private void otp_but_Click(object sender, EventArgs e)
        {
            otpuskaForm otpFrm = new otpuskaForm(res());
            otpFrm.ShowDialog();
        }

        private void pov_but_Click(object sender, EventArgs e)
        {
            povForm pForm = new povForm(res());
            pForm.ShowDialog();
        }

        private void prik_but_Click(object sender, EventArgs e)
        {
            prikForm prForm = new prikForm(res());
            prForm.ShowDialog();
        }

        private void sot_but_Click(object sender, EventArgs e)
        {
            sotrForm sotForm = new sotrForm(res());
            sotForm.ShowDialog();
        }
    }
}
