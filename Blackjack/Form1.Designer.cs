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
            btnHit = new Button();
            pictureBoxDealer1 = new PictureBox();
            pictureBox1Player = new PictureBox();
            pictureBox2Player = new PictureBox();
            pictureBoxDealer2 = new PictureBox();
            shuffleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer2).BeginInit();
            SuspendLayout();
            // 
            // btnHit
            // 
            btnHit.Location = new Point(98, 199);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(94, 29);
            btnHit.TabIndex = 0;
            btnHit.Text = "Deal";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += button1_Click;
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
            shuffleButton.Location = new Point(98, 139);
            shuffleButton.Name = "shuffleButton";
            shuffleButton.Size = new Size(94, 29);
            shuffleButton.TabIndex = 5;
            shuffleButton.Text = "Shuffle";
            shuffleButton.UseVisualStyleBackColor = true;
            shuffleButton.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(shuffleButton);
            Controls.Add(pictureBoxDealer2);
            Controls.Add(pictureBox2Player);
            Controls.Add(pictureBox1Player);
            Controls.Add(pictureBoxDealer1);
            Controls.Add(btnHit);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDealer2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnHit;
        private PictureBox pictureBoxDealer1;
        private PictureBox pictureBox1Player;
        private PictureBox pictureBox2Player;
        private PictureBox pictureBoxDealer2;
        private Button shuffleButton;
    }
}