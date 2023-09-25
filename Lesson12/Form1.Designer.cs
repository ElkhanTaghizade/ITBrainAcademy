namespace WinFormsApp2
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
            register = new Button();
            login = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            name = new Label();
            password = new Label();
            cpassword = new Label();
            SuspendLayout();
            // 
            // register
            // 
            register.BackColor = Color.Silver;
            register.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            register.Location = new Point(523, 425);
            register.Name = "register";
            register.Size = new Size(255, 47);
            register.TabIndex = 0;
            register.Text = "Register Now";
            register.UseVisualStyleBackColor = false;
            register.Click += register_Click;
            // 
            // login
            // 
            login.BackColor = Color.Silver;
            login.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            login.ForeColor = SystemColors.WindowText;
            login.Location = new Point(443, 501);
            login.Name = "login";
            login.Size = new Size(426, 47);
            login.TabIndex = 1;
            login.Text = "Have Account ? Login Now";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(652, 73);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 41);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(652, 163);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 41);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(652, 255);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(312, 41);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(282, 81);
            name.Name = "name";
            name.Size = new Size(207, 33);
            name.TabIndex = 5;
            name.Text = "Enter User Name";
            name.UseWaitCursor = true;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            password.Location = new Point(282, 163);
            password.Name = "password";
            password.Size = new Size(188, 33);
            password.TabIndex = 6;
            password.Text = "Enter Password";
            // 
            // cpassword
            // 
            cpassword.AutoSize = true;
            cpassword.Location = new Point(282, 255);
            cpassword.Name = "cpassword";
            cpassword.Size = new Size(214, 33);
            cpassword.TabIndex = 7;
            cpassword.Text = "Confirm Password";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1299, 607);
            Controls.Add(cpassword);
            Controls.Add(password);
            Controls.Add(name);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(login);
            Controls.Add(register);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button register;
        private Button login;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label cpassword;
        private Label password;
        private Label name;
    }
}