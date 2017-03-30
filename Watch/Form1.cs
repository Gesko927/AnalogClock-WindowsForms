using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Watch
{
    public partial class Form1 : Form
    {

        private Graphics graphics;

        private Brushes brush;

        private Pen pen;

        private Clock clock;

        public Form1()
        {
            InitializeComponent();

            graphics = panel1.CreateGraphics();

            pen = new Pen(Color.Black, 5);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            timer3.Start();

            clock = new Clock(panel1);

            clock.initSystemTime(DateTime.Now.Second, DateTime.Now.Minute, DateTime.Now.Hour);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            graphics.FillRectangle(Brushes.ForestGreen, 0, 0, 500, 500);
            graphics.FillRectangle(Brushes.Gold, 500, 0, 800, 800);

            graphics.DrawLine(new Pen(Color.Black, 10), clock.XBegin, clock.YBegin, clock.XEndHours, clock.YEndHours);
            graphics.DrawLine(new Pen(Color.Black, 5), clock.XBegin, clock.YBegin, clock.XEndMinute, clock.YEndMinute);
            graphics.DrawLine(new Pen(Color.Red, 3), clock.XBegin, clock.YBegin, clock.XEndSecond, clock.YEndSecond);
            
            clock.moveSecondsArrow();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            clock.moveMinuteArrow();
            //graphics.DrawLine(new Pen(Color.Black, 5), clock.XBegin, clock.YBegin, clock.XEndMinute, clock.YEndMinute);
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            clock.moveHourArrow();
            //graphics.DrawLine(new Pen(Color.Black, 10), clock.XBegin, clock.YBegin, clock.XEndHours, clock.YEndHours);
        }
    }

}
  
