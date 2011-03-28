// By: Erik Hanchett
// Date:3/28/2011
// Assignment: #5
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

        //properties
        private const string ERROR_MESSAGE = "Sorry can only have up to 20 balls at one time!";
        private const int TIMER_SLEEP = 15;
        private const int MAXIMUM_BALLS = 20;
        
        private Thread t;
        private List<Ball> balls;
       
        private Random rand;

        //constructor
        public BouncingBallMain()
        {

            rand = new Random();
            InitializeComponent();
            mainPB.Invalidate();
         //new thread
            t = new Thread(new ThreadStart(Run));
            balls = new List<Ball>();
            t.Start();
                
            
        }

        //paints graphic
        private void mainPB_Paint(object sender, PaintEventArgs e)
        {
            
           
            foreach(Ball b in balls)
                b.Paint(e.Graphics);
            

           numOfBallsLbl.Text = balls.Count.ToString();
            
        }

        

        //this is used with the thread to run events for picturebox
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

        
        
        //closes windows stops thread
        private void BouncingBallMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }

        //different events to add balls
        private void addBall_Click(object sender, EventArgs e)
        {
            AddBalls();
        }

        private void resetBall_Click(object sender, EventArgs e)
        {
            balls.Clear();
        }

        //adds balls
        private void AddBalls()
        {
            if (balls.Count < MAXIMUM_BALLS)
                balls.Add(new Ball(rand.Next(mainPB.Bounds.Width), rand.Next(mainPB.Bounds.Height), mainPB));
            else
                MessageBox.Show(ERROR_MESSAGE);
        }

        private void DetectCollision()
        {
            
        }

        private void BouncingBallMain_MouseClick(object sender, MouseEventArgs e)
        {
            AddBalls();
        }

        private void mainPB_MouseClick(object sender, MouseEventArgs e)
        {
            AddBalls();
        }
        

        

        





    }
}
