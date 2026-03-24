using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestBd
{
    public partial class AddUserForm: Form
    {
        PgUsersLoader loader = new PgUsersLoader();
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Login = LoginTextBox.Text;
            user.Name = NameTextBox.Text;
            user.Password = PasswordTextBox.Text;
            user.LastName = LastNameTextBox.Text;
            user.Age = Convert.ToInt32(AgeTextBox.Text);
            loader.AddUser(user);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
