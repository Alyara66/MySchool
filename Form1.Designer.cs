namespace MySchool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            login_close = new Label();
            login_register = new Label();
            label4 = new Label();
            login_chekpassword = new CheckBox();
            login_btn = new Button();
            txtBox_password = new TextBox();
            label3 = new Label();
            textBoxUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            label_registerteacher = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label_registerteacher);
            panel1.Controls.Add(login_close);
            panel1.Controls.Add(login_register);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(login_chekpassword);
            panel1.Controls.Add(login_btn);
            panel1.Controls.Add(txtBox_password);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBoxUsername);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 358);
            panel1.TabIndex = 0;
            // 
            // login_close
            // 
            login_close.AutoSize = true;
            login_close.Cursor = Cursors.Hand;
            login_close.ForeColor = SystemColors.ControlDark;
            login_close.Location = new Point(427, 9);
            login_close.Name = "login_close";
            login_close.Size = new Size(14, 15);
            login_close.TabIndex = 10;
            login_close.Text = "X";
            login_close.Click += login_close_Click;
            // 
            // login_register
            // 
            login_register.AutoSize = true;
            login_register.Cursor = Cursors.Hand;
            login_register.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            login_register.ForeColor = Color.DarkRed;
            login_register.Location = new Point(320, 303);
            login_register.Name = "login_register";
            login_register.Size = new Size(107, 15);
            login_register.TabIndex = 9;
            login_register.Text = "Влез като гост";
            login_register.Click += login_register_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.Coral;
            label4.Location = new Point(218, 303);
            label4.Name = "label4";
            label4.Size = new Size(106, 16);
            label4.TabIndex = 8;
            label4.Text = "Нямаш акаунт?";
            // 
            // login_chekpassword
            // 
            login_chekpassword.AutoSize = true;
            login_chekpassword.Font = new Font("Rockwell", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            login_chekpassword.ForeColor = Color.Coral;
            login_chekpassword.Location = new Point(343, 189);
            login_chekpassword.Name = "login_chekpassword";
            login_chekpassword.Size = new Size(107, 21);
            login_chekpassword.TabIndex = 7;
            login_chekpassword.Text = "Покажи парола";
            login_chekpassword.UseVisualStyleBackColor = true;
            login_chekpassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.Coral;
            login_btn.Cursor = Cursors.Hand;
            login_btn.Font = new Font("Rockwell", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(218, 213);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(106, 33);
            login_btn.TabIndex = 6;
            login_btn.Text = "Влез";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // txtBox_password
            // 
            txtBox_password.Location = new Point(218, 160);
            txtBox_password.Name = "txtBox_password";
            txtBox_password.Size = new Size(223, 23);
            txtBox_password.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell", 14F);
            label3.ForeColor = Color.Coral;
            label3.Location = new Point(218, 136);
            label3.Name = "label3";
            label3.Size = new Size(69, 21);
            label3.TabIndex = 4;
            label3.Text = "Парола:";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(218, 94);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(223, 23);
            textBoxUsername.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 14F);
            label2.ForeColor = Color.Coral;
            label2.Location = new Point(218, 70);
            label2.Name = "label2";
            label2.Size = new Size(157, 21);
            label2.TabIndex = 2;
            label2.Text = "Потребителско име:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Monotype Corsiva", 22F);
            label1.ForeColor = Color.Coral;
            label1.Location = new Point(249, 9);
            label1.Name = "label1";
            label1.Size = new Size(170, 37);
            label1.TabIndex = 1;
            label1.Text = "Добре дошли!";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Coral;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 355);
            panel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Monotype Corsiva", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label6.Location = new Point(12, 160);
            label6.Name = "label6";
            label6.Size = new Size(197, 55);
            label6.TabIndex = 3;
            label6.Text = "Национално музикално училище       \" Недялка Симеонова\"";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(56, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label_registerteacher
            // 
            label_registerteacher.AutoSize = true;
            label_registerteacher.Cursor = Cursors.Hand;
            label_registerteacher.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label_registerteacher.ForeColor = Color.DarkRed;
            label_registerteacher.Location = new Point(231, 331);
            label_registerteacher.Name = "label_registerteacher";
            label_registerteacher.Size = new Size(212, 15);
            label_registerteacher.TabIndex = 11;
            label_registerteacher.Text = "/ Регистрирай се като учител /";
            label_registerteacher.Click += label_registerteacher_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(453, 355);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button login_btn;
        private TextBox txtBox_password;
        private Label label3;
        private TextBox textBoxUsername;
        private CheckBox login_chekpassword;
        private Label label4;
        private Label login_register;
        private PictureBox pictureBox1;
        private Label label6;
        private Label login_close;
        private Label label_registerteacher;
    }
}
