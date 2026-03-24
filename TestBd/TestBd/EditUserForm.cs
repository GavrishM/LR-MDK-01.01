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
    public partial class EditUserForm: Form
    {
        PgUsersLoader loader = new PgUsersLoader();
        User globalUser = new User();
        public EditUserForm()
        {
            InitializeComponent();
        }
        public void SpiUzer(User user)
        {
            globalUser = user;
        }

        private void EAddButton_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Login = ELoginTextBox.Text;
            user.Name = ENameTextBox.Text;
            user.Password = EPasswordTextBox.Text;
            user.LastName = ELastNameTextBox.Text;
            user.Age = Convert.ToInt32(EAgeTextBox.Text);
            loader.AddUser(user);
        }

        private void ECancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
