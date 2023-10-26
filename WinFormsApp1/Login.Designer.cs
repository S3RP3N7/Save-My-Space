namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            goToLogin = new Button();
            goToRegister = new Button();
            panel1 = new Panel();
            loginButton = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            textBox7 = new TextBox();
            label7 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            textBox6 = new TextBox();
            label6 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            panel_login = new Panel();
            panel_register = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // goToLogin
            // 
            goToLogin.FlatAppearance.BorderColor = Color.PowderBlue;
            goToLogin.FlatStyle = FlatStyle.Flat;
            goToLogin.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point);
            goToLogin.Location = new Point(12, 11);
            goToLogin.Name = "goToLogin";
            goToLogin.Size = new Size(153, 58);
            goToLogin.TabIndex = 0;
            goToLogin.Text = "Login";
            goToLogin.UseVisualStyleBackColor = true;
            goToLogin.Click += goToLogin_Click;
            // 
            // goToRegister
            // 
            goToRegister.FlatAppearance.BorderColor = Color.PowderBlue;
            goToRegister.FlatStyle = FlatStyle.Flat;
            goToRegister.Font = new Font("Palatino Linotype", 18F, FontStyle.Regular, GraphicsUnit.Point);
            goToRegister.Location = new Point(229, 14);
            goToRegister.Name = "goToRegister";
            goToRegister.Size = new Size(153, 58);
            goToRegister.TabIndex = 1;
            goToRegister.Text = "Register";
            goToRegister.UseVisualStyleBackColor = true;
            goToRegister.Click += GoToregister_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(loginButton);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(1, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 393);
            panel1.TabIndex = 2;
            // 
            // loginButton
            // 
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(78, 207);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(281, 43);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(118, 134);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(246, 29);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 141);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 2;
            label2.Text = "Password:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(118, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(246, 29);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 71);
            label1.Name = "label1";
            label1.Size = new Size(84, 22);
            label1.TabIndex = 0;
            label1.Text = "Username:";
            // 
            // panel2
            // 
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(1, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(423, 393);
            panel2.TabIndex = 5;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(110, 27);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(254, 29);
            textBox7.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(20, 27);
            label7.Name = "label7";
            label7.Size = new Size(90, 22);
            label7.TabIndex = 9;
            label7.Text = "First Name:";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(110, 206);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(254, 29);
            textBox5.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 209);
            label5.Name = "label5";
            label5.Size = new Size(104, 22);
            label5.TabIndex = 7;
            label5.Text = "Confirm Pass:";
            // 
            // textBox6
            // 
            textBox6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(110, 164);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(254, 29);
            textBox6.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(20, 164);
            label6.Name = "label6";
            label6.Size = new Size(78, 22);
            label6.TabIndex = 5;
            label6.Text = "Password:";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(83, 281);
            button1.Name = "button1";
            button1.Size = new Size(281, 43);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(110, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(254, 29);
            textBox3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 119);
            label3.Name = "label3";
            label3.Size = new Size(54, 22);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(110, 75);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(254, 29);
            textBox4.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(20, 75);
            label4.Name = "label4";
            label4.Size = new Size(89, 22);
            label4.TabIndex = 0;
            label4.Text = "Last Name:";
            // 
            // panel_login
            // 
            panel_login.Location = new Point(12, 67);
            panel_login.Name = "panel_login";
            panel_login.Size = new Size(153, 5);
            panel_login.TabIndex = 11;
            // 
            // panel_register
            // 
            panel_register.Location = new Point(229, 67);
            panel_register.Name = "panel_register";
            panel_register.Size = new Size(153, 5);
            panel_register.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(391, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 19);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(423, 470);
            Controls.Add(panel1);
            Controls.Add(panel_login);
            Controls.Add(pictureBox1);
            Controls.Add(panel_register);
            Controls.Add(panel2);
            Controls.Add(goToRegister);
            Controls.Add(goToLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button goToLogin;
        private Button goToRegister;
        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private Button loginButton;
        private TextBox textBox2;
        private Label label2;
        private Panel panel2;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel_login;
        private Panel panel_register;
    }
}