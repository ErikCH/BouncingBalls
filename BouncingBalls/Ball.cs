using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace BouncingBalls
{
    public class Ball
    {
        public int  dx { get; set; }
        public int dy { get; set; }
        public int speedx { get; set; }
        public int speedy { get; set; }
        public SolidBrush solid;
        private const int SIZE_BALL = 25;
        private PictureBox mainPB;
        private Random randonGen;

        public Ball(int dx, int dy,  PictureBox p)
        {
            this.dx = dx;
            this.dy = dy;
            randonGen = new Random();
            speedx = randonGen.Next(-1,1);
            if (speedx == 0)
                speedx = 1;
            speedy = randonGen.Next(-1,1);
            if (speedy == 0)
                speedy = -1;

            

            this.mainPB = p;
            solid = new SolidBrush(CreateRandomColor());
            
        }

        public void Go()
        {
            checkdx();
            checkdy();
            dx += speedx;
            dy += speedy;
        }

        private void checkdx()
        {

            if (mainPB.Bounds.Right < dx + SIZE_BALL * 1.5)
                speedx *= -1;

            if (mainPB.Bounds.Left > dx + SIZE_BALL - .90)
                speedx *= -1;


        }

        private Color CreateRandomColor()
        {
            
            Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));

            return randomColor;
        }




        public void paint(Graphics c)
        {
            c.FillEllipse(solid, dx, dy, SIZE_BALL, SIZE_BALL);
            
        }

        private void checkdy()
        {
            if (mainPB.Bounds.Bottom < dy + SIZE_BALL * 2.1)
                speedy *= -1;

            if (mainPB.Bounds.Top > dy + SIZE_BALL)
                speedy *= -1;

        }

        
    }
}
