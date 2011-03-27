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

        private const int TIMER_SLEEP = 15;
        
        private Thread t;
        private List<Ball> balls;
       
        private Random rand;
        public BouncingBallMain()
        {



            rand = new Random();
            InitializeComponent();
            mainPB.Invalidate();
            t = new Thread(new ThreadStart(Run));
            balls = new List<Ball>();
            t.Start();
                
            
        }

        private void mainPB_Paint(object sender, PaintEventArgs e)
        {
            
           
            foreach(Ball b in balls)
                b.paint(e.Graphics);
            

           numOfBallsLbl.Text = balls.Count.ToString();
            
        }

        

        private void Run()
        {
            while (true)
            {
                foreach (Ball b in balls)
                    b.Go();
                
                mainPB.Invalidate(); 
                Thread.Sleep(TIMER_SLEEP);
               
            }

        }

        
        

        private void BouncingBallMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }

        private void addBall_Click(object sender, EventArgs e)
        {

            balls.Add(new Ball(rand.Next(mainPB.Bounds.Width), rand.Next(mainPB.Bounds.Height), mainPB));
        }

        private void resetBall_Click(object sender, EventArgs e)
        {
            balls.Clear();
        }

        

        





    }
}
