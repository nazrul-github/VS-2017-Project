namespace DeviceFromWhichCompany
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
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lblNmberAplDvc = new System.Windows.Forms.Label();
            this.lblNmbrSmgnDvc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter The Device Name:";
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(543, 35);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(0, 17);
            this.lblDeviceName.TabIndex = 1;
            // 
            // lblNmberAplDvc
            // 
            this.lblNmberAplDvc.AutoSize = true;
            this.lblNmberAplDvc.Location = new System.Drawing.Point(386, 270);
            this.lblNmberAplDvc.Name = "lblNmberAplDvc";
            this.lblNmberAplDvc.Size = new System.Drawing.Size(46, 17);
            this.lblNmberAplDvc.TabIndex = 2;
            this.lblNmberAplDvc.Text = "label3";
            // 
            // lblNmbrSmgnDvc
            // 
            this.lblNmbrSmgnDvc.AutoSize = true;
            this.lblNmbrSmgnDvc.Location = new System.Drawing.Point(386, 314);
            this.lblNmbrSmgnDvc.Name = "lblNmbrSmgnDvc";
            this.lblNmbrSmgnDvc.Size = new System.Drawing.Size(46, 17);
            this.lblNmbrSmgnDvc.TabIndex = 3;
            this.lblNmbrSmgnDvc.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 17);
            this.label5.TabIndex = 4;
            this.label5.Tag = "";
            this.label5.Text = "Number Of Samsung Devices:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Number Of Apple Devices:";
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Location = new System.Drawing.Point(357, 30);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(100, 22);
            this.txtDeviceName.TabIndex = 6;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(357, 112);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(82, 28);
            this.btnResult.TabIndex = 7;
            this.btnResult.Text = "Submit";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNmbrSmgnDvc);
            this.Controls.Add(this.lblNmberAplDvc);
            this.Controls.Add(this.lblDeviceName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblNmberAplDvc;
        private System.Windows.Forms.Label lblNmbrSmgnDvc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.Button btnResult;
    }
}

