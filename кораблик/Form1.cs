using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace кораблик
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.LightBlue);
            SolidBrush myCorp = new SolidBrush(Color.DarkKhaki);
            SolidBrush myKoleso = new SolidBrush(Color.Gold);
            SolidBrush myWindow = new SolidBrush(Color.DarkGoldenrod);
            SolidBrush mySeа = new SolidBrush(Color.IndianRed);
           
            Pen myWind = new Pen(Color.Yellow, 2);
            g.FillPolygon(myCorp, new Point[]
            {
                new Point(150,300),new Point(700,300),
                new Point(150,300),new Point(250,200),
                new Point(250,200),new Point(600,200),
                new Point(600,200),new Point(700,300)
            }
            );
            g.FillRectangle(myCorp, 50, 300, 800, 80);
            g.FillEllipse(myKoleso, 150, 320, 100, 100);
            g.FillEllipse(myKoleso, 650, 320, 100, 100);
            g.FillEllipse(myWindow, 660, 330, 80, 80);
            g.FillEllipse(myWindow, 160, 330, 80, 80);

            g.FillPolygon(myWindow, new Point[]
            {
                new Point(170,300),new Point(250,220),
                new Point(250,220),new Point(250,300)
            }
            );
            g.FillRectangle(myWindow, 270, 220, 310, 80);

            g.FillPolygon(myWindow, new Point[]
            {
                new Point(600,300),new Point(600,220),
                new Point(600,220),new Point(680,300)
            }
            );
            g.FillRectangle(myKoleso, 820, 300, 30, 20);
            g.FillRectangle(mySeа, 50, 300, 30, 20);
        }
    }
}
