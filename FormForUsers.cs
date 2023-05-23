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
    public partial class FormForUsers : Form
    {
        DataBase dataBase = new DataBase();
        int selectedRow;
        int myID;

        public FormForUsers(int id)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            myID = id;
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
            textBoxWatch.Text = "";
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

        private void FormForUsers_Load(object sender, EventArgs e)
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
                textBoxWatch.Text = GetWatched(dataGridView1);
                textBoxComment.Text = GetComment(dataGridView1);
            }
        }

        private string GetWatched(DataGridView dgw)
        {
            var id_film = textBoxId.Text;
            string queryString = $"select id_watching from Watching where id_user = '{myID}' AND id_film = '{id_film}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.HasRows)
            {
                dataBase.closeConnection();
                return "Watched";
            }

            reader.Close();
            dataBase.closeConnection();
            return "Not watched";
        }

        private string GetComment(DataGridView dgw)
        {
            String result = "";
            var id_film = textBoxId.Text;
            string queryString = $"select * from Comment where id_user = '{myID}' AND id_film = '{id_film}'";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());

            dataBase.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                Console.WriteLine("!!!!!!" + reader[0]);
                result = reader[0].ToString();
                dataBase.closeConnection();
                return result;
            }

            reader.Close();
            dataBase.closeConnection();
            return "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void btnWatchThisFilm_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();

            var id_film = textBoxId.Text;

            if(id_film != string.Empty)
            {
                try
                {
                    var addQuery = $"insert into Watching (id_user, id_film) values ('{myID}', '{id_film}')";

                    var command = new SqlCommand(addQuery, dataBase.getConnection());
                    command.ExecuteNonQuery();

                    MessageBox.Show("You've seen this movie!", "Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Error!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("No movie is selected!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            dataBase.closeConnection();
            RefreshDataGrid(dataGridView1);
            ClearFields();
        }

        private void btnComment_Click(object sender, EventArgs e)
        {

        }
    }
}
