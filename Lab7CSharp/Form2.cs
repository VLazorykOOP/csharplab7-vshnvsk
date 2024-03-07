using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7CSharp
{
    public partial class Form2 : Form
    {
        private Bitmap originalImage;
        private Bitmap modifiedImage;
        public Form2()
        {
            InitializeComponent();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(ofd.FileName);
                    pictureBox1.Image = originalImage;
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(modifiedImage != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog()) 
                {
                    sfd.Filter = "Bitmap files (*.bmp)|*.bmp|All files (*.*)|*.*";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        modifiedImage.Save(sfd.FileName);
                    }
                }
            } 
            else
            {
                MessageBox.Show("No modified image to save");
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if (originalImage == null)
            {
                MessageBox.Show("No image to manipulate.");
                return;
            }

            Bitmap manipulatedImage = new Bitmap(originalImage);

            if (redRadioButton.Checked)
            {
                for (int y = 0; y < manipulatedImage.Height; y++)
                {
                    for (int x = 0; x < manipulatedImage.Width; x++)
                    {
                        Color pixel = manipulatedImage.GetPixel(x, y);
                        Color newPixel = Color.FromArgb(0, pixel.G, pixel.B);
                        manipulatedImage.SetPixel(x, y, newPixel);
                    }
                }
            }
            else if (greenRadioButton.Checked)
            {
                for (int y = 0; y < manipulatedImage.Height; y++)
                {
                    for (int x = 0; x < manipulatedImage.Width; x++)
                    {
                        Color pixel = manipulatedImage.GetPixel(x, y);
                        Color newPixel = Color.FromArgb(pixel.R, 0, pixel.B);
                        manipulatedImage.SetPixel(x, y, newPixel);
                    }
                }
            }
            else if (blueRadioButton.Checked)
            {
                for (int y = 0; y < manipulatedImage.Height; y++)
                {
                    for (int x = 0; x < manipulatedImage.Width; x++)
                    {
                        Color pixel = manipulatedImage.GetPixel(x, y);
                        Color newPixel = Color.FromArgb(pixel.R, pixel.G, 0);
                        manipulatedImage.SetPixel(x, y, newPixel);
                    }
                }
            }

            pictureBox1.Image = manipulatedImage;
        }
    }
}
