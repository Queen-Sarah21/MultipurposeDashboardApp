namespace FinalProject_2023
{
    partial class Temperature
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
            this.radioButtonCtoF = new System.Windows.Forms.RadioButton();
            this.radioButtonFtoC = new System.Windows.Forms.RadioButton();
            this.txtConvert = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblTo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblC = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButtonCtoF
            // 
            this.radioButtonCtoF.AutoSize = true;
            this.radioButtonCtoF.Location = new System.Drawing.Point(229, 55);
            this.radioButtonCtoF.Name = "radioButtonCtoF";
            this.radioButtonCtoF.Size = new System.Drawing.Size(113, 24);
            this.radioButtonCtoF.TabIndex = 0;
            this.radioButtonCtoF.TabStop = true;
            this.radioButtonCtoF.Text = "from C to F";
            this.radioButtonCtoF.UseVisualStyleBackColor = true;
            this.radioButtonCtoF.CheckedChanged += new System.EventHandler(this.radioButtonCtoF_CheckedChanged);
            // 
            // radioButtonFtoC
            // 
            this.radioButtonFtoC.AutoSize = true;
            this.radioButtonFtoC.Location = new System.Drawing.Point(229, 100);
            this.radioButtonFtoC.Name = "radioButtonFtoC";
            this.radioButtonFtoC.Size = new System.Drawing.Size(113, 24);
            this.radioButtonFtoC.TabIndex = 1;
            this.radioButtonFtoC.TabStop = true;
            this.radioButtonFtoC.Text = "from F to C";
            this.radioButtonFtoC.UseVisualStyleBackColor = true;
            this.radioButtonFtoC.CheckedChanged += new System.EventHandler(this.radioButtonFtoC_CheckedChanged);
            // 
            // txtConvert
            // 
            this.txtConvert.Location = new System.Drawing.Point(52, 186);
            this.txtConvert.Name = "txtConvert";
            this.txtConvert.Size = new System.Drawing.Size(154, 26);
            this.txtConvert.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.SystemColors.Window;
            this.txtResult.Location = new System.Drawing.Point(349, 186);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(154, 26);
            this.txtResult.TabIndex = 3;
            this.txtResult.TabStop = false;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(265, 189);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(23, 20);
            this.lblTo.TabIndex = 4;
            this.lblTo.Text = "to";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message:";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(43, 324);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.ReadOnly = true;
            this.txtMessage.Size = new System.Drawing.Size(460, 103);
            this.txtMessage.TabIndex = 6;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(43, 448);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(128, 37);
            this.btnConvert.TabIndex = 7;
            this.btnConvert.Text = "&Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(214, 448);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(128, 37);
            this.btnRead.TabIndex = 8;
            this.btnRead.Text = "&Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(375, 448);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 37);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(105, 237);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(21, 20);
            this.lblC.TabIndex = 10;
            this.lblC.Text = "C";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF.Location = new System.Drawing.Point(415, 237);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(20, 20);
            this.lblF.TabIndex = 11;
            this.lblF.Text = "F";
            // 
            // Temperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 517);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtConvert);
            this.Controls.Add(this.radioButtonFtoC);
            this.Controls.Add(this.radioButtonCtoF);
            this.Name = "Temperature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature + Queen Sarah Anumu Bih";
            this.Load += new System.EventHandler(this.Temperature_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonCtoF;
        private System.Windows.Forms.RadioButton radioButtonFtoC;
        private System.Windows.Forms.TextBox txtConvert;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblF;
    }
}