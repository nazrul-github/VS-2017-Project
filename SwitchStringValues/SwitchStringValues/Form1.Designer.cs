namespace SwitchStringValues
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxDeviceName = new System.Windows.Forms.TextBox();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblNumberOfAppleDevices = new System.Windows.Forms.Label();
            this.lblNumberOfSamsungDevices = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(232, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Device Name:";
            // 
            // txtBoxDeviceName
            // 
            this.txtBoxDeviceName.Location = new System.Drawing.Point(446, 32);
            this.txtBoxDeviceName.Name = "txtBoxDeviceName";
            this.txtBoxDeviceName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxDeviceName.TabIndex = 1;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(637, 37);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(0, 17);
            this.lblDeviceName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number Of Apple Devices";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number Of Samsung Devices";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(446, 91);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblNumberOfAppleDevices
            // 
            this.lblNumberOfAppleDevices.AutoSize = true;
            this.lblNumberOfAppleDevices.Location = new System.Drawing.Point(475, 217);
            this.lblNumberOfAppleDevices.Name = "lblNumberOfAppleDevices";
            this.lblNumberOfAppleDevices.Size = new System.Drawing.Size(46, 17);
            this.lblNumberOfAppleDevices.TabIndex = 6;
            this.lblNumberOfAppleDevices.Text = "label5";
            // 
            // lblNumberOfSamsungDevices
            // 
            this.lblNumberOfSamsungDevices.AutoSize = true;
            this.lblNumberOfSamsungDevices.Location = new System.Drawing.Point(475, 259);
            this.lblNumberOfSamsungDevices.Name = "lblNumberOfSamsungDevices";
            this.lblNumberOfSamsungDevices.Size = new System.Drawing.Size(46, 17);
            this.lblNumberOfSamsungDevices.TabIndex = 7;
            this.lblNumberOfSamsungDevices.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNumberOfSamsungDevices);
            this.Controls.Add(this.lblNumberOfAppleDevices);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDeviceName);
            this.Controls.Add(this.txtBoxDeviceName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxDeviceName;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblNumberOfAppleDevices;
        private System.Windows.Forms.Label lblNumberOfSamsungDevices;
    }
}

