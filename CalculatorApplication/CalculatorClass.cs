using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);
    internal class CalculatorClass
    {
        
        public Formula<double> formula;

        public double GetSum(double num,double num2)
        {
            double sum = num + num2;
            return sum;
            
        }
        public double GetDifference(double num,double num2)
        {
            double diff = num - num2;
            return diff;
        }
        public double GetProduct(double num, double num2)
        {
            double pro = num * num2;
            return pro;
        }
        public double GetQuotient(double num, double num2)
        {
            double quo = num / num2;
            return quo;
        }

        public event Formula<double> CalculateEvent
        {
            add {
                MessageBox.Show("Delegate Added");
                formula += value;
            }
            remove {
                MessageBox.Show("Delegate Removed");
                formula -= value;
            }
        }
    }
}
