namespace NameOfComputers
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFirstName
            // 
            this.lblFirstName.Location = new System.Drawing.Point(256, 39);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(100, 23);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbLastName
            // 
            this.lbLastName.Location = new System.Drawing.Point(259, 76);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(100, 23);
            this.lbLastName.TabIndex = 1;
            this.lbLastName.Text = "Last Name";
            this.lbLastName.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(259, 115);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(181, 32);
            this.btnResult.TabIndex = 2;
            this.btnResult.Text = "Click To Get The Result";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(259, 172);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result";
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lblFirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblResult;
    }
}

