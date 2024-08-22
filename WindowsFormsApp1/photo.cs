using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class photo : Form
    {
        private List<string> imageFilePaths = new List<string>();
        private int currentImageIndex = -1;
        private float zoomFactor = 1.0f;
        private float maxZoomLevel = 5.0f;
        private float minZoomLevel = 0.1f;
        private bool isDragging = false;
        private Point mouseDownPosition;
        public string username;

       

        public photo()
        {
            InitializeComponent();
            this.Load += photo_Load;
            this.Largerpicturebox.MouseWheel += Largerpicturebox_MouseWheel;
            this.Largerpicturebox.MouseDown += Largerpicturebox_MouseDown;
            this.Largerpicturebox.MouseMove += Largerpicturebox_MouseMove;
            this.Largerpicturebox.MouseUp += Largerpicturebox_MouseUp;
            this.Largerpicturebox.MouseDoubleClick += Largerpicturebox_MouseDoubleClick;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Reset.Click += Reset_Click;


        }
        public void photo_Load(object sender, EventArgs e)
        {
            if (username == "mansoor")
            {
                Upload.Enabled = true;
                Delete.Enabled = false;
                Delete.Visible = false;
            }
            else if (username == "basha")
            {
                Upload.Enabled = false;
                Delete.Enabled = true;
                SaveAndDisplay();
            }
            else
            {
                Upload.Enabled = false;
                Delete.Enabled = false;
            }

        }

        private void Largerpicturebox_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                ZoomIn(e.X, e.Y);
            }
            else
            {
                ZoomOut(e.X, e.Y);
            }
        }

        private void ZoomOut(int centerX, int centerY)
        {
            if (Largerpicturebox.Image != null && zoomFactor > minZoomLevel)
            {
                zoomFactor /= 1.2f;
                var newWidth = (int)(Largerpicturebox.Width / 1.2f);
                var newHeight = (int)(Largerpicturebox.Height / 1.2f);
                var offsetX = (int)(centerX - (centerX / 1.2f));
                var offsetY = (int)(centerY - (centerY / 1.2f));
                Largerpicturebox.Width = newWidth;
                Largerpicturebox.Height = newHeight;
                Largerpicturebox.Location = new Point(Largerpicturebox.Location.X + offsetX, Largerpicturebox.Location.Y + offsetY);
                Largerpicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void ZoomIn(int centerX, int centerY)
        {
            if (Largerpicturebox.Image != null && zoomFactor < maxZoomLevel)
            {
                zoomFactor *= 1.2f;
                var newWidth = (int)(Largerpicturebox.Width * 1.2f);
                var newHeight = (int)(Largerpicturebox.Height * 1.2f);
                var offsetX = (int)((centerX * 1.2f) - centerX);
                var offsetY = (int)((centerY * 1.2f) - centerY);
                Largerpicturebox.Width = newWidth;
                Largerpicturebox.Height = newHeight;
                Largerpicturebox.Location = new Point(Largerpicturebox.Location.X - offsetX, Largerpicturebox.Location.Y - offsetY);
                Largerpicturebox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
       
        private void SaveAndDisplay()
        {
            // daivame una save pani execute panrathukula vedinjiduchu

            string imagesFolderPath = Path.Combine(Application.StartupPath, "Images");
            if (Directory.Exists(imagesFolderPath))
            {
                string[] imageFiles = Directory.GetFiles(imagesFolderPath, "*.jpg").Concat(Directory.GetFiles(imagesFolderPath, "*.jpeg")).ToArray();
                foreach (string imagePath in imageFiles)
                {
                    imageFilePaths.Add(imagePath);
                    DisplayImage(imagePath);
                }

                // if i need to display the first image with out selecting
                //      if (imageFilePaths.Count > 0)
                // {
                //   currentImageIndex = 0;
                //    DisplayLargerImage(imageFilePaths[currentImageIndex]);
                // }
                
            }
        }
        private void Upload_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "JPEG|*.jpeg|JPG|*.jpg";
                DialogResult dr = openFileDialog.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    imageFilePaths.Clear();
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        imageFilePaths.Add(filePath);
                        string fileName = Path.GetFileName(filePath);
                        string destPath = Path.Combine(Application.StartupPath, "Images", fileName);
                        File.Copy(filePath, destPath, true);
                    }

                    DisplayImagesForUser();
                    currentImageIndex = imageFilePaths.Count > 0 ? 0 : -1;

                    if (currentImageIndex != -1)
                    {
                        DisplayLargerImage(imageFilePaths[currentImageIndex]);
                    }

                    MessageBox.Show("Images have been uploaded successfully");
                }
            }
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < flowLayoutPanel.Controls.Count; i++)
            {
                if (flowLayoutPanel.Controls[i] is PictureBox pictureBox && pictureBox.BackColor == Color.YellowGreen)
                {
                    
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this image?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        flowLayoutPanel.Controls.RemoveAt(i);
                        imageFilePaths.RemoveAt(currentImageIndex);
                        pictureBox.Dispose();

                        if (imageFilePaths.Count > 0)
                        {
                            currentImageIndex = currentImageIndex % imageFilePaths.Count;
                            DisplayLargerImage(imageFilePaths[currentImageIndex]);
                        }
                        else
                        {
                            currentImageIndex = -1;
                            Largerpicturebox.Visible = false;
                        }

                        MessageBox.Show("Image has been deleted successfully");
                    }
                    break;
                }
            }

        }

        private void DisplayImage(string filePath)
        {
            PictureBox pictureBox = new PictureBox
            {
                Image = Image.FromFile(filePath),
                SizeMode = PictureBoxSizeMode.Zoom,
                Height = 200,
                Width = 200,
                BorderStyle = BorderStyle.FixedSingle
            };
            pictureBox.Click += pictureBox_Click;
            flowLayoutPanel.Controls.Add(pictureBox);
        }
        private void DisplayLargerImage(string filePath)
        {
            if (Largerpicturebox == null)
            {
                Largerpicturebox = new PictureBox
                {
                    Height = 30,
                    Width = 30,
                    BorderStyle = BorderStyle.FixedSingle,
                    Visible = true
                };
                Controls.Add(Largerpicturebox);
                Largerpicturebox.BringToFront();
            }
            Largerpicturebox.Image = Image.FromFile(filePath);
        }
        private void Largerpicturebox_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                foreach (Control ctrl in flowLayoutPanel.Controls)
                {
                    if (ctrl is PictureBox)
                    {
                        (ctrl as PictureBox).BackColor = Color.Transparent;
                    }
                }

                pictureBox.BackColor = Color.YellowGreen;
                currentImageIndex = flowLayoutPanel.Controls.GetChildIndex(pictureBox);
                DisplayLargerImage(imageFilePaths[currentImageIndex]);
            }
        }
       private void Preview_Click(object sender, EventArgs e)
        {
            if (imageFilePaths.Count > 0)
            {
                currentImageIndex = (currentImageIndex - 1 + imageFilePaths.Count) % imageFilePaths.Count;
                DisplayLargerImage(imageFilePaths[currentImageIndex]);
                HighlightCurrentImage();
            }
            else
            {
                MessageBox.Show("Upload an image");
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (imageFilePaths.Count > 0)
            {
                currentImageIndex = (currentImageIndex + 1) % imageFilePaths.Count;
                DisplayLargerImage(imageFilePaths[currentImageIndex]);
                HighlightCurrentImage();
            }
            else
            {
                MessageBox.Show("Upload an image");
            }
        }

        private void HighlightCurrentImage()
        {
            foreach (Control ctrl in flowLayoutPanel.Controls)
            {
                if (ctrl is PictureBox pictureBox)
                {
                    pictureBox.BackColor = Color.Transparent;
                }
            }

            if (currentImageIndex != -1 && currentImageIndex < flowLayoutPanel.Controls.Count)
            {
                ((PictureBox)flowLayoutPanel.Controls[currentImageIndex]).BackColor = Color.YellowGreen;
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            dashbord ds = new dashbord();
            this.Hide();
            ds.Show();
        }

        private void Largerpicturebox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ZoomIn(e.X, e.Y);
        }

        private void DisplayImagesForUser()
        {
            flowLayoutPanel.Controls.Clear();

            foreach (string path in imageFilePaths)
            {
              
                DisplayImage(path);
            }
        }

        private void Largerpicturebox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseDownPosition = e.Location;
                Largerpicturebox.Cursor = Cursors.Hand;
            }
        }

        private void Largerpicturebox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Largerpicturebox.Left += e.X - mouseDownPosition.X;
                Largerpicturebox.Top += e.Y - mouseDownPosition.Y;
            }
        }

        private void Largerpicturebox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                Largerpicturebox.Cursor = Cursors.Default;
            }
        }

        

        private void Logout_Click(object sender, EventArgs e)
        {
            // pothum da niruthikalam

            Form1 ds = new Form1();
            this.Hide();
            ds.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ResetZoomAndPosition();
        }
        private void ResetZoomAndPosition()
        {
            if (Largerpicturebox != null && Largerpicturebox.Image != null)
            {
                
                zoomFactor = 1.0f;
                Largerpicturebox.Width = Largerpicturebox.Image.Width;
                Largerpicturebox.Height = Largerpicturebox.Image.Height;
                Largerpicturebox.Location = new Point(0, 0);
                Largerpicturebox.SizeMode = PictureBoxSizeMode.StretchImage;

                isDragging = false;
                Largerpicturebox.Cursor = Cursors.Default;
            }
        }

    }
}
