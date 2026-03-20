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
    //Добавить кнопки "добавить и удалить пользователя"
    public partial class MainForm: Form
    {
        List<User> users = new List<User>();
        PgUsersLoader loader = new PgUsersLoader();
        public MainForm()
        {
            InitializeComponent();
            users.AddRange(loader.LoadUsers());
            usersDataGridView.DataSource = users;
            
            //var cs = "Host=192.168.1.48;Username=postgres;Password=PG@dmin$;Database=proptest";
            //var con = new NpgsqlConnection(cs);

            //con.Open();
            //var sql = "SELECT password,login FROM myusers";
            //var cmd = new NpgsqlCommand(sql, con);

            //var reader = cmd.ExecuteReader();
            //List<string> Logins = new List<string>();
            //while (reader.Read())
            //{
            //    Logins.Add(reader.GetString(0) + ":" + reader.GetString(1));
            //}
            //MessageBox.Show(string.Join(",", PgUsersLoader.LoadUse));
            //con.Close();
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    //
                    //cmd.Parameters.AddWithValue("@id", 1);
                    //
                    //await cmd.ExecuteNonQuery();
                }
                List<User> selectedUser = new List<User>();
                //selectedUser.AddRange(usersDataGridView.SelectedRows);
                users = loader.RemoveUser(selectedUser, users);
                usersDataGridView.DataSource = users;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            

        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {

        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
