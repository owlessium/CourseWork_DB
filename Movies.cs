using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SD = System.Data;
using System.Data.SqlClient;

namespace CourseWork
{
    public partial class Movies : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;

        public Movies()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_film", "id");
            dataGridView1.Columns.Add("title", "Название");
            dataGridView1.Columns.Add("rating", "Рейтинг");
            dataGridView1.Columns.Add("genre", "Жанр");
            dataGridView1.Columns.Add("content_rating", "Возрастное ограничение");
            dataGridView1.Columns.Add("duration", "Продолжительность (в мин.)");
        }

        private void ReadSingleRow(DataGridView dgv, IDataRecord record)
        {
            dgv.Rows.Add(record.GetValue(5), record.GetString(1), record.GetValue(0), record.GetString(3), record.GetString(2), record.GetValue(4));
        }

        private void ClearFields()
        {
            textBoxId.Text = "";
            textBoxTitle.Text = "";
            textBoxRating.Text = "";
            textBoxContRat.Text = "";
            textBoxGenre.Text = "";
            textBoxDuration.Text = "";
        }

        private void RefreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"select * from Movies_table";

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

        private void Movies_Load(object sender, EventArgs e)
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

                textBoxId.Text = row.Cells[0].Value.ToString();
                textBoxTitle.Text = row.Cells[1].Value.ToString();
                textBoxRating.Text = row.Cells[2].Value.ToString();
                textBoxDuration.Text = row.Cells[5].Value.ToString();
                textBoxContRat.Text = row.Cells[4].Value.ToString();
                textBoxGenre.Text = row.Cells[3].Value.ToString();
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

            var title = textBoxTitle.Text;
            var rating = textBoxRating.Text;
            var content_rating = textBoxContRat.Text;
            var genre = textBoxGenre.Text;
            int duration = -1;

            if (int.TryParse(textBoxDuration.Text, out duration) || title != string.Empty || rating != string.Empty || content_rating != string.Empty || genre != string.Empty)
            {
                try
                {
                    var addQuery = $"insert into Movies_table (rating, title, content_rating, genre, duration) values ('{rating}', '{title}', '{content_rating}', '{genre}', '{duration}')";

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

            string searchingString = $"select * from Movies_table where concat (rating, title, content_rating, genre, duration) like '%" + textBox_search.Text + "%'";

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

            var id = Convert.ToInt32(textBoxId.Text);
            var deleteQuery = $"delete from Movies_table where id_film = '{id}'";
            var command = new SqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
            MessageBox.Show("Record successfully deleted!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            dataBase.openConnection();

            var title = textBoxTitle.Text;
            var rating = textBoxRating.Text;
            var content_rating = textBoxContRat.Text;
            var genre = textBoxGenre.Text;
            int duration = -1;


            if (int.TryParse(textBoxDuration.Text, out duration) && title != string.Empty &&  rating != string.Empty && content_rating != string.Empty && genre != string.Empty)
            {
                try
                {
                    var editQuery = $"update Movies_table set rating = '{rating}', title = '{title}', content_rating = '{content_rating}', genre = '{genre}', duration = '{duration}' where id_film = '{id}'";

                    var command = new SqlCommand(editQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Record successfully edited!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void textBoxRating_KeyPress(object sender, KeyPressEventArgs e)
        {
            // разрешить ввод цифр, точки и запятой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)
                && (e.KeyChar != '.') && (e.KeyChar != ','))
            { 
                e.Handled = true;
            }

            if ((e.KeyChar == '.') || (e.KeyChar == ','))
            {
                e.KeyChar = '.';
                if ((sender as TextBox).Text.IndexOf('.') > -1 || (sender as TextBox).Text.IndexOf(',') > -1)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            this.Hide();
            menu.ShowDialog();
            this.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
