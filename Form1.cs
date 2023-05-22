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
    public partial class Form1 : Form
    {

        DataBase dataBase = new DataBase();
        int selectedRow;

        public Form1()
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

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetValue(5), record.GetString(1), record.GetValue(0), record.GetString(3), record.GetString(2), record.GetValue(4));
        }

        private void RefreshDataGrid (DataGridView dgw)
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

        private void Form1_Load(object sender, EventArgs e)
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
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var title = textBoxTitle.Text;
            var rating = textBoxRating.Text;
            var content_rating = textBoxContRat.Text;
            var genre = textBoxGenre.Text;
            int duration;

            if(int.TryParse(textBoxDuration.Text, out duration))
            {
                try
                {
                   var addQuery = $"insert into Movies_table (rating, title, content_rating, genre, duration) values ('{rating}', '{title}', '{content_rating}', '{genre}', '{duration}')";

                    var command = new SqlCommand(addQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("Record successfully created!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } catch
                {
                    MessageBox.Show("Record not created! Incorrect rating format! You should use a dot!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            } else
            {
                MessageBox.Show("Record not created! Incorrect duration format!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
        }

        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string searchingString = $"select * from Movies_table where concat (rating, title, content_rating, genre, duration) like '%" + textBox_search.Text + "%'";

            SqlCommand command = new SqlCommand(searchingString, dataBase.getConnection());
            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
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
            int index = dataGridView1.CurrentCell.RowIndex;

            dataBase.openConnection();

            var id = Convert.ToInt32(textBoxId.Text);
            var deleteQuery = $"delete from Movies_table where id_film = '{id}'";
            var command = new SqlCommand(deleteQuery, dataBase.getConnection());
            command.ExecuteNonQuery();

            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var id = textBoxId.Text;
            var title = textBoxTitle.Text;
            var rating = textBoxRating.Text;
            var content_rating = textBoxContRat.Text;
            var genre = textBoxGenre.Text;
            int duration;

            //if (int.TryParse(textBoxDuration.Text, out duration))
            //{
            //    var addQuery = $"update Movies_table set rating = '""', title, content_rating, genre, duration values ('{rating}', '{title}', '{content_rating}', '{genre}', '{duration}')";

            //    var command = new SqlCommand(addQuery, dataBase.getConnection());
            //    command.ExecuteNonQuery();

            //    MessageBox.Show("Record successfully updated!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show("Record not updated!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
        }

    }

}
