using Paper1.Db;

namespace Paper1
{
    public partial class SignUpForm : Form
    {
        readonly Backable Backable;
        Dictionary<string, int> UserTypeIds = new();
        
        public SignUpForm(Form previous_form)
        {
            InitializeComponent();
            Backable = new Backable(this, previous_form);
        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            using var context = new Session1Context();
            ComboUserType.DataSource = context.UserTypes
                .Select(ut => ut.UserTypeName)
                .ToList();
            UserTypeIds = context.UserTypes
                .ToDictionary(ut => ut.UserTypeName, ut => ut.UserTypeId);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Backable.BackToParent();
        }

        private void BtnDone_Click(object sender, EventArgs e)
        {
            // Fail if data is invalid
            if (!ValidateData()) return;

            // Create account
            CreateAccount(BoxUsername.Text.Trim(),
                BoxUserId.Text.Trim(),
                BoxPassword.Text.Trim(),
                ComboUserType.SelectedValue.ToString());
                
            // Redirect to main menu
            Backable.BackToParent();
        }

        private bool ValidateData()
        {
            string username = BoxUsername.Text.Trim(),
                userId = BoxUserId.Text.Trim(),
                password = BoxPassword.Text.Trim(),
                rePassword = BoxRePassword.Text.Trim();

            if (username == string.Empty ||
                userId == string.Empty ||
                password == string.Empty ||
                rePassword == string.Empty)
            {
                MessageBox.Show("All fields must be completed.");
                return false;
            }

            if (userId.Length < 8)
            {
                MessageBox.Show("User ID must contain at least 8 characters.");
                return false;
            }

            if (password != rePassword)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }
            using var context = new Session1Context();
            if (context.Users.Where(u => u.UserId == userId).Any())
            {
                MessageBox.Show("User with that User ID already exists.");
                return false;
            }

            return true;
        }

        private void CreateAccount(string username, string userId, string password, string userType)
        {
            using var context = new Session1Context();
            var user = new User
            {
                UserId = userId,
                UserName = username,
                UserPw = password,
                UserTypeIdFk = UserTypeIds[userType],
            };
            context.Users.Add(user);
            context.SaveChanges();
        }
    }
}
