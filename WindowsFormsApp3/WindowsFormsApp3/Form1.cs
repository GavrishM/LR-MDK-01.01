using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1: Form
    {
        int speed_vert = 2;
        int speed_hor = 2;
        int score = 0;
        int a1 = 0;
        bool a = true;
        public Form1()
        {
            InitializeComponent();
            timer.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle= FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds=Screen.PrimaryScreen.Bounds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a1++;
            if (a1 == 2)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                Cursor.Hide();
            }
            if (a1 == 1)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                Cursor.Show();
            }
            if (a1 == 3)
            {
                a1 = 1;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) 
                this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            gamePanel.Left = Cursor.Position.X - (gamePanel.Width / 2);
            gameBall.Left += speed_hor;
            gameBall.Top += speed_vert;

            gamePanel.Top = tabPage1.Bottom - (tabPage1.Bottom / 10);

            if (gameBall.Left <= background.Left)
                speed_hor *= -1;
            if (gameBall.Right <= background.Right)
                speed_hor *= -1;
            if (gameBall.Top <= background.Top)
                speed_vert *= -1;

            if (gameBall.Bottom >= background.Bottom)
                timer.Enabled = false;

            if (gameBall.Bottom >= gamePanel.Top && gameBall.Left >=gamePanel.Left && gameBall.Right<=gamePanel.Right)
            {
                speed_hor += 2;
                speed_vert += 2;
                speed_vert *= -1;
                score++;
            }
        }

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}
