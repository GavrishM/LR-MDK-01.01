using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PR_DB_V12.MainForm;

namespace PR_DB_V12
{
    public partial class CreateForm : Form
    {
        PgMealsLoader loader = new PgMealsLoader();
        public CreateForm()
        {
            InitializeComponent();
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal();
            meal.Name = NameTextBox.Text;
            meal.Type = TypeTextBox.Text;
            meal.Price = Convert.ToInt32(PriceTextBox.Text);
            meal.Delivery = Convert.ToBoolean(DeliveryComboBox.Text);
            loader.AddMeal(meal);
            //MainForm.mealsDataGridView.Refresh();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
