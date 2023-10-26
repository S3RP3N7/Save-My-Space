namespace WinFormsApp1
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Color select_Color = Color.FromArgb(173, 216, 230);

        private void GoToregister_Click(object sender, EventArgs e)
        {
            panel2.BringToFront();
            panel_login.BackColor = Color.PowderBlue;
            panel_register.BackColor = Color.White;
            goToRegister.BackColor = select_Color;
            loginButton.BackColor = select_Color;
            panel2.BackColor = select_Color;
            panel1.BackColor = Color.PowderBlue;
            goToLogin.BackColor = Color.PowderBlue;


        }

        private void goToLogin_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel_login.BackColor = Color.White;
            panel_register.BackColor = Color.PowderBlue;
            goToLogin.BackColor = select_Color;
            loginButton.BackColor = select_Color;
            panel1.BackColor = select_Color;
            panel2.BackColor = Color.PowderBlue;
            goToRegister.BackColor = Color.PowderBlue;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}