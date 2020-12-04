using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        Image img;
        Image imgCopy;

        // The original image.
        private Bitmap OriginalImage;

        // The currently cropped image.
        private Bitmap CroppedImage;

        // The cropped image with the selection rectangle.
        private Bitmap DisplayImage;
        private Graphics DisplayGraphics;

        public Form4()
        {
            InitializeComponent();
        }

        void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(openFileDialog.FileName);
                pictureBox1.Image = img;
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                Form1 getImg = this.Owner as Form1;
                img = getImg.pictureBox1.Image;

                if (img == null)
                {
                    OpenFile();
                }
                imgCopy = (Bitmap)img.Clone();
                pictureBox1.Image = img;

                OriginalImage = img.Clone() as Bitmap;
                CroppedImage = OriginalImage.Clone() as Bitmap;
                DisplayImage = CroppedImage.Clone() as Bitmap;
                DisplayGraphics = Graphics.FromImage(DisplayImage);

                pictureBox1.Image = DisplayImage;
                pictureBox1.Visible = true;
            }
            catch(Exception w)
            {
                if (w is OutOfMemoryException)
                throw;
            }
        }

        // Let the user select an area.
        private bool Drawing = false;
        private Point StartPoint, EndPoint;

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!Drawing) return;

            // Draw the area selected.
            DrawSelectionBox(e.Location);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!Drawing) return;
            Drawing = false;

            // Crop.
            // Get the selected area's dimensions.
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            int width = Math.Abs(StartPoint.X - EndPoint.X);
            int height = Math.Abs(StartPoint.Y - EndPoint.Y);
            Rectangle source_rect = new Rectangle(x, y, width, height);
            Rectangle dest_rect = new Rectangle(0, 0, width, height);

            // Copy that part of the image to a new bitmap.
            DisplayImage = new Bitmap(width, height);
            DisplayGraphics = Graphics.FromImage(DisplayImage);
            DisplayGraphics.DrawImage(CroppedImage, dest_rect, source_rect, GraphicsUnit.Pixel);

            // Display the new bitmap.
            CroppedImage = DisplayImage;
            DisplayImage = CroppedImage.Clone() as Bitmap;
            DisplayGraphics = Graphics.FromImage(DisplayImage);
            pictureBox1.Image = DisplayImage;
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Drawing = true;
            StartPoint = e.Location;
            // Draw the area selected.
            DrawSelectionBox(e.Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CroppedImage = OriginalImage.Clone() as Bitmap;
            DisplayImage = OriginalImage.Clone() as Bitmap;
            DisplayGraphics = Graphics.FromImage(DisplayImage);
            pictureBox1.Image = DisplayImage;
        }

        private void DrawSelectionBox(Point end_point)
        {
            // Проверка на выход за границы картинки
            EndPoint = end_point;
            if (EndPoint.X < 0) EndPoint.X = 0;
            if (EndPoint.X >= CroppedImage.Width) EndPoint.X = CroppedImage.Width - 1;
            if (EndPoint.Y < 0) EndPoint.Y = 0;
            if (EndPoint.Y >= CroppedImage.Height) EndPoint.Y = CroppedImage.Height - 1;

            // Reset the image.
            DisplayGraphics.DrawImageUnscaled(CroppedImage, 0, 0);

            // Draw the selection area.
            int x = Math.Min(StartPoint.X, EndPoint.X);
            int y = Math.Min(StartPoint.Y, EndPoint.Y);
            int width = Math.Abs(StartPoint.X - EndPoint.X);
            int height = Math.Abs(StartPoint.Y - EndPoint.Y);
            DisplayGraphics.DrawRectangle(Pens.AliceBlue, x, y, width, height);
            pictureBox1.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Bitmap LoadBitmapUnlocked(string file_name)
        {
            using (Bitmap bm = new Bitmap(file_name))
            {
                Bitmap new_bitmap = new Bitmap(bm.Width, bm.Height);
                using (Graphics gr = Graphics.FromImage(new_bitmap))
                {
                    gr.DrawImage(bm, 0, 0);
                }
                return new_bitmap;
            }
        }

        public void saveImage()
        {
            if (pictureBox1 != null)
            {
                SaveFileDialog sfd = new SaveFileDialog(); // create a new save file dialog object
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;// you want to store it in by default format
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);

                }
            }
            else { MessageBox.Show("No image loaded, first upload image "); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveImage();
        }

    }
}
