using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCalculatorApp
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0") || (isOperationPerformed))
                textBox_Result.Clear();

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
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (isOperationPerformed)
            {
                MessageBox.Show("Error: You cannot enter two operators at the same time. Please complete the current operation first.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (resultValue != 0)
            {
                buttonequalsto.PerformClick(); 
            }

            operationPerformed = button.Text; 
            resultValue = Double.Parse(textBox_Result.Text); 
            labelCurrentOperation.Text = resultValue + " " + operationPerformed; 
            isOperationPerformed = true; 
        }

        private void buttonclearall_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            operationPerformed = "";
            labelCurrentOperation.Text = "";
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void buttonequalsto_Click(object sender, EventArgs e)
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
                    if (Double.Parse(textBox_Result.Text) != 0)
                    {
                        textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    }
                    else
                    {
                        textBox_Result.Text = "Error"; 
                    }
                    break;
                default:
                    break;
            }

            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = "";
            operationPerformed = "";
            isOperationPerformed = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}