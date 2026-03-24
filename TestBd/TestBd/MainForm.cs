using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TestBd
{
    //Добавить кнопки "добавить и удалить пользователя" и кнопку (очистки всей таблицы?)
    public partial class MainForm: Form
    {
        AddUserForm AddForm = new AddUserForm();
        EditUserForm EditForm = new EditUserForm();
        PgUsersLoader loader = new PgUsersLoader();
        public MainForm()
        {
            InitializeComponent();
            //users.AddRange(loader.LoadUsers());
            usersDataGridView.DataSource = loader.LoadUsers();
            

        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow rows = usersDataGridView.SelectedRows[0];
            User user = rows.DataBoundItem as User;
            loader.DeleteUser(user.Login);
            usersDataGridView.Refresh();
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            AddForm.Show();
            
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow rows = usersDataGridView.SelectedRows[0];
                User user = rows.DataBoundItem as User;
                EditForm.SpiUzer(user);
                EditForm.Show();
                
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            try 
            {
                DataGridViewRow rows = usersDataGridView.SelectedRows[0];
                foreach (DataGridViewRow row in usersDataGridView.Rows)
                {
                    User user = row.DataBoundItem as User;
                    loader.DeleteUser(user.Login);
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
