using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class calculator : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        bool isOperatorClickedAfterEqual = false;

        public calculator()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            dashbord ds = new dashbord();
            this.Hide();
            ds.Show();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
            {
                textBox_Result.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                {
                    textBox_Result.Text = textBox_Result.Text + button.Text;
                }
            }
            else
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            labelOperation.Text += button.Text;

        }
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isOperatorClickedAfterEqual)
            {
                operationPerformed = button.Text;
                labelOperation.Text = resultValue + " " + operationPerformed + " ";
                isOperationPerformed = true;
            }
            else if (resultValue != 0)
            {
                equal.PerformClick();
                operationPerformed = button.Text;
                labelOperation.Text = resultValue + " " + operationPerformed + " ";
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox_Result.Text);
                labelOperation.Text = resultValue + " " + operationPerformed + " ";
                isOperationPerformed = true;
            }
            isOperatorClickedAfterEqual = false;
        }

        private void CE_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            labelOperation.Text = ""; 
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            labelOperation.Text = "";
        }
        private void equal_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;

                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;
            }
            resultValue = Double.Parse(textBox_Result.Text);
            labelOperation.Text = ""; 
            isOperatorClickedAfterEqual = true;
        }

        private void labelOperation_Click(object sender, EventArgs e)
        {

        }
        private void calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
