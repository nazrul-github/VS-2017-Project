namespace SwitchStatements
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
            this.txtBoxBoxerSpeed = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblGreatBoxer = new System.Windows.Forms.Label();
            this.lblGoodBoxer = new System.Windows.Forms.Label();
            this.lblBadBoxer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(365, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Boxer Speed:";
            // 
            // txtBoxBoxerSpeed
            // 
            this.txtBoxBoxerSpeed.Location = new System.Drawing.Point(529, 34);
            this.txtBoxBoxerSpeed.Name = "txtBoxBoxerSpeed";
            this.txtBoxBoxerSpeed.Size = new System.Drawing.Size(100, 22);
            this.txtBoxBoxerSpeed.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(553, 89);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 31);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblGreatBoxer
            // 
            this.lblGreatBoxer.AutoSize = true;
            this.lblGreatBoxer.Location = new System.Drawing.Point(483, 120);
            this.lblGreatBoxer.Name = "lblGreatBoxer";
            this.lblGreatBoxer.Size = new System.Drawing.Size(46, 17);
            this.lblGreatBoxer.TabIndex = 3;
            this.lblGreatBoxer.Text = "label2";
            // 
            // lblGoodBoxer
            // 
            this.lblGoodBoxer.AutoSize = true;
            this.lblGoodBoxer.Location = new System.Drawing.Point(483, 160);
            this.lblGoodBoxer.Name = "lblGoodBoxer";
            this.lblGoodBoxer.Size = new System.Drawing.Size(46, 17);
            this.lblGoodBoxer.TabIndex = 4;
            this.lblGoodBoxer.Text = "label3";
            // 
            // lblBadBoxer
            // 
            this.lblBadBoxer.AutoSize = true;
            this.lblBadBoxer.Location = new System.Drawing.Point(483, 217);
            this.lblBadBoxer.Name = "lblBadBoxer";
            this.lblBadBoxer.Size = new System.Drawing.Size(46, 17);
            this.lblBadBoxer.TabIndex = 5;
            this.lblBadBoxer.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Number of bad boxer";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Number of good Boxers:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number of great boxer";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(228, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 46);
            this.label8.TabIndex = 9;
            this.label8.Text = "Enter a number in the range 10...200";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblBadBoxer);
            this.Controls.Add(this.lblGoodBoxer);
            this.Controls.Add(this.lblGreatBoxer);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtBoxBoxerSpeed);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxBoxerSpeed;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblGreatBoxer;
        private System.Windows.Forms.Label lblGoodBoxer;
        private System.Windows.Forms.Label lblBadBoxer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

