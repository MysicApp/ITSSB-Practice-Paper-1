using Paper1.Db;

namespace Paper1
{
    public partial class LoginForm: Form
    {
        readonly Backable Backable;
        
        public LoginForm(Form previous_form)
        {
            Backable = new Backable(this, previous_form);
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Backable.BackToParent();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            using (var context = new Session1Context())
            {
                var currentUser = from user in context.Users 
                                  where user.UserName == BoxUserId.Text &&
                                        user.UserPw == BoxPassword.Text
                                  select user;
                //var currentUser = Context.Users.Where(x => x.UserName == BoxUserId.Text && x.UserPw == BoxPassword.Text).FirstOrDefault();
                if (currentUser.Any())
                {
                    MessageBox.Show("Login Successful!");
                    var resourceManagementForm = new ResourceManagementForm(this);
                    resourceManagementForm.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
        }
    }
}
