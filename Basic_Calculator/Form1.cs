using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int number1, number2,result;
        String operation;
        bool cleaning;
        
        private void button0_Click(object sender, EventArgs e)
        {
            if (cleaning )
            {
                ScreenBox.Text = string.Empty;
                cleaning = false;
            }
                if (ScreenBox.Text == "0")
            {
                ScreenBox.Text = string.Empty;


            }
            ScreenBox.Text += 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cleaning ) { 
                ScreenBox.Text = string.Empty;
                cleaning = false;
            }
            if (ScreenBox.Text == "0")
            {
                ScreenBox.Text = string.Empty;


            }
            ScreenBox.Text +=1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cleaning ) { 
                
                
                
                ScreenBox.Text = string.Empty;
                cleaning = false;
            }
            if (ScreenBox.Text == "0")
            {
                ScreenBox.Text = string.Empty;


            }
            ScreenBox.Text +=2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (cleaning ) { 
                ScreenBox.Text = string.Empty;
                cleaning = false;
            }
            if (ScreenBox.Text == "0")
            {
                ScreenBox.Text = string.Empty;


            }
            ScreenBox.Text += 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cleaning ) { 
                ScreenBox.Text = string.Empty;
                cleaning = false;
            }
            if (ScreenBox.Text == "0")
            {
                ScreenBox.Text = string.Empty;


            }
            ScreenBox.Text += 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cleaning) { 
                ScreenBox.Text = string.Empty;
                cleaning = false;
            }
            if (ScreenBox.Text == "0")
            {
                ScreenBox.Text = string.Empty;


            }
            ScreenBox.Text += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if  (cleaning) { 
                    ScreenBox.Text = string.Empty;
            cleaning = false;
            }
            if (ScreenBox.Text == "0")
            {
                ScreenBox.Text = string.Empty;


            }
            ScreenBox.Text += 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (cleaning)
            {
                ScreenBox.Text = string.Empty;
                cleaning = false;
            }
            if (ScreenBox.Text == "0")
            {
                ScreenBox.Text = string.Empty;


            }
            ScreenBox.Text += 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (cleaning) {
                
                ScreenBox.Text = string.Empty;
                cleaning = false;
            }
                if (ScreenBox.Text == "0")
            {
                ScreenBox.Text = string.Empty;


            }
            ScreenBox.Text += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (cleaning)
            {

                ScreenBox.Text = string.Empty;
                cleaning = false;
            }
            if (ScreenBox.Text == "0")
            {
                ScreenBox.Text = string.Empty;


            }
            ScreenBox.Text += 9;
        }
        

        private void buttonaddition_Click(object sender, EventArgs e)
        {
            
            
                operation = "+";
            number1 = Convert.ToInt32(ScreenBox.Text);
                cleaning = true;
            
        }

        private void buttonsubstract_Click(object sender, EventArgs e)
        {
            operation += "-";
            number1 = Convert.ToInt32(ScreenBox.Text);
            cleaning = true;
        }

        private void buttonmultip_Click(object sender, EventArgs e)
        {
            
            operation = "*";
            number1 = Convert.ToInt32(ScreenBox.Text);
            cleaning = true;
        }

        private void buttondivision_Click(object sender, EventArgs e)
        {operation += "/";
            number1 = Convert.ToInt32(ScreenBox.Text);
            cleaning = true;

        }

        private void buttonc_Click(object sender, EventArgs e)
        {
            ScreenBox.Text=string.Empty;
            result = 0;
             number2 = 0;
            number1 = 0;
        }

        private void buttonresult_Click(object sender, EventArgs e)
        {
            
            number2 = Convert.ToInt32(ScreenBox.Text);
            switch (operation)
            {
                 case "+":
                    result = number1 + number2;
                    ScreenBox.Text=result.ToString();
                    break;
                    case "-":
                    result = number1 - number2;
                    ScreenBox.Text = result.ToString();
                    break;
                case "*":
                    result = number1 * number2;
                    ScreenBox.Text = result.ToString();
                    break;
                case "/":
                    result = number1 / number2;
                    ScreenBox.Text = result.ToString();
                    break;
            }


        }
    }
}
