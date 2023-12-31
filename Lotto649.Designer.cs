namespace FinalProject_2023
{
    partial class Lotto649
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
            this.btnReadAndDisplay = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtExtra = new System.Windows.Forms.TextBox();
            this.txtGeneratedN = new System.Windows.Forms.TextBox();
            this.lblGeneratedN = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReadAndDisplay
            // 
            this.btnReadAndDisplay.Location = new System.Drawing.Point(100, 312);
            this.btnReadAndDisplay.Name = "btnReadAndDisplay";
            this.btnReadAndDisplay.Size = new System.Drawing.Size(102, 77);
            this.btnReadAndDisplay.TabIndex = 0;
            this.btnReadAndDisplay.Text = "&Read and \r\nDisplay the\r\nText File\r\n\r\n";
            this.btnReadAndDisplay.UseVisualStyleBackColor = true;
            this.btnReadAndDisplay.Click += new System.EventHandler(this.btnReadAndDisplay_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(326, 93);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(215, 104);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = " Generate 6 + 1 out of 49\r\nunique numbers\r\nGenerate 7 digits for Extra\r\n";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(419, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(122, 32);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtExtra
            // 
            this.txtExtra.Location = new System.Drawing.Point(276, 232);
            this.txtExtra.Name = "txtExtra";
            this.txtExtra.ReadOnly = true;
            this.txtExtra.Size = new System.Drawing.Size(129, 26);
            this.txtExtra.TabIndex = 4;
            this.txtExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGeneratedN
            // 
            this.txtGeneratedN.Location = new System.Drawing.Point(587, 51);
            this.txtGeneratedN.Multiline = true;
            this.txtGeneratedN.Name = "txtGeneratedN";
            this.txtGeneratedN.ReadOnly = true;
            this.txtGeneratedN.Size = new System.Drawing.Size(44, 217);
            this.txtGeneratedN.TabIndex = 5;
            // 
            // lblGeneratedN
            // 
            this.lblGeneratedN.AutoSize = true;
            this.lblGeneratedN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneratedN.Location = new System.Drawing.Point(293, 51);
            this.lblGeneratedN.Name = "lblGeneratedN";
            this.lblGeneratedN.Size = new System.Drawing.Size(260, 25);
            this.lblGeneratedN.TabIndex = 6;
            this.lblGeneratedN.Text = "The generated numbers are:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject_2023.Properties.Resources._649Extra;
            this.pictureBox1.Location = new System.Drawing.Point(31, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Lotto649
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 428);
            this.Controls.Add(this.lblGeneratedN);
            this.Controls.Add(this.txtGeneratedN);
            this.Controls.Add(this.txtExtra);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnReadAndDisplay);
            this.Name = "Lotto649";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lotto649 + Queen Sarah Anumu Bih";
            this.Load += new System.EventHandler(this.Lotto649_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadAndDisplay;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtExtra;
        private System.Windows.Forms.TextBox txtGeneratedN;
        private System.Windows.Forms.Label lblGeneratedN;
    }
}