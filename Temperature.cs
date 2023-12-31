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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//Name: Queen Sarah Anumu Bih
//Description: A temperature conversion application that converts degree celsius to Fahrenheit and Fahrenheit to degree celsius.
//Date: 07/25/2023
namespace FinalProject_2023
{
    public partial class Temperature : Form
    {
        public Temperature()
        {
            InitializeComponent();
        }
        static string dirPath = @"C:.\Files\";
        string filePath = dirPath + "TempConversions.txt";
        FileStream fs = null;
        private void Temperature_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }

        private void radioButtonCtoF_CheckedChanged(object sender, EventArgs e)
        {
            lblC.Text = "C";
            lblF.Text = "F";
        }

        private void radioButtonFtoC_CheckedChanged(object sender, EventArgs e)
        {
            lblC.Text = "F";
            lblF.Text = "C";
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double celsius = 0;
            double farenhait = 0;
            if (radioButtonCtoF.Checked)
            {
                celsius = double.Parse(txtConvert.Text);
                if (celsius == 100)
                {
                    txtConvert.ForeColor = Color.Red;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    farenhait = 212;
                    txtResult.Text = farenhait.ToString();
                    txtResult.ForeColor = Color.Red;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Water boils";
                }
                else if (celsius == 40)
                {
                    txtConvert.ForeColor = Color.Red;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    farenhait = 104;
                    txtResult.Text = farenhait.ToString();
                    txtResult.ForeColor = Color.Red;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Hot Bath";
                }
                else if (celsius == 37)
                {
                    txtConvert.ForeColor = Color.Orange;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    farenhait = 98.6;
                    txtResult.Text = farenhait.ToString();
                    txtResult.ForeColor = Color.Orange;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Body temprature";
                }
                else if (celsius == 30)
                {
                    txtConvert.ForeColor = Color.Orange;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    farenhait = 86;
                    txtResult.Text = farenhait.ToString();
                    txtResult.ForeColor = Color.Orange;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Beach weather";
                }
                else if (celsius == 21)
                {
                    txtConvert.ForeColor = Color.Green;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Regular);
                    farenhait = 70;
                    txtResult.Text = farenhait.ToString();
                    txtResult.ForeColor = Color.Green;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Regular);
                    txtMessage.Text = "Room temperature";
                }
                else if (celsius == 10)
                {
                    txtConvert.ForeColor = Color.Blue;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    farenhait = 50;
                    txtResult.Text = farenhait.ToString();
                    txtResult.ForeColor = Color.Blue;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Cool Day";
                }
                else if (celsius == 0)
                {
                    txtConvert.ForeColor = Color.Blue;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    farenhait = 32;
                    txtResult.Text = farenhait.ToString();
                    txtResult.ForeColor = Color.Blue;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Freezing Point of Water";
                }
                else if (celsius == -18)
                {
                    txtConvert.ForeColor = Color.Black;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Regular);
                    farenhait = 0;
                    txtResult.Text = farenhait.ToString();
                    txtResult.ForeColor = Color.Black;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Regular);
                    txtMessage.Text = "Very Cold Day";
                }
                else if (celsius == -40)
                {
                    txtConvert.ForeColor = Color.Black;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    farenhait = -40;
                    txtResult.Text = farenhait.ToString();
                    txtResult.ForeColor = Color.Black;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Extremely Cold Day";
                }
                else
                {
                    txtConvert.ForeColor = Color.Black;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Regular);
                    farenhait = (celsius * 9 / 5) + 32;
                    txtResult.Text = farenhait.ToString();
                    txtResult.ForeColor = Color.Black;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Regular);
                    txtMessage.Text = "No specific description.";
                }
            }
            if (radioButtonFtoC.Checked)
            {
                farenhait = double.Parse(txtConvert.Text);
                if (farenhait == 212)
                {
                    txtConvert.ForeColor = Color.Red;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    celsius = 100;
                    txtResult.Text = celsius.ToString();
                    txtResult.ForeColor = Color.Red;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Water boils";
                }
                else if (farenhait == 104)
                {
                    txtConvert.ForeColor = Color.Red;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    celsius = 40;
                    txtResult.Text = celsius.ToString();
                    txtResult.ForeColor = Color.Red;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Hot Bath";
                }
                else if (farenhait == 98.6)
                {
                    txtConvert.ForeColor = Color.Orange;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    celsius = 37;
                    txtResult.Text = celsius.ToString();
                    txtResult.ForeColor = Color.Orange;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Body temprature";
                }
                else if (farenhait == 86)
                {
                    txtConvert.ForeColor = Color.Orange;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    celsius = 30;
                    txtResult.Text = celsius.ToString();
                    txtResult.ForeColor = Color.Orange;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Beach weather";
                }
                else if (farenhait == 70)
                {
                    txtConvert.ForeColor = Color.Green;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Regular);
                    celsius = 21;
                    txtResult.Text = celsius.ToString();
                    txtResult.ForeColor = Color.Green;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Regular);
                    txtMessage.Text = "Room temperature";
                }
                else if (farenhait == 50)
                {
                    txtConvert.ForeColor = Color.Blue;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    celsius = 10;
                    txtResult.Text = celsius.ToString();
                    txtResult.ForeColor = Color.Blue;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Cool Day";
                }
                else if (farenhait == 32)
                {
                    txtConvert.ForeColor = Color.Blue;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    celsius = 0;
                    txtResult.Text = celsius.ToString();
                    txtResult.ForeColor = Color.Blue;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Freezing Point of Water";
                }
                else if (farenhait == 0)
                {
                    txtConvert.ForeColor = Color.Black;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Regular);
                    celsius = -18;
                    txtResult.Text = celsius.ToString();
                    txtResult.ForeColor = Color.Black;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Regular);
                    txtMessage.Text = "Very Cold Day";
                }
                else if (farenhait == -40)
                {
                    txtConvert.ForeColor = Color.Black;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Bold);
                    celsius = -40;
                    txtResult.Text = celsius.ToString();
                    txtResult.ForeColor = Color.Black;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Bold);
                    txtMessage.Text = "Extremely Cold Day";
                }
                else
                {
                    txtConvert.ForeColor = Color.Black;
                    txtConvert.Font = new Font(txtConvert.Font, FontStyle.Regular);
                    celsius = (farenhait - 32) * 5 / 9;
                    txtResult.Text = celsius.ToString();
                    txtResult.ForeColor = Color.Black;
                    txtResult.Font = new Font(txtResult.Font, FontStyle.Regular);
                    txtMessage.Text = "No specific description.";
                }
            }
            try
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("dd MM yyyy");
                string time = currentDate.ToString("HH:mm:ss tt");
                string[] dateFile = formattedDate.Split(' ');
                string day = dateFile[0];
                string month = dateFile[1];
                string year = dateFile[2];
                if (radioButtonCtoF.Checked)
                {
                    textOut.WriteLine(celsius.ToString() + " C = " + farenhait.ToString() + " F, " + year + "/" + month + "/" + day + "   " + time + " " + txtMessage.Text, "\n");
                }
                else
                {
                    textOut.WriteLine(farenhait.ToString() + " F = " + celsius.ToString() + " C, " + year + "/" + month + "/" + day + "   " + time + " " + txtMessage.Text, "\n");
                }
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
            { MessageBox.Show(ex.Message, "IOException"); }
            finally
            { if (fs != null) fs.Close(); }
        }
        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = textIn.ReadToEnd();
                MessageBox.Show(textToPrint + "\n");
                textIn.Close();
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
            { MessageBox.Show(ex.Message, "IOException"); }
            finally
            { if (fs != null) fs.Close(); }
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
