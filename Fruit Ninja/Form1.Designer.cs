namespace Fruit_Ninja
{
    partial class playArea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playArea));
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.buttonHelpLabel = new System.Windows.Forms.Label();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.appleImage = new System.Windows.Forms.PictureBox();
            this.pineappleImage = new System.Windows.Forms.PictureBox();
            this.bananaImage = new System.Windows.Forms.PictureBox();
            this.bombImage = new System.Windows.Forms.PictureBox();
            this.gameEngine = new System.Windows.Forms.Timer(this.components);
            this.exit2Button = new System.Windows.Forms.Button();
            this.life1 = new System.Windows.Forms.PictureBox();
            this.life2 = new System.Windows.Forms.PictureBox();
            this.life3 = new System.Windows.Forms.PictureBox();
            this.deadLabel = new System.Windows.Forms.Label();
            this.mangoImage = new System.Windows.Forms.PictureBox();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.watermelonImage = new System.Windows.Forms.PictureBox();
            this.easyButton = new System.Windows.Forms.Button();
            this.hardButton = new System.Windows.Forms.Button();
            this.mediumButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineappleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.watermelonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLabel.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.instructionsLabel.Location = new System.Drawing.Point(185, 78);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(582, 375);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = resources.GetString("instructionsLabel.Text");
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.titleLabel.Font = new System.Drawing.Font("Baskerville Old Face", 20F);
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(399, -4);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(169, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Fruit Ninja";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.scoreLabel.Font = new System.Drawing.Font("Baskerville Old Face", 16F);
            this.scoreLabel.ForeColor = System.Drawing.Color.Red;
            this.scoreLabel.Location = new System.Drawing.Point(172, 1);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(181, 23);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Your Score:";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Red_brick;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startButton.Location = new System.Drawing.Point(12, 166);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(115, 60);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Red_brick;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exitButton.Location = new System.Drawing.Point(12, 248);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(115, 60);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // buttonHelpLabel
            // 
            this.buttonHelpLabel.BackColor = System.Drawing.Color.Transparent;
            this.buttonHelpLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelpLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonHelpLabel.Image = global::Fruit_Ninja.Properties.Resources.Red_brick;
            this.buttonHelpLabel.Location = new System.Drawing.Point(12, 325);
            this.buttonHelpLabel.Name = "buttonHelpLabel";
            this.buttonHelpLabel.Size = new System.Drawing.Size(115, 113);
            this.buttonHelpLabel.TabIndex = 0;
            this.buttonHelpLabel.Text = "Controls:\r\n\r\n  Player 1:  Move mouse to\r\nmove\r\n\r\n";
            this.buttonHelpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // logoImage
            // 
            this.logoImage.BackColor = System.Drawing.Color.Transparent;
            this.logoImage.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Lago;
            this.logoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoImage.Location = new System.Drawing.Point(36, 1);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(91, 78);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImage.TabIndex = 2;
            this.logoImage.TabStop = false;
            // 
            // appleImage
            // 
            this.appleImage.BackColor = System.Drawing.Color.Transparent;
            this.appleImage.BackgroundImage = global::Fruit_Ninja.Properties.Resources.apple;
            this.appleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.appleImage.Location = new System.Drawing.Point(751, 99);
            this.appleImage.Name = "appleImage";
            this.appleImage.Size = new System.Drawing.Size(46, 31);
            this.appleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.appleImage.TabIndex = 2;
            this.appleImage.TabStop = false;
            // 
            // pineappleImage
            // 
            this.pineappleImage.BackColor = System.Drawing.Color.Transparent;
            this.pineappleImage.BackgroundImage = global::Fruit_Ninja.Properties.Resources.pineapple;
            this.pineappleImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pineappleImage.Location = new System.Drawing.Point(168, 258);
            this.pineappleImage.Name = "pineappleImage";
            this.pineappleImage.Size = new System.Drawing.Size(48, 31);
            this.pineappleImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pineappleImage.TabIndex = 2;
            this.pineappleImage.TabStop = false;
            // 
            // bananaImage
            // 
            this.bananaImage.BackColor = System.Drawing.Color.Transparent;
            this.bananaImage.BackgroundImage = global::Fruit_Ninja.Properties.Resources.banana;
            this.bananaImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bananaImage.Location = new System.Drawing.Point(726, 368);
            this.bananaImage.Name = "bananaImage";
            this.bananaImage.Size = new System.Drawing.Size(41, 31);
            this.bananaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bananaImage.TabIndex = 2;
            this.bananaImage.TabStop = false;
            // 
            // bombImage
            // 
            this.bombImage.BackColor = System.Drawing.Color.Transparent;
            this.bombImage.BackgroundImage = global::Fruit_Ninja.Properties.Resources.bomb;
            this.bombImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bombImage.Location = new System.Drawing.Point(213, 405);
            this.bombImage.Name = "bombImage";
            this.bombImage.Size = new System.Drawing.Size(33, 33);
            this.bombImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bombImage.TabIndex = 2;
            this.bombImage.TabStop = false;
            // 
            // gameEngine
            // 
            this.gameEngine.Interval = 20;
            this.gameEngine.Tick += new System.EventHandler(this.gameEngine_Tick);
            // 
            // exit2Button
            // 
            this.exit2Button.BackColor = System.Drawing.Color.Transparent;
            this.exit2Button.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Red_brick;
            this.exit2Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit2Button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit2Button.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit2Button.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.exit2Button.Location = new System.Drawing.Point(3, 5);
            this.exit2Button.Name = "exit2Button";
            this.exit2Button.Size = new System.Drawing.Size(73, 25);
            this.exit2Button.TabIndex = 1;
            this.exit2Button.Text = "Exit";
            this.exit2Button.UseVisualStyleBackColor = false;
            this.exit2Button.Visible = false;
            this.exit2Button.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // life1
            // 
            this.life1.BackColor = System.Drawing.Color.Transparent;
            this.life1.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Heart;
            this.life1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.life1.Location = new System.Drawing.Point(760, 423);
            this.life1.Name = "life1";
            this.life1.Size = new System.Drawing.Size(48, 40);
            this.life1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life1.TabIndex = 3;
            this.life1.TabStop = false;
            this.life1.Visible = false;
            // 
            // life2
            // 
            this.life2.BackColor = System.Drawing.Color.Transparent;
            this.life2.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Heart;
            this.life2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.life2.Location = new System.Drawing.Point(760, 386);
            this.life2.Name = "life2";
            this.life2.Size = new System.Drawing.Size(48, 40);
            this.life2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life2.TabIndex = 4;
            this.life2.TabStop = false;
            this.life2.Visible = false;
            // 
            // life3
            // 
            this.life3.BackColor = System.Drawing.Color.Transparent;
            this.life3.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Heart;
            this.life3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.life3.Location = new System.Drawing.Point(760, 350);
            this.life3.Name = "life3";
            this.life3.Size = new System.Drawing.Size(48, 40);
            this.life3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.life3.TabIndex = 5;
            this.life3.TabStop = false;
            this.life3.Visible = false;
            // 
            // deadLabel
            // 
            this.deadLabel.BackColor = System.Drawing.Color.Transparent;
            this.deadLabel.Font = new System.Drawing.Font("Baskerville Old Face", 20F);
            this.deadLabel.ForeColor = System.Drawing.Color.Red;
            this.deadLabel.Location = new System.Drawing.Point(327, 194);
            this.deadLabel.Name = "deadLabel";
            this.deadLabel.Size = new System.Drawing.Size(169, 32);
            this.deadLabel.TabIndex = 0;
            this.deadLabel.Text = "You Lose!";
            this.deadLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.deadLabel.Visible = false;
            // 
            // mangoImage
            // 
            this.mangoImage.BackColor = System.Drawing.Color.Transparent;
            this.mangoImage.BackgroundImage = global::Fruit_Ninja.Properties.Resources.mango;
            this.mangoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.mangoImage.Location = new System.Drawing.Point(155, 86);
            this.mangoImage.Name = "mangoImage";
            this.mangoImage.Size = new System.Drawing.Size(46, 31);
            this.mangoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mangoImage.TabIndex = 2;
            this.mangoImage.TabStop = false;
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.highscoreLabel.Font = new System.Drawing.Font("Baskerville Old Face", 16F);
            this.highscoreLabel.ForeColor = System.Drawing.Color.Red;
            this.highscoreLabel.Location = new System.Drawing.Point(616, 1);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(181, 23);
            this.highscoreLabel.TabIndex = 0;
            this.highscoreLabel.Text = "High Score:";
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Red_brick;
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartButton.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.restartButton.Location = new System.Drawing.Point(93, 5);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(73, 25);
            this.restartButton.TabIndex = 1;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // watermelonImage
            // 
            this.watermelonImage.BackColor = System.Drawing.Color.Transparent;
            this.watermelonImage.BackgroundImage = global::Fruit_Ninja.Properties.Resources.watermelon;
            this.watermelonImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.watermelonImage.Location = new System.Drawing.Point(751, 229);
            this.watermelonImage.Name = "watermelonImage";
            this.watermelonImage.Size = new System.Drawing.Size(55, 46);
            this.watermelonImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.watermelonImage.TabIndex = 2;
            this.watermelonImage.TabStop = false;
            // 
            // easyButton
            // 
            this.easyButton.BackColor = System.Drawing.Color.Transparent;
            this.easyButton.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Red_brick;
            this.easyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.easyButton.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.easyButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.easyButton.Location = new System.Drawing.Point(3, 77);
            this.easyButton.Name = "easyButton";
            this.easyButton.Size = new System.Drawing.Size(66, 31);
            this.easyButton.TabIndex = 1;
            this.easyButton.Text = "Lvl 1";
            this.easyButton.UseVisualStyleBackColor = false;
            this.easyButton.Click += new System.EventHandler(this.easyButton_Click);
            // 
            // hardButton
            // 
            this.hardButton.BackColor = System.Drawing.Color.Transparent;
            this.hardButton.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Red_brick;
            this.hardButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hardButton.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hardButton.Location = new System.Drawing.Point(36, 114);
            this.hardButton.Name = "hardButton";
            this.hardButton.Size = new System.Drawing.Size(71, 33);
            this.hardButton.TabIndex = 1;
            this.hardButton.Text = "Lvl 3";
            this.hardButton.UseVisualStyleBackColor = false;
            this.hardButton.Click += new System.EventHandler(this.hardButton_Click_1);
            // 
            // mediumButton
            // 
            this.mediumButton.BackColor = System.Drawing.Color.Transparent;
            this.mediumButton.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Red_brick;
            this.mediumButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mediumButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mediumButton.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.mediumButton.Location = new System.Drawing.Point(75, 77);
            this.mediumButton.Name = "mediumButton";
            this.mediumButton.Size = new System.Drawing.Size(66, 31);
            this.mediumButton.TabIndex = 1;
            this.mediumButton.Text = "Lvl 2";
            this.mediumButton.UseVisualStyleBackColor = false;
            this.mediumButton.Click += new System.EventHandler(this.mediumButton_Click);
            // 
            // playArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Screenshot__6_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 461);
            this.Controls.Add(this.deadLabel);
            this.Controls.Add(this.life3);
            this.Controls.Add(this.life2);
            this.Controls.Add(this.life1);
            this.Controls.Add(this.bananaImage);
            this.Controls.Add(this.pineappleImage);
            this.Controls.Add(this.bombImage);
            this.Controls.Add(this.mangoImage);
            this.Controls.Add(this.watermelonImage);
            this.Controls.Add(this.appleImage);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.exit2Button);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.hardButton);
            this.Controls.Add(this.mediumButton);
            this.Controls.Add(this.easyButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.buttonHelpLabel);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.logoImage);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "playArea";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineappleImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.life3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mangoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.watermelonImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label buttonHelpLabel;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.PictureBox appleImage;
        private System.Windows.Forms.PictureBox pineappleImage;
        private System.Windows.Forms.PictureBox bananaImage;
        private System.Windows.Forms.PictureBox bombImage;
        private System.Windows.Forms.Timer gameEngine;
        private System.Windows.Forms.Button exit2Button;
        private System.Windows.Forms.PictureBox life1;
        private System.Windows.Forms.PictureBox life2;
        private System.Windows.Forms.PictureBox life3;
        private System.Windows.Forms.Label deadLabel;
        private System.Windows.Forms.PictureBox mangoImage;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.PictureBox watermelonImage;
        private System.Windows.Forms.Button easyButton;
        private System.Windows.Forms.Button hardButton;
        private System.Windows.Forms.Button mediumButton;
        //     private System.Windows.Forms.Label playArea;
    }
}

