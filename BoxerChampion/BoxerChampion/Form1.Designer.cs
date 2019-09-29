namespace BoxerChampion
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxMatchesWon = new System.Windows.Forms.TextBox();
            this.txtBoxMatchesLost = new System.Windows.Forms.TextBox();
            this.lblEvaluation = new System.Windows.Forms.Label();
            this.lblWinnerResult = new System.Windows.Forms.Label();
            this.btnResult = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(227, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter name of the Boxer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the number of matches won:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter the number of matches lost:";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(411, 47);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxName.TabIndex = 3;
            // 
            // txtBoxMatchesWon
            // 
            this.txtBoxMatchesWon.Location = new System.Drawing.Point(411, 103);
            this.txtBoxMatchesWon.Name = "txtBoxMatchesWon";
            this.txtBoxMatchesWon.Size = new System.Drawing.Size(100, 22);
            this.txtBoxMatchesWon.TabIndex = 4;
            // 
            // txtBoxMatchesLost
            // 
            this.txtBoxMatchesLost.Location = new System.Drawing.Point(411, 163);
            this.txtBoxMatchesLost.Name = "txtBoxMatchesLost";
            this.txtBoxMatchesLost.Size = new System.Drawing.Size(100, 22);
            this.txtBoxMatchesLost.TabIndex = 5;
            // 
            // lblEvaluation
            // 
            this.lblEvaluation.AutoSize = true;
            this.lblEvaluation.Location = new System.Drawing.Point(408, 349);
            this.lblEvaluation.Name = "lblEvaluation";
            this.lblEvaluation.Size = new System.Drawing.Size(0, 17);
            this.lblEvaluation.TabIndex = 6;
            // 
            // lblWinnerResult
            // 
            this.lblWinnerResult.AutoSize = true;
            this.lblWinnerResult.Location = new System.Drawing.Point(408, 256);
            this.lblWinnerResult.Name = "lblWinnerResult";
            this.lblWinnerResult.Size = new System.Drawing.Size(0, 17);
            this.lblWinnerResult.TabIndex = 7;
            // 
            // btnResult
            // 
            this.btnResult.Location = new System.Drawing.Point(638, 106);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(90, 31);
            this.btnResult.TabIndex = 8;
            this.btnResult.Text = "Press Me";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 500);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.lblWinnerResult);
            this.Controls.Add(this.lblEvaluation);
            this.Controls.Add(this.txtBoxMatchesLost);
            this.Controls.Add(this.txtBoxMatchesWon);
            this.Controls.Add(this.txtBoxName);
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
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.TextBox txtBoxMatchesWon;
        private System.Windows.Forms.TextBox txtBoxMatchesLost;
        private System.Windows.Forms.Label lblEvaluation;
        private System.Windows.Forms.Label lblWinnerResult;
        private System.Windows.Forms.Button btnResult;
    }
}

