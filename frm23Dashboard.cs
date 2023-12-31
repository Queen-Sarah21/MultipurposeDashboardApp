using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Name: Queen Sarah Anumu Bih
//Description: A dashboard windows form application which comprises of several other windows form applications which are: 
//An IP Validator Application, A Simple Calculator Application, A Money Exchange & Temperature Convertion Application, and
//A Lotto Max & Lotto 649 Application.
//Date: 07/11/2023
namespace FinalProject_2023
{
    public partial class frm23Dashboard : Form
    {
        public frm23Dashboard()
        {
            InitializeComponent();    
        }

        private void btn_IP_Validator_Click(object sender, EventArgs e)
        {
            IP_Validator obj = new IP_Validator();
            obj.ShowDialog();
        }

        private void btn_Simple_Calculator_Click(object sender, EventArgs e)
        {
            Simple_Calculator obj = new Simple_Calculator();
            obj.ShowDialog();
        }

        private void btn_Lotto_Max_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();
            obj.ShowDialog();
        }

        private void btn_Lotto_649_Click_1(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();
            obj.ShowDialog();
        }

        private void btn_Money_Exchange_Click(object sender, EventArgs e)
        {
            MoneyExchange obj = new MoneyExchange();
            obj.ShowDialog();
        }

        private void btn_Temperature_Convert_Click(object sender, EventArgs e)
        {
            Temperature obj = new Temperature();
            obj.ShowDialog();
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit this application?", "Exit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString() == "Yes")
            {
               Application.Exit();
            }
        }

     
    }
}
