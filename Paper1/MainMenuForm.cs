namespace Paper1
{
    public partial class MainMenuForm : Form
    {
        private SignUpForm SignUpForm;
        private LoginForm LoginForm;
        
        public MainMenuForm()
        {
            InitializeComponent();
            SignUpForm = new SignUpForm(this);
            LoginForm = new LoginForm(this);
        }
        
        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnSignUp_Click(object sender, EventArgs e)
        {
            Hide();
            SignUpForm.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm.Show();
        }
    }
}