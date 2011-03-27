﻿// By: Erik Hanchett
// Date:3/28/2011
// Assignment: #4
// Exercise Multithreading

// Ball class has info about Ball, properties, direction, size, etc;
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
        public int size { get; set; }
        public SolidBrush solid;
        private PictureBox mainPB;
        private Random randonGen;
        private const int LOWER_RANGE = 1;
        private const int UPPER_RANGE = 5;
        private const int UPPER_RANGE_V = 2;
        private const int LOWER_SIZE_LIMIT = 15;
        private const int UPPER_SIZE_LIMIT = 55;
        private const double EDGE1 = 1.5;
        private const double EDGE2 = .90;
        private const double EDGE3 = 2.1;
        

        public Ball(int dx, int dy,  PictureBox p)
        {
            this.dx = dx;
            this.dy = dy;
            randonGen = new Random();
            randomSpeedAndDirection();
            randomSize();
            this.mainPB = p;
            solid = new SolidBrush(CreateRandomColor());
            
        }

        private void randomSize()
        {
            size = randonGen.Next(LOWER_SIZE_LIMIT, UPPER_SIZE_LIMIT);
            
        }
        private void randomSpeedAndDirection()
        {
            speedx = randonGen.Next(LOWER_RANGE, UPPER_RANGE);
            speedy = speedx;
            if (randonGen.Next(0, UPPER_RANGE_V) == 0)
                speedx *= -1;

            if (randonGen.Next(0, UPPER_RANGE_V) == 0)
                speedy *= -1;
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

            if (mainPB.Bounds.Right < dx + size * EDGE1)
                speedx *= -1;

            if (mainPB.Bounds.Left > dx + size - EDGE2)
                speedx *= -1;


        }

        private Color CreateRandomColor()
        {
            
            Color randomColor = Color.FromArgb(randonGen.Next(255), randonGen.Next(255), randonGen.Next(255));

            return randomColor;
        }




        public void paint(Graphics c)
        {
            c.FillEllipse(solid, dx, dy, size, size);
            
        }

        private void checkdy()
        {
            if (mainPB.Bounds.Bottom < dy + size * EDGE3)
                speedy *= -1;

            if (mainPB.Bounds.Top > dy + size)
                speedy *= -1;

        }

        
    }
}
