using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PR_DB_V12
{
    public class PgMealsLoader
    {
        
        public string cs = "Host=192.168.1.48;Username=postgres;Password=PG@dmin$;Database=GavrishM PRBD V12";
        public BindingList<Meal> allMeals = new BindingList<Meal>();
        public BindingList<Meal> LoadMeals()
        {
            try
            {
                var con = new NpgsqlConnection(cs);

                con.Open();
                //var sql = "SELECT " + '"' + "Name" + '"' + ", " + '"' + "Type" + '"' + ", " + '"' + "Price" + '"' + ", " + '"' + "Delivery" + '"' + " FROM " + '"' + "Meals" + '"';
                var sql = "SELECT Name, Type, Price, Delivery FROM Meals";
                var cmd = new NpgsqlCommand(sql, con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    allMeals.Add(new Meal
                    {
                        Name = reader.GetString(0),
                        Type = reader.GetString(1),
                        Price = reader.GetInt32(2),
                        Delivery = reader.GetBoolean(3)                        
                    });
                }
                con.Close();

                return allMeals;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            return allMeals;
        }
        public bool UpdateMeal(Meal meal, string name)
        {
            try
            {
                var con = new NpgsqlConnection(cs);
                con.Open();
                //var sql = @"DELETE FROM " + '"' + "Meals" + '"' + " WHERE " + '"' + "Name" + '"' + " = @name";
                var sql = @"UPDATE Meals SET Name = @name, Type = @type, Price = @price, Delivery = @delivery WHERE Name = @mname";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@mname", name);
                cmd.Parameters.AddWithValue("@name", meal.Name);
                cmd.Parameters.AddWithValue("@type", meal.Type);
                cmd.Parameters.AddWithValue("@price", meal.Price);
                cmd.Parameters.AddWithValue("@delivery", meal.Delivery);
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
        public bool DeleteMeal(string name)
        {
            try
            {
                var con = new NpgsqlConnection(cs);
                con.Open();
                //var sql = @"DELETE FROM " + '"' + "Meals" + '"' + " WHERE " + '"' + "Name" + '"' + " = @name";
                var sql = @"DELETE FROM Meals WHERE Name = @name";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", name);
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
        public bool AddMeal(Meal meal)
        {
            try
            {
                var con = new NpgsqlConnection(cs);
                con.Open();
                //var sql = @"INSERT INTO " + '"' + "Meals" + '"' + "(" + '"' + "Name" + '"' + ", " + '"' + "Type" + '"' + ", " + '"' + "Price" + '"' + ", " + '"' + "Delivery" + '"' + ") VALUES (@name, @type, @price, @delivery)";
                var sql = @"INSERT INTO Meals (Name, Type, Price, Delivery) VALUES (@name, @type, @price, @delivery)";
                var cmd = new NpgsqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", meal.Name);
                cmd.Parameters.AddWithValue("@type", meal.Type);
                cmd.Parameters.AddWithValue("@price", meal.Price);
                cmd.Parameters.AddWithValue("@delivery", meal.Delivery);
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
