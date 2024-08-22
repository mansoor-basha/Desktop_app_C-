using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class camera : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private float zoomFactor = 1.0f;
        private Point zoomPoint = Point.Empty;
        private bool isPanning = false;
        private Point lastMousePos;

        private float brightnessFactor = 1.0f;
        private float contrastFactor = 1.0f;
        private float exposureFactor = 1.0f;
        private float highlightFactor = 1.0f;
        private float sharpnessFactor = 1.0f;
        private float saturationFactor = 1.0f;

        private readonly object frameLock = new object();
        private Bitmap currentFrame;
        
        private bool hasImageBeenSaved = false;
       

        private int frameCount = 0;
        private DateTime lastTime = DateTime.Now;
        private float fps = 0.0f;

       
        private float maxZoomLevel = 5.0f;
        private float minZoomLevel = 0.1f;
        private bool isDragging = false;
        private Point mouseDownPosition;
        private Size originalPictureBoxSize;
        private Point originalPictureBoxLocation;

        public camera()
        {
            InitializeComponent();
            lastTime = DateTime.Now;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;


            Load += new EventHandler(camera_Load);
            pictureBox.MouseWheel += new MouseEventHandler(pictureBox_MouseWheel);
            pictureBox.MouseDown += new MouseEventHandler(pictureBox_MouseDown);
            pictureBox.MouseMove += new MouseEventHandler(pictureBox_MouseMove);
            pictureBox.MouseUp += new MouseEventHandler(pictureBox_MouseUp);

            capture.Click += new EventHandler(capture_Click);
            brightness_trackBar.Scroll += new EventHandler(brightness_trackBar_Scroll);
            Contrast_trackBar.Scroll += new EventHandler(Contrast_trackBar_Scroll);
            Exposure_trackBar.Scroll += new EventHandler(Exposure_trackBar_Scroll);
            sharpness_trackBar.Scroll += new EventHandler(sharpness_trackBar_Scroll);
            saturation_trackBar.Scroll += new EventHandler(saturation_trackBar_Scroll);
            Highlights_trackBar.Scroll += new EventHandler(Highlights_trackBar_Scroll);

            // Attach MouseWheel event handlers for TrackBars
            brightness_trackBar.MouseWheel += new MouseEventHandler(trackBar_MouseWheel);
            Contrast_trackBar.MouseWheel += new MouseEventHandler(trackBar_MouseWheel);
            Exposure_trackBar.MouseWheel += new MouseEventHandler(trackBar_MouseWheel);
            sharpness_trackBar.MouseWheel += new MouseEventHandler(trackBar_MouseWheel);
            saturation_trackBar.MouseWheel += new MouseEventHandler(trackBar_MouseWheel);
            Highlights_trackBar.MouseWheel += new MouseEventHandler(trackBar_MouseWheel);

            // Add MouseEnter event for trackbars
            brightness_trackBar.MouseEnter += new EventHandler(trackBar_MouseEnter);
            Contrast_trackBar.MouseEnter += new EventHandler(trackBar_MouseEnter);
            Exposure_trackBar.MouseEnter += new EventHandler(trackBar_MouseEnter);
            sharpness_trackBar.MouseEnter += new EventHandler(trackBar_MouseEnter);
            saturation_trackBar.MouseEnter += new EventHandler(trackBar_MouseEnter);
            Highlights_trackBar.MouseEnter += new EventHandler(trackBar_MouseEnter);
        }
        private void pictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }
        private void camera_Load(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video devices found");
                return;
            }

            foreach (FilterInfo device in videoDevices)
            {
                comboBox.Items.Add(device.Name);
            }
            comboBox.SelectedIndex = 0;

           
            originalPictureBoxSize = pictureBox.Size;
            originalPictureBoxLocation = pictureBox.Location;
        }

        private void camOn_Click(object sender, EventArgs e)
        {
            if (videoDevices.Count == 0) return;

            videoSource = new VideoCaptureDevice(videoDevices[comboBox.SelectedIndex].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
            videoSource.Start();
        }
        private void camOff_Click(object sender, EventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;
                return;
            }

            Bitmap cameraOffImage = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics man = Graphics.FromImage(cameraOffImage))
            {
                man.Clear(Color.Black);
                man.DrawString("Camera Off", new Font("Arial", 24), Brushes.White, new PointF(pictureBox.Width / 2 - 75, pictureBox.Height / 2 - 20));
            }
            pictureBox.Image = cameraOffImage;
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            lock (frameLock)
            {
                currentFrame?.Dispose();
                currentFrame = (Bitmap)eventArgs.Frame.Clone();
                pictureBox.Invoke(new Action(() =>
                {
                    pictureBox.Image = Adjustments(currentFrame);

                    frameCount++;
                    DateTime now = DateTime.Now;
                    TimeSpan elapsed = now - lastTime;

                    if (elapsed.TotalSeconds >= 1.0) // Update FPS every second
                    {
                        fps = frameCount / (float)elapsed.TotalSeconds;
                        fps_textBox1.Invoke(new Action(() =>
                        {
                            fps_textBox1.Text = $"FPS: {fps:F2}";
                        }));

                        frameCount = 0;
                        lastTime = now;
                    }
                }));
            }
        }
        
        private void pictureBox_MouseWheel(object sender, MouseEventArgs e)
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
        private void ZoomIn(int centerX, int centerY)
        {
            if (pictureBox.Image != null && zoomFactor < maxZoomLevel)
            {
                zoomFactor *= 1.2f;
                var newWidth = (int)(pictureBox.Width * 1.2f);
                var newHeight = (int)(pictureBox.Height * 1.2f);
                var offsetX = (int)((centerX * 1.2f) - centerX);
                var offsetY = (int)((centerY * 1.2f) - centerY);
                pictureBox.Width = newWidth;
                pictureBox.Height = newHeight;
                pictureBox.Location = new Point(pictureBox.Location.X - offsetX, pictureBox.Location.Y - offsetY);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void ZoomOut(int centerX, int centerY)
        {
            if (pictureBox.Image != null && zoomFactor > minZoomLevel)
            {
                zoomFactor /= 1.2f;
                var newWidth = (int)(pictureBox.Width / 1.2f);
                var newHeight = (int)(pictureBox.Height / 1.2f);
                var offsetX = (int)(centerX - (centerX / 1.2f));
                var offsetY = (int)(centerY - (centerY / 1.2f));
                pictureBox.Width = newWidth;
                pictureBox.Height = newHeight;
                pictureBox.Location = new Point(pictureBox.Location.X + offsetX, pictureBox.Location.Y + offsetY);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                mouseDownPosition = e.Location;
                pictureBox.Cursor = Cursors.Hand;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {

            if (isDragging)
            {
                pictureBox.Left += e.X - mouseDownPosition.X;
                pictureBox.Top += e.Y - mouseDownPosition.Y;
            }

        }
        


        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                pictureBox.Cursor = Cursors.Default;
            }
        }
       

        private Bitmap Adjustments(Bitmap bitmap)
        {
           
            Bitmap adjustedBitmap = new Bitmap(bitmap.Width, bitmap.Height);
            using (Graphics man = Graphics.FromImage(adjustedBitmap))
            {
               man.Clear(Color.Black);
                man.InterpolationMode = InterpolationMode.HighQualityBicubic;
                man.DrawImage(bitmap, 0, 0, bitmap.Width, bitmap.Height);

                using (ImageAttributes imageAttributes = new ImageAttributes())
                {

                float[][] colorMatrixElements = {
                new float[] {contrastFactor, 0, 0, 0, 0},
                new float[] {0, contrastFactor * saturationFactor, 0, 0, 0},
                new float[] {0, 0, contrastFactor * saturationFactor, 0, 0},
                new float[] {0, 0, 0, 1, 0},
                new float[] {brightnessFactor - 1 + highlightFactor - 1 + exposureFactor - 1,
                             brightnessFactor - 1 + highlightFactor - 1 + exposureFactor - 1,
                             brightnessFactor - 1 + highlightFactor - 1 + exposureFactor - 1, 0, 1}
            };

                    ColorMatrix colorMatrix = new ColorMatrix(colorMatrixElements);
                    imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);

                    man.DrawImage(bitmap,
                                new Rectangle(0, 0, bitmap.Width, bitmap.Height),
                                0, 0, bitmap.Width, bitmap.Height,
                                GraphicsUnit.Pixel, imageAttributes);
                }

                if (sharpnessFactor != 1.0f)
                {
                    float sharpnessLevel = 1.0f + (sharpnessFactor - 1.0f) * 0.5f;
                    float[][] sharpnessMatrix = {
                    new float[] {-sharpnessLevel, -sharpnessLevel, -sharpnessLevel},
                    new float[] {-sharpnessLevel, 1.0f + 8.0f * sharpnessLevel, -sharpnessLevel},
                    new float[] {-sharpnessLevel, -sharpnessLevel, -sharpnessLevel}
                    };
                    ConvolutionFilter(adjustedBitmap, sharpnessMatrix);
                }
                adjustedBitmap.RotateFlip(RotateFlipType.RotateNoneFlipX);
            }
     
            return adjustedBitmap;
        }


        private void capture_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image != null)
            {
                if (hasImageBeenSaved)
                {

                    return; 
                }

                DialogResult result = MessageBox.Show("Do you want to save the image?", "Save Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    SaveCapturedImage((Bitmap)pictureBox.Image);
                    return; 
                }
            }
        }
        private void SaveCapturedImage(Bitmap bitmap)
        {
            try
            {
                string imagesFolder = Path.Combine(Application.StartupPath, "camera");
                if (!Directory.Exists(imagesFolder))
                {
                    Directory.CreateDirectory(imagesFolder);
                }

                string fileName = Path.Combine(imagesFolder, $"Capture_{DateTime.Now:yyyyMMdd_HHmmss}.jpeg");
                bitmap.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);

                
                hasImageBeenSaved = true;

                MessageBox.Show($"Image saved successfully! {fileName}", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ConvolutionFilter(Bitmap image, float[][] kernel)
        {
            Bitmap sourceImage = (Bitmap)image.Clone();
            int width = image.Width;
            int height = image.Height;

            BitmapData srcData = sourceImage.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            BitmapData dstData = image.LockBits(new Rectangle(0, 0, width, height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

            int bytes = srcData.Stride * srcData.Height;
            byte[] pixelBuffer = new byte[bytes];
            byte[] resultBuffer = new byte[bytes];

            System.Runtime.InteropServices.Marshal.Copy(srcData.Scan0, pixelBuffer, 0, bytes);
            sourceImage.UnlockBits(srcData);

            int filterOffset = 1;
            int calcOffset = 0;
            int byteOffset = 0;

            for (int offsetY = filterOffset; offsetY < height - filterOffset; offsetY++)
            {
                for (int offsetX = filterOffset; offsetX < width - filterOffset; offsetX++)
                {
                    float blue = 0;
                    float green = 0;
                    float red = 0;

                    byteOffset = offsetY * srcData.Stride + offsetX * 4;

                    for (int filterY = -filterOffset; filterY <= filterOffset; filterY++)
                    {
                        for (int filterX = -filterOffset; filterX <= filterOffset; filterX++)
                        {
                            calcOffset = byteOffset + (filterX * 4) + (filterY * srcData.Stride);

                            blue += (float)(pixelBuffer[calcOffset]) * kernel[filterY + filterOffset][filterX + filterOffset];
                            green += (float)(pixelBuffer[calcOffset + 1]) * kernel[filterY + filterOffset][filterX + filterOffset];
                            red += (float)(pixelBuffer[calcOffset + 2]) * kernel[filterY + filterOffset][filterX + filterOffset];
                        }
                    }

                    resultBuffer[byteOffset] = (byte)Math.Min(Math.Max((int)(blue), 0), 255);
                    resultBuffer[byteOffset + 1] = (byte)Math.Min(Math.Max((int)(green), 0), 255);
                    resultBuffer[byteOffset + 2] = (byte)Math.Min(Math.Max((int)(red), 0), 255);
                    resultBuffer[byteOffset + 3] = pixelBuffer[byteOffset + 3];
                }
            }

            System.Runtime.InteropServices.Marshal.Copy(resultBuffer, 0, dstData.Scan0, bytes);
            image.UnlockBits(dstData);
        }

        private void AdjustExposureFactor(float factor)
        {
            exposureFactor = factor;
            UpdateImage();
            
        }

        private void AdjustBrightnessFactor(float factor)
        {
            brightnessFactor = factor;
            UpdateImage();
            
        }

        private void AdjustHighlightFactor(float factor)
        {
            highlightFactor = factor;
            UpdateImage();
            
        }

        private void AdjustContrastFactor(float factor)
        {
            contrastFactor = factor;
            UpdateImage();
            
        }

        private void AdjustSharpnessFactor(float factor)
        {
            sharpnessFactor = factor;
            UpdateImage();
            
        }

        private void AdjustSaturationFactor(float factor)
        {
            saturationFactor = factor;
            UpdateImage();
            
        }

        private void brightness_trackBar_Scroll(object sender, EventArgs e)
        {
            float newBrightnessFactor = brightness_trackBar.Value / 50f;
            AdjustBrightnessFactor(newBrightnessFactor);
        }

        private void Exposure_trackBar_Scroll(object sender, EventArgs e)
        {
            float newExposureFactor = Exposure_trackBar.Value / 50f;
            AdjustExposureFactor(newExposureFactor);
        }

        private void Contrast_trackBar_Scroll(object sender, EventArgs e)
        {
            float newContrastFactor = Contrast_trackBar.Value / 50f;
            AdjustContrastFactor(newContrastFactor);
        }

        private void sharpness_trackBar_Scroll(object sender, EventArgs e)
        {
            float newSharpnessFactor = sharpness_trackBar.Value / 50f;
            AdjustSharpnessFactor(newSharpnessFactor);
        }

        private void saturation_trackBar_Scroll(object sender, EventArgs e)
        {
            float newSaturationFactor = saturation_trackBar.Value / 50f;
            AdjustSaturationFactor(newSaturationFactor);
        }

        private void Highlights_trackBar_Scroll(object sender, EventArgs e)
        {
            float newHighlightFactor = Highlights_trackBar.Value / 50f;
            AdjustHighlightFactor(newHighlightFactor);
        }

        private void UpdateImage()
        {
            if (pictureBox.Image != null)
            {
                Bitmap originalBitmap = (Bitmap)pictureBox.Image;
                Bitmap adjustedBitmap = Adjustments(originalBitmap);
                pictureBox.Image = adjustedBitmap;
                originalBitmap.Dispose(
                    );
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            base.OnFormClosing(e);
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            
            zoomFactor = 1.0f;
            pictureBox.Size = originalPictureBoxSize;
            pictureBox.Location = originalPictureBoxLocation;
                    
            brightness_trackBar.Value = 50;
            Contrast_trackBar.Value = 50;
            Exposure_trackBar.Value = 50;
            sharpness_trackBar.Value = 0;
            saturation_trackBar.Value = 50;
            Highlights_trackBar.Value = 50;
                        
            brightnessFactor = 1.0f;
            contrastFactor = 1.0f;
            exposureFactor = 1.0f;
            highlightFactor = 1.0f;
            sharpnessFactor = 1.0f;
            saturationFactor = 1.0f;
                        
            UpdateImage();
        }

        // over :)

        private void Back_Click(object sender, EventArgs e)
        {
            dashbord ds = new dashbord();
            this.Hide();
            ds.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label_Click(object sender, EventArgs e)
        {

        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void pictureBox_Click(object sender, EventArgs e)
        {

        } 

        private void fps_textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar_MouseHover(object sender, EventArgs e)
        {
            

        }
        private void trackBar_MouseWheel(object sender, MouseEventArgs e)
        {
           
        }

        private void trackBar_MouseEnter(object sender, EventArgs e)
        {
            
        }
       

        private void camera_Load_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
