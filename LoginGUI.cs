using Microsoft.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class LoginGUI : Form

    {
        MainGUI maingui;

        public LoginGUI()
        {
            InitializeComponent();
        }

        SqlConnection link = new SqlConnection(@"Data Source=MEHMET;Initial Catalog=DbLibrary;Integrated Security=True;Trust Server Certificate=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            string password= null;

            try
            {
                link.Open();
                SqlCommand cmd = new SqlCommand("SELECT Password FROM Admin WHERE Username = @p1",link);
                cmd.Parameters.AddWithValue("@p1", textBoxUsername.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    password = reader[0].ToString();
                }
                if (password== textBoxPassword.Text)
                {
                 
                    label3.Text = "Succesful";
                    
                    maingui = new MainGUI();
                    maingui.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Username or Pasword invalid!");
                    textBoxUsername.Text = null;
                    textBoxPassword.Text = null; 
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Baðlantý Hatasý" + ex.Message);

            }
            finally { link.Close(); }
            
        }

        
    }
}
