using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextForm
{
    public partial class MainForm: Form
    {
        private int number_;
        private DateTime timer_;

        public MainForm()
        {
            InitializeComponent();
            Random rnd = new Random();
            number_ = rnd.Next(1, 100);
            NumberLabel.Text = number_.ToString();
            OutputLabel.Text = "";
            //timer_ = ;
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            int input = Convert.ToInt32(InputTextBox.Text);
            if (input == number_)
            {
                OutputLabel.Text = "Правильно";
            }
            if (input < number_)
            {
                OutputLabel.Text = "Меньше";
            }
            if (input > number_)
            {
                OutputLabel.Text = "Больше";
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {

        }
    }
}
