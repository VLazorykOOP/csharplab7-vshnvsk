using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab7CSharp
{
    public partial class Form3 : Form
    {
        public Color color;
        private List<Form3> list;
        public Random random = new Random();

        public string FigureType { get; set; }
        public Color FigureColor { get; set; }
        public double CircleRadius { get; set; }
        public double SectorRadius { get; set; }
        public double StarRadiusOut { get; set; }
        public double StarRadiusIn { get; set; }
        public double SectorAngleStart { get; set; }
        public double SectorAngleSweep { get; set; }
        public double StarAngle { get; set; }
        public double RectangleHeight { get; set; }
        public double RectangleWeight { get; set; }
        public string Text { get; set; }

        public Form3()
        {
            InitializeComponent();
            list = new List<Form3>();
        }

        private void cirleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            circleGroupBox.Visible = true;
            sectorGroupBox.Visible = false;
            recGroupBox.Visible = false;
            starGroupBox.Visible = false;
        }

        private void sectorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            circleGroupBox.Visible = false;
            sectorGroupBox.Visible = true;
            recGroupBox.Visible = false;
            starGroupBox.Visible = false;
        }

        private void rectangleRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            circleGroupBox.Visible = false;
            sectorGroupBox.Visible = false;
            recGroupBox.Visible = true;
            starGroupBox.Visible = false;
        }

        private void starRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            circleGroupBox.Visible = false;
            sectorGroupBox.Visible = false;
            recGroupBox.Visible = false;
            starGroupBox.Visible = true;
        }

        private void colorCircleButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
            colorCircleButton.BackColor = color;
            colorCircleButton.ForeColor = color == Color.Black || color == Color.Brown ? Color.White : Color.Black;
        }

        private void colorSectorButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
            colorSectorButton.BackColor = color;
            colorSectorButton.ForeColor = color == Color.Black || color == Color.Brown ? Color.White : Color.Black;
        }

        private void colorRecButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
            colorRecButton.BackColor = color;
            colorRecButton.ForeColor = color == Color.Black || color == Color.Brown ? Color.White : Color.Black;
        }

        private void colorStarButton_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            color = colorDialog1.Color;
            colorStarButton.BackColor = color;
            colorStarButton.ForeColor = color == Color.Black || color == Color.Brown ? Color.White : Color.Black;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string figureType;
            Color figureColor;
            double circleRadius = 0, sectorRadius, starRadiusOut, starRadiusIn;
            double sectorAngleStart, sectorAngleSweep, starAngle;
            double rectangleHeight, rectangleWeight;
            string text;

            if(circleRadioButton.Checked)
            {
                figureType = "Circle";
                richTextBox.AppendText("Figure: Circle, ");

                figureColor = colorDialog1.Color;
                richTextBox.Text += "Color: " + color.Name + ", ";

                circleRadius = Decimal.ToDouble(circleNumericUpDown.Value);
                richTextBox.Text += "Radius: " + circleRadius + ", ";
                sectorRadius = starRadiusOut = starRadiusIn = 0;
                sectorAngleStart = sectorAngleSweep = starAngle = 0;
                rectangleHeight = rectangleWeight = 0;

                text = circleTextBox.Text;
                string inputTextCircle = text;
                string[] words = inputTextCircle.Split(' ');
                string outputTextCircle = string.Join(" ", words);
                richTextBox.Text += "Text: " + outputTextCircle + Environment.NewLine;
            }
            else if (sectorRadioButton.Checked)
            {
                figureType = "Sector";
                richTextBox.AppendText("Figure: Sector, ");

                figureColor = colorDialog1.Color;
                richTextBox.Text += "Color: " + color.Name + ", ";

                sectorRadius = Decimal.ToDouble(sectorR_NumericUpDown.Value);
                sectorAngleStart = Decimal.ToDouble(sectorAS_NumericUpDown.Value);
                sectorAngleSweep = Decimal.ToDouble(sectorASW_NumericUpDown.Value);
                richTextBox.Text += "Radius: " + sectorRadius + ", "
                    + "Angles: " + sectorAngleStart + ", " + sectorAngleSweep + ", ";
                circleRadius = starRadiusOut = starRadiusIn = 0;
                starAngle = 0;
                rectangleHeight = rectangleWeight = 0;

                text = sectorTextBox.Text;
                string inputTextSector = text;
                string[] words = inputTextSector.Split(' ');
                string outputTextSector = string.Join(" ", words);
                richTextBox.Text += "Text: " + outputTextSector + Environment.NewLine;
            }
            else if (recRadioButton.Checked)
            {
                figureType = "Rectangle";
                richTextBox.AppendText("Figure: Rectangle, ");

                figureColor = colorDialog1.Color;
                richTextBox.Text += "Color: " + color.Name + ", ";

                rectangleHeight = Decimal.ToDouble(heightNumericUpDown.Value);
                rectangleWeight = Decimal.ToDouble(weightNumericUpDown.Value);  
                richTextBox.Text += "Height: " + rectangleHeight + ", "
                    + "Weight: " + rectangleWeight + ", ";
                circleRadius = sectorRadius = starRadiusOut = starRadiusIn = 0;
                sectorAngleStart = sectorAngleSweep = starAngle = 0;

                text = recTextBox.Text;
                string inputTextRec = text;
                string[] words = inputTextRec.Split(' ');
                string outputTextRec = string.Join(" ", words);
                richTextBox.Text += "Text: " + outputTextRec + Environment.NewLine;
            }
            else if (starRadioButton.Checked)
            {
                figureType = "Star";
                richTextBox.AppendText("Figure: Star, ");

                figureColor = colorDialog1.Color;
                richTextBox.Text += "Color: " + color.Name + ", ";

                starRadiusOut = Decimal.ToDouble(starRO_NumericUpDown.Value);
                starRadiusIn = Decimal.ToDouble(starRI_NumericUpDown.Value);
                starAngle = Decimal.ToDouble(starA_NumericUpDown.Value);
                richTextBox.Text += "Radius: " + starRadiusOut + ", " + starRadiusIn + ", "
                    + "Angle: " + starAngle + ", ";
                sectorRadius = 0;
                sectorAngleStart = sectorAngleSweep = 0;
                rectangleHeight = rectangleWeight = 0;

                text = starTextBox.Text;
                string inputTextStar = text;
                string[] words = inputTextStar.Split(' ');
                string outputTextStar = string.Join(" ", words);
                richTextBox.Text += "Text: " + outputTextStar + Environment.NewLine;
            } 
            else
            {
                return;
            }

            Form3 shapeParams = new Form3
            {
                FigureType = figureType,
                FigureColor = figureColor,
                CircleRadius = circleRadius,
                SectorRadius = sectorRadius,
                StarRadiusOut = starRadiusOut,
                StarRadiusIn = starRadiusIn,
                SectorAngleStart = sectorAngleStart,
                SectorAngleSweep = sectorAngleSweep,
                StarAngle = starAngle,
                RectangleHeight = rectangleHeight,
                RectangleWeight = rectangleWeight,
                Text = text
            };
            list.Add(shapeParams);
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Random random = new Random();
            Graphics graphics = Graphics.FromImage(bitmap);

            foreach (Form3 shapeParams in list)
            {
                string figureType = shapeParams.FigureType;
                Color figureColor = shapeParams.FigureColor;
                double circleRadius = shapeParams.CircleRadius;
                double sectorRadius = shapeParams.SectorRadius;
                double starRadiusOut = shapeParams.StarRadiusOut;
                double starRadiusIn = shapeParams.StarRadiusIn;
                double sectorAngleStart = shapeParams.SectorAngleStart;
                double sectorAngleSweep = shapeParams.SectorAngleSweep;
                double starAngle = shapeParams.StarAngle;
                double rectangleHeight = shapeParams.RectangleHeight;
                double rectangleWeight = shapeParams.RectangleWeight;
                string text = shapeParams.Text;

                int x = random.Next(pictureBox1.Width);
                int y = random.Next(pictureBox1.Height);

                if (figureType == "Circle")
                {
                    graphics.FillEllipse(new SolidBrush(figureColor), x, y, (float)circleRadius, (float)circleRadius);
                    SizeF textSize = graphics.MeasureString(text, Font);
                    float textX = x + ((float)circleRadius - textSize.Width) / 2;
                    float textY = y + ((float)circleRadius - textSize.Height) / 2;
                    graphics.DrawString(text, Font, Brushes.Black, textX, textY);
                }
                else if (figureType == "Sector")
                {
                    float startAngle = (float)sectorAngleStart;
                    float sweepAngle = (float)sectorAngleSweep;
                    graphics.FillPie(new SolidBrush(figureColor), x, y, (float)sectorRadius, (float)sectorRadius, startAngle, sweepAngle);
                    SizeF textSize = graphics.MeasureString(text, Font);
                    float textX = x + ((float)sectorRadius - textSize.Width) / 2;
                    float textY = y + ((float)sectorRadius - textSize.Height) / 2;
                    graphics.DrawString(text, Font, Brushes.Black, textX, textY);
                } 
                else if (figureType == "Rectangle")
                {
                    graphics.FillRectangle(new SolidBrush(figureColor), x, y, (float)rectangleHeight, (float)rectangleWeight);
                    SizeF textSize = graphics.MeasureString(text, Font);
                    float textX = x + ((float)rectangleHeight - textSize.Width) / 2;
                    float textY = y + ((float)rectangleWeight - textSize.Height) / 2;
                    graphics.DrawString(text, Font, Brushes.Black, textX, textY);
                } 
                else if (figureType == "Star")
                {
                    PointF[] starPoints = GetStarPoints(x, y, (float)starRadiusOut, (float)starRadiusIn, (int)starAngle);
                    graphics.FillPolygon(new SolidBrush(figureColor), starPoints);
                    SizeF textSize = graphics.MeasureString(text, Font);
                    float textX = x + ((float)starRadiusOut - textSize.Width) / 2;
                    float textY = y + ((float)starRadiusOut - textSize.Height) / 2;
                    graphics.DrawString(text, Font, Brushes.Black, textX, textY);
                }
            }
            pictureBox1.Image = bitmap;

            graphics.Dispose();
        }

        private PointF[] GetStarPoints(float centerX, float centerY, float outerRadius, float innerRadius, int numPoints)
        {
            PointF[] points = new PointF[numPoints * 2];
            double angleIncrement = Math.PI / numPoints;

            double angle = -Math.PI / 2;
            for (int i = 0; i < numPoints * 2; i++)
            {
                double radius = (i % 2 == 0) ? outerRadius : innerRadius;
                points[i] = new PointF((float)(centerX + radius * Math.Cos(angle)), (float)(centerY + radius * Math.Sin(angle)));
                angle += angleIncrement;
            }

            return points;
        }
    }
}
