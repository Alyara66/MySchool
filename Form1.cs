using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using MySql.Data.MySqlClient;

namespace MySchool
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            InitializeDatabaseConnection();

        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = "Server=localhost;Database= school24;User ID=root;Charset=utf8;";
            connection = new MySqlConnection(connectionString);
        }

        private void login_register_Click(object sender, EventArgs e)
        {
            Goust sForm = new Goust(this);
            sForm.Show();
            this.Hide();
        }

        private void login_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (login_chekpassword.Checked)
            {
                txtBox_password.PasswordChar = '\0';
            }
            else
            {
                txtBox_password.PasswordChar = '*';
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = txtBox_password.Text;
            if (AuthenticateUser(username, password))
            {
                MessageBox.Show("Login successful!");
                teachers_login mainForm = new teachers_login(this);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }
        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM admins WHERE username = @username AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    return true;
                }
                else
                {
                    reader.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private void label_registerteacher_Click(object sender, EventArgs e)
        {
            NewTeachers newTeacherForm = new NewTeachers();
            newTeacherForm.Show();
        }
    }
}
