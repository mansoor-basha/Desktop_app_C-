using System;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();
            Password.PasswordChar = '*';
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Password_KeyDown);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void login_Click(object sender, EventArgs e)
        {
            // aaramikulama :)

            if (Username.Text == "mansoor" && Password.Text == "12345")
            {
                
                MessageBox.Show("Login Successful for Uploader");
                photo photoForm = new photo();
                photoForm.username = "mansoor";
                this.Hide();
                photoForm.Show();

            }
            else if (Username.Text == "basha" && Password.Text == "1128")
            {
                
                MessageBox.Show("Login Successful for Deleter");
                photo photoForm = new photo();
                photoForm.username = "basha";
                this.Hide();
                photoForm.Show();
            }
            else if (Username.Text == "KML" && Password.Text == "1122")
            {
                MessageBox.Show("Login Successful");
                dashbord ds = new dashbord();
                ds.username = "KML";
                this.Hide();
                ds.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username and Password");

            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            Username.Clear();
            Password.Clear();
        }

        private bool isValid()
        {
            if (Username.Text.TrimStart() == string.Empty || Password.Text.TrimStart() == string.Empty)
            {
                MessageBox.Show("Enter Username and Password");
                return false;
            }
            return true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        }
       
        private void Username_TextChanged(object sender, EventArgs e)
        {
        }

        private void Password_TextChanged(object sender, EventArgs e)
        {
        }

        private void Showpassword_CheckedChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = Showpassword.Checked ? '\0' : '*';
        }

        private void Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login_Click(sender, e);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
