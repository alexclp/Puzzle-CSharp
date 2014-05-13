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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void InitializeTable()
        {
            string[] columns = { "Name", "Surname", "Username", "Password", "Type" };

            foreach (string current in columns)
            {
                this.usersListView.Columns.Add(current, -2, HorizontalAlignment.Left);
            }
        }

        private void AddUsersToTable()
        {
            List<User> listOfUsers = SqlManager.GetUsersFromDatabase();

            foreach (User current in listOfUsers)
            {

            }
        }
    }
}
