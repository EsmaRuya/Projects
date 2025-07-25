using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BouncingBallGame
{
    public partial class Form1 : Form
    {
        int stepMovement = 10; // Paddle
        int dx = 5, dy = 5; // Ball

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Create a new GraphicsPath to draw - define a shape
            GraphicsPath gp = new GraphicsPath();

            // Add a circle shape (ellipse) the same size as the PictureBox
            gp.AddEllipse(0, 0, Ball.Width, Ball.Height);

            // Apply the shape to the PictureBox so it appears circular
            Ball.Region = new Region(gp);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                Paddle.Left = Math.Min(this.ClientSize.Width - Paddle.Width, Paddle.Left + stepMovement);
            }
            if (e.KeyCode == Keys.Left)
            {
                Paddle.Left = Math.Max(0, Paddle.Left - stepMovement);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Ball.Left += dx;
            Ball.Top += dy;

            // Right and Left edge
            if (Ball.Right >= this.ClientSize.Width || Ball.Left <= 0)
            {
                dx = -dx;
            }

            // Top and paddle edge
            if (Ball.Bottom >= Paddle.Top && Ball.Left <= Paddle.Right && Ball.Right >= Paddle.Left || Ball.Top <= 0)
            {
                dy = -dy;
            }

            // Bottom edge = Loses
            if (Ball.Bottom >= this.ClientSize.Height)
            {
                timer.Stop();
                DialogResult result = MessageBox.Show("Ops! You lost!\nDo you want to play again?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    Ball.Top = 0;
                    Ball.Left = 0;
                    timer.Start();
                }
                else
                {
                    this.Close();
                }

            }


        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Ball.Visible = true;
            Paddle.Visible = true;

            btnAbout.Visible = false;
            btnPlay.Visible = false;

            timer.Enabled = true;

            this.ActiveControl = null;
            this.Focus();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Bouncing Ball is a simple reflex-based game where a ball bounces around the screen, and your goal is to keep it from falling by controlling a paddle at the bottom. Use the keyboard arrow keys to move the paddle left and right. Each time the ball hits the paddle, it bounces back—and if you miss, the game ends. Try to catch it as many times as you can!", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
