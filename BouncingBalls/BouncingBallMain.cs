using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace BouncingBalls
{
    public partial class BouncingBallMain : Form
    {
        private int dx = 0;
        private int dy = 0;

      
        SolidBrush solid = new SolidBrush(Color.Blue);
        Thread t;

        public BouncingBallMain()
        {
            
            t = new Thread(new ThreadStart(Run));
            
            InitializeComponent();
            t.Start();
            
            
        }

        private void mainPB_Paint(object sender, PaintEventArgs e)
        {

            
            
            e.Graphics.FillEllipse(solid, dx, dy, 25, 25);
            dxLabelA.Text = dx.ToString();
            dyLabelA.Text = mainPB.Bounds.Right.toS
            
        }

        

        private void Run()
        {
            while (true)
            {
                //dx = checkdx();
                //dy = checkdy();
                dx += 1;
                dy += 1;
                mainPB.Invalidate(); 
                Thread.Sleep(20);
               
            }

        }

        

        private void BouncingBallMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }






    }
}
