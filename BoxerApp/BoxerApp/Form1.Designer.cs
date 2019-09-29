namespace BoxerApp
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPunchPower = new System.Windows.Forms.Label();
            this.lblKickPower = new System.Windows.Forms.Label();
            this.lblLeftHookPower = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPunchPower = new System.Windows.Forms.TextBox();
            this.txtKickPower = new System.Windows.Forms.TextBox();
            this.txtLeftHookPwer = new System.Windows.Forms.TextBox();
            this.lblRightHookPower = new System.Windows.Forms.Label();
            this.txtRightHookPower = new System.Windows.Forms.TextBox();
            this.lblIncrsdRslt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(219, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 17);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name ";
            // 
            // lblPunchPower
            // 
            this.lblPunchPower.AutoSize = true;
            this.lblPunchPower.Location = new System.Drawing.Point(219, 67);
            this.lblPunchPower.Name = "lblPunchPower";
            this.lblPunchPower.Size = new System.Drawing.Size(91, 17);
            this.lblPunchPower.TabIndex = 1;
            this.lblPunchPower.Text = "Punch Power";
            // 
            // lblKickPower
            // 
            this.lblKickPower.AutoSize = true;
            this.lblKickPower.Location = new System.Drawing.Point(219, 95);
            this.lblKickPower.Name = "lblKickPower";
            this.lblKickPower.Size = new System.Drawing.Size(77, 17);
            this.lblKickPower.TabIndex = 2;
            this.lblKickPower.Text = "Kick Power";
            // 
            // lblLeftHookPower
            // 
            this.lblLeftHookPower.AutoSize = true;
            this.lblLeftHookPower.Location = new System.Drawing.Point(219, 126);
            this.lblLeftHookPower.Name = "lblLeftHookPower";
            this.lblLeftHookPower.Size = new System.Drawing.Size(112, 17);
            this.lblLeftHookPower.TabIndex = 3;
            this.lblLeftHookPower.Text = "Left Hook Power";
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(264, 219);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(155, 29);
            this.btnResult.TabIndex = 4;
            this.btnResult.Text = "Show The Result ";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(56, 270);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(48, 17);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Result";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(361, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtPunchPower
            // 
            this.txtPunchPower.Location = new System.Drawing.Point(361, 64);
            this.txtPunchPower.Name = "txtPunchPower";
            this.txtPunchPower.Size = new System.Drawing.Size(100, 22);
            this.txtPunchPower.TabIndex = 7;
            // 
            // txtKickPower
            // 
            this.txtKickPower.Location = new System.Drawing.Point(361, 95);
            this.txtKickPower.Name = "txtKickPower";
            this.txtKickPower.Size = new System.Drawing.Size(100, 22);
            this.txtKickPower.TabIndex = 8;
            // 
            // txtLeftHookPwer
            // 
            this.txtLeftHookPwer.Location = new System.Drawing.Point(361, 126);
            this.txtLeftHookPwer.Name = "txtLeftHookPwer";
            this.txtLeftHookPwer.Size = new System.Drawing.Size(100, 22);
            this.txtLeftHookPwer.TabIndex = 9;
            // 
            // lblRightHookPower
            // 
            this.lblRightHookPower.AutoSize = true;
            this.lblRightHookPower.Location = new System.Drawing.Point(219, 158);
            this.lblRightHookPower.Name = "lblRightHookPower";
            this.lblRightHookPower.Size = new System.Drawing.Size(121, 17);
            this.lblRightHookPower.TabIndex = 10;
            this.lblRightHookPower.Text = "Right Hook Power";
            // 
            // txtRightHookPower
            // 
            this.txtRightHookPower.Location = new System.Drawing.Point(361, 158);
            this.txtRightHookPower.Name = "txtRightHookPower";
            this.txtRightHookPower.Size = new System.Drawing.Size(100, 22);
            this.txtRightHookPower.TabIndex = 11;
            // 
            // lblIncrsdRslt
            // 
            this.lblIncrsdRslt.AutoSize = true;
            this.lblIncrsdRslt.Location = new System.Drawing.Point(479, 270);
            this.lblIncrsdRslt.Name = "lblIncrsdRslt";
            this.lblIncrsdRslt.Size = new System.Drawing.Size(114, 17);
            this.lblIncrsdRslt.TabIndex = 12;
            this.lblIncrsdRslt.Text = "Increased Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIncrsdRslt);
            this.Controls.Add(this.txtRightHookPower);
            this.Controls.Add(this.lblRightHookPower);
            this.Controls.Add(this.txtLeftHookPwer);
            this.Controls.Add(this.txtKickPower);
            this.Controls.Add(this.txtPunchPower);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblLeftHookPower);
            this.Controls.Add(this.lblKickPower);
            this.Controls.Add(this.lblPunchPower);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPunchPower;
        private System.Windows.Forms.Label lblKickPower;
        private System.Windows.Forms.Label lblLeftHookPower;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPunchPower;
        private System.Windows.Forms.TextBox txtKickPower;
        private System.Windows.Forms.TextBox txtLeftHookPwer;
        private System.Windows.Forms.Label lblRightHookPower;
        private System.Windows.Forms.TextBox txtRightHookPower;
        private System.Windows.Forms.Label lblIncrsdRslt;
    }
}

