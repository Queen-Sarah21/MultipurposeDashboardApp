namespace FinalProject_2023
{
    partial class IP_Validator
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
            this.lblToday = new System.Windows.Forms.Label();
            this.lblIPv4 = new System.Windows.Forms.Label();
            this.lblIPv6 = new System.Windows.Forms.Label();
            this.txtIPv4 = new System.Windows.Forms.TextBox();
            this.txtIPv6 = new System.Windows.Forms.TextBox();
            this.btnValidate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReadAndDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToday.Location = new System.Drawing.Point(247, 38);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(74, 25);
            this.lblToday.TabIndex = 0;
            this.lblToday.Text = "Today:";
            // 
            // lblIPv4
            // 
            this.lblIPv4.AutoSize = true;
            this.lblIPv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPv4.Location = new System.Drawing.Point(69, 111);
            this.lblIPv4.Name = "lblIPv4";
            this.lblIPv4.Size = new System.Drawing.Size(191, 25);
            this.lblIPv4.TabIndex = 2;
            this.lblIPv4.Text = "Enter IP v4 Address:";
            // 
            // lblIPv6
            // 
            this.lblIPv6.AutoSize = true;
            this.lblIPv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIPv6.Location = new System.Drawing.Point(69, 161);
            this.lblIPv6.Name = "lblIPv6";
            this.lblIPv6.Size = new System.Drawing.Size(191, 25);
            this.lblIPv6.TabIndex = 3;
            this.lblIPv6.Text = "Enter IP v6 Address:";
            // 
            // txtIPv4
            // 
            this.txtIPv4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv4.Location = new System.Drawing.Point(295, 111);
            this.txtIPv4.Name = "txtIPv4";
            this.txtIPv4.Size = new System.Drawing.Size(364, 30);
            this.txtIPv4.TabIndex = 4;
            // 
            // txtIPv6
            // 
            this.txtIPv6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIPv6.Location = new System.Drawing.Point(295, 161);
            this.txtIPv6.Name = "txtIPv6";
            this.txtIPv6.Size = new System.Drawing.Size(364, 30);
            this.txtIPv6.TabIndex = 5;
            // 
            // btnValidate
            // 
            this.btnValidate.Location = new System.Drawing.Point(74, 285);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(164, 50);
            this.btnValidate.TabIndex = 6;
            this.btnValidate.Text = "Validate IP";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(279, 247);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(187, 48);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReadAndDisplay
            // 
            this.btnReadAndDisplay.Location = new System.Drawing.Point(252, 321);
            this.btnReadAndDisplay.Name = "btnReadAndDisplay";
            this.btnReadAndDisplay.Size = new System.Drawing.Size(240, 60);
            this.btnReadAndDisplay.TabIndex = 8;
            this.btnReadAndDisplay.Text = "Read and display";
            this.btnReadAndDisplay.UseVisualStyleBackColor = true;
            this.btnReadAndDisplay.Click += new System.EventHandler(this.btnReadAndDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(511, 285);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 49);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(327, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 20);
            this.lblDate.TabIndex = 10;
            // 
            // IP_Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 411);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReadAndDisplay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.txtIPv6);
            this.Controls.Add(this.txtIPv4);
            this.Controls.Add(this.lblIPv6);
            this.Controls.Add(this.lblIPv4);
            this.Controls.Add(this.lblToday);
            this.Name = "IP_Validator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IPValidator + Queen Sarah Anumu Bih";
            this.Load += new System.EventHandler(this.IP_Validator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblToday;
        private System.Windows.Forms.Label lblIPv4;
        private System.Windows.Forms.Label lblIPv6;
        private System.Windows.Forms.TextBox txtIPv4;
        private System.Windows.Forms.TextBox txtIPv6;
        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReadAndDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblDate;
    }
}