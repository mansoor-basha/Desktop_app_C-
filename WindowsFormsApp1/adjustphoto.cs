using System;
 
using System.Drawing;
 
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class adjustphoto : Form
    {
        public string username;
        private Image originalImage;
        public adjustphoto()
        {
            InitializeComponent();
            this.Load += adjustphoto_Load;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
        private void Upload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "JPEG|*.jpeg|JPG|*.jpg";
                openFileDialog1.Title = "Select an Image";
                DialogResult mb = openFileDialog1.ShowDialog();

                if (mb == DialogResult.OK)
                {
                    try
                    {
                        originalImage = Image.FromFile(openFileDialog1.FileName);
                        pictureBox.Image = originalImage;
                        txtWidth.Text = originalImage.Width.ToString();
                        txtHeight.Text = originalImage.Height.ToString();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message);
                    }
                }
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            pictureBox.Image = null;
            txtWidth.Text = string.Empty;
            txtHeight.Text = string.Empty;
            altWidth.Text = string.Empty;
            altHeight.Text = string.Empty;
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void adjustphoto_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void altHeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void altWidth_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apply_Click(object sender, EventArgs e)
        {
            try
            {
                int newWidth = int.Parse(altWidth.Text);
                int newHeight = int.Parse(altHeight.Text);

                if (originalImage != null && newWidth > 0 && newHeight > 0)
                { 
                    if (newWidth > originalImage.Width || newHeight > originalImage.Height)
                    {     
                        MessageBox.Show("Crop dimensions exceed original image dimensions.");
                        return;
                    }                                       
                    int startX = (originalImage.Width - newWidth) / 2;
                    int startY = (originalImage.Height - newHeight) / 2;
                    Rectangle cropArea = new Rectangle(startX, startY, newWidth, newHeight);
                    Bitmap crpImage = new Bitmap(originalImage);
                    Bitmap croppedImage = crpImage.Clone(cropArea, crpImage.PixelFormat);
                    pictureBox.Image = croppedImage;
                }
                else
                {
                    MessageBox.Show("Please enter valid dimensions.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error applying new dimensions: " + ex.Message);
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            if (originalImage != null)
            {
                pictureBox.Image = new Bitmap(originalImage);
                txtWidth.Text = originalImage.Width.ToString();
                txtHeight.Text = originalImage.Height.ToString();
                altWidth.Text = string.Empty;
                altHeight.Text = string.Empty;
            }
        }
        private void back_Click(object sender, EventArgs e)
        {
            dashbord ds = new dashbord();
            this.Hide();
            ds.Show();
        }
    }
}
