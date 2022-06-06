using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Fruit_Ninja
{
    public partial class playArea : Form
    {
        //Player score and high score
        int score = 0;
        //Countdown to game start
        int counter = 0;
        //Player and ball hit box
        Rectangle target = new Rectangle(0, 0, 10, 10);
        //Obstacles lists
        List<Rectangle> apple = new List<Rectangle>();
        List<Rectangle> banana = new List<Rectangle>();
        List<Rectangle> pineapple = new List<Rectangle>();
        //Play area
        //Rectangle playArea = new Rectangle(150, 30, 3, 1000);
        //Different brushes/pens
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        //Random values
        Random randGen = new Random();
        //Game State
        string gameState = "waiting";

        public playArea()
        {
            InitializeComponent();
            apple.Add(new Rectangle(300, 500, 10, 10));
            banana.Add(new Rectangle(200, 500, 10, 10));

        }
        public void GameInitialize()
        {
            gameEngine.Enabled = true;
            gameState = "running";
            score = 0;
            apple.Clear();

        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            target.X = e.X - target.Width / 2;
            target.Y = e.Y - target.Height / 2;
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            //Buttons, images & text removed when start button is pressed
            startButton.Visible = false;
            exitButton.Visible = false; 
            this.BackgroundImage = Properties.Resources.Wood_Wall;
            Convert.ToString(counter);
            appleImage.Visible = false;
            bananaImage.Visible =  false;
            pineappleImage.Visible = false;
            buttonHelpLabel.Visible = false;
            logoImage.Visible = false;
            bombImage.Visible = false;
            instructionsLabel.Visible = false;
            startButton.Text = "Restart";
            gameEngine.Enabled = true;
            restartButton.Visible = true;
            exit2Button.Visible = true;
            restartButton.Visible = true;
            
            //Add a 3, 2, 1 countdown
            //for (int i = 0; i < 3; i++)
            //{ 
            // counter++;
            // instructionsLabel.Text = $"{counter}!";
            //Thread.Sleep(1000);
            //}

            this.Focus();   
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void restartButton_Click(object sender, EventArgs e)
        {

        }
        private void gameEngine_Tick(object sender, EventArgs e)
        {
            //move fruits
            for (int i = 0; i < apple.Count(); i++)
            {
                //find the new postion of y based on speed 
                int y = apple[i].Y + -5;

                //replace the rectangle in the list with updated one using new y 
                apple[i] = new Rectangle(apple[i].X, y, apple[i].Width, apple[i].Height);
            }
            for (int i = 0; i < banana.Count(); i++)
            {
                //find the new postion of y based on speed 
                int y = banana[i].Y + -5;

                //replace the rectangle in the list with updated one using new y 
                banana[i] = new Rectangle(banana[i].X, y, banana[i].Width, banana[i].Height);
            }

            counter++;
            int x;
            int x2;
            x = randGen.Next(0, 825);
            x2 = randGen.Next(0, 825);

            if (counter == 80)
            {
                apple.Add(new Rectangle(x, 500, 10, 10));
                banana.Add(new Rectangle(x, 500, 10, 10));
                counter = 0;
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, target);

            for (int i = 0; i < apple.Count(); i++)
            {
                e.Graphics.FillRectangle(whiteBrush, apple[i]);
            }
            for (int i = 0; i < banana.Count(); i++)
            {
                e.Graphics.FillRectangle(whiteBrush, banana[i]);
            }
        }
      
    }
}
