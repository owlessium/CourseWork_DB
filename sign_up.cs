using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class sign_up : Form
    {
        DataBase dataBase = new DataBase();

        public sign_up()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void sign_up_load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '$';
            picture_show.Visible = false;
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
        }

        private void picture_show_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = false;
            picture_show.Visible = false;
            picture_hide.Visible = true;
        }

        private void picture_hide_Click(object sender, EventArgs e)
        {
            textBox_password.UseSystemPasswordChar = true;
            picture_show.Visible = true;
            picture_hide.Visible = false;
        }

        private Boolean checkUser()
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string qyeryString = $"select * from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(qyeryString, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("The user already exists!");
                return true;
            }
            else
                return false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (checkUser())

            {
                return;
            }

            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;
            var roleUser = comboBoxRole.Text;

            String queryString = $"insert into register(login_user, password_user, role) values ('{loginUser}', '{passUser}', '{roleUser}')";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            if (loginUser == "" || passUser == "" || roleUser == "")
            {
                MessageBox.Show("Account successfully created!", "Successfully!");
                log_in frm_login = new log_in();
                this.Hide();
                frm_login.ShowDialog();
            } else
                MessageBox.Show("Account not created!");
            dataBase.closeConnection();

        }
    }
}
