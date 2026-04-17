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
    public partial class EditForm : Form
    {
        PgMealsLoader loader = new PgMealsLoader();
        Meal globalMeal = new Meal();
        public EditForm()
        {
            InitializeComponent();
            ENameTextBox.Text = globalMeal.Name;
            ETypeTextBox.Text = globalMeal.Type;
            EPriceTextBox.Text = globalMeal.Price.ToString();
            //if (globalMeal.Delivery == true)
            //{
            //    EDeliveryComboBox.SelectedIndex = 0;
            //}
            //else
            //{
            //    EDeliveryComboBox.SelectedIndex = 1;
            //}
        }
        public void SpiMeal(Meal meal)
        {
            globalMeal = meal;
        }

        private void EAddButton_Click(object sender, EventArgs e)
        {
            Meal meal = new Meal();
            meal.Name = ENameTextBox.Text;
            meal.Type = ETypeTextBox.Text;
            meal.Price = Convert.ToInt32(EPriceTextBox.Text);
            meal.Delivery = Convert.ToBoolean(EDeliveryComboBox.Text);
            loader.UpdateMeal(meal, globalMeal.Name);
            ActiveForm.Close();
        }

        private void ECancelButton_Click(object sender, EventArgs e)
        {
            ActiveForm.Close();
        }
    }
}
