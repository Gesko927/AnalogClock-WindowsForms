using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace Watch
{
    class Clock
    {
        private Panel panel;

        private int r;

        private int fiSeconds;
        private int fiMinutes;
        private int fiHours;

        private int fiStrBeg;
        private int fiStrEnd;

        private int xBegin;
        private int yBegin;

        private float xEndSecond;
        private float yEndSecond;

        private float xEndMinute;
        private float yEndMinute;

        private float xEndHours;
        private float yEndHours;

        private float xStrBegin;
        private float yStrBegin;

        private float xStrEnd;
        private float yStrEnd;

        public void strings()
        {
            for (int i = 0; i < 60; ++i)
            {
                fiStrBeg += 6;

            }
        }

        #region Properies
        public int R
        {
            get
            {
                return r;
            }

            private set
            {
                r = value;
            }
        }

        public int XBegin
        {
            get
            {
                return xBegin;
            }

            private set
            {
                xBegin = value;
            }
        }

        public int YBegin
        {
            get
            {
                return yBegin;
            }

            private set
            {
                yBegin = value;
            }
        }

        public float XEndSecond
        {
            get
            {
                return xEndSecond;
            }

            private set
            {
                xEndSecond = value;
            }
        }

        public float YEndSecond
        {
            get
            {
                return yEndSecond;
            }

            private set
            {
                yEndSecond = value;
            }
        }

        public float XEndMinute
        {
            get
            {
                return xEndMinute;
            }

            private set
            {
                xEndMinute = value;
            }
        }

        public float YEndMinute
        {
            get
            {
                return yEndMinute;
            }

            private set
            {
                yEndMinute = value;
            }
        }

        public float XEndHours
        {
            get
            {
                return xEndHours;
            }

            private set
            {
                xEndHours = value;
            }
        }

        public float YEndHours
        {
            get
            {
                return yEndHours;
            }

            private set
            {
                yEndHours = value;
            }
        }


        #endregion

        public Clock(Panel _panel)
        {
            this.panel = _panel;
            XBegin = panel.ClientSize.Width / 2;
            yBegin = panel.ClientSize.Height / 2;

            R = 200;

            fiSeconds = -90;
            fiMinutes = -90;
            fiHours = -90;
            fiStrBeg = -90;
        }

        public void moveSecondsArrow()
        {
            fiSeconds += 6;

            XEndSecond = XBegin + r * cosFi(fiSeconds);
            YEndSecond = YBegin + r * sinFi(fiSeconds);
        }

        public void moveMinuteArrow()
        {
            fiMinutes += 6;

            XEndMinute = XBegin + r * cosFi(fiMinutes);
            YEndMinute = YBegin + r * sinFi(fiMinutes);
        }

        public void moveHourArrow()
        {
            fiHours += 30;

            XEndHours = XBegin + r * cosFi(fiHours);
            YEndHours = YBegin + r * sinFi(fiHours);
        }

        public void initSystemTime(int seconds, int minutes, int hours)
        {
            fiSeconds += (seconds+2) * 6;
            XEndSecond = XBegin + r * cosFi(fiSeconds);
            YEndSecond = YBegin + r * sinFi(fiSeconds);

            fiMinutes += (minutes) * 6;
            XEndMinute = XBegin + r * cosFi(fiMinutes);
            YEndMinute = YBegin + r * sinFi(fiMinutes);

            fiHours += (hours) * 30;
            XEndHours = XBegin + r * cosFi(fiHours);
            YEndHours = YBegin + r * sinFi(fiHours);

        }

        private float cosFi(int fi)
        {
            return (float)Math.Cos((Math.PI * fi) / 180);
        }

        private float sinFi(int fi)
        {
            return (float)Math.Sin((Math.PI * fi) / 180);
        }

    }
}
