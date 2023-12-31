using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Queen Sarah Anumu Bih
//Description:This is the class of the calculator  having some private fields, a constructor, a property and several methods which help 
//the calculator to function properly.
//Date: 07/18/2023
namespace FinalProject_2023
{
    internal class Calculator
    {
        private double currentValue;
        private double operand1;
        private double operand2;
        private string op;

        public double Value { set {  currentValue = value; } get { return currentValue; } }
 
        public Calculator() 
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            op = null;
        }

        public void Add(double displayValue) 
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = "+";
        }
        public void Subtract(double displayValue) 
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = "-";
        }
        public void Multiply(double displayValue) 
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = "*";
        }
        public void Divide(double displayValue) 
        {
            operand1 = displayValue;
            currentValue = displayValue;
            op = "/";
        }

        public void SetOperator (string operation)
        {
            op = operation;
        }

        public void Equals()
        {
            switch (op)
            {
                case "+":
                    currentValue = operand1 + operand2; 
                    break;

                case "-":
                    currentValue = operand1 - operand2;
                    break;

                case "x":
                    currentValue = operand1 * operand2;
                    break;

                case "/":
                    if (operand2 != 0)
                    {
                        try
                        {
                        currentValue = operand1 / operand2;

                        }
                        catch(Exception ex1)
                        {
                            MessageBox.Show(ex1.Message);
                        }
                    }
                    else
                    {
                        currentValue = operand1 / operand2;
                    }
                        
                    break;
            }
            operand1 = currentValue; 
            operand2 = 0;
            op = null;
        }
        public void Equals(double displayValue)
        {
            operand2 += displayValue;
            Equals();
        }
        public void Clear()
        {
            currentValue = 0;
            operand1 = 0;
            operand2 = 0;
            op = null;
        }
    }
}
