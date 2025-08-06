using Microsoft.VisualBasic.Devices;
using System.Windows.Forms;

namespace PaintApp
{
    public partial class frmPaint : System.Windows.Forms.Form
    {
        enum DrawingMode { Pen, Circle, Rectangle, Traingle }

        DrawingMode currentMode = DrawingMode.Pen;
        Point startPoint, currentPoint;
        bool isDrawingShape = false;

        int prevX = -1;
        int prevY = -1;
        bool isDrawing = false;
        Graphics graphic;
        Pen pen;
        Color color = Color.Black;
        int thickness = 3;

        public frmPaint()
        {
            InitializeComponent();
        }

        // Start drawing
        private void DrawingSpacePanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentMode == DrawingMode.Pen)
            {
                // Record the starting position
                prevX = e.X;
                prevY = e.Y;

                // Set a flag that drawing has started
                isDrawing = true;

                // Capture the mouse to this control
                prevX = e.X;
                prevY = e.Y;
            }

            else
            {
                startPoint = e.Location;
                isDrawingShape = true;
            }

        }

        // Drawing
        private void DrawingSpacePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentMode == DrawingMode.Pen && isDrawing)
            {
                // Check if we're currently drawing 
                if (isDrawing && prevX != -1 && prevY != -1)
                {

                    // If yes, draw a line from the previous position to current position
                    graphic = DrawingSpacePanel.CreateGraphics();
                    pen = new Pen(color, thickness);
                    graphic.DrawLine(pen, prevX, prevY, e.Location.X, e.Location.Y);

                    // Update the previous position to current position
                    prevX = e.X;
                    prevY = e.Y;
                }
            }

            

            else if (isDrawingShape)
            {
                pen = new Pen(color, thickness);
                currentPoint = e.Location;
                // DrawingSpacePanel.Invalidate();    

            }

        }

        private void DrawingSpacePanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (currentMode == DrawingMode.Pen)
            {
                // Set the drawing flag to false
                isDrawing = false;

                // Release mouse capture
                prevX = -1;
                prevY = -1;
            }
            else if (isDrawingShape)
            {
                DrawFinalShape(startPoint, e.Location);
                isDrawingShape = false;
            }

        }

        private void picBoxEraser_Click(object sender, EventArgs e)
        {
            Graphics g = DrawingSpacePanel.CreateGraphics();
            g.Clear(DrawingSpacePanel.BackColor);
            g.Dispose(); //  cleaning up system resources
        }

        private void picBoxColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            color = colorDialog.Color;
        }

        private void picBoxPen_Click(object sender, EventArgs e)
        {
            currentMode = DrawingMode.Pen;
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter pen thickness (1-20):", "Pen Thickness", "3");

            if (int.TryParse(input, out thickness) && thickness >= 1 && thickness <= 20)
            {
                pen = new Pen(color, thickness);
            }
        }

        private void picBoxCircle_Click(object sender, EventArgs e)
        {
            currentMode = DrawingMode.Circle;
        }

        private void picBocTraingle_Click(object sender, EventArgs e)
        {
            currentMode = DrawingMode.Traingle;
        }

        private void picBoxRectangle_Click(object sender, EventArgs e)
        {
            currentMode = DrawingMode.Rectangle;
        }

        private void DrawFinalShape(Point start, Point end)
        {
            Graphics g = DrawingSpacePanel.CreateGraphics();
            Rectangle rect = GetRectangle(start, end);

            if (currentMode == DrawingMode.Circle)
                g.DrawEllipse(pen, rect);
            else if (currentMode == DrawingMode.Rectangle)
                g.DrawRectangle(pen, rect);

            g.Dispose();
        }

        private void DrawingSpacePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if (isDrawingShape)
            {
                DrawShapePreview(e.Graphics, startPoint, currentPoint);
            }
        }

        private void DrawShapePreview(Graphics g, Point start, Point current)
        {
            Rectangle rect = GetRectangle(start, current);

            if (currentMode == DrawingMode.Circle)
                g.DrawEllipse(pen, rect);
            else if (currentMode == DrawingMode.Rectangle)
                g.DrawRectangle(pen, rect);
            else if (currentMode == DrawingMode.Traingle)
            {
                Point[] trianglePoints = GetTrianglePoints(start, current);
                g.DrawPolygon(pen, trianglePoints);
            }
        }

        private Rectangle GetRectangle(Point start, Point end)
        {
            return new Rectangle(
                Math.Min(start.X, end.X),
                Math.Min(start.Y, end.Y),
                Math.Abs(end.X - start.X),
                Math.Abs(end.Y - start.Y)
            );
        }

        private Point[] GetTrianglePoints(Point start, Point end)
        {
            Point top = new Point((start.X + end.X) / 2, Math.Min(start.Y, end.Y));

            Point bottomLeft = new Point(Math.Min(start.X, end.X), Math.Max(start.Y, end.Y));

            Point bottomRight = new Point(Math.Max(start.X, end.X), Math.Max(start.Y, end.Y));

            return new Point[] { top, bottomLeft, bottomRight };
        }


    }
}
