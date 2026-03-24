using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestBd;

namespace TestBd
{
    public class PgUsersLoader
    {
        public string cs = "Host=192.168.1.48;Username=postgres;Password=PG@dmin$;Database=test01";
        public BindingList<User> allUsers = new BindingList<User>();
        public BindingList<User> LoadUsers()
        {
            try
            {
                var con = new NpgsqlConnection(cs);

                con.Open();
                var sql = "SELECT login,password,name,last_name,age FROM users";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allUsers.Add(new User
                    {
                        Login = reader.GetString(0),
                        Password = reader.GetString(1),
                        Name = reader.GetString(2),
                        LastName = reader.GetString(3),
                        Age = reader.GetInt32(4)
                    });
                }
                con.Close();

                return allUsers;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return allUsers;
        }
        public bool DeleteUser(string login)
        {
            try
            {
                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = @"DELETE FROM users WHERE login = @login";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", login);
                int changedRows = cmd.ExecuteNonQuery();

                if (changedRows < 1)
                {
                    return false;
                }
                return true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }
        public bool AddUser(User user)
        {
            try
            {
                var con = new NpgsqlConnection(cs);
                con.Open();
                var sql = @"INSERT INTO Users(login,password,name,last_name,age) VALUES (@login, @password, @name, @last_name, @age)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@last_name", user.LastName);
                cmd.Parameters.AddWithValue("@age", user.Age);
                int changedRows = cmd.ExecuteNonQuery();
                if (changedRows < 1)
                {
                    return false;
                }
                return true;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return false;
        }
    }
}