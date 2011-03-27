// By: Erik Hanchett
// Date:3/28/2011
// Assignment: #4
// Exercise Multithreading

// GUI Class that contronls the properties of the window. 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BouncingBalls
{
    public partial class BouncingBallMain : Form
    {
        private const string ERROR_MESSAGE = "Sorry can only have up to 20 balls at one time!";
        private const int TIMER_SLEEP = 15;
        private const int MAXIMUM_BALLS = 20;
        
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
            addBalls();
        }

        private void resetBall_Click(object sender, EventArgs e)
        {
            balls.Clear();
        }

        private void addBalls()
        {
            if (balls.Count < MAXIMUM_BALLS)
                balls.Add(new Ball(rand.Next(mainPB.Bounds.Width), rand.Next(mainPB.Bounds.Height), mainPB));
            else
                MessageBox.Show(ERROR_MESSAGE);
        }

        private void BouncingBallMain_MouseClick(object sender, MouseEventArgs e)
        {
            addBalls();
        }

        private void mainPB_MouseClick(object sender, MouseEventArgs e)
        {
            addBalls();
        }
        

        

        





    }
}
