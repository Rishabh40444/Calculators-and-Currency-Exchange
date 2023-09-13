using System.IO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators_and_Currency_Exchange
{
    public partial class frmCalculator1 : Form
    {
        public frmCalculator1()
        {
            InitializeComponent();
        }

        string num1, num2;                      // two global variables which will contain user input
        char operation;                         // operator
        Double result=0.0;                      // result gven after operations
        string userInput="";                    // input given by user

        
        private void lblresult_Click(object sender, EventArgs e)
        {
            lblresult.Text = "0";
        }
        private void btnzero_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";                // clearing the display
            userInput += "0";                   // adding userinput
            lblresult.Text = userInput;         // displaying userinput

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            userInput += "1";
            lblresult.Text = userInput;
            

        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            userInput += "2";
            lblresult.Text = userInput;




        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";            
            userInput += "3";
            lblresult.Text = userInput;


        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            userInput += "4";
            lblresult.Text = userInput;


        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            userInput += "5";
            lblresult.Text = userInput;


        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            userInput += "6";
            lblresult.Text = userInput;


        }

        private void btnNine_Click(object sender, EventArgs e)
        {

            lblresult.Text = "";
            userInput += "9";
            lblresult.Text = userInput;

        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
            userInput += "8";
            lblresult.Text = userInput;


        }

        private void btnSeven_Click(object sender, EventArgs e)
        {

            lblresult.Text = "";
            userInput += "7";
            lblresult.Text = userInput;

        }
        private void btnadd_Click(object sender, EventArgs e)
        {
            operation = '+';
            num1=userInput;           // after btnadd is clicked, the userinput is assigned to num1
            userInput = "";
            lblcalcuation.Text = num1 + "+";

        }
        private void btnsubtract_Click(object sender, EventArgs e)
        {
            operation = '-';
            num1 = userInput;           // after btnsubtract is clicked, the userinput is assigned to num1
            userInput = "";
            lblcalcuation.Text = num1 + "-";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {

            num2 = userInput;
            lblcalcuation.Text = num1+" "+operation+num2 + "=";
            Single first_num, second_num;
            first_num = Convert.ToSingle(num1);
            second_num = Convert.ToSingle(num2);
            if(operation == '+')
            {
                result = first_num + second_num;
                lblresult.Text = result.ToString();
            }
            else if (operation == '-')
            {

                result = first_num - second_num;
                lblresult.Text = result.ToString();
            }
            else if (operation == 'x')
            {

                result = first_num * second_num;
                lblresult.Text = result.ToString();
            }
            else if (operation == '/')
            {

                result = first_num / second_num;
                lblresult.Text = result.ToString();
                if (second_num == 0)
                {
                    MessageBox.Show("Cannot divide by zero","Error message"
                    ,MessageBoxButtons.OK,MessageBoxIcon.Error);
                    lblresult.Text = "0";
                }
            }
            else if (operation == '%')
            {
                result = (first_num * second_num) / 100;
                lblresult.Text = result.ToString();
            }
            else if(operation== Convert.ToChar("x²"))
            {
                first_num = second_num;
                result = first_num * second_num;
                lblresult.Text = result.ToString();
            }
            else if(operation == Convert.ToChar("²√x"))
            {
                result = Math.Sqrt(first_num);
                lblresult.Text = result.ToString();
            }
        }

        private void btnmultiply_Click(object sender, EventArgs e)
        {
            operation = 'x';
            num1 = userInput;           // after btnmultiply is clicked, the userinput is assigned to num1
            userInput = "";
            lblcalcuation.Text = num1 + "x";

        }

        private void btndivide_Click(object sender, EventArgs e)
        {
            operation = '/';
            num1 = userInput;           // after btndivide is clicked, the userinput is assigned to num1
            userInput = "";
            lblcalcuation.Text = num1 + "/";

        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            operation = '%';
            num1 = userInput;           // after btndivide is clicked, the userinput is assigned to num1
            userInput = "";
            lblcalcuation.Text = num1 + "%";

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            num1 = num2 = "";
            userInput = "";
            lblresult.Text = "0";
            lblcalcuation.Text = "";
        }

      
        
        private void btnBackspace_Click(object sender, EventArgs e)
        {
            lblresult.Text = lblresult.Text.Remove(lblresult.Text.Length - 1);
            if (lblresult.Text == "")
            {
                lblresult.Text = "0";
            }
            /*else
            {
                lblresult.Text = "This operation is invalid right now";
            }
            */

            /*if (lblresult.Text == "")
            {
                btnBackspace.Enabled = false;
            }
            else
            {
                btnBackspace.Enabled = true;
            }
            */
        }

        private void btnclearentry_Click(object sender, EventArgs e)
        {
            lblresult.Text = "";
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            operation = Convert.ToChar("+/-");
            num1 = userInput;
            userInput = "";
            lblcalcuation.Text = "-" +num1;


        }

        private void btnsquare_Click(object sender, EventArgs e)
        {
            operation = Convert.ToChar("x²");
            num1 = userInput;
            userInput = "";
            lblcalcuation.Text = num1 + "²";
        }

        private void btnsqrt_Click(object sender, EventArgs e)
        {
            operation = Convert.ToChar("²√x");
            num1 = userInput;
            userInput = "";
            lblcalcuation.Text = "²√" + num1;
        }

        private void btndecimal_Click(object sender, EventArgs e)
        {
            
            operation='.';
            if (!(lblresult.Text.Contains(".")))
            {
               
                lblresult.Text += ".";

            }

           
            
        }
       
    }
}
