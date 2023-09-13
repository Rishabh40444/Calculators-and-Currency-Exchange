using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators_and_Currency_Exchange
{
    public partial class frmChange : Form
    {
        public frmChange()
        {
            InitializeComponent();
        }
        
       struct country
        {
            public string name;
            public string currency;
            public double value;
        }
        static country[] tabcountry = new country[50];
        Int16 nbcountry;
        string cont;
        string curr;
    


        private void readFile()                 // function to read file CountryInfo.txt to array
        {
            StreamReader myfile = new StreamReader("Countryinfo.txt");
            Int16 i = 0;
            while (myfile.EndOfStream == false)
            {
                tabcountry[i].name = myfile.ReadLine();
                tabcountry[i].currency = myfile.ReadLine();
                tabcountry[i].value = Convert.ToDouble(myfile.ReadLine());

                cboCountry.Items.Add(tabcountry[i].name);
                i++;
            }
            myfile.Close();
            nbcountry = i;
        }

        private void frmChange_Load(object sender, EventArgs e)
        {

            readFile();



        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            cont = cboCountry.SelectedItem.ToString();
            
            for(Int16 i = 0; i<nbcountry; i++)
            {
                if (cont == tabcountry[i].name && cont=="France")
                {
                    curr = tabcountry[i].currency;
                    radioButton1.Text = "Convert US Dollars to " + curr;
                    radioButton2.Text = " Convert " + curr + "(s) to US dollar(s)";
                    lblDisplay1.Text = " 1 US Dollar = 6.2385682 " + curr+"(s)";
                    lblDisplay2.Text = "1 " + curr + " = " + tabcountry[i].value + " US dollar(s)";
                }
                if (cont == tabcountry[i].name && cont == "Canada")
                {
                    curr = tabcountry[i].currency;
                    radioButton1.Text = "Convert US Dollars to " + curr;
                    radioButton2.Text = " Convert " + curr + "(s) to US dollar(s)";
                    lblDisplay1.Text = " 1 US Dollar = 1.3670427 " + curr + "(s)";
                    lblDisplay2.Text = "1 " + curr + " = " + tabcountry[i].value + " US dollar(s)";
                }
                if (cont == tabcountry[i].name && cont == "England")
                {
                    curr = tabcountry[i].currency;
                    radioButton1.Text = "Convert US Dollars to " + curr;
                    radioButton2.Text = " Convert " + curr + "(s) to US dollar(s)";
                    lblDisplay1.Text = " 1 US Dollar = 0.8181884 " + curr + "(s)";
                    lblDisplay2.Text = "1 " + curr + " = "+tabcountry[i].value+" US dollar(s)";
                }
                if (cont == tabcountry[i].name && cont == "Japan")
                {
                    curr = tabcountry[i].currency;
                    radioButton1.Text = "Convert US Dollars to "+curr;
                    radioButton2.Text = " Convert " + curr + "(s) to US dollar(s)";
                    lblDisplay1.Text = " 1 US Dollar = 136.85716 " + curr + "(s)";
                    lblDisplay2.Text = "1 " + curr + " = "+tabcountry[i].value+" US dollar(s)";
                }


            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure you want to exit the program?", "Warning", MessageBoxButtons.OKCancel,
                             MessageBoxIcon.Warning) == (DialogResult.OK)){
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //cboCountry.SelectedItem = null;
            radioButton1.Text= "";
            radioButton2.Text = "";
            lblDisplay1.Text="";
            lblDisplay2.Text = "";
            lblDisplay3.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAmount.Text = " ";
            lblResult.Text = "";


            
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double num_input = Convert.ToDouble(txtAmount.Text);
            cont = cboCountry.SelectedItem.ToString();
            
            lblResult.Text= ((cont == "France" && radioButton1.Checked == true)? num_input*0.1957: num_input * 6.2385682).ToString();
            lblResult.Text = ((cont == "Canada" && radioButton1.Checked == true) ? num_input * 0.9957: num_input * 1.3670427).ToString();
            lblResult.Text = ((cont == "England" && radioButton1.Checked == true) ? num_input * 1.9813: num_input * 0.8181884).ToString();
            lblResult.Text = ((cont == "Japan" && radioButton1.Checked == true) ? num_input * 1.1257: num_input * 136.85716).ToString();

           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            lblDisplay3.Text = "US Dollar(s)";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < nbcountry; i++)
            {
                if (cboCountry.SelectedItem.ToString() == tabcountry[i].name)
                {
                    curr = tabcountry[i].currency;
                    lblDisplay3.Text = curr + "(s)";
                }
                if (cboCountry.SelectedItem.ToString() == tabcountry[i].name)
                {
                    curr = tabcountry[i].currency;
                    lblDisplay3.Text = curr + "(s)";
                }
                if (cboCountry.SelectedItem.ToString() == tabcountry[i].name)
                {
                    curr = tabcountry[i].currency;
                    lblDisplay3.Text = curr + "(s)";
                }
                if (cboCountry.SelectedItem.ToString() == tabcountry[i].name)
                {
                    curr = tabcountry[i].currency;
                    lblDisplay3.Text = curr + "(s)";
                }
                
            }
            
        }
    }
}













