using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Puzzle_2013
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.userTextBox.Text;
            string password = this.passwordTextBox.Text;

            if (CheckUser(username, password))
            {
                if (GetUserType(username) == 1)
                {
                    // regular user
                }
                else if (GetUserType(username) == 2)
                {
                    // admin user
                }
            }
        }

        private bool CheckUser(string user, string pass)
        {
            List<User> listOfUsers = SqlManager.GetUsersFromDatabase();

            foreach (User currentUser in listOfUsers)
            {
                if (currentUser.username == user && currentUser.password == pass)
                {
                    return true;
                }
            }

            return false;
        }

        private int GetUserType(string user)
        {
            List<User> listOfUsers = SqlManager.GetUsersFromDatabase();

            int type = 0;

            foreach (User currentUser in listOfUsers)
            {
                if (currentUser.username == user)
                {
                    type = currentUser.userType;
                    break;
                }
            }

            return type;
        }
    }
}
