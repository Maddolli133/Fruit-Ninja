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
            this.highScoreLabel = new System.Windows.Forms.Label();
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
            this.restartButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pineappleImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bananaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bombImage)).BeginInit();
            this.SuspendLayout();
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.instructionsLabel.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.instructionsLabel.Location = new System.Drawing.Point(150, 77);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(614, 375);
            this.instructionsLabel.TabIndex = 0;
            this.instructionsLabel.Text = resources.GetString("instructionsLabel.Text");
            this.instructionsLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.titleLabel.Font = new System.Drawing.Font("Baskerville Old Face", 20F);
            this.titleLabel.ForeColor = System.Drawing.Color.Red;
            this.titleLabel.Location = new System.Drawing.Point(413, -2);
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
            this.scoreLabel.Location = new System.Drawing.Point(199, -2);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(181, 23);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "Your Score:";
            // 
            // highScoreLabel
            // 
            this.highScoreLabel.BackColor = System.Drawing.Color.YellowGreen;
            this.highScoreLabel.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScoreLabel.ForeColor = System.Drawing.Color.Red;
            this.highScoreLabel.Location = new System.Drawing.Point(630, -2);
            this.highScoreLabel.Name = "highScoreLabel";
            this.highScoreLabel.Size = new System.Drawing.Size(167, 25);
            this.highScoreLabel.TabIndex = 0;
            this.highScoreLabel.Text = "High Score: ";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Transparent;
            this.startButton.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Red_brick;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startButton.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.startButton.Location = new System.Drawing.Point(12, 137);
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
            this.exitButton.Location = new System.Drawing.Point(12, 229);
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
            this.buttonHelpLabel.Location = new System.Drawing.Point(12, 301);
            this.buttonHelpLabel.Name = "buttonHelpLabel";
            this.buttonHelpLabel.Size = new System.Drawing.Size(115, 162);
            this.buttonHelpLabel.TabIndex = 0;
            this.buttonHelpLabel.Text = "Controls:\r\n\r\n  Player 1:  Move mouse to\r\nmove\r\n\r\n Player 2: Spacebar to\r\n shoot b" +
    "ombs";
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
            this.appleImage.Location = new System.Drawing.Point(762, 203);
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
            this.pineappleImage.Location = new System.Drawing.Point(760, 277);
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
            this.bananaImage.Location = new System.Drawing.Point(762, 240);
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
            this.bombImage.Location = new System.Drawing.Point(770, 323);
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
            this.exit2Button.Location = new System.Drawing.Point(110, 0);
            this.exit2Button.Name = "exit2Button";
            this.exit2Button.Size = new System.Drawing.Size(73, 25);
            this.exit2Button.TabIndex = 1;
            this.exit2Button.Text = "Exit";
            this.exit2Button.UseVisualStyleBackColor = false;
            this.exit2Button.Visible = false;
            this.exit2Button.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.Transparent;
            this.restartButton.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Red_brick;
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restartButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.restartButton.Location = new System.Drawing.Point(12, 1);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(75, 24);
            this.restartButton.TabIndex = 3;
            this.restartButton.Text = "Restart";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Visible = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // playArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Fruit_Ninja.Properties.Resources.Screenshot__6_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 461);
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.bananaImage);
            this.Controls.Add(this.pineappleImage);
            this.Controls.Add(this.bombImage);
            this.Controls.Add(this.appleImage);
            this.Controls.Add(this.exit2Button);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.highScoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.buttonHelpLabel);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label highScoreLabel;
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
        private System.Windows.Forms.Button restartButton;
        //     private System.Windows.Forms.Label playArea;
    }
}

