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

namespace WindowsFormsApp1
{
    //Нужно сделать сохраниение, обновление картинки при закрытии окна, проверки на пустоту объектов и тп
    public partial class Form3 : Form
    {
        Image Wmark;
        Image img;
        Image imgCopy;
        bool opened;
        Image file;

        bool allImage = false;
        bool onlyCenter = false;
        //bool onlyRight = false;

        public Form3()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0; // дефолтное значение для комбобокса
        }



        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                Form1 getImg = this.Owner as Form1;//плучение изображения из окна один
                img = getImg.pictureBox1.Image;
                if (img == null)
                {
                    DialogResult dr = openFileDialog1.ShowDialog();
                    if (dr == DialogResult.OK)
                    img = Image.FromFile(openFileDialog1.FileName);
                }
                imgCopy = (Bitmap)img.Clone();
                pictureBox1.Image = img;
                //MessageBox.Show("sdfsdf");
            }
            catch(Exception q)
            {
                if (q is OutOfMemoryException)
                throw;
            }
        }

        void openImage()
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Wmark = Image.FromFile(openFileDialog1.FileName);
                pictureBox2.Image = Wmark;
                opened = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openImage();  
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

 
        //Запускаем алгоритм
        private void button2_Click(object sender, EventArgs e)
        {
            if (onlyCenter) WaterMarkOnCenter();
            else if (allImage) WaterMarkOnAllImage();
            //else if(leftUp) WaterMarkOnLeftUp();

            comboBox1.SelectedIndex = 0;
        }

        void WaterMarkOnCenter()
        {
            Image imgCopy;
            imgCopy = img;
            Graphics imageGraphics = Graphics.FromImage(imgCopy); //!!!
            if (Wmark == null) { MessageBox.Show("U need to choose a Watermark!"); return; }
            TextureBrush watermarkBrush = new TextureBrush(Wmark);

            int x = (imgCopy.Width / 2 - Wmark.Width / 2);
            int y = (imgCopy.Height / 2 - Wmark.Height / 2);
            watermarkBrush.TranslateTransform(x, y);
            imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(x, y), new Size(Wmark.Width + 1, Wmark.Height)));
            pictureBox3.Image = imgCopy;
        }

        void WaterMarkOnAllImage()
        {
            Graphics imageGraphics = Graphics.FromImage(img);
            Brush watermarkBrush = new TextureBrush(Wmark);
            imageGraphics.FillRectangle(watermarkBrush, new Rectangle(new Point(0, 0), img.Size));
            pictureBox3.Image = img;
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
                    pictureBox3.Image.Save(sfd.FileName, format);
                    
                }
            }
            else { MessageBox.Show("No image loaded, first upload image "); }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem.ToString() == "Выберите значение")
            {
                onlyCenter = false;
                allImage = false;

            }
            if (comboBox1.SelectedItem.ToString() == "Водяной знак по центру") {
                onlyCenter = true;               
            }
            if (comboBox1.SelectedItem.ToString() == "Водяные знаки по все площади")
            {
                allImage = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            img = (Bitmap)imgCopy.Clone();
            pictureBox3.Image = imgCopy;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveImage();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (img == null)
                {
                    DialogResult dr = openFileDialog1.ShowDialog();
                    if (dr == DialogResult.OK)
                        img = Image.FromFile(openFileDialog1.FileName);
                }
                else { MessageBox.Show("Image already uploaded"); }
                imgCopy = (Bitmap)img.Clone();
                pictureBox1.Image = img;
            }
            catch(Exception w)
            {
                if (w is OutOfMemoryException)
                throw;
            }
        }

    }
}
