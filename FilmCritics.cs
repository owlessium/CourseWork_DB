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
    public partial class FilmCritics : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;

        public FilmCritics()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_critic", "id");
            dataGridView1.Columns.Add("nickname_critic", "Никнейм");
            dataGridView1.Columns.Add("numberOfReviews", "Количество рецензий");

        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetValue(0), record.GetString(1), record.GetValue(2));
        }

        private void ClearFields()
        {
            textBoxIdCritic.Text = "";
            textBoxNicknameCritic.Text = "";
            textBoxNumReviews.Text = "";
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Film_critics";

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

        private void FilmCritics_Load(object sender, EventArgs e)
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

                textBoxIdCritic.Text = row.Cells[0].Value.ToString();
                textBoxNicknameCritic.Text = row.Cells[1].Value.ToString();
                textBoxNumReviews.Text = row.Cells[2].Value.ToString();
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

            var nickameCritic = textBoxNicknameCritic.Text;
            int numReviews = int.Parse(textBoxNumReviews.Text);

            if (nickameCritic != string.Empty || numReviews.ToString() != string.Empty)
            {
                try
                {
                    var addQuery = $"insert into Film_critics (nickname_critic, numberOfReviews) values ('{nickameCritic}', '{numReviews}')";

                    var command = new SqlCommand(addQuery, dataBase.getConnection());
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

            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }


        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchingString = $"select * from Film_critics where concat (nickname_critic, numberOfReviews) like '%" + textBox_search.Text + "%'";

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

            var id = Convert.ToInt32(textBoxIdCritic.Text);
            var deleteQuery = $"delete from Film_critics where id_critic = '{id}'";
            var command = new SqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxIdCritic.Text);
            dataBase.openConnection();

            var nickameCritic = textBoxNicknameCritic.Text;
            int numReviews = int.Parse(textBoxNumReviews.Text);

            if (nickameCritic != string.Empty || numReviews.ToString() != string.Empty)
            {
                try
                {
                    var addQuery = $"update Film_critics set nickname_critic = '{nickameCritic}', numberOfReviews = '{numReviews}' where id_critic = '{id}'";

                    var command = new SqlCommand(addQuery, dataBase.getConnection());
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

            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void textBoxNumReviews_KeyPress(object sender, KeyPressEventArgs e)
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
