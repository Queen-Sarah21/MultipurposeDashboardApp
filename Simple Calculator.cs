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
//Name: Queen Sarah Anumu Bih
//Description:  A Simple Calculator form that has sevaral buttons which consists of numbers(0-9), a dot(for decimal),
//operator (+, -, *, /), an equals to(=), a clear button, and an exit button. It performs all the operations with both integer numbers
//and real numbers with the help of the class Calculator and displays them in the text boxes.
//Date: 07/18/2023
namespace FinalProject_2023
{
    public partial class Simple_Calculator : Form
    {
        private Calculator calculator;  
        private string currentInput; //originally currentValue. Used that name in order not to get confused with that in class calc
        public Simple_Calculator()
        {
            InitializeComponent();
            calculator = new Calculator();
            currentInput = string.Empty;
        }
        static string dirPath = @"C:.\Files\";
        string filePath = dirPath + "Calculator.txt";
        FileStream fs = null;

        private void Simple_Calculator_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }

            
        bool isCreatedCal = false; //flag
        private void btn1_Click(object sender, EventArgs e)
        {
            if (isCreatedCal)
            {
                txtCalculate.Text = "";
                txtAnswer.Text = "";

                isCreatedCal = false;
                calculator.Clear();

                currentInput += btn1.Text;
                txtCalculate.Text += btn1.Text;
            }
            else
            {
                currentInput += btn1.Text;
                txtCalculate.Text += btn1.Text;
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (isCreatedCal)
            {
                txtCalculate.Text = "";
                txtAnswer.Text = "";

                isCreatedCal = false;
                calculator.Clear();

                currentInput += btn2.Text;
                txtCalculate.Text += btn2.Text;
            }
            else
            {
                currentInput += btn2.Text;
                txtCalculate.Text += btn2.Text;
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (isCreatedCal)
            {
                txtCalculate.Text = "";
                txtAnswer.Text = "";

                isCreatedCal = false; 
                calculator.Clear();

                currentInput += btn3.Text;
                txtCalculate.Text += btn3.Text;
            }
            else
            {
                currentInput += btn3.Text;
                txtCalculate.Text += btn3.Text;
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (isCreatedCal)
            {
                txtCalculate.Text = "";
                txtAnswer.Text = "";

                isCreatedCal = false;
                calculator.Clear();

                currentInput += btn4.Text;
                txtCalculate.Text += btn4.Text;
            }
            else
            {
                currentInput += btn4.Text;
                txtCalculate.Text += btn4.Text;
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (isCreatedCal)
            {
                txtCalculate.Text = "";
                txtAnswer.Text = "";

                isCreatedCal = false;
                calculator.Clear();

                currentInput += btn5.Text;
                txtCalculate.Text += btn5.Text;
            }
            else
            {
                currentInput += btn5.Text;
                txtCalculate.Text += btn5.Text;
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (isCreatedCal)
            {
                txtCalculate.Text = "";
                txtAnswer.Text = "";

                isCreatedCal = false;
                calculator.Clear();

                currentInput += btn6.Text;
                txtCalculate.Text += btn6.Text;
            }
            else
            {
                currentInput += btn6.Text;
                txtCalculate.Text += btn6.Text;
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (isCreatedCal)
            {
                txtCalculate.Text = "";
                txtAnswer.Text = "";

                isCreatedCal = false;
                calculator.Clear();

                currentInput += btn7.Text;
                txtCalculate.Text += btn7.Text;
            }
            else
            {
                currentInput += btn7.Text;
                txtCalculate.Text += btn7.Text;
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (isCreatedCal)
            {
                txtCalculate.Text = "";
                txtAnswer.Text = "";

                isCreatedCal = false;
                calculator.Clear();

                currentInput += btn8.Text;
                txtCalculate.Text += btn8.Text;
            }
            else
            {
                currentInput += btn8.Text;
                txtCalculate.Text += btn8.Text;
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (isCreatedCal)
            {
                txtCalculate.Text = "";
                txtAnswer.Text = "";

                isCreatedCal = false;
                calculator.Clear();

                currentInput += btn9.Text;
                txtCalculate.Text += btn9.Text;
            }
            else
            {
                currentInput += btn9.Text;
                txtCalculate.Text += btn9.Text;
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (isCreatedCal)
            {
                txtCalculate.Text = "";
                txtAnswer.Text = "";

                isCreatedCal = false;
                calculator.Clear();

                currentInput += btn0.Text;
                txtCalculate.Text += btn0.Text;
            }
            else
            {
                currentInput += btn0.Text;
                txtCalculate.Text += btn0.Text;
            }
        }
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (isCreatedCal)
            {
                txtCalculate.Text = "";
                txtAnswer.Text = "";

                isCreatedCal = false;
                calculator.Clear();

                currentInput += btnDecimal.Text;
                txtCalculate.Text += btnDecimal.Text;
            }
            else
            {
                currentInput += btnDecimal.Text;
                txtCalculate.Text += btnDecimal.Text;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string operation = btnAdd.Text;
            if (!string.IsNullOrEmpty(currentInput))
            {
                calculator.Add(double.Parse(currentInput));
                calculator.SetOperator(operation);
                currentInput = string.Empty;
                txtCalculate.Text += operation;
                
            }
        }
        private void btnSubtract_Click(object sender, EventArgs e)
        {
            string operation = btnSubtract.Text;
            if (!string.IsNullOrEmpty(currentInput))
            {
                calculator.Subtract(double.Parse(currentInput));
                calculator.SetOperator(operation);
                currentInput = string.Empty;
                txtCalculate.Text += operation;
            }
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            string operation = btnMultiply.Text;
            if (!string.IsNullOrEmpty(currentInput))
            {
                calculator.Multiply(double.Parse(currentInput));
                calculator.SetOperator(operation);
                currentInput = string.Empty;
                txtCalculate.Text += operation;
            }
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            string operation = btnDivide.Text;
            if (!string.IsNullOrEmpty(currentInput))
            {
                calculator.Divide(double.Parse(currentInput));
                calculator.SetOperator(operation);
                currentInput = string.Empty;
                txtCalculate.Text += operation;
            }
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string operation = button.Text;
            txtCalculate.Text += btnEquals.Text;
            if (!string.IsNullOrEmpty(currentInput))
            {
                calculator.Equals(double.Parse(currentInput));
                currentInput= string.Empty;
                txtCalculate.Text += calculator.Value.ToString();
                txtAnswer.Text = calculator.Value.ToString();

                //changes the condition of flag after clicking button '='
                isCreatedCal = true;
            }
            //used else to handle event: after pressing '=', stop appending text in textfields
            else
            {
                txtCalculate.Text = "";
                txtAnswer.Text= "";
            }
            try
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                // create the output stream for a text file that exists
                StreamWriter textOut = new StreamWriter(fs);
                // write the fields into text file
               textOut.Write(txtCalculate.Text + "\n");
                // close the output stream for the text file
                textOut.Close();
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(filePath + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dirPath + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            currentInput = string.Empty;
            txtCalculate.Text = string.Empty;
            txtAnswer.Text = string.Empty;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit this application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
