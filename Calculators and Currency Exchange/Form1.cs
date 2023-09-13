using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculators_and_Currency_Exchange
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
    
        private void menuStandard_Click(object sender, EventArgs e)
        {
            frmCalculator1 calc = new frmCalculator1();
            calc.MdiParent = this;
            calc.Show();

        }

        private void menuScientific_Click(object sender, EventArgs e)
        {
            frmCalculator2 calc2 = new frmCalculator2();
            calc2.MdiParent = this;
            calc2.Show();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.MdiParent = this;
            fa.Show();
        }

        private void menuQuit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit the program?",
                "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == (DialogResult.Yes))
            {
                Application.Exit();
            }
        }

        private void menuUserManual_Click(object sender, EventArgs e)
        {
            frmManual fm = new frmManual();
            fm.MdiParent = this;
            fm.Show();
        }

        private void toolbarMnuItem_Click(object sender, EventArgs e)
        {
            if(toolbarMnuItem.Checked == false)
            {
                toolStrip1.Visible = false;
            }
            else
            {
                toolStrip1.Visible = true;
            }
           
        }

        private void statusMnuItem_Click(object sender, EventArgs e)
        {
            if (statusMnuItem.Checked == false)
            {
                statusStrip1.Visible = false;
            }
            else
            {
                statusStrip1.Visible = true;
            }
        }

        private void stCalcbtn_Click(object sender, EventArgs e)
        {
            frmCalculator1 stCalc = new frmCalculator1();
            stCalc.Show();
        }

        private void sciCalcbtn_Click(object sender, EventArgs e)
        {
            frmCalculator2 sciCalc = new frmCalculator2();
            sciCalc.Show();
        }

        private void menulocal_Click(object sender, EventArgs e)
        {
            frmChange fc = new frmChange();
            fc.MdiParent = this;
            fc.Show()
            
;        }

        private void CurrExchangeINT_Click(object sender, EventArgs e)
        {
            frmChange obj = new frmChange();
            obj.Show();

        }
    }
}
