using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kursova
{
    public partial class Form1 : Form
    {
        // Перелік фракталів
        private enum FractalType
        {
            SierpinskiTriangle,
            SierpinskiCarpet,
            PeanoCurve,
            LevyCurve
        }
        //Повертає кінцеву точку на основі початкової точки, довжини та кута
        private PointF GetEndPoint(PointF startPoint, float length, int direction)
        {
            float radians = direction * (float)Math.PI / 180;
            float x = startPoint.X + length * (float)Math.Cos(radians);
            float y = startPoint.Y + length * (float)Math.Sin(radians);
            return new PointF(x, y);
        }


        private FractalType selectedFractal;
        private System.Windows.Forms.ToolStrip toolStripZoom;

        public Form1()
        {
            InitializeComponent();
            comboBoxFractals.SelectedIndex = 0;
        }

        // Кнопка згенерувати
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int depth = (int)numericUpDownDepth.Value;
            Bitmap fractalBitmap = GenerateFractal(depth);
            pictureBoxFractal.Image = fractalBitmap;
        }

        // Кнопка вибору фракталу
        private Bitmap GenerateFractal(int depth)
        {
            int width = pictureBoxFractal.Width;
            int height = pictureBoxFractal.Height;
            Bitmap bitmap = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);

                switch (selectedFractal)
                {
                    case FractalType.SierpinskiTriangle:
                        DrawSierpinskiTriangle(graphics, depth, new PointF(width / 2, 0), width);
                        break;
                    case FractalType.SierpinskiCarpet:
                        DrawSierpinskiCarpet(graphics, depth, new Rectangle(0, 0, width, height));
                        break;
                    case FractalType.PeanoCurve:
                        DrawPeanoCurve(graphics, depth, new PointF(0, height / 2), width, 0);
                        break;
                    case FractalType.LevyCurve:
                        DrawLevyCurve(graphics, depth, new PointF(0, height / 2), new PointF(width, height / 2), 0);
                        break;
                }
            }

            return bitmap;
        }

        private void comboBoxFractals_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFractal = (FractalType)comboBoxFractals.SelectedIndex;
        }

        // Кнопка зберегти
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "JPEG Image|*.jpg";
            saveDialog.Title = "Зберегти фрактал як зображення";
            saveDialog.ShowDialog();

            if (saveDialog.FileName != "")
            {
                pictureBoxFractal.Image.Save(saveDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        // Трикутник Серпінського
        private void DrawSierpinskiTriangle(Graphics graphics, int depth, PointF top, float size)
        {
            PointF left = new PointF(top.X - size / 2, top.Y + (float)(Math.Sqrt(3) * size) / 2);
            PointF right = new PointF(top.X + size / 2, top.Y + (float)(Math.Sqrt(3) * size) / 2);

            if (depth == 0)
            {
                graphics.DrawLine(Pens.Black, top, left);
                graphics.DrawLine(Pens.Black, left, right);
                graphics.DrawLine(Pens.Black, right, top);
            }
            else
            {
                PointF leftMid = new PointF((top.X + left.X) / 2, (top.Y + left.Y) / 2);
                PointF rightMid = new PointF((top.X + right.X) / 2, (top.Y + right.Y) / 2);
                PointF topMid = new PointF((left.X + right.X) / 2, (left.Y + right.Y) / 2);

                DrawSierpinskiTriangle(graphics, depth - 1, top, size / 2);
                DrawSierpinskiTriangle(graphics, depth - 1, leftMid, size / 2);
                DrawSierpinskiTriangle(graphics, depth - 1, rightMid, size / 2);
            }
        }

        // Ковер Серпінського
        private void DrawSierpinskiCarpet(Graphics graphics, int depth, Rectangle rectangle)
        {
            if (depth == 0)
            {
                graphics.FillRectangle(Brushes.Black, rectangle);
            }
            else
            {
                int width = rectangle.Width / 3;
                int height = rectangle.Height / 3;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (i != 1 || j != 1)
                        {
                            Rectangle subRectangle = new Rectangle(rectangle.Left + i * width, rectangle.Top + j * height, width, height);
                            DrawSierpinskiCarpet(graphics, depth - 1, subRectangle);
                        }
                    }
                }
            }
        }

        // Крива Пеано
        private void DrawPeanoCurve(Graphics graphics, int depth, PointF startPoint, float length, int direction)
        {
            if (depth == 0)
            {
                PointF endPoint = GetEndPoint(startPoint, length, direction);
                graphics.DrawLine(Pens.Black, startPoint, endPoint);
            }
            else
            {
                length /= 3;

                DrawPeanoCurve(graphics, depth - 1, startPoint, length, direction);

                startPoint = GetEndPoint(startPoint, length, direction);
                direction -= 90;
                DrawPeanoCurve(graphics, depth - 1, startPoint, length, direction);

                startPoint = GetEndPoint(startPoint, length, direction);
                direction += 90;
                DrawPeanoCurve(graphics, depth - 1, startPoint, length, direction);

                startPoint = GetEndPoint(startPoint, length, direction);
                direction -= 90;
                DrawPeanoCurve(graphics, depth - 1, startPoint, length, direction);

                startPoint = GetEndPoint(startPoint, length, direction);
                DrawPeanoCurve(graphics, depth - 1, startPoint, length, direction);

                startPoint = GetEndPoint(startPoint, length, direction);
                direction += 90;
                DrawPeanoCurve(graphics, depth - 1, startPoint, length, direction);

                startPoint = GetEndPoint(startPoint, length, direction);
                direction += 90;
                DrawPeanoCurve(graphics, depth - 1, startPoint, length, direction);

                startPoint = GetEndPoint(startPoint, length, direction);
                direction -= 90;
                DrawPeanoCurve(graphics, depth - 1, startPoint, length, direction);

                startPoint = GetEndPoint(startPoint, length, direction);
                direction -= 90;
                DrawPeanoCurve(graphics, depth - 1, startPoint, length, direction);
            }
        }



        // Крива Леві
        private void DrawLevyCurve(Graphics graphics, int depth, PointF start, PointF end, double angle)
        {
            if (depth == 0)
            {
                graphics.DrawLine(Pens.Black, start, end);
            }
            else
            {
                float dx = end.X - start.X;
                float dy = end.Y - start.Y;

                float segmentLength = (float)Math.Sqrt(dx * dx + dy * dy);
                float segmentAngle = (float)Math.Atan2(dy, dx);

                float segmentLengthDivided = segmentLength / 3;

                PointF pointA = start;
                PointF pointB = new PointF(start.X + (float)(segmentLengthDivided * Math.Cos(segmentAngle)), start.Y + (float)(segmentLengthDivided * Math.Sin(segmentAngle)));
                PointF pointC = new PointF(pointB.X + (float)(segmentLengthDivided * Math.Cos(segmentAngle - Math.PI / 3)), pointB.Y + (float)(segmentLengthDivided * Math.Sin(segmentAngle - Math.PI / 3)));
                PointF pointD = new PointF(pointC.X + (float)(segmentLengthDivided * Math.Cos(segmentAngle + Math.PI / 3)), pointC.Y + (float)(segmentLengthDivided * Math.Sin(segmentAngle + Math.PI / 3)));
                PointF pointE = new PointF(pointD.X + (float)(segmentLengthDivided * Math.Cos(segmentAngle)), pointD.Y + (float)(segmentLengthDivided * Math.Sin(segmentAngle)));
                PointF pointF = end;

                DrawLevyCurve(graphics, depth - 1, pointA, pointB, segmentAngle);
                DrawLevyCurve(graphics, depth - 1, pointB, pointC, segmentAngle - Math.PI / 3);
                DrawLevyCurve(graphics, depth - 1, pointC, pointD, segmentAngle + Math.PI / 3);
                DrawLevyCurve(graphics, depth - 1, pointD, pointE, segmentAngle);
                DrawLevyCurve(graphics, depth - 1, pointE, pointF, segmentAngle);
            }
        }

        private void pictureBoxFractal_Click(object sender, EventArgs e)
        {

        }

        private void labelDepth_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDownDepth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
