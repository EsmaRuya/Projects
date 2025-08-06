namespace PaintApp
{
    partial class frmPaint
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
            DrawingSpacePanel = new Panel();
            picBoxRectangle = new PictureBox();
            picBocTraingle = new PictureBox();
            picBoxCircle = new PictureBox();
            picBoxPen = new PictureBox();
            picBoxColor = new PictureBox();
            picBoxEraser = new PictureBox();
            colorDialog = new ColorDialog();
            DrawingSpacePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBoxRectangle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBocTraingle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxCircle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxColor).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBoxEraser).BeginInit();
            SuspendLayout();
            // 
            // DrawingSpacePanel
            // 
            DrawingSpacePanel.Controls.Add(picBoxRectangle);
            DrawingSpacePanel.Controls.Add(picBocTraingle);
            DrawingSpacePanel.Controls.Add(picBoxCircle);
            DrawingSpacePanel.Controls.Add(picBoxPen);
            DrawingSpacePanel.Controls.Add(picBoxColor);
            DrawingSpacePanel.Controls.Add(picBoxEraser);
            DrawingSpacePanel.Dock = DockStyle.Fill;
            DrawingSpacePanel.Location = new Point(0, 0);
            DrawingSpacePanel.Name = "DrawingSpacePanel";
            DrawingSpacePanel.Size = new Size(805, 450);
            DrawingSpacePanel.TabIndex = 0;
            DrawingSpacePanel.Paint += DrawingSpacePanel_Paint;
            DrawingSpacePanel.MouseDown += DrawingSpacePanel_MouseDown;
            DrawingSpacePanel.MouseMove += DrawingSpacePanel_MouseMove;
            DrawingSpacePanel.MouseUp += DrawingSpacePanel_MouseUp;
            // 
            // picBoxRectangle
            // 
            picBoxRectangle.Image = Properties.Resources.frame;
            picBoxRectangle.Location = new Point(273, 8);
            picBoxRectangle.Name = "picBoxRectangle";
            picBoxRectangle.Size = new Size(47, 37);
            picBoxRectangle.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxRectangle.TabIndex = 7;
            picBoxRectangle.TabStop = false;
            picBoxRectangle.Click += picBoxRectangle_Click;
            // 
            // picBocTraingle
            // 
            picBocTraingle.Image = Properties.Resources.triangle;
            picBocTraingle.Location = new Point(220, 8);
            picBocTraingle.Name = "picBocTraingle";
            picBocTraingle.Size = new Size(47, 37);
            picBocTraingle.SizeMode = PictureBoxSizeMode.StretchImage;
            picBocTraingle.TabIndex = 6;
            picBocTraingle.TabStop = false;
            picBocTraingle.Click += picBocTraingle_Click;
            // 
            // picBoxCircle
            // 
            picBoxCircle.Image = Properties.Resources.circle;
            picBoxCircle.Location = new Point(167, 8);
            picBoxCircle.Name = "picBoxCircle";
            picBoxCircle.Size = new Size(47, 37);
            picBoxCircle.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxCircle.TabIndex = 5;
            picBoxCircle.TabStop = false;
            picBoxCircle.Click += picBoxCircle_Click;
            // 
            // picBoxPen
            // 
            picBoxPen.Image = Properties.Resources.pencil;
            picBoxPen.Location = new Point(114, 8);
            picBoxPen.Name = "picBoxPen";
            picBoxPen.Size = new Size(47, 37);
            picBoxPen.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxPen.TabIndex = 4;
            picBoxPen.TabStop = false;
            picBoxPen.Click += picBoxPen_Click;
            // 
            // picBoxColor
            // 
            picBoxColor.Image = Properties.Resources.color_wheel;
            picBoxColor.Location = new Point(61, 8);
            picBoxColor.Name = "picBoxColor";
            picBoxColor.Size = new Size(47, 37);
            picBoxColor.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxColor.TabIndex = 3;
            picBoxColor.TabStop = false;
            picBoxColor.Click += picBoxColor_Click;
            // 
            // picBoxEraser
            // 
            picBoxEraser.Image = Properties.Resources.eraser;
            picBoxEraser.Location = new Point(8, 8);
            picBoxEraser.Name = "picBoxEraser";
            picBoxEraser.Size = new Size(47, 37);
            picBoxEraser.SizeMode = PictureBoxSizeMode.StretchImage;
            picBoxEraser.TabIndex = 2;
            picBoxEraser.TabStop = false;
            picBoxEraser.Click += picBoxEraser_Click;
            // 
            // frmPaint
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 450);
            Controls.Add(DrawingSpacePanel);
            Name = "frmPaint";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paint App";
            WindowState = FormWindowState.Maximized;
            DrawingSpacePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picBoxRectangle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBocTraingle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxCircle).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxPen).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxColor).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBoxEraser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel DrawingSpacePanel;
        private ColorDialog colorDialog;
        private PictureBox picBoxColor;
        private PictureBox picBoxEraser;
        private PictureBox picBoxPen;
        private PictureBox picBoxCircle;
        private PictureBox picBoxRectangle;
        private PictureBox picBocTraingle;
    }
}
