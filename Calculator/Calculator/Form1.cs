// Practical-2
// Developed by Meet Patel (161040107030)
// Developed in C# .net
// Creation date - 29/12/2018
// Project Title -- Scientific Calculator

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
    public partial class Form1 : Form
    {
        Double value = 0;
        string operation = "";
        int flag = 0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e) //button pressed between 0-9
        {
            if ((result.Text == "0")||flag==1)
                result.Clear();
            flag = 0;
            Button b = (Button)sender;
            if (b.Text == ".") //to check wheather textbox contains "." or not
            {
                if (!result.Text.Contains("."))
                    result.Text = result.Text + b.Text;
            }
            else
            {
                result.Text = result.Text + b.Text;
            } 
        }

        private void operator_click(object sender, EventArgs e) //operator pressed
        {
                Button b = (Button)sender;
                operation = b.Text;
                value = Double.Parse(result.Text);
                flag = 1; //when operator pressed flag set to 1
        }



        private void button_clear(object sender, EventArgs e) 
        {
            result.Clear(); //clear the textbox
            result.Text = "0"; //set textbox value to 0
        }

        private void button_equal(object sender, EventArgs e)
        {
            switch(operation) //operation performed when particular operator is pressed
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "%":
                    result.Text = (value % (Double.Parse(result.Text))).ToString();
                    break;
                
                default:
                    break;
            }
        }


        private void button_delete(object sender, EventArgs e) //delete one digit from textbox
        {
            string temp = result.Text;
            if(temp.Length!=0)
            {
                result.Text = temp.Substring(0,temp.Length-1);
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 370; //set form width
            result.Width = 330; //set textbox width

            DialogResult result1; 
            result1=MessageBox.Show("Welcome...\n\nDo You Want to Continue ?", "Calculator", MessageBoxButtons.YesNo);
            if (result1==DialogResult.No)
            {
                Application.Exit();
            }
        }


        private void standardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 370; //set form width
            result.Width = 330; //set textbox width
        }

        private void scientificToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Width = 590; //set form width
            result.Width = 550; //set textbox width
        }

       

        private void btnpi_Click(object sender, EventArgs e)
        {
            result.Text = "3.1415926535897932384626433832795";
        }

        private void btnlog_Click(object sender, EventArgs e) //log button
        {
            result.Text = (Math.Log10(Double.Parse(result.Text))).ToString();
        }
        private void btnln_Click(object sender, EventArgs e) //ln button
        {
            result.Text = (Math.Log(Double.Parse(result.Text))).ToString();
        }
        private void btnsqrt_Click(object sender, EventArgs e) //Square_Root Button
        {
            result.Text = (Math.Sqrt(Double.Parse(result.Text))).ToString();
        }

        private void btnfact_Click(object sender, EventArgs e) //Factorial Button
        {
            Double fact = 1;

            for (int i = 1; i <= Double.Parse(result.Text); i++)
            {
                fact = fact * i;
            }
            result.Text = fact.ToString();
        }

        private void btndiv_Click(object sender, EventArgs e) //1/x button
        {
            result.Text = (1/(Double.Parse(result.Text))).ToString();
        }

        private void btnsin_Click(object sender, EventArgs e) //Sin Button
        {
            result.Text = (Math.Sin(Double.Parse(result.Text))).ToString();
        }

        private void btncos_Click(object sender, EventArgs e) //Cos Button
        {
            result.Text = (Math.Cos(Double.Parse(result.Text))).ToString();
        }

        private void btntan_Click(object sender, EventArgs e) //Tan Button
        {
            result.Text = (Math.Tan(Double.Parse(result.Text))).ToString();
        }

        private void btnsqr_Click(object sender, EventArgs e) //Square Button
        {
            result.Text = ((Double.Parse(result.Text))*(Double.Parse(result.Text))).ToString();
        }

        private void btncube_Click(object sender, EventArgs e) //Cube Button
        {
            result.Text = ((Double.Parse(result.Text))*(Double.Parse(result.Text))* (Double.Parse(result.Text))).ToString();
        }

        private void btnexp_Click(object sender, EventArgs e) // Exponential Button
        {
            result.Text = (Math.Exp(Double.Parse(result.Text))).ToString();
        }

        private void result_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
