using Microsoft.Data.SqlClient;
using System.Data;



namespace LibraryManagementSystem
{
    public partial class MainGUI : Form

    {

        public MainGUI()
        {
            InitializeComponent();
        }
        SqlConnection link = new SqlConnection(@"Data Source=MEHMET;Initial Catalog=DbLibrary;Integrated Security=True;Trust Server Certificate=True");

        private void buttonUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                link.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Books SET BookName = @p1, AuthorName = @p2 , AuthorSurname = @p3, ISBN = @p4, BookGenre = @p5 WHERE ID =@P6", link);

                cmd.Parameters.AddWithValue("@p1", textBoxBookName.Text);
                cmd.Parameters.AddWithValue("@p2", textBoxAuthorName.Text);
                cmd.Parameters.AddWithValue("@p3", textBoxAuthorSurname.Text);
                cmd.Parameters.AddWithValue("@p4", textBoxISBN.Text);
                cmd.Parameters.AddWithValue("@p5", textBoxBookGenre.Text);
                cmd.Parameters.AddWithValue("@p6", labelBookId.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred " + ex.Message);
            }
            finally { link.Close(); }
            showData();
        }

        private void showData()
        {
            try
            {
                string q = "SELECT * FROM Books ";
                SqlDataAdapter adapter = new SqlDataAdapter(q, link);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewBookList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred " + ex.Message);
            }


        }

        private void MainGUI_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void buttonAddNewBook_Click(object sender, EventArgs e)
        {
            try
            {
                link.Open();

                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Books WHERE ISBN = @isbn", link);
                checkCmd.Parameters.AddWithValue("@isbn", textBoxISBN.Text);

                int existingCount = (int)checkCmd.ExecuteScalar();

                if (existingCount > 0)
                {
                    MessageBox.Show("There is already a book registered with this ISBN.");
                    return;
                }


                SqlCommand cmd = new SqlCommand("INSERT INTO Books" +
                "(BookName,AuthorName,AuthorSurname,ISBN,State,BookGenre) VALUES (@p1,@p2,@p3,@p4,@p5,@p6)", link);


                cmd.Parameters.AddWithValue("@p1", textBoxBookName.Text);
                cmd.Parameters.AddWithValue("@p2", textBoxAuthorName.Text);
                cmd.Parameters.AddWithValue("@p3", textBoxAuthorSurname.Text);
                cmd.Parameters.AddWithValue("@p4", textBoxISBN.Text);
                cmd.Parameters.AddWithValue("@p5", "True");
                cmd.Parameters.AddWithValue("@p6", textBoxBookGenre.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("The book has been added successfully.");

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the book, please check the information again! " + ex.Message);
            }
            finally
            {
                link.Close();
            }
            showData();
        }

        private void dataGridViewBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelFee.Text = "0";
            int selectedRow = dataGridViewBookList.SelectedCells[0].RowIndex;

            labelBookId.Text = dataGridViewBookList.Rows[selectedRow].Cells[0].Value.ToString();
            textBoxBookName.Text = dataGridViewBookList.Rows[selectedRow].Cells[1].Value.ToString();
            textBoxAuthorName.Text = dataGridViewBookList.Rows[selectedRow].Cells[2].Value.ToString();
            textBoxAuthorSurname.Text = dataGridViewBookList.Rows[selectedRow].Cells[3].Value.ToString();
            textBoxISBN.Text = dataGridViewBookList.Rows[selectedRow].Cells[4].Value.ToString();
            textBoxBookGenre.Text = dataGridViewBookList.Rows[selectedRow].Cells[8].Value.ToString();

            textBoxBarrower.Text = dataGridViewBookList.Rows[selectedRow].Cells[6].Value.ToString();
            if (dataGridViewBookList.Rows[selectedRow].Cells[7].Value != System.DBNull.Value)
                dateTimePickerLendingDate.Value = (DateTime)dataGridViewBookList.Rows[selectedRow].Cells[7].Value;
        }

        private void buttonLendBook_Click(object sender, EventArgs e)
        {
            try
            {
                link.Open();
                SqlCommand cmd = new SqlCommand("UPDATE Books SET Barrower = @p1, LoanDate = @p2 , State = @p3  WHERE ID =@P4", link);

                cmd.Parameters.AddWithValue("@p1", textBoxBarrower.Text);
                cmd.Parameters.Add("p2", SqlDbType.Date).Value = dateTimePickerLendingDate.Value.Date;
                cmd.Parameters.AddWithValue("@p3", "False");

                cmd.Parameters.AddWithValue("@p4", labelBookId.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred " + ex.Message);
            }
            finally { link.Close(); }
            showData();
        }

        private void buttonCalculateFee_Click(object sender, EventArgs e)
        {
            if (labelBookId.Text != "-")
            {
                DateTime today = DateTime.Now;
                int totalDays = (int)(today - dateTimePickerLendingDate.Value.Date).TotalDays;
                if (totalDays > 10)
                {
                    int fee = (totalDays - 10) * 1;
                    labelFee.Text = totalDays.ToString();
                }


            }
        }

        private void buttonTakeBook_Click(object sender, EventArgs e)
        {
            if (labelBookId.Text != "-")
            {
                try
                {
                    link.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Books SET Barrower = @p1, LoanDate = @p2 , State = @p3  WHERE ID =@P4", link);

                    cmd.Parameters.AddWithValue("@p1", "");
                    cmd.Parameters.Add("p2", SqlDbType.Date).Value = DBNull.Value;
                    cmd.Parameters.AddWithValue("@p3", "True");

                    cmd.Parameters.AddWithValue("@p4", labelBookId.Text);
                    textBoxBarrower.Text = "";
                    dateTimePickerLendingDate.Value = DateTime.Now.Date;

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred " + ex.Message);
                }
                finally { link.Close(); }
                showData();


            }
        }
        private void clearTextBoxs()
        {

            labelBookId.Text = "-";
            textBoxBookName.Text = "";
            textBoxAuthorName.Text = "";
            textBoxAuthorSurname.Text = "";
            textBoxISBN.Text = "";
            textBoxBookGenre.Text = "";
            textBoxBarrower.Text = "";
            dateTimePickerLendingDate.Value = DateTime.Now.Date;
            showData();
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            clearTextBoxs();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            showSearchData();
        }
        private void showSearchData()
        {
            try
            {
                string q = "SELECT* FROM Books WHERE BookName LIKE '" + textBoxBookName.Text
                                                                        + "%' AND AuthorName LIKE '" + textBoxAuthorName.Text + "%' "
                                                                         + " AND AuthorSurname LIKE '" + textBoxAuthorSurname.Text + "%' "
                                                                          + " AND ISBN LIKE '" + textBoxISBN.Text + "%' "
                                                                           + " AND BookGenre LIKE '" + textBoxBookGenre.Text + "%' "
                                                                            + " AND Barrower LIKE '" + textBoxBarrower.Text + "%' ";



                SqlDataAdapter adapter = new SqlDataAdapter(q, link);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    dataGridViewBookList.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred " + ex.Message);
            }


        }

        private void buttonDeleteBook_Click(object sender, EventArgs e)
        {
            if (labelBookId.Text == "-" || labelBookId.Text == "")
            {
                MessageBox.Show("Please choose a book! ");
            }
            else
            {
                try
                {
                    link.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Books WHERE ID = @P1", link);

                    cmd.Parameters.AddWithValue("@p1", labelBookId.Text);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred " + ex.Message);
                }
                finally { link.Close(); }
                clearTextBoxs();
                showData();

            }
        }

        private void MainGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
