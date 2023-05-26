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
    public partial class Users : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;

        public Users()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_user", "id");
            dataGridView1.Columns.Add("nickname_user", "Никнейм");
            dataGridView1.Columns.Add("age", "Возраст");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetValue(0), record.GetString(1), record.GetValue(2));
        }

        private void ClearFields()
        {
            textBoxIdUser.Text = "";
            textBoxNicknameUser.Text = "";
            textBoxAge.Text = "";
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Users";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
            dataBase.closeConnection();
        }

        private void FilmUsers_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];

                textBoxIdUser.Text = row.Cells[0].Value.ToString();
                textBoxNicknameUser.Text = row.Cells[1].Value.ToString();
                textBoxAge.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var nickameUser = textBoxNicknameUser.Text;
            int ageUser = int.Parse(textBoxAge.Text);
            
            if(ageUser >= 6)
            {
                if (nickameUser != string.Empty || ageUser.ToString() != string.Empty)
                {
                    try
                    {
                        var addQuery = $"insert into Users (nickname_user, age) values ('{nickameUser}', '{ageUser}')";

                        var command = new SqlCommand(addQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();

                        addQuery = $"insert into register (login_user, password_user, role) values ('{nickameUser}', 'egegrrg', 'user')";
                        command = new SqlCommand(addQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();

                        MessageBox.Show("Record successfully created!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Record not created!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Not all fields are filled in!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            } else
            {
                MessageBox.Show("The user must be over 6 years old!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchingString = $"select * from Users where concat (nickname_user, age) like '%" + textBox_search.Text + "%'";

            SqlCommand command = new SqlCommand(searchingString, dataBase.getConnection());
            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
            RefreshDataGrid(dataGridView1);
        }

        private void textBox_search_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var id = Convert.ToInt32(textBoxIdUser.Text);
            String nick = textBoxNicknameUser.Text;
            var deleteQuery = $"delete from Users where id_user = '{id}'";
            var command = new SqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();
            deleteQuery = $"delete from register where login_user = '{nick}'";
            command = new SqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
            MessageBox.Show("Record successfully deleted!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdUser.Text);
            dataBase.openConnection();

            var nickameUser = textBoxNicknameUser.Text;
            int age = int.Parse(textBoxAge.Text);

            if (age >= 6)
            {
                if (nickameUser != string.Empty || age.ToString() != string.Empty)
                {
                    try
                    {
                        var addQuery = $"update Users set nickname_user = '{nickameUser}', age = '{age}' where id_user = '{id}'";

                        var command = new SqlCommand(addQuery, dataBase.getConnection());
                        command.ExecuteNonQuery();

                        MessageBox.Show("Record successfully created!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Record not edited!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Not all fields are filled in!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("The user must be over 6 years old!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void textBoxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Show();
        }
    }
}