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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using MySql.Data.MySqlClient;

namespace MySchool
{
    public partial class Goust : Form
    {
        private MySqlConnection connection;
        private Form1 loginForm1;

        public Goust(Form1 form1)
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            loginForm1 = form1;
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



        private void button1_Click(object sender, EventArgs e)
        {
            LoadCourses();

        }
        private void LoadCourses()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM courses";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                richTextBox2.Clear();
                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string name = reader["Name"].ToString();
                    string teacherId = reader["teacher_id"].ToString();
                    string description = reader["Description"].ToString();


                    richTextBox2.SelectionColor = Color.Black; // Връщане на цвета на текста на стандартния

             
                    richTextBox2.AppendText($"{id}; Курс: ");

                    // Задаване на цвета на текста за името на курса
                    richTextBox2.SelectionColor = Color.Blue;
                    richTextBox2.AppendText($"{name}");

                    // Връщане на цвета на текста на стандартния
                    richTextBox2.SelectionColor = Color.Black;

                    // останалата част от информацията
                    richTextBox2.AppendText($", Ръководител: {teacherId}, Преподаватели: {description}\n");
                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при зареждане на курсовете: " + ex.Message);
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm1.Show();
        }

        private void btn_teachers_Click(object sender, EventArgs e)
        {
            LoadTeachers();
        }
        private void LoadTeachers()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM teachers";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                richTextBox1.Clear();

                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string name = reader["name"].ToString();
                    string family = reader["family"].ToString();

                    richTextBox1.SelectionColor = Color.Black; // Връщане на цвета на текста на стандартния
                    richTextBox1.AppendText($" {id}- ");

                    richTextBox1.SelectionColor = Color.Black; // Задаване на цвета на текста за името на учителя
                    richTextBox1.AppendText($"{name}");

                    richTextBox1.SelectionColor = Color.Black; // Връщане на цвета на текста на стандартния
                    richTextBox1.AppendText($" {family}\n");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при зареждане на учителите: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox4.Visible )
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if (pictureBox5.Visible )
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
            else if (pictureBox6.Visible )
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
            }
            else if (pictureBox7.Visible )
            {
                pictureBox7.Visible = false;
                pictureBox4.Visible = true;
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            timer1.Start();
            pictureBox4.Visible = true;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
        }
    }
}
