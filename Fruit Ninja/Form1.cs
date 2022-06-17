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
using System.IO;

namespace Fruit_Ninja
{
    public partial class playArea : Form
    {
        //Player score, life & speed
        int score = 0;
        int highscore = 0;
        int life = 3;
        int FruitSpeed = -9;
        //Countdown to game start
        int counter = 0;
        //Player and ball hit box
        Rectangle target = new Rectangle(0, 0, 10, 10);
        //Obstacles lists
        List<Rectangle> apple = new List<Rectangle>();
        List<int> appleSpeed = new List<int>();

        List<Rectangle> banana = new List<Rectangle>();
        List<int> bananaSpeed = new List<int>();

        List<Rectangle> pineapple = new List<Rectangle>();
        List<int> pineappleSpeed = new List<int>();

        List<Rectangle> mango = new List<Rectangle>();
        List<int> mangoSpeed = new List<int>();

        List<Rectangle> watermelon = new List<Rectangle>();
        List<int> watermelonSpeed = new List<int>();

        List<Rectangle> bomb = new List<Rectangle>();
        List<int> bombSpeed = new List<int>();

        //Different brushes/pens
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush orangeBrush = new SolidBrush(Color.Orange);

        //Random values
        Random randGen = new Random();

        //Game State
        string gameState = "waiting";

        //background music/music
        System.Windows.Media.MediaPlayer backMusic = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer slashSound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer boomSound = new System.Windows.Media.MediaPlayer();
        System.Windows.Media.MediaPlayer downSound = new System.Windows.Media.MediaPlayer();
        public playArea()
        {
            InitializeComponent();
            backMusic.Open(new Uri(Application.StartupPath + "/Resources/backMusic.mp3"));
            backMusic.MediaEnded += new EventHandler(Media_Ended);
            slashSound.Open(new Uri(Application.StartupPath + "/Resources/cut.wav"));
            boomSound.Open(new Uri(Application.StartupPath + "/Resources/boom.wav"));
            downSound.Open(new Uri(Application.StartupPath + "/Resources/down.wav"));

        }
        private void Media_Ended(object sender, EventArgs e)
        {
            backMusic.Stop();
            backMusic.Play();
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
            mango.Clear();
            mangoSpeed.Clear();
            watermelon.Clear();
            watermelonSpeed.Clear();
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
            scoreLabel.Text = "Your Score:";
            appleImage.Visible = false;
            bananaImage.Visible = false;
            pineappleImage.Visible = false;
            mangoImage.Visible = false;
            watermelonImage.Visible = false;
            buttonHelpLabel.Visible = false;
            logoImage.Visible = false;
            bombImage.Visible = false;
            instructionsLabel.Visible = false;
            deadLabel.Visible = false;
            gameEngine.Enabled = true;
            exit2Button.Visible = true;
            restartButton.Visible = true;
            easyButton.Visible = false;
            hardButton.Visible = false;
            mediumButton.Visible = false;
            life1.Visible = true;
            life2.Visible = true;
            life3.Visible = true;
            life = 3;
            //Background music
            backMusic.Play();

            this.Focus();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void restartButton_Click(object sender, EventArgs e)
        {
            
            apple.Clear();
            appleSpeed.Clear();
            banana.Clear();
            bananaSpeed.Clear();
            pineapple.Clear();
            pineappleSpeed.Clear();
            mango.Clear();
            mangoSpeed.Clear();
            watermelon.Clear();
            watermelonSpeed.Clear();
            bomb.Clear();
            bombSpeed.Clear();

            backMusic.Stop();

            //Buttons, images & text re added when restart button is pressed
            startButton.Visible = true;
            exitButton.Visible = true;
            this.BackgroundImage = Properties.Resources.Screenshot__6_;
            Convert.ToString(counter);
            appleImage.Visible = true;
            bananaImage.Visible = true;
            pineappleImage.Visible = true;
            mangoImage.Visible = true;
            watermelonImage.Visible = true;
            buttonHelpLabel.Visible = true;
            logoImage.Visible = true;
            bombImage.Visible = true;
            instructionsLabel.Visible = true;
            deadLabel.Visible = false;
            gameEngine.Enabled = false;
            exit2Button.Visible = false;
            restartButton.Visible = false;
            easyButton.Visible = true;
            hardButton.Visible = true;
            mediumButton.Visible = true;
            life1.Visible = false;
            life2.Visible = false;
            life3.Visible = false;

            //Creates High score
            if (score > highscore)
            {
                highscore = score;
                highscoreLabel.Text = $"High Score: {score}";
                score = 0;
            }
            else if (score < highscore)
            {
                score = 0;
            }
        }
        private void easyButton_Click(object sender, EventArgs e)
        {
            FruitSpeed = -9;
        }
        private void mediumButton_Click(object sender, EventArgs e)
        {
            FruitSpeed = -16;
        }
        private void hardButton_Click_1(object sender, EventArgs e)
        {
            FruitSpeed = -20;
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

            for (int i = 0; i < mango.Count(); i++)
            {
                //find the new postion of y based on speed 
                int y = mango[i].Y + mangoSpeed[i];

                //replace the rectangle in the list with updated one using new y 
                mango[i] = new Rectangle(mango[i].X, y, mango[i].Width, mango[i].Height);
            }

            for (int i = 0; i < watermelon.Count(); i++)
            {
                //find the new postion of y based on speed 
                int y = watermelon[i].Y + watermelonSpeed[i];

                //replace the rectangle in the list with updated one using new y 
                watermelon[i] = new Rectangle(watermelon[i].X, y, watermelon[i].Width, watermelon[i].Height);
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
                    appleSpeed[i] *= -2;
                }
            }
            for (int i = 0; i < apple.Count(); i++)
            {
                //Removes apple list
                if (apple[i].Y > 550)
                {
                    apple.RemoveAt(i);
                    appleSpeed.RemoveAt(i);
                    life--;
                    downSound.Stop();
                    downSound.Play();
                }
            }

            for (int i = 0; i < banana.Count(); i++)
            {
                if (banana[i].Y < 0)
                {
                    //find the new postion of y based on speed 
                    bananaSpeed[i] *= -2;
                }
            }
            for (int i = 0; i < banana.Count(); i++)
            {
                if (banana[i].Y > 550)
                {
                    //Removes banana list
                    banana.RemoveAt(i);
                    bananaSpeed.RemoveAt(i);
                    life--;
                    downSound.Stop();
                    downSound.Play();
                }
            }

            for (int i = 0; i < pineapple.Count(); i++)
            {
                if (pineapple[i].Y < 0)
                {
                    //find the new postion of y based on speed 
                    pineappleSpeed[i] *= -2;
                }
            }
            for (int i = 0; i < pineapple.Count(); i++)
            {
                if (pineapple[i].Y > 550)
                {
                    //Removes pineapple list
                    pineapple.RemoveAt(i);
                    pineappleSpeed.RemoveAt(i);
                    life--;
                    downSound.Stop();
                    downSound.Play();
                }
            }

            for (int i = 0; i < mango.Count(); i++)
            {
                if (mango[i].Y < 0)
                {
                    //find the new postion of y based on speed 
                    mangoSpeed[i] *= -2;
                }
            }
            for (int i = 0; i < mango.Count(); i++)
            {
                //Removes mango list
                if (mango[i].Y > 550)
                {
                    mango.RemoveAt(i);
                    mangoSpeed.RemoveAt(i);
                    life--;
                    downSound.Stop();
                    downSound.Play();
                }
            }

            for (int i = 0; i < watermelon.Count(); i++)
            {
                if (watermelon[i].Y < 0)
                {
                    //find the new postion of y based on speed 
                    watermelonSpeed[i] *= -3;
                }
            }
            for (int i = 0; i < watermelon.Count(); i++)
            {
                //Removes watermelon list
                if (watermelon[i].Y > 550)
                {
                    watermelon.RemoveAt(i);
                    watermelonSpeed.RemoveAt(i);
                    life--;
                    downSound.Stop();
                    downSound.Play();
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
                }
            }
            //checks is lifes is lost than remove hearts, if all life gone player dies

            if (life == 2)
            {
                life3.Visible = false;
            }
            else if (life == 1)
            {
                life2.Visible = false;
            }
            else if (life == 0)
            {
                life1.Visible = false;
                gameState = "waiting";
                deadLabel.Visible = true;
                gameEngine.Enabled = false;
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
                    slashSound.Stop();
                    slashSound.Play();
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
                    slashSound.Stop();
                    slashSound.Play();
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
                    slashSound.Stop();
                    slashSound.Play();
                }
            }

            for (int i = 0; i < bomb.Count(); i++)
            {
                if (target.IntersectsWith(bomb[i]))
                {
                    bomb.RemoveAt(i);
                    bombSpeed.RemoveAt(i);
                    life--;
                    boomSound.Stop();
                    boomSound.Play();
                }
            }

            for (int i = 0; i < mango.Count(); i++)
            {
                if (target.IntersectsWith(mango[i]))
                {
                    mango.RemoveAt(i);
                    mangoSpeed.RemoveAt(i);
                    score++;
                    scoreLabel.Text = $"Your Score: {score}";
                    slashSound.Stop();
                    slashSound.Play();
                }
            }

            for (int i = 0; i < watermelon.Count(); i++)
            {
                if (target.IntersectsWith(watermelon[i]))
                {
                    watermelon.RemoveAt(i);
                    watermelonSpeed.RemoveAt(i);
                    score++;
                    scoreLabel.Text = $"Your Score: {score}";
                    slashSound.Stop();
                    slashSound.Play();
                }
            }

            counter++;

            int x;
            int x2;
            int x3;
            int x4;
            int x5;
            int x6;
           
            x = randGen.Next(10, 790);
            x2 = randGen.Next(10, 790);
            x3 = randGen.Next(10, 790);
            x4 = randGen.Next(10, 790);
            x5 = randGen.Next(10, 790);
            x6 = randGen.Next(10, 790);
            
            if (counter == 40)
            {
                apple.Add(new Rectangle(x, 499, 40, 40));
                appleSpeed.Add(FruitSpeed);
            }
            if (counter == 60)
            {
                banana.Add(new Rectangle(x2, 499, 40, 40));
                bananaSpeed.Add(FruitSpeed);
            }
            if (counter == 80)
            {
                pineapple.Add(new Rectangle(x3, 499, 40, 40));
                pineappleSpeed.Add(FruitSpeed);
            }
            if (counter == 100)
            {
                bomb.Add(new Rectangle(x4, 499, 40, 40));
                bombSpeed.Add(FruitSpeed);
            }
            if (counter == 110)
            {
                mango.Add(new Rectangle(x5, 499, 40, 40));
                mangoSpeed.Add(FruitSpeed);
            }
            if (counter == 115)
            {
                watermelon.Add(new Rectangle(x5, 499, 40, 40));
                watermelonSpeed.Add(FruitSpeed);
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
            for (int i = 0; i < mango.Count(); i++)
            {
                e.Graphics.DrawImage(Properties.Resources.mango, mango[i]);
            }
            for (int i = 0; i < watermelon.Count(); i++)
            {
                e.Graphics.DrawImage(Properties.Resources.watermelon, watermelon[i]);
            }
        }
    }
}
