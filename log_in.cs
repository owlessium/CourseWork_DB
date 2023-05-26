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
    public partial class log_in : Form
    {
        DataBase dataBase = new DataBase();

        public log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void log_in_load (object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '$';
            picture_show.Visible = false;
            textBox_login.MaxLength = 50;
            textBox_password.MaxLength = 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var loginUser = textBox_login.Text;
            var passUser = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String queryString = $"select * from register where login_user = '{loginUser}' and password_user = '{passUser}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("You have successfully logged in!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String nick = table.Rows[0].Field<string>(1);
                String role = table.Rows[0].Field<string>(3);
                

                if (role == "admin")
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();
                } else if (role == "user")
                {
                    int id = int.Parse(GetId(nick));
                    FormForUsers usersForm = new FormForUsers(id);
                    this.Hide();
                    usersForm.ShowDialog();
                } else if (role == "critic")
                {
                    int id = int.Parse(GetId(nick));
                    FormForUsers usersForm = new FormForUsers(id);
                    this.Hide();
                    usersForm.ShowDialog();
                }
            }
            else
                MessageBox.Show("There is no such account!", "The account doesn't exist!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        private string GetId(String nick)
        {
            String result = "";
            string queryString = $"select id_user from Users where nickname_user = '{nick}'";


            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                result = ReadSingleRow((IDataRecord)reader);
            }
            reader.Close();
            dataBase.closeConnection();
            return result;
        }

        private static String ReadSingleRow(IDataRecord record)
        {
            return record[0].ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            sign_up frm_sign = new sign_up();
            this.Hide();
            frm_sign.Show();
            this.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox_login.Text = "";
            textBox_password.Text = "";
        }

        private void log_in_Load_1(object sender, EventArgs e)
        {

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
    }
}
