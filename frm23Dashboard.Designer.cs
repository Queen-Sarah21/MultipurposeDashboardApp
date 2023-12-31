namespace FinalProject_2023
{
    partial class frm23Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_IP_Validator = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Simple_Calculator = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Temperature_Convert = new System.Windows.Forms.Button();
            this.btn_Money_Exchange = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Lotto_649 = new System.Windows.Forms.Button();
            this.btn_Lotto_Max = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(43, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 378);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_IP_Validator);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(671, 345);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "IP v4 & v6 validator";
            this.tabPage1.UseVisualStyleBackColor = true;
//            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "IP validator";
            // 
            // btn_IP_Validator
            // 
            this.btn_IP_Validator.Image = global::FinalProject_2023.Properties.Resources.ip4;
            this.btn_IP_Validator.Location = new System.Drawing.Point(179, 40);
            this.btn_IP_Validator.Name = "btn_IP_Validator";
            this.btn_IP_Validator.Size = new System.Drawing.Size(294, 244);
            this.btn_IP_Validator.TabIndex = 0;
            this.btn_IP_Validator.UseVisualStyleBackColor = true;
            this.btn_IP_Validator.Click += new System.EventHandler(this.btn_IP_Validator_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.btn_Simple_Calculator);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(671, 345);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simple Calculator";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Simple Calculator";
            // 
            // btn_Simple_Calculator
            // 
            this.btn_Simple_Calculator.Image = global::FinalProject_2023.Properties.Resources.Calculator;
            this.btn_Simple_Calculator.Location = new System.Drawing.Point(195, 48);
            this.btn_Simple_Calculator.Name = "btn_Simple_Calculator";
            this.btn_Simple_Calculator.Size = new System.Drawing.Size(264, 222);
            this.btn_Simple_Calculator.TabIndex = 0;
            this.btn_Simple_Calculator.UseVisualStyleBackColor = true;
            this.btn_Simple_Calculator.Click += new System.EventHandler(this.btn_Simple_Calculator_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(671, 345);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Convertions";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btn_Temperature_Convert);
            this.groupBox2.Controls.Add(this.btn_Money_Exchange);
            this.groupBox2.Location = new System.Drawing.Point(52, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(569, 267);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convertions";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Temperature Convert";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Money Exchange";
            // 
            // btn_Temperature_Convert
            // 
            this.btn_Temperature_Convert.Image = global::FinalProject_2023.Properties.Resources.tempConvert;
            this.btn_Temperature_Convert.Location = new System.Drawing.Point(348, 49);
            this.btn_Temperature_Convert.Name = "btn_Temperature_Convert";
            this.btn_Temperature_Convert.Size = new System.Drawing.Size(182, 156);
            this.btn_Temperature_Convert.TabIndex = 1;
            this.btn_Temperature_Convert.UseVisualStyleBackColor = true;
            this.btn_Temperature_Convert.Click += new System.EventHandler(this.btn_Temperature_Convert_Click);
            // 
            // btn_Money_Exchange
            // 
            this.btn_Money_Exchange.Image = global::FinalProject_2023.Properties.Resources.moneyConvert;
            this.btn_Money_Exchange.Location = new System.Drawing.Point(29, 49);
            this.btn_Money_Exchange.Name = "btn_Money_Exchange";
            this.btn_Money_Exchange.Size = new System.Drawing.Size(171, 156);
            this.btn_Money_Exchange.TabIndex = 0;
            this.btn_Money_Exchange.UseVisualStyleBackColor = true;
            this.btn_Money_Exchange.Click += new System.EventHandler(this.btn_Money_Exchange_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.groupBox1);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(671, 345);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Generated Numbers";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btn_Lotto_649);
            this.groupBox1.Controls.Add(this.btn_Lotto_Max);
            this.groupBox1.Location = new System.Drawing.Point(52, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 271);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lotto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(402, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Lotto 649";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Lotto Max";
            // 
            // btn_Lotto_649
            // 
            this.btn_Lotto_649.Image = global::FinalProject_2023.Properties.Resources.Lotto649;
            this.btn_Lotto_649.Location = new System.Drawing.Point(369, 42);
            this.btn_Lotto_649.Name = "btn_Lotto_649";
            this.btn_Lotto_649.Size = new System.Drawing.Size(136, 157);
            this.btn_Lotto_649.TabIndex = 1;
            this.btn_Lotto_649.UseVisualStyleBackColor = true;
            this.btn_Lotto_649.Click += new System.EventHandler(this.btn_Lotto_649_Click_1);
            // 
            // btn_Lotto_Max
            // 
            this.btn_Lotto_Max.Image = global::FinalProject_2023.Properties.Resources.LottoMax;
            this.btn_Lotto_Max.Location = new System.Drawing.Point(54, 42);
            this.btn_Lotto_Max.Name = "btn_Lotto_Max";
            this.btn_Lotto_Max.Size = new System.Drawing.Size(134, 157);
            this.btn_Lotto_Max.TabIndex = 0;
            this.btn_Lotto_Max.UseVisualStyleBackColor = true;
            this.btn_Lotto_Max.Click += new System.EventHandler(this.btn_Lotto_Max_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(639, 396);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(79, 42);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "E&xit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // frm23Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.tabControl1);
            this.Name = "frm23Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard + Queen Sarah Anumu Bih";
         //   this.Load += new System.EventHandler(this.frm23Dashboard_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_IP_Validator;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button btn_Simple_Calculator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Lotto_649;
        private System.Windows.Forms.Button btn_Lotto_Max;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Temperature_Convert;
        private System.Windows.Forms.Button btn_Money_Exchange;
    }
}

