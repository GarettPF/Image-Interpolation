namespace HW4
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void load_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg;*.jpeg; *.gif; *.bmp; *.png)| *.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                original_img.Image = new Bitmap(ofd.FileName);
                original_img.Size = original_img.Image.Size;
                this.Width = original_img.Image.Width + load_image.Width + 50;
                this.Height = original_img.Image.Height + 70;
            }
        }

        private Bitmap resizeImage(Bitmap image)
        {
            // convert img into array of bytes
            byte[,,] img = new byte[image.Width, image.Height, 3];
            for (int y = 0; y < image.Height; y++)
            {
                for (int x = 0; x < image.Width; x++)
                {
                    Color pixel = image.GetPixel(x, y);
                    img[x, y, 0] = pixel.R;
                    img[x, y, 1] = pixel.G;
                    img[x, y, 2] = pixel.B;
                }
            }

            // resize each RGB layer of the image into a double big array
            int rows = 2 * image.Height - 1;
            int cols = 2 * image.Width - 1;
            byte[,,] nimg = new byte[cols, rows, 3];

            for (int layer = 0; layer < 3; layer++)
            {
                // move the original points into the new array
                for (int y = 0; y < image.Height; y++)
                {
                    for (int x = 0; x < image.Width; x++)
                    {
                        nimg[2 * x, 2 * y, layer] = img[x, y, layer];
                    }
                }

                // interpolate to create the vertical values
                for (int y = 1; y < rows; y += 2)
                {
                    for (int x = 0; x < cols; x += 2)
                    {
                        nimg[x, y, layer] = (byte)((nimg[x, y - 1, layer] + nimg[x, y + 1, layer])/2);
                    }
                }

                // interpolate to create the horizontal values
                for (int y = 0; y < rows; y += 2)
                {
                    for (int x = 1; x < cols; x += 2)
                    {
                        nimg[x, y, layer] = (byte)((nimg[x - 1, y, layer] + nimg[x + 1, y, layer]) / 2);
                    }
                }

                // produce the center values
                for (int y = 1; y < rows; y += 2)
                {
                    for (int x = 1; x < cols; x += 2)
                    {
                        int sum = nimg[x - 1, y, layer] + nimg[x + 1, y, layer] + nimg[x, y - 1, layer] + nimg[x, y + 1, layer];
                        nimg[x, y, layer] = (byte)(sum / 4);
                    }
                }
            }

            // convert nimg to Bitmap type
            Bitmap result = new Bitmap(image.Width*2 - 1, image.Height*2 - 1);
            for (int y = 0; y < result.Height; y++)
            {
                for (int x = 0; x < result.Width; x++)
                {
                    result.SetPixel(x, y, Color.FromArgb(255, nimg[x, y, 0], nimg[x, y, 1], nimg[x, y, 2]));
                }
            }

            return result;
        }

        private void double_size_Click(object sender, EventArgs e)
        {
            Bitmap doubleImage = resizeImage((Bitmap)original_img.Image);
            Form wn = new Form2();
            wn.Text = "Double Size of the selected image: ";

            PictureBox picture = new PictureBox();
            picture.Image = doubleImage;
            picture.Size = doubleImage.Size;
            wn.Size = picture.Size;
            wn.Controls.Add(picture);
            wn.Show();
        }
    }
}