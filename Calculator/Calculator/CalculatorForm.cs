using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        //number click events
        private void button_click(object sender, EventArgs e)
        {
            if((textBox_Result.Text == "0") || (isOperationPerformed) )
            {
                textBox_Result.Clear();
            }

            Button button = (Button)sender;
            if(button.Text == ".")
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
            
            isOperationPerformed = false;
        }

        // operator (+,-,*,/) click event
        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrentOperation.Text = resultValue + " " + operationPerformed;
            isOperationPerformed = true;
        }

        //clear entry event
        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        //clear everything event
        private void button6_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
            labelCurrentOperation.Text = "";
        }

        //equals event click
        private void button16_Click(object sender, EventArgs e)
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
        }

        private void change_red(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            button2.BackColor = Color.Red;
            button3.BackColor = Color.Red;
            button4.BackColor = Color.Red;
            button5.BackColor = Color.Red;
            button6.BackColor = Color.Red;
            button7.BackColor = Color.Red;
            button8.BackColor = Color.Red;
            button9.BackColor = Color.Red;
            button10.BackColor = Color.Red;
            button12.BackColor = Color.Red;
            button13.BackColor = Color.Red;
            button14.BackColor = Color.Red;
            button15.BackColor = Color.Red;
            button16.BackColor = Color.Red;
            button17.BackColor = Color.Red;
            button18.BackColor = Color.Red;            
            button20.BackColor = Color.Red;
            textBox_Result.BackColor = Color.Red;
            labelCurrentOperation.BackColor = Color.Red;
        }

        private void change_blue(object sender, EventArgs e)
        {
            button1.BackColor = Color.Blue;
            button2.BackColor = Color.Blue;
            button3.BackColor = Color.Blue;
            button4.BackColor = Color.Blue;
            button5.BackColor = Color.Blue;
            button6.BackColor = Color.Blue;
            button7.BackColor = Color.Blue;
            button8.BackColor = Color.Blue;
            button9.BackColor = Color.Blue;
            button10.BackColor = Color.Blue;
            button12.BackColor = Color.Blue;
            button13.BackColor = Color.Blue;
            button14.BackColor = Color.Blue;
            button15.BackColor = Color.Blue;
            button16.BackColor = Color.Blue;
            button17.BackColor = Color.Blue;
            button18.BackColor = Color.Blue;
            button20.BackColor = Color.Blue;
            textBox_Result.BackColor = Color.Blue;
            labelCurrentOperation.BackColor = Color.Blue;
        }

        private void change_green(object sender, EventArgs e)
        {
            button1.BackColor = Color.Green;
            button2.BackColor = Color.Green;
            button3.BackColor = Color.Green;
            button4.BackColor = Color.Green;
            button5.BackColor = Color.Green;
            button6.BackColor = Color.Green;
            button7.BackColor = Color.Green;
            button8.BackColor = Color.Green;
            button9.BackColor = Color.Green;
            button10.BackColor = Color.Green;
            button12.BackColor = Color.Green;
            button13.BackColor = Color.Green;
            button14.BackColor = Color.Green;
            button15.BackColor = Color.Green;
            button16.BackColor = Color.Green;
            button17.BackColor = Color.Green;
            button18.BackColor = Color.Green;
            button20.BackColor = Color.Green;
            textBox_Result.BackColor = Color.Green;
            labelCurrentOperation.BackColor = Color.Green;
        }

        private void change_default(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            button6.BackColor = Color.White;
            button7.BackColor = Color.White;
            button8.BackColor = Color.White;
            button9.BackColor = Color.White;
            button10.BackColor = Color.White;
            button12.BackColor = Color.White;
            button13.BackColor = Color.White;
            button14.BackColor = Color.White;
            button15.BackColor = Color.White;
            button16.BackColor = Color.White;
            button17.BackColor = Color.White;
            button18.BackColor = Color.White;
            button20.BackColor = Color.White;
            textBox_Result.BackColor = Color.White;
            labelCurrentOperation.BackColor = Color.White;
        }
    }
}
