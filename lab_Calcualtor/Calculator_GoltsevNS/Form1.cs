using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// using static Calculator_try_project.Operations;

namespace Calculator_GoltsevNS
{
    public partial class Form1 : Form
    {
        //Global vars for project
        double firstNum, secNum, answer;
        String op;
        private Operations operHandl;
        public Form1()
        {
            operHandl = new Operations();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if(lblDisplay.Text == "Cannot div by zero")
            {
                lblDisplay.Text = "";
            }

            if(!string.IsNullOrEmpty(lblResult.Text) && !string.IsNullOrEmpty(op) && !string.IsNullOrEmpty(lblDisplay.Text))
            {
                firstNum = Convert.ToDouble(lblDisplay.Text);
                secNum = Convert.ToDouble(lblResult.Text);
                answer = 0;

                answer = operHandl.CalcRes(op, firstNum, secNum);
                string local_stat = operHandl.stat_of_div;

                if(local_stat == "Cannot div by zero")
                {
                    lblResult.Text = ("Cannot div by zero");
                    lblDisplay.Text = "";
                }
                else
                {
                    lblResult.Text = Convert.ToString(answer);
                }


                //
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            string f, s;
            lblResult.Text = "";

            f = Convert.ToString(firstNum);
            s = Convert.ToString(secNum);

            f = "";
            s = "";

        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            lblDisplay.Text = "";
        }

        private void btnBS(object sender, EventArgs e)
        {
            if (lblResult.Text.Length > 0)
            {
                lblResult.Text = lblResult.Text.Remove(lblResult.Text.Length - 1, 1);

            }
        }

        private void btnPM_Click(object sender, EventArgs e)
        {
            double PM = Convert.ToDouble(lblResult.Text);
            lblResult.Text = Convert.ToString(PM * -1);
        }

        private void btn_TrigClick(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                op = b.Text;
                if (!string.IsNullOrEmpty(lblResult.Text))
                {
                    secNum = Convert.ToDouble(lblResult.Text);

                    answer = operHandl.CalcRes(op, secNum);
                    lblResult.Text = Convert.ToString(answer);
                }
            }
            catch { }
        }

        private void btnRadDeg_Click(object sender, EventArgs e)
        {
            // Change button itno oper class

            Button b = (Button)sender;

            if(b.Text == "Deg")
            {
                b.Text = "Rad";
            }
            else
            {
                b.Text = "Deg";
            }
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            lblDisplay.Text = lblResult.Text;
            lblResult.Text = "";
            op = b.Text;
        }

        private void NumberClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;


            // For dot character events
            if(b.Text == ".")
            {
                if (!lblResult.Text.Contains("."))
                    lblResult.Text = lblResult.Text + b.Text;
            }
            else
            {
                lblResult.Text = lblResult.Text + b.Text;
            }
        }

        private void opClick(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;

                if (lblResult.Text != "0")
                {
                    lblDisplay.Text = lblResult.Text;
                    lblResult.Text = "";
                    op = b.Text;

                }
            }catch { }
        }
    }
}
