using SellSix.Model;
using SellSix.Model.Entities;
using System.Net;

namespace SellSix.View
{
    public partial class UserManagement : UserControl
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
            tvUsers.Nodes.Clear();
                        _savedUsers = Program._savedUsers;
            if (_savedUsers.Count > 0)
            {
                _selectedUser = _savedUsers[0];
                tbUserName.Text = _selectedUser._name;
                tbEmail.Text = _selectedUser._email;
                tbPass.Text = _selectedUser._password;
                tbDocument.Text = _selectedUser._document;
                tbAddress.Text = _selectedUser._address;
                tbCity.Text = _selectedUser._city;
                tbPhone.Text = _selectedUser._phone;
                cbAccessLevel.SelectedIndex = _selectedUser._accesslevel;
            }
            
            LoadUsers();
        }


        public void LoadUsers()
        {
            tvUsers.Nodes.Clear();
            foreach (User user in _savedUsers)
            {
                TreeNode node = new TreeNode(user._name);
                node.Tag = user;
                tvUsers.Nodes.Add(node);
            }
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
