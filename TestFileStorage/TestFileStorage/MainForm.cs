using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileStorage
{
    public partial class MainForm: Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        //--------------

        private void AuthorizationButton_Click(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            FileUsersStorage UserInformation = new FileUsersStorage();
            users = UserInformation.Load();
            foreach (User element in users)
            {
                if (PasswordTextBox.Text == element.Password)
                {
                    MessageBox.Show("Пароль введён верно");
                    return;
                }
            }
            MessageBox.Show("Пароль введён неверно");
        }
        
        //--------------

        private void MainForm_Load(object sender, EventArgs e)
        {
            FileUsersStorage UserInformation = new FileUsersStorage();
            List<User> users = UserInformation.Load();
            //LoginComboBox.DataSource = users;
            foreach (User element in users)
            {
                LoginComboBox.Items.Add(element.Login);
            }
        }
    }
}
