using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Image file;
        Image img;
        Image imgCopy;



        public Boolean opened = false;
        public void cleanImg()
        {
            img = pictureBox1.Image;
            if (file == null)
            {
                MessageBox.Show("No image loaded, first upload image ");
                return;
            }
            else { file = imgCopy; }
            pictureBox1.Image = file;
            opened = true;
        }


        public Form1()
        {
            InitializeComponent();
            //to add the scroll bar to panel
            panel1.AutoScroll = true;
            panel1.HorizontalScroll.Enabled = true;
            panel1.HorizontalScroll.Visible = true;
            //panel1.HorizontalScroll.Maximum = 0;
            panel1.AutoScroll = true;
        }

        public Form1(Image data)
        {
            
            //Обрабатываем данные
            //Или записываем их в поле
            this.data = data;
        }
        Image data;


        void openImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = file;
                imgCopy = file;
                opened = true;
            }
        }

        void saveImage()
        {
            if (opened)
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

        void reload()
        {
            if (!opened)
            {
                //MessageBox.Show("Open an Image then apply changes");

            }
            else
            {
                if (opened)
                {
                    file = Image.FromFile(openFileDialog1.FileName);
                    pictureBox1.Image = file;
                    opened = true;
                }
            }
        }

        void rgb()
        {
            try
            {
            float changered = redbar.Value/10 * 0.1f;
            float changegreen = greenbar.Value/10 * 0.1f;
            float changeblue = bluebar.Value/10 * 0.1f;

            //redvalue.Text = changered.ToString();
            //greenvalue.Text = changeblue.ToString();
            //bluevalue.Text = changegreen.ToString();

            reload();
            if (!opened)
            {
            }
            else
            {



                Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1+changered, 0, 0, 0, 0},
                    new float[]{0, 1+changegreen, 0, 0, 0},
                    new float[]{0, 0, 1+changeblue, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
               location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
               format of graphics unit,provide the image attributes   */


                g.Dispose();                            //Releases all resources used by this Graphics.
                pictureBox1.Image = bmpInverted;

            }
            }
            catch (Exception w)
            {
                if (w is OutOfMemoryException)
                    throw;
            }
        }




        //-----------------------------------------------------------------------Gray Scale Filter ------------------------------------------------------------------------------------

        void grayscale()
        {
            try
            {
                if (!opened)
                {
                    MessageBox.Show("Open an Image then apply changes");
                }
                else
                {
                    Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                    Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                    ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                    ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                    ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                    Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                    g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                    /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
                   location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
                   format of graphics unit,provide the image attributes   */


                    g.Dispose();                            //Releases all resources used by this Graphics.
                    pictureBox1.Image = bmpInverted;
                }
            }
            catch (Exception c)
            {
                if (c is OutOfMemoryException)
                    throw;
            }
        }

        //-----------------------------------------------------------------------RED Filter ------------------------------------------------------------------------------------

        void redscale()
        {
            try
            {
                if (!opened)
                {
                    MessageBox.Show("Open an Image then apply changes");
                }
                else
                {

                    Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                    Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                    ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                    ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                    ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                    Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                    g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                    /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
                   location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
                   format of graphics unit,provide the image attributes   */


                    g.Dispose();                            //Releases all resources used by this Graphics.
                    pictureBox1.Image = bmpInverted;

                }
            }
            catch (Exception v)
            {
                if (v is OutOfMemoryException)
                    throw;
            }
        }

        void filter1()
        {
            try
            {
                if (!opened)
                {
                    MessageBox.Show("Open an Image then apply changes");
                }
                else
                {

                    Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                    Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                    ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                    ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
            new float[]{.769f, .686f+0.5f, .534f, 0, 0},
            new float[]{.189f+2.3f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                    ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                    Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                    g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                    /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
                   location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
                   format of graphics unit,provide the image attributes   */


                    g.Dispose();                            //Releases all resources used by this Graphics.
                    pictureBox1.Image = bmpInverted;

                }
            }
            catch (Exception z)
            {
                if (z is OutOfMemoryException)
                    throw;
            }
        }








        void filter2()
        {
            try
            {
                if (!opened)
                {
                    MessageBox.Show("Open an Image then apply changes");
                }
                else
                {

                    Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                    Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                    ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                    ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
            new float[]{.769f+0.3f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.5f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                    ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                    Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                    g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                    /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
                   location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
                   format of graphics unit,provide the image attributes   */


                    g.Dispose();                            //Releases all resources used by this Graphics.
                    pictureBox1.Image = bmpInverted;

                }
            }
            catch (Exception b)
            {
                if (b is OutOfMemoryException)
                    throw;
            }
        }









        void filter3()
        {
            try
            {
                if (!opened)
                {
                    MessageBox.Show("Open an Image then apply changes");
                }
                else
                {

                    Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                    Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                    ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                    ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{.393f+0.3f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f+0.2f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f+0.9f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}
                });
                    ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                    Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                    g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                    /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
                   location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
                   format of graphics unit,provide the image attributes   */


                    g.Dispose();                            //Releases all resources used by this Graphics.
                    pictureBox1.Image = bmpInverted;

                }
            }
            catch (Exception n)
            {
                if (n is OutOfMemoryException)
                    throw;
            }
        }















        //-----------------------------------------------------------------------RED Filter ------------------------------------------------------------------------------------

        void Winter()
        {
            try
            {
                if (!opened)
                {
                    MessageBox.Show("Open an Image then apply changes");
                }
                else
                {

                    Image img = pictureBox1.Image;                             // storing image into img variable of image type from picturebox1
                    Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   /* creating a bitmap of the height of imported picture in picturebox which consists of the pixel data for a graphics image
                                                                        and its attributes. A Bitmap is an object used to work with images defined by pixel data.*/

                    ImageAttributes ia = new ImageAttributes();                 //creating an object of imageattribute ia to change the attribute of images
                    ColorMatrix cmPicture = new ColorMatrix(new float[][]       // now creating the color matrix object to change the colors or apply  image filter on image
                {
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 1, 0, 1}
                });
                    ia.SetColorMatrix(cmPicture);           //pass the color matrix to imageattribute object ia
                    Graphics g = Graphics.FromImage(bmpInverted);   /*create a new object of graphics named g, ; Create graphics object for alteration.
                                                            Graphics newGraphics = Graphics.FromImage(imageFile); is the format of loading image into graphics for alteration*/

                    g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);


                    /*   g.drawimage(image, new rectangle(location of rectangle axix-x, location axis-y, width of rectangle, height of rectangle),
                   location of image in rectangle x-axis, location of image in rectangle y-axis, width of image, height of image,
                   format of graphics unit,provide the image attributes   */


                    g.Dispose();                            //Releases all resources used by this Graphics.
                    pictureBox1.Image = bmpInverted;

                }
            }
            catch (Exception m)
            {
                if (m is OutOfMemoryException)
                    throw;
            }
        }


       

        //--------------------------------------------------------------

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //reload();
            grayscale();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            redscale();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openImage();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private void redbar_Scroll(object sender, EventArgs e)
        {
            rgb();
        }

        private void greenbar_Scroll(object sender, EventArgs e)
        {
            rgb();
        }

        private void bluebar_Scroll(object sender, EventArgs e)
        {
            rgb();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //reload();
            filter3();
        }

        public void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void сделатьФотоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 formWeb = new Form2();
            formWeb.Owner = this;
            formWeb.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cleanImg();//очистить фото
        }

        private void cropThePictreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 formWM = new Form3();
            formWM.Owner = this;
            formWM.Show();
        }

        private void cropTheImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 formCrop = new Form4();
            formCrop.Owner = this;
            formCrop.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
