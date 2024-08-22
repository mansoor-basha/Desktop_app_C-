using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class dashbord : Form
    {

        public string username;
        public dashbord()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

        }
        private void dashbord_Load(object sender, EventArgs e)
        {
           
        }

        private void Image_Click(object sender, EventArgs e)
        {
            adjustphoto photoForm = new adjustphoto();
            this.Hide();
            photoForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            calculator cal = new calculator();
            this.Hide();
            cal.Show();
        }
        private void Webcam_Click(object sender, EventArgs e)
        {
            camera cam = new camera();
            this.Hide();
            cam.Show();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void Logout_Click(object sender, EventArgs e)
        {

            Form1 lo = new Form1();
            this.Hide();
            lo.Show();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
    }
}
