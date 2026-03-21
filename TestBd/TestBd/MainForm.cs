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
       
        PgUsersLoader loader = new PgUsersLoader();
        public MainForm()
        {
            InitializeComponent();
            //users.AddRange(loader.LoadUsers());
            usersDataGridView.DataSource = loader.LoadUsers();

        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вы точно хотите удалить этого пользователя?", "Удаление", MessageBoxButtons.YesNo);

            try
            {
                {
                    //
                    //cmd.Parameters.AddWithValue("@id", 1);
                    //
                    //await cmd.ExecuteNonQuery();
                }
                
                BindingList<User> selectedUser = new BindingList<User>();
                foreach (User user in usersDataGridView.SelectedRows)
                {selectedUser.Add(user);}
                loader.RemoveUser(selectedUser);
                //usersDataGridView.DataSource = loader.LoadUsers();
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                ShowDialog(/*AddUserForm*/);
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            try
            {

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

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
