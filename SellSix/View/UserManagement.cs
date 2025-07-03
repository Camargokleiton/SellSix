using SellSix.Model.Entities;
using SellSix.Model;

namespace SellSix.View
{
    public partial class UserManagement : Form
    {
        private bool _isPasswordVisible = false;
        private User _selectedUser = new User();
        List<User> _savedUsers = new List<User>();
        public UserManagement()
        {
            InitializeComponent();
            initialize();
              
        }

        private void initialize()
        {
            tbPass.UseSystemPasswordChar = true;
            tbPass.PasswordChar = '*';
            tbUserName.Focus();
        }

        private void tbDocument_TextChanged(object sender, EventArgs e)
        {

        }

        private void btShowPass_Click(object sender, EventArgs e)
        {
            _isPasswordVisible |= !_isPasswordVisible;
            tbPass.UseSystemPasswordChar = !tbPass.UseSystemPasswordChar;
            btShowPass.Image = _isPasswordVisible
         ? Properties.Resources.visibility_off
         : Properties.Resources.visibility;
        }
    }
}
