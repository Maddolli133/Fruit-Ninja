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
        //Player score & life
        int score = 0;
        int life = 3;
        //Countdown to game start
        int counter = 0;
        //Player and ball hit box
        Rectangle target = new Rectangle(0, 0, 10, 10);
        //Obstacles lists
        List<Rectangle> apple = new List<Rectangle>();
        List<int> appleSpeed = new List<int>(8);
        List<Rectangle> banana = new List<Rectangle>();
        List<int> bananaSpeed = new List<int>(8);
        List<Rectangle> pineapple = new List<Rectangle>();
        List<int> pineappleSpeed = new List<int>(8);
        List<Rectangle> bomb = new List<Rectangle>();
        List<int> bombSpeed = new List<int>(8);
        //Different brushes/pens
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);
        //Random values
        Random randGen = new Random();
        //Game State
        string gameState = "waiting";
        public playArea()
        {
            InitializeComponent();
            apple.Add(new Rectangle());
            appleSpeed.Add(-6);
            banana.Add(new Rectangle());
            bananaSpeed.Add(-6);
            pineapple.Add(new Rectangle());
            pineappleSpeed.Add(-6);
            bomb.Add(new Rectangle());
            bombSpeed.Add(-6);
        }
        public void GameInitialize()
        {
            gameEngine.Enabled = true;
            gameState = "running";
            score = 0;
            apple.Clear();
            appleSpeed.Clear();
            banana.Clear();
            bananaSpeed.Clear();
            pineapple.Clear();
            pineappleSpeed.Clear();
            bomb.Clear();
            bombSpeed.Clear();
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
            bananaImage.Visible = false;
            pineappleImage.Visible = false;
            buttonHelpLabel.Visible = false;
            logoImage.Visible = false;
            bombImage.Visible = false;
            instructionsLabel.Visible = false;
            startButton.Text = "Restart";
            gameEngine.Enabled = true;
            exit2Button.Visible = true;
            life1.Visible = true;
            life2.Visible = true;
            life3.Visible = true;

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
        private void gameEngine_Tick(object sender, EventArgs e)
        {
            //move fruits
            for (int i = 0; i < apple.Count(); i++)
            {
                //find the new postion of y based on speed 
                int y = apple[i].Y + appleSpeed[i];

                //replace the rectangle in the list with updated one using new y 
                apple[i] = new Rectangle(apple[i].X, y, apple[i].Width, apple[i].Height);
            }
            for (int i = 0; i < banana.Count(); i++)
            {
                //find the new postion of y based on speed 
                int y = banana[i].Y + bananaSpeed[i];

                //replace the rectangle in the list with updated one using new y 
                banana[i] = new Rectangle(banana[i].X, y, banana[i].Width, banana[i].Height);
            }
            for (int i = 0; i < pineapple.Count(); i++)
            {
                //find the new postion of y based on speed 
                int y = pineapple[i].Y + pineappleSpeed[i];

                //replace the rectangle in the list with updated one using new y 
                pineapple[i] = new Rectangle(pineapple[i].X, y, pineapple[i].Width, pineapple[i].Height);
            }
            for (int i = 0; i < bomb.Count(); i++)
            {
                //find the new postion of y based on speed 
                int y = bomb[i].Y + bombSpeed[i];

                //replace the rectangle in the list with updated one using new y 
                bomb[i] = new Rectangle(bomb[i].X, y, bomb[i].Width, bomb[i].Height);
            }

            //check if fruit hit top or bottom wall and change direction if it does
            for (int i = 0; i < apple.Count(); i++)
            {
                if (apple[i].Y < 0)
                {
                    //find the new postion of y based on speed 
                    appleSpeed[i] *= -1;
                }
            }
            for (int i = 0; i < apple.Count(); i++)
            {
                //Removes apple list
                if (apple[i].Y > 550)
                {
                    apple.RemoveAt(i);
                    appleSpeed.RemoveAt(i);
                }
                //Rremove life
                if (life1.Visible == true)
                {
                    life1.Visible = false;
                }
                else if (life2.Visible == true)
                {
                    life2.Visible = false;
                }
                else if (life3.Visible == true)
                { 
                    life3.Visible = false;
                }
            }

            for (int i = 0; i < banana.Count(); i++)
            {
                if (banana[i].Y < 0)
                {
                    //find the new postion of y based on speed 
                    bananaSpeed[i] *= -1;
                }
            }
            for (int i = 0; i < banana.Count(); i++)
            {
                if (banana[i].Y > 550)
                {
                    //Removes banana list
                    banana.RemoveAt(i);
                    bananaSpeed.RemoveAt(i);
                    //add a remove heart code here
                }
            } 

            for (int i = 0; i < pineapple.Count(); i++)
            {
                if (pineapple[i].Y < 0)
                {
                    //find the new postion of y based on speed 
                    pineappleSpeed[i] *= -1;
                }
            }
            for (int i = 0; i < pineapple.Count(); i++)
            {
                if (pineapple[i].Y > 550)
                {
                    //Removes pineapple list
                    pineapple.RemoveAt(i);
                    pineappleSpeed.RemoveAt(i);
                    //add a remove heart code here
                }
            }

            for (int i = 0; i < bomb.Count(); i++)
            {
                if (bomb[i].Y < 0)
                {
                    //find the new postion of y based on speed 
                    bombSpeed[i] *= -1;
                }
            }
            for (int i = 0; i < bomb.Count(); i++)
            {
                if (bomb[i].Y > 550)
                {
                    //Removes apple list
                    bomb.RemoveAt(i);
                    bombSpeed.RemoveAt(i);
                    //add a remove heart code here
                }
            }
            //check if fruit hits player. If yes remove it & add score
            for (int i = 0; i < apple.Count(); i++)
            {
                if (target.IntersectsWith(apple[i]))
                {
                    apple.RemoveAt(i);
                    appleSpeed.RemoveAt(i);
                    score++;
                    scoreLabel.Text = $"Your Score: {score}";
                }
            }

            for (int i = 0; i < banana.Count(); i++)
            {
                if (target.IntersectsWith(banana[i]))
                {
                    banana.RemoveAt(i);
                    bananaSpeed.RemoveAt(i);
                    score++;
                    scoreLabel.Text = $"Your Score: {score}";
                }
            }

            for (int i = 0; i < pineapple.Count(); i++)
            {
                if (target.IntersectsWith(pineapple[i]))
                {
                    pineapple.RemoveAt(i);
                    pineappleSpeed.RemoveAt(i);
                    score++;
                    scoreLabel.Text = $"Your Score: {score}";
                }
            }

            for (int i = 0; i < bomb.Count(); i++)
            {
                if (target.IntersectsWith(bomb[i]))
                {
                    bomb.RemoveAt(i);
                    bombSpeed.RemoveAt(i);
                    score++;
                    scoreLabel.Text = $"Your Score: die{score}";
                }
            }
            counter++;
            int x;
            int x2;
            int x3;
            int x4;
            int count;
            int count2;
            int count3;
            int count4;
            count = randGen.Next(40, 130);
            count2 = randGen.Next(40, 130);
            count3 = randGen.Next(40, 130);
            count4 = randGen.Next(40, 130);
            x = randGen.Next(0, 825);
            x2 = randGen.Next(0, 825);
            x3 = randGen.Next(0, 825);
            x4 = randGen.Next(0, 825);

            if (counter == 40)
            {
                apple.Add(new Rectangle(x, 500, 40, 40));
                appleSpeed.Add(-6);              
            }
            if (counter == 60)
            {
                banana.Add(new Rectangle(x2, 500, 40, 40));
                bananaSpeed.Add(-6);
            }
            if (counter == 80)
            {
                pineapple.Add(new Rectangle(x3, 500, 40, 40));
                pineappleSpeed.Add(-6);
            }
            if (counter == 100)
            {
                bomb.Add(new Rectangle(x4, 500, 40, 40));
                bombSpeed.Add(-6);
                counter = 0;
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.White, target);

            for (int i = 0; i < apple.Count(); i++)
            {
                e.Graphics.DrawImage(Properties.Resources.apple, apple[i]);
            }
            for (int i = 0; i < banana.Count(); i++)
            {
                e.Graphics.DrawImage(Properties.Resources.banana, banana[i]);
            }
            for (int i = 0; i < pineapple.Count(); i++)
            {
                e.Graphics.DrawImage(Properties.Resources.pineapple, pineapple[i]);
            }
            for (int i = 0; i < bomb.Count(); i++)
            {
                e.Graphics.DrawImage(Properties.Resources.bomb, bomb[i]);
            }
        }
      
    }
}
