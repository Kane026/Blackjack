namespace Blackjack
{
    partial class Form1
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
            dealButton = new Button();
            pictureBoxDealer1 = new PictureBox();
            pictureBox1Player = new PictureBox();
            pictureBox2Player = new PictureBox();
            pictureBoxDealer2 = new PictureBox();
            shuffleButton = new Button();
            dealerScore = new TextBox();
            playerScore = new TextBox();
            standButton = new Button();
            hitButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBoxDealer3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer3).BeginInit();
            SuspendLayout();
            // 
            // dealButton
            // 
            dealButton.Location = new Point(98, 199);
            dealButton.Name = "dealButton";
            dealButton.Size = new Size(94, 29);
            dealButton.TabIndex = 0;
            dealButton.Text = "Deal";
            dealButton.UseVisualStyleBackColor = true;
            dealButton.Click += dealButton_Click;
            // 
            // pictureBoxDealer1
            // 
            pictureBoxDealer1.Location = new Point(254, 48);
            pictureBoxDealer1.Name = "pictureBoxDealer1";
            pictureBoxDealer1.Size = new Size(106, 139);
            pictureBoxDealer1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDealer1.TabIndex = 1;
            pictureBoxDealer1.TabStop = false;
            pictureBoxDealer1.Click += pictureCard_Click;
            // 
            // pictureBox1Player
            // 
            pictureBox1Player.Location = new Point(254, 259);
            pictureBox1Player.Name = "pictureBox1Player";
            pictureBox1Player.Size = new Size(106, 147);
            pictureBox1Player.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1Player.TabIndex = 2;
            pictureBox1Player.TabStop = false;
            pictureBox1Player.Click += pictureBox1_Click;
            // 
            // pictureBox2Player
            // 
            pictureBox2Player.Location = new Point(406, 259);
            pictureBox2Player.Name = "pictureBox2Player";
            pictureBox2Player.Size = new Size(106, 147);
            pictureBox2Player.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2Player.TabIndex = 3;
            pictureBox2Player.TabStop = false;
            // 
            // pictureBoxDealer2
            // 
            pictureBoxDealer2.Location = new Point(406, 48);
            pictureBoxDealer2.Name = "pictureBoxDealer2";
            pictureBoxDealer2.Size = new Size(106, 139);
            pictureBoxDealer2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDealer2.TabIndex = 4;
            pictureBoxDealer2.TabStop = false;
            // 
            // shuffleButton
            // 
            shuffleButton.Location = new Point(98, 148);
            shuffleButton.Name = "shuffleButton";
            shuffleButton.Size = new Size(94, 29);
            shuffleButton.TabIndex = 5;
            shuffleButton.Text = "Shuffle";
            shuffleButton.UseVisualStyleBackColor = true;
            shuffleButton.Click += shuffleButton_Click;
            // 
            // dealerScore
            // 
            dealerScore.Location = new Point(318, 12);
            dealerScore.Name = "dealerScore";
            dealerScore.Size = new Size(125, 27);
            dealerScore.TabIndex = 6;
            dealerScore.TextChanged += textBox1_TextChanged;
            // 
            // playerScore
            // 
            playerScore.Location = new Point(318, 226);
            playerScore.Name = "playerScore";
            playerScore.Size = new Size(125, 27);
            playerScore.TabIndex = 7;
            // 
            // standButton
            // 
            standButton.Location = new Point(98, 302);
            standButton.Name = "standButton";
            standButton.Size = new Size(94, 29);
            standButton.TabIndex = 8;
            standButton.Text = "Stand";
            standButton.UseVisualStyleBackColor = true;
            standButton.Click += standButton_Click;
            // 
            // hitButton
            // 
            hitButton.Location = new Point(98, 249);
            hitButton.Name = "hitButton";
            hitButton.Size = new Size(94, 29);
            hitButton.TabIndex = 9;
            hitButton.Text = "Hit";
            hitButton.UseVisualStyleBackColor = true;
            hitButton.Click += hitButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(555, 259);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 147);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBoxDealer3
            // 
            pictureBoxDealer3.Location = new Point(555, 48);
            pictureBoxDealer3.Name = "pictureBoxDealer3";
            pictureBoxDealer3.Size = new Size(106, 139);
            pictureBoxDealer3.TabIndex = 11;
            pictureBoxDealer3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBoxDealer3);
            Controls.Add(pictureBox1);
            Controls.Add(hitButton);
            Controls.Add(standButton);
            Controls.Add(playerScore);
            Controls.Add(dealerScore);
            Controls.Add(shuffleButton);
            Controls.Add(pictureBoxDealer2);
            Controls.Add(pictureBox2Player);
            Controls.Add(pictureBox1Player);
            Controls.Add(pictureBoxDealer1);
            Controls.Add(dealButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button dealButton;
        private PictureBox pictureBoxDealer1;
        private PictureBox pictureBox1Player;
        private PictureBox pictureBox2Player;
        private PictureBox pictureBoxDealer2;
        private Button shuffleButton;
        private TextBox dealerScore;
        private TextBox playerScore;
        private Button standButton;
        private Button hitButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBoxDealer3;
    }
}