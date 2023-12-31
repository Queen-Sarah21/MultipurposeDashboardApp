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
//Description: A money conversion application that converts money from one currency to several currencies.
//The app also tells the user how long he/she has spent on it before the user exits the application.
//Date: 07/25/2023
namespace FinalProject_2023
{
    public partial class MoneyExchange : Form
    {
        public MoneyExchange()
        {
            InitializeComponent();
        }
        static string dirPath = @"C:.\Files\";
        string filePath = dirPath + "MoneyConversions.txt";
        FileStream fs = null;

        private void MoneyExchange_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
            startTime = DateTime.Now;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                double inputValue = double.Parse(txtAmount.Text);
                
                double cadToUsd = 0.7353;
                double cadToEur = 0.6757;
                double cadToGbp = 0.5952;
                double cadToCfa = 441.74;
                double cadToInr = 62.32;

                double usdToCad = 1.32;
                double usdToEur = 0.89;
                double usdToGbp = 0.77;
                double usdToCfa = 581.50;
                double usdToInr = 82.07;

                double eurToCad = 1.48;
                double eurToUsd = 1.12;
                double eurToGbp = 0.87;
                double eurToCfa = 651.43;
                double eurToInr = 91.92;

                double gbpToCad = 1.70;
                double gbpToUsd = 1.29;
                double gbpToEur = 1.67;
                double gbpToCfa = 752.23;
                double gbpToInr = 106.18;

                double cfaToCad = 0.0023;
                double cfaToUsd = 0.00171038;
                double cfaToEur = 0.0015;
                double cfaToGbp = 0.0013;
                double cfaToInr = 0.14;

                double inrToCad = 0.016;
                double inrToUsd = 0.012;
                double inrToEur = 0.011;
                double inrToGbp = 0.0094;
                double inrToCfa = 7.09;

                double usd, cad, eur, gbp, cfa, inr;
                string labelValue;
                if (radioButtonCAD.Checked)
                {
                    labelValue = radioButtonCAD.Text;
                    cad = inputValue;
                    usd = cad * cadToUsd;
                    eur = cad * cadToEur;
                    gbp = cad * cadToGbp;
                    cfa = cad * cadToCfa;
                    inr = cad * cadToInr;
                }
                else if (radioButtonUSD.Checked)
                {
                    labelValue = radioButtonUSD.Text;
                    usd = inputValue;
                    cad = usd * usdToCad;
                    eur = usd * usdToEur;
                    gbp = usd * usdToGbp;
                    cfa = usd * usdToCfa;
                    inr = usd * usdToInr;
                }
                else if (radioButtonEUR.Checked)
                {
                    labelValue = radioButtonEUR.Text;
                    eur = inputValue;
                    cad = eur * eurToCad;
                    usd = eur * eurToUsd;
                    gbp = eur * eurToGbp;
                    cfa = eur * eurToCfa;
                    inr = eur * eurToInr;
                }
                else if (radioButtonGBP.Checked)
                {
                    labelValue = radioButtonGBP.Text;
                    gbp = inputValue;
                    cad = gbp * gbpToCad;
                    usd = gbp * gbpToUsd;
                    eur = gbp * gbpToEur;
                    cfa = gbp * gbpToCfa;
                    inr = gbp * gbpToInr;
                }
                else if (radioButtonCFA.Checked)
                {
                    labelValue = radioButtonCFA.Text;
                    cfa = inputValue;
                    cad = cfa * cfaToCad;
                    usd = cfa * cfaToUsd;
                    eur = cfa * cfaToEur;
                    gbp = cfa * cfaToGbp;
                    inr = cfa * cfaToInr;
                }
                else // radioButtonINR.Checked
                {
                    labelValue = radioButtonINR.Text;
                    inr = inputValue;
                    cad = inr * inrToCad;
                    usd = inr * inrToUsd;
                    eur = inr * inrToEur;
                    gbp = inr * inrToGbp;
                    cfa = inr * inrToCfa;
                }

                txtCad.Text = cad.ToString();
                txtUsd.Text = usd.ToString();
                txtEur.Text = eur.ToString();
                txtGbp.Text = gbp.ToString();
                txtCfa.Text = cfa.ToString();
                txtInr.Text = inr.ToString();
                
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
                    textOut.Write(year + "/" + month + "/" + day + "   " + time + "\n" + inputValue + " " +labelValue + 
                    " = " + cad + " CAD; " + usd + " USD; " + eur + " EUR; " + gbp + " GBP; " + cfa + " CFA; " + inr + "  INR\n");

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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Conversion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
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

        DateTime startTime;
        private void btnExit_Click(object sender, EventArgs e)
        {
            DateTime startTime2 = DateTime.Now;
            DateTime startTime3 = DateTime.Now;
            TimeSpan elapsedTime = startTime2 - startTime;
            TimeSpan elapsedTime2 = startTime3 - startTime;
            string lblElapsedTime = elapsedTime.ToString(@"mm");
            string lblElapsedTime2 = elapsedTime2.ToString(@"ss");
            if (MessageBox.Show("Do you want to quit this app? You have been here for " + lblElapsedTime + " minutes " + 
                lblElapsedTime2 + " sec", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
