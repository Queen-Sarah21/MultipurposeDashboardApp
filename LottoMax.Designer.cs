namespace FinalProject_2023
{
    partial class LottoMax
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
            this.lblGeneratedN = new System.Windows.Forms.Label();
            this.btnReadAndDisplay = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtExtraMax = new System.Windows.Forms.TextBox();
            this.txtGeneratedN = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGeneratedN
            // 
            this.lblGeneratedN.AutoSize = true;
            this.lblGeneratedN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneratedN.Location = new System.Drawing.Point(315, 48);
            this.lblGeneratedN.Name = "lblGeneratedN";
            this.lblGeneratedN.Size = new System.Drawing.Size(260, 25);
            this.lblGeneratedN.TabIndex = 0;
            this.lblGeneratedN.Text = "The generated numbers are:";
            // 
            // btnReadAndDisplay
            // 
            this.btnReadAndDisplay.Location = new System.Drawing.Point(99, 317);
            this.btnReadAndDisplay.Name = "btnReadAndDisplay";
            this.btnReadAndDisplay.Size = new System.Drawing.Size(109, 77);
            this.btnReadAndDisplay.TabIndex = 1;
            this.btnReadAndDisplay.Text = "&Read and \r\nDisplay the\r\nText File\r\n";
            this.btnReadAndDisplay.UseVisualStyleBackColor = true;
            this.btnReadAndDisplay.Click += new System.EventHandler(this.btnReadAndDisplay_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(344, 100);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(215, 106);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate 7 + 1 out of 50\r\nunique numbers\r\nand 7 digits for Extra\r\n";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(427, 332);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtExtraMax
            // 
            this.txtExtraMax.Location = new System.Drawing.Point(311, 221);
            this.txtExtraMax.Name = "txtExtraMax";
            this.txtExtraMax.ReadOnly = true;
            this.txtExtraMax.Size = new System.Drawing.Size(133, 26);
            this.txtExtraMax.TabIndex = 4;
            this.txtExtraMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGeneratedN
            // 
            this.txtGeneratedN.Location = new System.Drawing.Point(601, 48);
            this.txtGeneratedN.Multiline = true;
            this.txtGeneratedN.Name = "txtGeneratedN";
            this.txtGeneratedN.ReadOnly = true;
            this.txtGeneratedN.Size = new System.Drawing.Size(42, 215);
            this.txtGeneratedN.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinalProject_2023.Properties.Resources.MaxExtra;
            this.pictureBox1.Location = new System.Drawing.Point(31, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LottoMax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtGeneratedN);
            this.Controls.Add(this.txtExtraMax);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnReadAndDisplay);
            this.Controls.Add(this.lblGeneratedN);
            this.Name = "LottoMax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LottoMax + Queen Sarah Anumu Bih";
            this.Load += new System.EventHandler(this.LottoMax_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGeneratedN;
        private System.Windows.Forms.Button btnReadAndDisplay;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtExtraMax;
        private System.Windows.Forms.TextBox txtGeneratedN;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}