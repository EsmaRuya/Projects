namespace BouncingBallGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            Paddle = new PictureBox();
            Ball = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            btnAbout = new Button();
            btnPlay = new Button();
            ((System.ComponentModel.ISupportInitialize)Paddle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ball).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(240, 9);
            label1.Name = "label1";
            label1.Size = new Size(322, 45);
            label1.TabIndex = 0;
            label1.Text = "Bouncing Ball Game";
            // 
            // Paddle
            // 
            Paddle.BackColor = Color.Yellow;
            Paddle.Location = new Point(292, 425);
            Paddle.Name = "Paddle";
            Paddle.Size = new Size(152, 24);
            Paddle.TabIndex = 1;
            Paddle.TabStop = false;
            Paddle.Visible = false;
            // 
            // Ball
            // 
            Ball.BackColor = Color.Red;
            Ball.Location = new Point(375, 68);
            Ball.Name = "Ball";
            Ball.Size = new Size(30, 30);
            Ball.TabIndex = 2;
            Ball.TabStop = false;
            Ball.Visible = false;
            // 
            // timer
            // 
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // btnAbout
            // 
            btnAbout.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnAbout.Location = new Point(302, 153);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(198, 54);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "About";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnPlay
            // 
            btnPlay.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            btnPlay.Location = new Point(302, 258);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(198, 54);
            btnPlay.TabIndex = 4;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPlay);
            Controls.Add(btnAbout);
            Controls.Add(Ball);
            Controls.Add(Paddle);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BouncingBallGame";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Paddle).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ball).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox Paddle;
        private PictureBox Ball;
        private System.Windows.Forms.Timer timer;
        private Button btnAbout;
        private Button btnPlay;
    }
}
