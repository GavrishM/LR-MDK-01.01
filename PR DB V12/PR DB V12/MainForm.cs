using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR_DB_V12
{
    public partial class MainForm : Form
    {
        CreateForm create = new CreateForm();
        EditForm edit = new EditForm();
        PgMealsLoader loader = new PgMealsLoader();
        public MainForm()
        {

            InitializeComponent();
            mealsDataGridView.DataSource = loader.LoadMeals();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow rows = mealsDataGridView.SelectedRows[0];
            Meal meal = rows.DataBoundItem as Meal;
            loader.DeleteMeal(meal.Name);
            mealsDataGridView.Refresh();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            create.Show();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow rows = mealsDataGridView.SelectedRows[0];
                Meal meal = rows.DataBoundItem as Meal;
                edit.SpiMeal(meal);
                edit.Show();

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
