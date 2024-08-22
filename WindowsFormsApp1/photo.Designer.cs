namespace WindowsFormsApp1
{
    partial class photo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(photo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Preview = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.Largerpicturebox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Largerpicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(856, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Images File";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F);
            this.label2.Location = new System.Drawing.Point(1293, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(379, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Display the selected image";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(321, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "select image to upload";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Silver;
            this.exit.Font = new System.Drawing.Font("Swis721 Hv BT", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1756, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(136, 42);
            this.exit.TabIndex = 3;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Back.Font = new System.Drawing.Font("Swis721 Hv BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Back.Location = new System.Drawing.Point(12, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(136, 42);
            this.Back.TabIndex = 4;
            this.Back.Text = "back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Preview
            // 
            this.Preview.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Preview.Location = new System.Drawing.Point(1164, 887);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(206, 46);
            this.Preview.TabIndex = 5;
            this.Preview.Text = "< Prev";
            this.Preview.UseVisualStyleBackColor = true;
            this.Preview.Click += new System.EventHandler(this.Preview_Click);
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.YellowGreen;
            this.Upload.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.Location = new System.Drawing.Point(79, 885);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(206, 46);
            this.Upload.TabIndex = 7;
            this.Upload.Text = "Choose image ";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.SystemColors.Highlight;
            this.Next.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.ForeColor = System.Drawing.Color.White;
            this.Next.Location = new System.Drawing.Point(1597, 885);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(206, 46);
            this.Next.TabIndex = 8;
            this.Next.Text = "Next >";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(116, 296);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(555, 516);
            this.pictureBox.TabIndex = 10;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // Largerpicturebox
            // 
            this.Largerpicturebox.BackColor = System.Drawing.Color.White;
            this.Largerpicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Largerpicturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Largerpicturebox.Location = new System.Drawing.Point(0, 1);
            this.Largerpicturebox.Name = "Largerpicturebox";
            this.Largerpicturebox.Size = new System.Drawing.Size(638, 641);
            this.Largerpicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Largerpicturebox.TabIndex = 11;
            this.Largerpicturebox.TabStop = false;
            this.Largerpicturebox.Click += new System.EventHandler(this.Largerpicturebox_Click);
            this.Largerpicturebox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Largerpicturebox_MouseDoubleClick);
            this.Largerpicturebox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Largerpicturebox_MouseDown);
            this.Largerpicturebox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Largerpicturebox_MouseMove);
            this.Largerpicturebox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Largerpicturebox_MouseUp);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel.Location = new System.Drawing.Point(79, 222);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(694, 641);
            this.flowLayoutPanel.TabIndex = 12;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.Largerpicturebox);
            this.panel1.Location = new System.Drawing.Point(1165, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 641);
            this.panel1.TabIndex = 13;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(614, 885);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(159, 46);
            this.Delete.TabIndex = 14;
            this.Delete.Text = "delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.AliceBlue;
            this.Logout.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.Color.Red;
            this.Logout.Location = new System.Drawing.Point(1571, 12);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(136, 42);
            this.Logout.TabIndex = 15;
            this.Logout.Text = "logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Reset.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.Location = new System.Drawing.Point(1087, 223);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(72, 41);
            this.Reset.TabIndex = 16;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // photo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "photo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "photo";
            this.Load += new System.EventHandler(this.photo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Largerpicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Preview;
        private System.Windows.Forms.Button Upload;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.PictureBox Largerpicturebox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button Reset;
    }
}