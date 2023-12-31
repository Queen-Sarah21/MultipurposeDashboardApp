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
//Description: A LottoMax Windows form that has two buttons(which writes, reads and display the random
//numbers in and from a textfile) and two textboxes(one displaying random numbers from 1-50 and the other
//from 0-9).
//Date:07/18/2023
namespace FinalProject_2023
{
    public partial class LottoMax : Form
    {
        public LottoMax()
        {
            InitializeComponent();
        }
        //string dir = @"C:\Files\";
        static string dirPath = @"C:.\Files\";
        string filePath = dirPath + "LottoNbrs.txt";
        FileStream fs = null;
        private void LottoMax_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string genNums = "";
            int[] results = new int[8];
            Random random = new Random();
            int randomNumber;
            for (int i = 0; i < results.Length; i++)
            {
                do
                {
                    randomNumber = random.Next(1, 50);
                }
                while (results.Contains(randomNumber));
                results[i] = randomNumber;
                genNums = genNums + results[i].ToString() + "\t";
            }
            txtGeneratedN.Text = genNums;

            string extraNums = "";
            int[] extra = new int[7];
            Random random2 = new Random();
            int randomExtra;
            for (int i = 0; i < extra.Length; i++)
            {
                randomExtra = random2.Next(0, 9);
                extra[i] = randomExtra;
                extraNums = extraNums + extra[i].ToString();
            }
            txtExtraMax.Text = extraNums;

            try
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                // create the output stream for a text file that exists
                StreamWriter textOut = new StreamWriter(fs);
                // write the fields into text file
                textOut.Write("Max, " + DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss tt") + ",  ");
                for (int i = 0; i < results.Length; i++)
                {
                    if (i < 6)
                    {
                        textOut.Write(results[i] + ", ");
                    }
                    if (i == 6)
                    {
                        textOut.Write(results[i] + " ");
                    }
                    if (i == 7)
                    {
                        textOut.Write(" Bonus: " + results[i] + " ");
                    }
                }
                textOut.Write(" Extra: " + extraNums + "\n");
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

        private void btnReadAndDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                // create the object for the input stream for a text file
                StreamReader textIn = new StreamReader(fs);
                string textToPrint = "";
                // read the data from the file and store it in the list
                while (textIn.Peek() != -1)
                {
                    string row = textIn.ReadLine().Trim();
                    textToPrint += row + "\n";
                }
                MessageBox.Show(textToPrint);
                // close the input stream for the text file
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
            {
                MessageBox.Show(ex.Message, "IOException");
            }
            finally
            {
                if (fs != null) fs.Close();
            }
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
