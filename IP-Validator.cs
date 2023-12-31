using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//Name: Queen Sarah Anumu Bih
//Description: An IPv4 and IPv6 address Validator which writes, reads and displays its valid address in a binary file
//followed by the current date and time.
//Date:07/11/2023
namespace FinalProject_2023
{
    public partial class IP_Validator : Form
    {
        public IP_Validator()
        {
            InitializeComponent();
        }
        Regex obj;
        private void IP_Validator_Load(object sender, EventArgs e)
        {
            DateTime obj = DateTime.Today;
            lblDate.Text = obj.ToLongDateString(); //.ToString();

            if (!Directory.Exists(dirPath1))
                Directory.CreateDirectory(dirPath1);
        }
        //string dir = @"C:\Files\";
        static string dirPath1 = @"C:.\Files\";
       // static string dirPath2 = @"C:..\Files\";
        static string path = dirPath1 + "IPv4B.txt";
        FileStream fs = null;

        private void btnValidate_Click(object sender, EventArgs e)
        {
            DateTime d = DateTime.Now;
            obj = new Regex(@"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$");
            if (obj.IsMatch(txtIPv4.Text))
            {
                try
                {
                    fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                    BinaryWriter bw = new BinaryWriter(fs);
                    bw.Write(txtIPv4.Text);
                    
                    bw.Write(d.ToShortDateString() + " " + d.ToShortTimeString());
                    bw.Close();
                }
                catch (FileNotFoundException)
                {
                    MessageBox.Show(path + " not found.", "File Not Found");
                }
                catch (DirectoryNotFoundException)
                {
                    MessageBox.Show(dirPath1 + " not found.", "Directory Not Found");
                }
                catch (IOException ex)
                { MessageBox.Show(ex.Message, "IOException"); }
                finally { if (fs != null) fs.Close(); }

                MessageBox.Show($"{txtIPv4.Text} \n" +
                               $"The IP is correct", "Valid IP");
            }
            else
            {
                MessageBox.Show($"{txtIPv4.Text}\n"+
                    "The IP must have 4bytes\ninteger numbers between 0 to 255\n" +
                    "separated by a dot (255.255.255.255)", "Error");
                txtIPv4.Focus();
            }
                Regex obj2 = new Regex(@"^(?:[0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$");
                if (obj2.IsMatch(txtIPv6.Text))
                {
                    try
                    {
                        fs = new FileStream(path, FileMode.Append, FileAccess.Write);
                        BinaryWriter bw = new BinaryWriter(fs);
                        bw.Write(txtIPv6.Text);

                        bw.Write(d.ToShortDateString() + " " + d.ToShortTimeString());
                        bw.Close();
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show(path + " not found.", "File Not Found");
                    }
                    catch (DirectoryNotFoundException)
                    {
                        MessageBox.Show(dirPath1 + " not found.", "Directory Not Found");
                    }
                    catch (IOException ex)
                    { MessageBox.Show(ex.Message, "IOException"); }
                    finally { if (fs != null) fs.Close(); }

                    MessageBox.Show($"{txtIPv6.Text}\n" +
                                $"The IP is correct", "Valid IP");
                }
                else
                {
                    MessageBox.Show($"{txtIPv6.Text}\n" +
                   "The IP must have 8bytes\ninteger numbers and letters (a-f or A-F)\n" +
                   "separated by a column (2001:0Db8:0000:0000:0000:ff00:0042:8329)", "Error");
                    txtIPv6.Focus();
                }
        }
        private void btnReadAndDisplay_Click(object sender, EventArgs e)
        {
            string ipToPrint = "IP Address \t\t\t Date \n";
            string ipAddress, date;
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                while (br.PeekChar() != -1) //not finding the end of string
                {
                    ipAddress = br.ReadString();
       
                    date = br.ReadString();
                    if(ipAddress.Length < 15)
                    {
                        ipToPrint += ipAddress + "\t\t\t\t" + date + "\n";
                    }
                    else
                    {
                        ipToPrint += ipAddress + "\t\t\t" + date + "\n" ;

                    }
                }
                MessageBox.Show(ipToPrint);
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtIPv4.ReadOnly = false;
            txtIPv4.Text = null;
            txtIPv4.Focus();
            txtIPv6.Text = "";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
                this.Close();
            }
        } 
    }
}
