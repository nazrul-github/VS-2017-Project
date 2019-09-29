namespace App2
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxAge = new System.Windows.Forms.TextBox();
            this.txtBoxPower = new System.Windows.Forms.TextBox();
            this.txtBoxSpeed = new System.Windows.Forms.TextBox();
            this.btnShowResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblIncreasedAge = new System.Windows.Forms.Label();
            this.lblIncreasePower = new System.Windows.Forms.Label();
            this.lblIncreaseSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Power:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(270, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Speed:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(335, 51);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxName.TabIndex = 4;
            // 
            // txtBoxAge
            // 
            this.txtBoxAge.Location = new System.Drawing.Point(335, 96);
            this.txtBoxAge.Name = "txtBoxAge";
            this.txtBoxAge.Size = new System.Drawing.Size(100, 22);
            this.txtBoxAge.TabIndex = 5;
            // 
            // txtBoxPower
            // 
            this.txtBoxPower.Location = new System.Drawing.Point(335, 133);
            this.txtBoxPower.Name = "txtBoxPower";
            this.txtBoxPower.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPower.TabIndex = 6;
            // 
            // txtBoxSpeed
            // 
            this.txtBoxSpeed.Location = new System.Drawing.Point(335, 169);
            this.txtBoxSpeed.Name = "txtBoxSpeed";
            this.txtBoxSpeed.Size = new System.Drawing.Size(100, 22);
            this.txtBoxSpeed.TabIndex = 7;
            // 
            // btnShowResult
            // 
            this.btnShowResult.Location = new System.Drawing.Point(273, 197);
            this.btnShowResult.Name = "btnShowResult";
            this.btnShowResult.Size = new System.Drawing.Size(188, 28);
            this.btnShowResult.TabIndex = 8;
            this.btnShowResult.Text = "Show Me The Result";
            this.btnShowResult.UseVisualStyleBackColor = true;
            this.btnShowResult.Click += new System.EventHandler(this.btnShowResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(356, 254);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 17);
            this.lblResult.TabIndex = 9;
            // 
            // lblIncreasedAge
            // 
            this.lblIncreasedAge.AutoSize = true;
            this.lblIncreasedAge.Location = new System.Drawing.Point(335, 343);
            this.lblIncreasedAge.Name = "lblIncreasedAge";
            this.lblIncreasedAge.Size = new System.Drawing.Size(46, 17);
            this.lblIncreasedAge.TabIndex = 10;
            this.lblIncreasedAge.Text = "label5";
            // 
            // lblIncreasePower
            // 
            this.lblIncreasePower.AutoSize = true;
            this.lblIncreasePower.Location = new System.Drawing.Point(335, 385);
            this.lblIncreasePower.Name = "lblIncreasePower";
            this.lblIncreasePower.Size = new System.Drawing.Size(46, 17);
            this.lblIncreasePower.TabIndex = 11;
            this.lblIncreasePower.Text = "label5";
            // 
            // lblIncreaseSpeed
            // 
            this.lblIncreaseSpeed.AutoSize = true;
            this.lblIncreaseSpeed.Location = new System.Drawing.Point(335, 306);
            this.lblIncreaseSpeed.Name = "lblIncreaseSpeed";
            this.lblIncreaseSpeed.Size = new System.Drawing.Size(46, 17);
            this.lblIncreaseSpeed.TabIndex = 12;
            this.lblIncreaseSpeed.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIncreaseSpeed);
            this.Controls.Add(this.lblIncreasePower);
            this.Controls.Add(this.lblIncreasedAge);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnShowResult);
            this.Controls.Add(this.txtBoxSpeed);
            this.Controls.Add(this.txtBoxPower);
            this.Controls.Add(this.txtBoxAge);
            this.Controls.Add(this.txtBoxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxAge;
        private System.Windows.Forms.TextBox txtBoxPower;
        private System.Windows.Forms.TextBox txtBoxSpeed;
        private System.Windows.Forms.Button btnShowResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblIncreasedAge;
        private System.Windows.Forms.Label lblIncreasePower;
        private System.Windows.Forms.Label lblIncreaseSpeed;
    }
}

