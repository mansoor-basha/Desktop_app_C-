namespace WindowsFormsApp1
{
    partial class calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculator));
            this.num2 = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.num3 = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.num0 = new System.Windows.Forms.Button();
            this.div = new System.Windows.Forms.Button();
            this.num9 = new System.Windows.Forms.Button();
            this.num8 = new System.Windows.Forms.Button();
            this.num7 = new System.Windows.Forms.Button();
            this.mul = new System.Windows.Forms.Button();
            this.num6 = new System.Windows.Forms.Button();
            this.num5 = new System.Windows.Forms.Button();
            this.num4 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.CE = new System.Windows.Forms.Button();
            this.equal = new System.Windows.Forms.Button();
            this.textBox_Result = new System.Windows.Forms.TextBox();
            this.labelOperation = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num2.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num2.Location = new System.Drawing.Point(565, 629);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(181, 60);
            this.num2.TabIndex = 3;
            this.num2.Text = "2";
            this.num2.UseVisualStyleBackColor = false;
            this.num2.Click += new System.EventHandler(this.button_click);
            // 
            // sub
            // 
            this.sub.BackColor = System.Drawing.Color.WhiteSmoke;
            this.sub.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sub.Location = new System.Drawing.Point(1007, 629);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(181, 60);
            this.sub.TabIndex = 5;
            this.sub.Text = "-";
            this.sub.UseVisualStyleBackColor = false;
            this.sub.Click += new System.EventHandler(this.operator_click);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num3.Location = new System.Drawing.Point(786, 629);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(181, 60);
            this.num3.TabIndex = 4;
            this.num3.Text = "3";
            this.num3.UseVisualStyleBackColor = false;
            this.num3.Click += new System.EventHandler(this.button_click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.add.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(1007, 708);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(181, 60);
            this.add.TabIndex = 9;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.operator_click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(786, 706);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(181, 60);
            this.button3.TabIndex = 8;
            this.button3.Text = ".";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_click);
            // 
            // num0
            // 
            this.num0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num0.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num0.Location = new System.Drawing.Point(340, 708);
            this.num0.Name = "num0";
            this.num0.Size = new System.Drawing.Size(406, 60);
            this.num0.TabIndex = 6;
            this.num0.Text = "0";
            this.num0.UseVisualStyleBackColor = false;
            this.num0.Click += new System.EventHandler(this.button_click);
            // 
            // div
            // 
            this.div.BackColor = System.Drawing.Color.WhiteSmoke;
            this.div.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div.Location = new System.Drawing.Point(1007, 471);
            this.div.Name = "div";
            this.div.Size = new System.Drawing.Size(181, 60);
            this.div.TabIndex = 13;
            this.div.Text = "/";
            this.div.UseVisualStyleBackColor = false;
            this.div.Click += new System.EventHandler(this.operator_click);
            // 
            // num9
            // 
            this.num9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num9.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num9.Location = new System.Drawing.Point(786, 471);
            this.num9.Name = "num9";
            this.num9.Size = new System.Drawing.Size(181, 60);
            this.num9.TabIndex = 12;
            this.num9.Text = "9";
            this.num9.UseVisualStyleBackColor = false;
            this.num9.Click += new System.EventHandler(this.button_click);
            // 
            // num8
            // 
            this.num8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num8.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num8.Location = new System.Drawing.Point(565, 471);
            this.num8.Name = "num8";
            this.num8.Size = new System.Drawing.Size(181, 60);
            this.num8.TabIndex = 11;
            this.num8.Text = "8";
            this.num8.UseVisualStyleBackColor = false;
            this.num8.Click += new System.EventHandler(this.button_click);
            // 
            // num7
            // 
            this.num7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num7.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num7.Location = new System.Drawing.Point(340, 471);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(181, 60);
            this.num7.TabIndex = 10;
            this.num7.Text = "7";
            this.num7.UseVisualStyleBackColor = false;
            this.num7.Click += new System.EventHandler(this.button_click);
            // 
            // mul
            // 
            this.mul.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mul.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mul.Location = new System.Drawing.Point(1007, 550);
            this.mul.Name = "mul";
            this.mul.Size = new System.Drawing.Size(181, 60);
            this.mul.TabIndex = 17;
            this.mul.Text = "*";
            this.mul.UseVisualStyleBackColor = false;
            this.mul.Click += new System.EventHandler(this.operator_click);
            // 
            // num6
            // 
            this.num6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num6.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num6.Location = new System.Drawing.Point(786, 552);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(181, 60);
            this.num6.TabIndex = 16;
            this.num6.Text = "6";
            this.num6.UseVisualStyleBackColor = false;
            this.num6.Click += new System.EventHandler(this.button_click);
            // 
            // num5
            // 
            this.num5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num5.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num5.Location = new System.Drawing.Point(565, 550);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(181, 60);
            this.num5.TabIndex = 15;
            this.num5.Text = "5";
            this.num5.UseVisualStyleBackColor = false;
            this.num5.Click += new System.EventHandler(this.button_click);
            // 
            // num4
            // 
            this.num4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num4.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num4.Location = new System.Drawing.Point(340, 550);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(181, 60);
            this.num4.TabIndex = 14;
            this.num4.Text = "4";
            this.num4.UseVisualStyleBackColor = false;
            this.num4.Click += new System.EventHandler(this.button_click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.clear.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(1231, 550);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(181, 60);
            this.clear.TabIndex = 21;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // CE
            // 
            this.CE.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CE.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CE.Location = new System.Drawing.Point(1231, 471);
            this.CE.Name = "CE";
            this.CE.Size = new System.Drawing.Size(181, 60);
            this.CE.TabIndex = 20;
            this.CE.Text = "CE";
            this.CE.UseVisualStyleBackColor = false;
            this.CE.Click += new System.EventHandler(this.CE_Click);
            // 
            // equal
            // 
            this.equal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.equal.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal.Location = new System.Drawing.Point(1231, 629);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(181, 137);
            this.equal.TabIndex = 19;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = false;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // textBox_Result
            // 
            this.textBox_Result.BackColor = System.Drawing.Color.LightGray;
            this.textBox_Result.Font = new System.Drawing.Font("GeoSlab703 Md BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Result.Location = new System.Drawing.Point(340, 369);
            this.textBox_Result.Multiline = true;
            this.textBox_Result.Name = "textBox_Result";
            this.textBox_Result.Size = new System.Drawing.Size(1068, 62);
            this.textBox_Result.TabIndex = 22;
            this.textBox_Result.Text = "0";
            this.textBox_Result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelOperation
            // 
            this.labelOperation.AutoSize = true;
            this.labelOperation.BackColor = System.Drawing.Color.LightGray;
            this.labelOperation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelOperation.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOperation.Location = new System.Drawing.Point(340, 277);
            this.labelOperation.Name = "labelOperation";
            this.labelOperation.Size = new System.Drawing.Size(2, 30);
            this.labelOperation.TabIndex = 23;
            this.labelOperation.Click += new System.EventHandler(this.labelOperation_Click);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.Silver;
            this.back.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(12, 35);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(136, 42);
            this.back.TabIndex = 25;
            this.back.Text = "back";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Font = new System.Drawing.Font("Swis721 Hv BT", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(1751, 35);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(136, 42);
            this.exit.TabIndex = 24;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.num1.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num1.Location = new System.Drawing.Point(340, 629);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(181, 60);
            this.num1.TabIndex = 26;
            this.num1.Text = "1";
            this.num1.UseVisualStyleBackColor = false;
            this.num1.Click += new System.EventHandler(this.button_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1879, 22);
            this.label1.TabIndex = 27;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(833, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 37);
            this.label2.TabIndex = 28;
            this.label2.Text = "CALCULATOR";
            // 
            // calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1037);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.labelOperation);
            this.Controls.Add(this.textBox_Result);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.CE);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.mul);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.div);
            this.Controls.Add(this.num9);
            this.Controls.Add(this.num8);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.add);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.num0);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculator";
            this.Load += new System.EventHandler(this.calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button num2;
        private System.Windows.Forms.Button sub;
        private System.Windows.Forms.Button num3;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button num0;
        private System.Windows.Forms.Button div;
        private System.Windows.Forms.Button num9;
        private System.Windows.Forms.Button num8;
        private System.Windows.Forms.Button num7;
        private System.Windows.Forms.Button mul;
        private System.Windows.Forms.Button num6;
        private System.Windows.Forms.Button num5;
        private System.Windows.Forms.Button num4;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button CE;
        private System.Windows.Forms.Button equal;
        private System.Windows.Forms.TextBox textBox_Result;
        private System.Windows.Forms.Label labelOperation;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}