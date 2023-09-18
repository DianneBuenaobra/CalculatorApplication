using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        double num1, num2;
        public FrmCalculator()
        {
            InitializeComponent();
            cal =  new CalculatorClass();
            string[] operators = { "+", "-", "*", "/" };
            for(int i = 0; i < operators.Length; i++)
            {
                cbOperator.Items.Add(operators[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtBoxInput1.Text);
            num2 = double.Parse(txtBoxInput2.Text);
            if(cbOperator.Text == "+")
            {
                
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }
            else if (cbOperator.Text == "-")
            {
                
                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }
            else if (cbOperator.Text == "*")
            {
               
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }
            else if (cbOperator.Text == "/")
            {
                lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
            }
            txtBoxInput1.Clear();
            txtBoxInput2.Clear();
            cbOperator.Text = "";
            lblDisplayTotal.Text = "";
        }
    }
}
