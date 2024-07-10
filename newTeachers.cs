using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace MySchool
{
    public partial class NewTeachers : Form
    {

        private MySqlConnection connection;
        public NewTeachers()
        {
            InitializeComponent();
            InitializeDatabaseConnection();



        }

        private void InitializeDatabaseConnection()
        {
            try
            {
                string connectionString = "Server=localhost;Database=school24;Uid=root;";
                connection = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при свързване с базата данни: " + ex.Message);
            }
        }


        private void btn_save_Click(object sender, EventArgs e)
        {


            try
            {
                connection.Open();

                string username = textBoxusername.Text;
                string password = textBoxpassword.Text;

                string query = "INSERT INTO admins (username, password) VALUES (@username, @password)";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Данните са записани успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при записване на данните: " + ex.Message);
            }
            finally
            {
                if (connection.State == System.Data.ConnectionState.Open)
                    connection.Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
            

        }
    }

}
