namespace MySchool
{
    partial class teachers_login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teachers_login));
            panel1 = new Panel();
            buttonSave_Click = new Button();
            textBox_number = new TextBox();
            label10 = new Label();
            label9 = new Label();
            ID_student = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            comboBox_courses = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            textBox_family = new TextBox();
            textBox_name = new TextBox();
            courses_btn = new Button();
            richTextBox_courses = new RichTextBox();
            students_btn = new Button();
            richTextBox_Student = new RichTextBox();
            buttonLogout = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(buttonSave_Click);
            panel1.Controls.Add(textBox_number);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(ID_student);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(comboBox_courses);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox_family);
            panel1.Controls.Add(textBox_name);
            panel1.Controls.Add(courses_btn);
            panel1.Controls.Add(richTextBox_courses);
            panel1.Controls.Add(students_btn);
            panel1.Controls.Add(richTextBox_Student);
            panel1.Controls.Add(buttonLogout);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(-15, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(850, 532);
            panel1.TabIndex = 2;
            // 
            // buttonSave_Click
            // 
            buttonSave_Click.BackColor = Color.PeachPuff;
            buttonSave_Click.Font = new Font("Monotype Corsiva", 11.25F, FontStyle.Italic);
            buttonSave_Click.Location = new Point(634, 362);
            buttonSave_Click.Name = "buttonSave_Click";
            buttonSave_Click.Size = new Size(132, 38);
            buttonSave_Click.TabIndex = 20;
            buttonSave_Click.Text = "Добави ученик";
            buttonSave_Click.UseVisualStyleBackColor = false;
            buttonSave_Click.Click += buttonSave_Click_Click;
            // 
            // textBox_number
            // 
            textBox_number.Location = new Point(634, 305);
            textBox_number.Name = "textBox_number";
            textBox_number.Size = new Size(130, 23);
            textBox_number.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Monotype Corsiva", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label10.ForeColor = Color.Firebrick;
            label10.Location = new Point(646, 280);
            label10.Name = "label10";
            label10.Size = new Size(105, 22);
            label10.TabIndex = 18;
            label10.Text = "Тел. номер";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Monotype Corsiva", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label9.ForeColor = Color.Firebrick;
            label9.Location = new Point(589, 134);
            label9.Name = "label9";
            label9.Size = new Size(118, 22);
            label9.TabIndex = 17;
            label9.Text = "id на ученика";
            // 
            // ID_student
            // 
            ID_student.Location = new Point(563, 133);
            ID_student.Name = "ID_student";
            ID_student.Size = new Size(20, 23);
            ID_student.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.MediumBlue;
            dateTimePicker1.CustomFormat = "dd-MM-yyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(708, 245);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(130, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Monotype Corsiva", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label7.ForeColor = Color.Firebrick;
            label7.Location = new Point(708, 220);
            label7.Name = "label7";
            label7.Size = new Size(124, 22);
            label7.TabIndex = 14;
            label7.Text = "Рождена дата";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Monotype Corsiva", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.Firebrick;
            label5.Location = new Point(563, 220);
            label5.Name = "label5";
            label5.Size = new Size(50, 22);
            label5.TabIndex = 13;
            label5.Text = "Курс";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Monotype Corsiva", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Firebrick;
            label4.Location = new Point(708, 169);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 12;
            label4.Text = "Фамилия";
            // 
            // comboBox_courses
            // 
            comboBox_courses.FormattingEnabled = true;
            comboBox_courses.Location = new Point(563, 245);
            comboBox_courses.Name = "comboBox_courses";
            comboBox_courses.Size = new Size(121, 23);
            comboBox_courses.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Monotype Corsiva", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(563, 169);
            label2.Name = "label2";
            label2.Size = new Size(45, 22);
            label2.TabIndex = 10;
            label2.Text = "Име";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(612, 85);
            label1.Name = "label1";
            label1.Size = new Size(198, 24);
            label1.TabIndex = 9;
            label1.Text = "Запиши нов ученик";
            // 
            // textBox_family
            // 
            textBox_family.Location = new Point(708, 194);
            textBox_family.Name = "textBox_family";
            textBox_family.Size = new Size(120, 23);
            textBox_family.TabIndex = 8;
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(563, 194);
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(130, 23);
            textBox_name.TabIndex = 7;
            // 
            // courses_btn
            // 
            courses_btn.BackColor = Color.PeachPuff;
            courses_btn.Font = new Font("Monotype Corsiva", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            courses_btn.Location = new Point(315, 85);
            courses_btn.Name = "courses_btn";
            courses_btn.Size = new Size(146, 42);
            courses_btn.TabIndex = 6;
            courses_btn.Text = "Курсове";
            courses_btn.UseVisualStyleBackColor = false;
            courses_btn.Click += courses_btn_Click;
            // 
            // richTextBox_courses
            // 
            richTextBox_courses.Location = new Point(284, 133);
            richTextBox_courses.Name = "richTextBox_courses";
            richTextBox_courses.Size = new Size(263, 205);
            richTextBox_courses.TabIndex = 5;
            richTextBox_courses.Text = "";
            // 
            // students_btn
            // 
            students_btn.BackColor = Color.PeachPuff;
            students_btn.Font = new Font("Monotype Corsiva", 12F, FontStyle.Italic, GraphicsUnit.Point, 204);
            students_btn.Location = new Point(64, 85);
            students_btn.Name = "students_btn";
            students_btn.Size = new Size(156, 42);
            students_btn.TabIndex = 4;
            students_btn.Text = "Данни на учениците";
            students_btn.UseVisualStyleBackColor = false;
            students_btn.Click += students_btn_Click;
            // 
            // richTextBox_Student
            // 
            richTextBox_Student.Location = new Point(21, 133);
            richTextBox_Student.Name = "richTextBox_Student";
            richTextBox_Student.Size = new Size(257, 396);
            richTextBox_Student.TabIndex = 3;
            richTextBox_Student.Text = "";
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.LightBlue;
            buttonLogout.Location = new Point(697, 483);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(130, 27);
            buttonLogout.TabIndex = 3;
            buttonLogout.Text = "Начална страница";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(850, 68);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(662, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 35);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Monotype Corsiva", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(87, 17);
            label6.Name = "label6";
            label6.Size = new Size(219, 55);
            label6.TabIndex = 3;
            label6.Text = "Национално музикално училище       \" Недялка Симеонова\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Snow;
            label8.Location = new Point(699, 20);
            label8.Name = "label8";
            label8.Size = new Size(96, 17);
            label8.TabIndex = 2;
            label8.Text = "089 3456 867";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Snow;
            label3.Location = new Point(699, 37);
            label3.Name = "label3";
            label3.Size = new Size(139, 16);
            label3.TabIndex = 4;
            label3.Text = "n.Simeonova@nmu.bg";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._131;
            pictureBox3.Location = new Point(294, 344);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(296, 185);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // teachers_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(835, 528);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "teachers_login";
            Text = "teachers_login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label6;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label3;
        private Button buttonLogout;
        private RichTextBox richTextBox_Student;
        private Button students_btn;
        private Button courses_btn;
        private RichTextBox richTextBox_courses;
        private TextBox textBox_family;
        private TextBox textBox_name;
        private Label label7;
        private Label label5;
        private Label label4;
        private ComboBox comboBox_courses;
        private Label label2;
        private Label label1;
        private DateTimePicker dateTimePicker1;
        private TextBox ID_student;
        private TextBox textBox_number;
        private Label label10;
        private Label label9;
        private Button buttonSave_Click;
        private PictureBox pictureBox3;
    }
}