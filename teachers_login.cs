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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.EntityFrameworkCore;

namespace MySchool
{
    public partial class teachers_login : Form
    {
        private MySqlConnection connection;
        private Form1 loginForm;

        public teachers_login(Form1 form1)
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            loginForm = form1;
            PopulateComboBox();
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

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm.Show(); 
        }

        private void students_btn_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }
        private void LoadStudents()
        {
            try
            {
                connection.Open();
                string query = "SELECT id, name, family, birthday, course_id, number FROM students";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                richTextBox_Student.Clear();
                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string name = reader["name"].ToString();
                    string family = reader["family"].ToString();
                    string birthday = reader["birthday"].ToString();
                    string courseId = reader["course_id"].ToString();
                    string number = reader["number"].ToString();



                    richTextBox_Student.SelectionColor = Color.Black; // Връщане на цвета на текста на стандартния

                    
                    richTextBox_Student.AppendText($"{id} - Име:"); // Добавяне на данните към RichTextBox с различен цвят за определени части

                    // Задаване на цвета на текста за името на курса
                    richTextBox_Student.SelectionColor = Color.MediumBlue;
                    richTextBox_Student.AppendText($" {name} {family}");

                    
                    richTextBox_Student.SelectionColor = Color.Black;

                    
                    richTextBox_Student.AppendText($"; Рожден ден:  {birthday};  Курс: {courseId};  Тел. номер - {number}\n");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при зареждане на учениците: " + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }



        private void courses_btn_Click(object sender, EventArgs e)
        {


            LoadCourses1();

        }

        private void LoadCourses1()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM courses";
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                richTextBox_courses.Clear();
                while (reader.Read())
                {
                    string id = reader["id"].ToString();
                    string name = reader["Name"].ToString();



                    richTextBox_courses.SelectionColor = Color.Black; // Връщане на цвета на текста на стандартния

                    
                    richTextBox_courses.AppendText($"    {id}- Курс: ");

                    // Задаване на цвета на текста за името на курса
                    richTextBox_courses.SelectionColor = Color.MediumBlue;
                    richTextBox_courses.AppendText($"{name}");

                    
                    richTextBox_courses.SelectionColor = Color.Black;


                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при зареждане на курсовете: " + ex.Message);
            }
        }

        private void buttonSave_Click_Click(object sender, EventArgs e)
        {


            try
            {
                connection.Open();

                string name = textBox_name.Text;
                string family = textBox_family.Text;
                string number = textBox_number.Text;
                string courseId = comboBox_courses.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(courseId))
                {
                    MessageBox.Show("Моля, изберете валиден курс.");
                    return;
                }
               

                string birthday = dateTimePicker1.Value.ToString("yyyy-MM-dd");

                string query = "INSERT INTO students (name, family, birthday, course_id, number) VALUES (@name, @family, @birthday, @course_id, @number)";
                MySqlCommand cmd = new MySqlCommand(query, connection);


                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@family", family);
                cmd.Parameters.AddWithValue("@birthday", birthday);
                cmd.Parameters.AddWithValue("@course_id", courseId);
                cmd.Parameters.AddWithValue("@number", number);

                cmd.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Ученикът е добавен успешно!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при записване на ученика: " + ex.Message);
            }

        }

      

        private void PopulateComboBox()
        {
            try
            {
                connection.Open();

                
                string query = "SELECT DISTINCT course_id FROM students";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                // Изпълнявам  заявката и извличам  данните
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // Добавям  курсовете в ComboBox
                    comboBox_courses.Items.Add(dr["course_id"].ToString());
                }

                
                dr.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при зареждане на данните: " + ex.Message);
            }
            finally
            {
                // Затварям
                //
                // връзката
                if (connection.State == ConnectionState.Open)
                    connection.Close();
            }
        }


    }
    
}
