namespace WindowsFormsApp1
{
    partial class camera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(camera));
            this.camOn = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.camOff = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.fps_textBox1 = new System.Windows.Forms.TextBox();
            this.Highlights_trackBar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.saturation_trackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.sharpness_trackBar = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.brightness_trackBar = new System.Windows.Forms.TrackBar();
            this.Contrast_trackBar = new System.Windows.Forms.TrackBar();
            this.Exposure_trackBar = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.capture = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Highlights_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpness_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exposure_trackBar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // camOn
            // 
            this.camOn.BackColor = System.Drawing.SystemColors.Highlight;
            this.camOn.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camOn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.camOn.Location = new System.Drawing.Point(19, 38);
            this.camOn.Name = "camOn";
            this.camOn.Size = new System.Drawing.Size(176, 55);
            this.camOn.TabIndex = 0;
            this.camOn.Text = "Cam On";
            this.camOn.UseVisualStyleBackColor = false;
            this.camOn.Click += new System.EventHandler(this.camOn_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Back.Font = new System.Drawing.Font("Swis721 Hv BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Back.Location = new System.Drawing.Point(21, 36);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(136, 42);
            this.Back.TabIndex = 5;
            this.Back.Text = "back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Silver;
            this.exit.Font = new System.Drawing.Font("Swis721 Hv BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1741, 36);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(136, 42);
            this.exit.TabIndex = 16;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Swis721 Blk BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1887, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // camOff
            // 
            this.camOff.BackColor = System.Drawing.Color.IndianRed;
            this.camOff.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camOff.ForeColor = System.Drawing.Color.White;
            this.camOff.Location = new System.Drawing.Point(19, 138);
            this.camOff.Name = "camOff";
            this.camOff.Size = new System.Drawing.Size(176, 55);
            this.camOff.TabIndex = 19;
            this.camOff.Text = "Cam Off";
            this.camOff.UseVisualStyleBackColor = false;
            this.camOff.Click += new System.EventHandler(this.camOff_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(819, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 65);
            this.label2.TabIndex = 20;
            this.label2.Text = "WEBCAM";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.fps_textBox1);
            this.panel2.Controls.Add(this.Highlights_trackBar);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.saturation_trackBar);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.sharpness_trackBar);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.Reset);
            this.panel2.Controls.Add(this.brightness_trackBar);
            this.panel2.Controls.Add(this.Contrast_trackBar);
            this.panel2.Controls.Add(this.Exposure_trackBar);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.capture);
            this.panel2.Controls.Add(this.comboBox);
            this.panel2.Controls.Add(this.camOn);
            this.panel2.Controls.Add(this.camOff);
            this.panel2.Location = new System.Drawing.Point(1296, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(541, 805);
            this.panel2.TabIndex = 22;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // fps_textBox1
            // 
            this.fps_textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fps_textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fps_textBox1.Location = new System.Drawing.Point(317, 239);
            this.fps_textBox1.Name = "fps_textBox1";
            this.fps_textBox1.ReadOnly = true;
            this.fps_textBox1.Size = new System.Drawing.Size(176, 26);
            this.fps_textBox1.TabIndex = 41;
            this.fps_textBox1.TextChanged += new System.EventHandler(this.fps_textBox1_TextChanged);
            // 
            // Highlights_trackBar
            // 
            this.Highlights_trackBar.Location = new System.Drawing.Point(326, 565);
            this.Highlights_trackBar.Maximum = 100;
            this.Highlights_trackBar.Name = "Highlights_trackBar";
            this.Highlights_trackBar.Size = new System.Drawing.Size(193, 45);
            this.Highlights_trackBar.TabIndex = 40;
            this.Highlights_trackBar.Value = 50;
            this.Highlights_trackBar.Scroll += new System.EventHandler(this.Highlights_trackBar_Scroll);
            this.Highlights_trackBar.MouseHover += new System.EventHandler(this.trackBar_MouseHover);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("News701 BT", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(214, 350);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 35);
            this.label9.TabIndex = 39;
            this.label9.Text = "Effects";
            // 
            // saturation_trackBar
            // 
            this.saturation_trackBar.Location = new System.Drawing.Point(326, 670);
            this.saturation_trackBar.Maximum = 100;
            this.saturation_trackBar.Name = "saturation_trackBar";
            this.saturation_trackBar.Size = new System.Drawing.Size(193, 45);
            this.saturation_trackBar.TabIndex = 38;
            this.saturation_trackBar.Value = 50;
            this.saturation_trackBar.Scroll += new System.EventHandler(this.saturation_trackBar_Scroll);
            this.saturation_trackBar.MouseHover += new System.EventHandler(this.trackBar_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(369, 627);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Saturation";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // sharpness_trackBar
            // 
            this.sharpness_trackBar.Location = new System.Drawing.Point(29, 670);
            this.sharpness_trackBar.Maximum = 100;
            this.sharpness_trackBar.Minimum = -100;
            this.sharpness_trackBar.Name = "sharpness_trackBar";
            this.sharpness_trackBar.Size = new System.Drawing.Size(193, 45);
            this.sharpness_trackBar.TabIndex = 36;
            this.sharpness_trackBar.Scroll += new System.EventHandler(this.sharpness_trackBar_Scroll);
            this.sharpness_trackBar.MouseHover += new System.EventHandler(this.trackBar_MouseHover);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(66, 627);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 25);
            this.label8.TabIndex = 35;
            this.label8.Text = "Sharpness";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(369, 524);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(113, 25);
            this.label.TabIndex = 33;
            this.label.Text = "Highlights";
            this.label.Click += new System.EventHandler(this.label_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.Color.Black;
            this.Reset.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reset.ForeColor = System.Drawing.Color.White;
            this.Reset.Location = new System.Drawing.Point(317, 138);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(176, 55);
            this.Reset.TabIndex = 32;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // brightness_trackBar
            // 
            this.brightness_trackBar.Location = new System.Drawing.Point(29, 459);
            this.brightness_trackBar.Maximum = 100;
            this.brightness_trackBar.Name = "brightness_trackBar";
            this.brightness_trackBar.Size = new System.Drawing.Size(193, 45);
            this.brightness_trackBar.TabIndex = 31;
            this.brightness_trackBar.Value = 50;
            this.brightness_trackBar.Scroll += new System.EventHandler(this.brightness_trackBar_Scroll);
            this.brightness_trackBar.MouseHover += new System.EventHandler(this.trackBar_MouseHover);
            // 
            // Contrast_trackBar
            // 
            this.Contrast_trackBar.Location = new System.Drawing.Point(29, 565);
            this.Contrast_trackBar.Maximum = 100;
            this.Contrast_trackBar.Name = "Contrast_trackBar";
            this.Contrast_trackBar.Size = new System.Drawing.Size(193, 45);
            this.Contrast_trackBar.TabIndex = 29;
            this.Contrast_trackBar.Value = 50;
            this.Contrast_trackBar.Scroll += new System.EventHandler(this.Contrast_trackBar_Scroll);
            this.Contrast_trackBar.MouseHover += new System.EventHandler(this.trackBar_MouseHover);
            // 
            // Exposure_trackBar
            // 
            this.Exposure_trackBar.Location = new System.Drawing.Point(326, 459);
            this.Exposure_trackBar.Maximum = 100;
            this.Exposure_trackBar.Name = "Exposure_trackBar";
            this.Exposure_trackBar.Size = new System.Drawing.Size(193, 45);
            this.Exposure_trackBar.TabIndex = 28;
            this.Exposure_trackBar.Value = 50;
            this.Exposure_trackBar.Scroll += new System.EventHandler(this.Exposure_trackBar_Scroll);
            this.Exposure_trackBar.MouseHover += new System.EventHandler(this.trackBar_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(74, 524);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Contrast";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 422);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Exposure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Brightness";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Swis721 Blk BT", 9.75F);
            this.label3.Location = new System.Drawing.Point(3, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(532, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "---------------------------------------------------------------------------------" +
    "------------------------";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // capture
            // 
            this.capture.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capture.Location = new System.Drawing.Point(317, 38);
            this.capture.Name = "capture";
            this.capture.Size = new System.Drawing.Size(176, 55);
            this.capture.TabIndex = 21;
            this.capture.Text = "capture";
            this.capture.UseVisualStyleBackColor = true;
            this.capture.Click += new System.EventHandler(this.capture_Click);
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(19, 239);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(176, 28);
            this.comboBox.TabIndex = 20;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox);
            this.panel1.Location = new System.Drawing.Point(51, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 805);
            this.panel1.TabIndex = 25;
            // 
            // pictureBox
            // 
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(0, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1163, 805);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 27;
            this.pictureBox.TabStop = false;
            // 
            // camera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.Back);
            this.Name = "camera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "camera";
            this.Load += new System.EventHandler(this.camera_Load_1);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Highlights_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saturation_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharpness_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Contrast_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exposure_trackBar)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button camOn;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button camOff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button capture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar Contrast_trackBar;
        private System.Windows.Forms.TrackBar Exposure_trackBar;
        private System.Windows.Forms.TrackBar brightness_trackBar;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar saturation_trackBar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar sharpness_trackBar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar Highlights_trackBar;
        private System.Windows.Forms.TextBox fps_textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}