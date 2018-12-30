using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CsharpGUI
{
    public partial class Form1 : Form
    {

        [DllImport("Project.dll")]
        private static extern int Sum(int y, int b);

        [DllImport("Project.dll")]
        private static extern int SumArr([In] int[] arr, int sz);

        [DllImport("Project.dll")]
        private static extern void ToUpper([In, Out]char[] arr, int sz);

        [DllImport("Project.dll")]
        private static extern void AddImages([In] int[] firstChannelToAdd, [In] int[] secondChannelToAdd
                                            , [Out] int[] output, int imageSize);

        [DllImport("Project.dll")]
        private static extern void SubImages([In] int[] firstChannelToSub, [In] int[] secondChannelToSub
                                            , [Out] int[] output, int imageSize);

        [DllImport("Project.dll")]
        private static extern void Invert([In, Out] int[] redChannel, [In, Out] int[] greenChannel,
                                            [In, Out] int[] blueChannel, int imageSize);
        [DllImport("Project.dll")]
        private static extern void Equalize([In, Out] int[] freqarr, int imageSize);

        [DllImport("Project.dll")]
        private static extern void addpic([In, Out] int[] result, [In] int[] channel1, [In]int[] channel2, int sz);

        [DllImport("Project.dll")]
        private static extern void subpic([In, Out] int[] result, [In] int[] channel1, [In]int[] channel2, int sz);

        [DllImport("Project.dll")]
        private static extern void grayscale([In, Out] int[] result, [In] int[] channel1, [In]int[] channel2, [In]int[] channel3, int sz);

        public ImageBuffers BuffersFirstImage
        {
            get
            {
                if (this.inputImage_pictureBox != null && this.inputImage_pictureBox.Image != null && FirstImage != null)
                {
                    return ImageHelper.GetBuffersFromImage(this.FirstImage);
                }
                return null;
            }
        }

        public ImageBuffers BuffersSecondImage
        {
            get
            {
                if (this.inputImage2_pictureBox1 != null && this.inputImage2_pictureBox1.Image != null && SecondImage != null)
                {
                    return ImageHelper.GetBuffersFromImage(this.SecondImage);
                }
                return null;
            }
        }


        public Bitmap FirstImage { get; set; }

        public Bitmap SecondImage { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\Libraries\\Pictures";
            openFileDialog1.Filter = "*.BMP;*.PPM;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            string fname = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        string ext = Path.GetExtension(openFileDialog1.FileName);
                        fname = openFileDialog1.FileName;
                        using (myStream)
                        {
                            this.FirstImage = new Bitmap(myStream);
                            this.inputImage_pictureBox.Image = this.FirstImage;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void secondImage_button2_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\Libraries\\Pictures";
            openFileDialog1.Filter = "*.BMP;*.PPM;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            string fname = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        string ext = Path.GetExtension(openFileDialog1.FileName);
                        fname = openFileDialog1.FileName;
                        using (myStream)
                        {
                            this.SecondImage = new Bitmap(myStream);
                            this.inputImage2_pictureBox1.Image = this.SecondImage;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void invert_button_Click(object sender, EventArgs e)
        {
            //Get first image buffers
            var buffersOfFirstImage = BuffersFirstImage;

            int width = buffersOfFirstImage.Width;
            int height = buffersOfFirstImage.Height;
            int imageSize = width * height;

            Invert(buffersOfFirstImage.RedChannel, buffersOfFirstImage.GreenChannel, buffersOfFirstImage.BlueChannel, imageSize);
            //Refelct the result to the GUI
            //1. Convert the output channels into bitmap
            var outputBuffersObject = ImageHelper.CreateNewImageBuffersObject(buffersOfFirstImage.RedChannel, buffersOfFirstImage.GreenChannel, buffersOfFirstImage.BlueChannel, width, height);
            this.outputImage_pictureBox.Image = (Bitmap)ImageHelper.GetImageFromBuffers(outputBuffersObject).BitmapObject;
        }

        private void equalize_button_Click(object sender, EventArgs e)
        {
            int[] freqr = new int[300];
            int[] freqg = new int[300];
            int[] freqb = new int[300];
            Bitmap img = new Bitmap(inputImage2_pictureBox1.Image);
            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color pxl = img.GetPixel(i, j);
                    freqb[pxl.B]++;
                    freqr[pxl.R]++;
                    freqg[pxl.G]++;
                }

            Equalize(freqr, img.Width * img.Height);
            Equalize(freqb, img.Width * img.Height);
            Equalize(freqg, img.Width * img.Height);

            for (int i = 0; i < img.Width; i++)
                for (int j = 0; j < img.Height; j++)
                {
                    Color pxl = img.GetPixel(i, j);
                    img.SetPixel(i, j, Color.FromArgb(freqr[pxl.R], freqg[pxl.G], freqb[pxl.B]));
                }
            outputImage_pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            outputImage_pictureBox.Image = img;
        }

        private void loadSecondImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\Libraries\\Pictures";
            openFileDialog1.Filter = "*.BMP;*.PPM;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            string fname = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        string ext = Path.GetExtension(openFileDialog1.FileName);
                        fname = openFileDialog1.FileName;
                        using (myStream)
                        {
                            this.SecondImage = new Bitmap(myStream);
                            this.inputImage2_pictureBox1.Image = this.SecondImage;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int width = BuffersFirstImage.Width;
            int height = BuffersFirstImage.Height;
            int NW = width + 2;
            int NH = height + 2;
            int[] PaddedRedChannel = new int[NW * NH];
            int[] Redges = new int[width * height];
            Program.pad_zeros(PaddedRedChannel, BuffersFirstImage.RedChannel, NW, NH);
            Program.Gx(PaddedRedChannel, Redges, NW, NH);
            var outputBuffersObject = ImageHelper.CreateNewImageBuffersObject(Redges, Redges, Redges, width, height);
            this.outputImage_pictureBox.Image = (Bitmap)ImageHelper.GetImageFromBuffers(outputBuffersObject).BitmapObject;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int width = BuffersFirstImage.Width;
            int height = BuffersFirstImage.Height;
            int NW = width + 2;
            int NH = height + 2;
            int[] PaddedRedChannel = new int[NW * NH];
            int[] Redges = new int[width * height];
            Program.pad_zeros(PaddedRedChannel, BuffersFirstImage.RedChannel, NW, NH);
            Program.Gy(PaddedRedChannel, Redges, NW, NH);
            var outputBuffersObject = ImageHelper.CreateNewImageBuffersObject(Redges, Redges, Redges, width, height);
            this.outputImage_pictureBox.Image = (Bitmap)ImageHelper.GetImageFromBuffers(outputBuffersObject).BitmapObject;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int width = BuffersFirstImage.Width, height = BuffersFirstImage.Height;
            int[] resultR = new int[width * height];
            int[] resultG = new int[width * height];
            int[] resultB = new int[width * height];
            addpic(resultR, BuffersFirstImage.RedChannel, BuffersSecondImage.RedChannel, width * height);
            addpic(resultB, BuffersFirstImage.BlueChannel, BuffersSecondImage.BlueChannel, width * height);
            addpic(resultG, BuffersFirstImage.GreenChannel, BuffersSecondImage.GreenChannel, width * height);

            for (int i = 0; i < width * height; ++i)
            {
                resultR[i] = Math.Min(resultR[i], 255);
                resultG[i] = Math.Min(resultG[i], 255);
                resultB[i] = Math.Min(resultB[i], 255);
            }

            var outputBuffersObject = ImageHelper.CreateNewImageBuffersObject(resultR, resultG, resultB, width, height);
            this.outputImage_pictureBox.Image = (Bitmap)ImageHelper.GetImageFromBuffers(outputBuffersObject).BitmapObject;
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            int width = BuffersFirstImage.Width, height = BuffersFirstImage.Height;
            int[] resultR = new int[width * height];
            int[] resultG = new int[width * height];
            int[] resultB = new int[width * height];
            subpic(resultR, BuffersFirstImage.RedChannel, BuffersSecondImage.RedChannel, width * height);
            subpic(resultB, BuffersFirstImage.BlueChannel, BuffersSecondImage.BlueChannel, width * height);
            subpic(resultG, BuffersFirstImage.GreenChannel, BuffersSecondImage.GreenChannel, width * height);

            var outputBuffersObject = ImageHelper.CreateNewImageBuffersObject(resultR, resultG, resultB, width, height);
            this.outputImage_pictureBox.Image = (Bitmap)ImageHelper.GetImageFromBuffers(outputBuffersObject).BitmapObject;
        }

        private void Gray_Click(object sender, EventArgs e)
        {
            int width = BuffersSecondImage.Width, height = BuffersSecondImage.Height;
            int[] resultR = new int[width * height];
            int[] resultG = new int[width * height];
            int[] resultB = new int[width * height];
            grayscale(resultR, BuffersSecondImage.RedChannel, BuffersSecondImage.BlueChannel, BuffersSecondImage.GreenChannel, width * height);
            grayscale(resultB, BuffersSecondImage.RedChannel, BuffersSecondImage.BlueChannel, BuffersSecondImage.GreenChannel, width * height);
            grayscale(resultG, BuffersSecondImage.RedChannel, BuffersSecondImage.BlueChannel, BuffersSecondImage.GreenChannel, width * height);

            var outputBuffersObject = ImageHelper.CreateNewImageBuffersObject(resultR, resultG, resultB, width, height);
            this.outputImage_pictureBox.Image = (Bitmap)ImageHelper.GetImageFromBuffers(outputBuffersObject).BitmapObject;
        }
    }
}
