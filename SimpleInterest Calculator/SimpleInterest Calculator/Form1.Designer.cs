namespace SimpleInterest_Calculator
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
            this.perYearLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.timeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.resultDisplayLabel = new System.Windows.Forms.Label();
            this.thirdLabel = new System.Windows.Forms.Label();
            this.secondLabel = new System.Windows.Forms.Label();
            this.firstLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.thirdTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.whereConditionLabel = new System.Windows.Forms.Label();
            this.solveLabel = new System.Windows.Forms.Label();
            this.conditionSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.perYearLastLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // perYearLabel
            // 
            this.perYearLabel.AutoSize = true;
            this.perYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perYearLabel.ForeColor = System.Drawing.Color.Gray;
            this.perYearLabel.Location = new System.Drawing.Point(157, 232);
            this.perYearLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.perYearLabel.Name = "perYearLabel";
            this.perYearLabel.Size = new System.Drawing.Size(70, 20);
            this.perYearLabel.TabIndex = 33;
            this.perYearLabel.Text = "per year";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Maroon;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(96, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 52);
            this.label2.TabIndex = 31;
            this.label2.Text = "Simple Interest Calculator";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.clearButton.Location = new System.Drawing.Point(101, 375);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 42);
            this.clearButton.TabIndex = 25;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // timeSelectionComboBox
            // 
            this.timeSelectionComboBox.BackColor = System.Drawing.Color.White;
            this.timeSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.timeSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeSelectionComboBox.FormattingEnabled = true;
            this.timeSelectionComboBox.Location = new System.Drawing.Point(223, 305);
            this.timeSelectionComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.timeSelectionComboBox.Name = "timeSelectionComboBox";
            this.timeSelectionComboBox.Size = new System.Drawing.Size(245, 28);
            this.timeSelectionComboBox.TabIndex = 23;
            // 
            // resultDisplayLabel
            // 
            this.resultDisplayLabel.AutoSize = true;
            this.resultDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultDisplayLabel.Location = new System.Drawing.Point(71, 517);
            this.resultDisplayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.resultDisplayLabel.Name = "resultDisplayLabel";
            this.resultDisplayLabel.Size = new System.Drawing.Size(66, 25);
            this.resultDisplayLabel.TabIndex = 30;
            this.resultDisplayLabel.Text = "Result";
            // 
            // thirdLabel
            // 
            this.thirdLabel.AutoSize = true;
            this.thirdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdLabel.Location = new System.Drawing.Point(97, 266);
            this.thirdLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.thirdLabel.Name = "thirdLabel";
            this.thirdLabel.Size = new System.Drawing.Size(95, 25);
            this.thirdLabel.TabIndex = 29;
            this.thirdLabel.Text = "Condition";
            this.thirdLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // secondLabel
            // 
            this.secondLabel.AutoSize = true;
            this.secondLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondLabel.Location = new System.Drawing.Point(97, 201);
            this.secondLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.secondLabel.Name = "secondLabel";
            this.secondLabel.Size = new System.Drawing.Size(95, 25);
            this.secondLabel.TabIndex = 28;
            this.secondLabel.Text = "Condition";
            this.secondLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // firstLabel
            // 
            this.firstLabel.AutoSize = true;
            this.firstLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstLabel.Location = new System.Drawing.Point(97, 159);
            this.firstLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.firstLabel.Name = "firstLabel";
            this.firstLabel.Size = new System.Drawing.Size(95, 25);
            this.firstLabel.TabIndex = 27;
            this.firstLabel.Text = "Condition";
            this.firstLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.Location = new System.Drawing.Point(449, 375);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(6);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(98, 42);
            this.calculateButton.TabIndex = 24;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // thirdTextBox
            // 
            this.thirdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdTextBox.Location = new System.Drawing.Point(222, 263);
            this.thirdTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.thirdTextBox.Name = "thirdTextBox";
            this.thirdTextBox.Size = new System.Drawing.Size(246, 30);
            this.thirdTextBox.TabIndex = 22;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondTextBox.Location = new System.Drawing.Point(223, 198);
            this.secondTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(246, 30);
            this.secondTextBox.TabIndex = 21;
            // 
            // firstTextBox
            // 
            this.firstTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTextBox.Location = new System.Drawing.Point(222, 156);
            this.firstTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(247, 30);
            this.firstTextBox.TabIndex = 18;
            // 
            // whereConditionLabel
            // 
            this.whereConditionLabel.AutoSize = true;
            this.whereConditionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whereConditionLabel.Location = new System.Drawing.Point(228, 121);
            this.whereConditionLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.whereConditionLabel.Name = "whereConditionLabel";
            this.whereConditionLabel.Size = new System.Drawing.Size(0, 25);
            this.whereConditionLabel.TabIndex = 20;
            // 
            // solveLabel
            // 
            this.solveLabel.AutoSize = true;
            this.solveLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveLabel.Location = new System.Drawing.Point(96, 76);
            this.solveLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.solveLabel.Name = "solveLabel";
            this.solveLabel.Size = new System.Drawing.Size(96, 25);
            this.solveLabel.TabIndex = 19;
            this.solveLabel.Text = "Solve For";
            // 
            // conditionSelectionComboBox
            // 
            this.conditionSelectionComboBox.BackColor = System.Drawing.Color.White;
            this.conditionSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conditionSelectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conditionSelectionComboBox.FormattingEnabled = true;
            this.conditionSelectionComboBox.Location = new System.Drawing.Point(222, 77);
            this.conditionSelectionComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.conditionSelectionComboBox.Name = "conditionSelectionComboBox";
            this.conditionSelectionComboBox.Size = new System.Drawing.Size(247, 28);
            this.conditionSelectionComboBox.TabIndex = 17;
            this.conditionSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.conditionSelectionComboBox_SelectedIndexChanged);
            // 
            // perYearLastLabel
            // 
            this.perYearLastLabel.AutoSize = true;
            this.perYearLastLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perYearLastLabel.ForeColor = System.Drawing.Color.Gray;
            this.perYearLastLabel.Location = new System.Drawing.Point(157, 334);
            this.perYearLastLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.perYearLastLabel.Name = "perYearLastLabel";
            this.perYearLastLabel.Size = new System.Drawing.Size(70, 20);
            this.perYearLastLabel.TabIndex = 34;
            this.perYearLastLabel.Text = "per year";
            // 
            // resultLabel
            // 
            this.resultLabel.BackColor = System.Drawing.Color.White;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.Location = new System.Drawing.Point(156, 468);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(391, 118);
            this.resultLabel.TabIndex = 35;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 660);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.perYearLastLabel);
            this.Controls.Add(this.perYearLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.timeSelectionComboBox);
            this.Controls.Add(this.resultDisplayLabel);
            this.Controls.Add(this.thirdLabel);
            this.Controls.Add(this.secondLabel);
            this.Controls.Add(this.firstLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.thirdTextBox);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.whereConditionLabel);
            this.Controls.Add(this.solveLabel);
            this.Controls.Add(this.conditionSelectionComboBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label perYearLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ComboBox timeSelectionComboBox;
        private System.Windows.Forms.Label resultDisplayLabel;
        private System.Windows.Forms.Label thirdLabel;
        private System.Windows.Forms.Label secondLabel;
        private System.Windows.Forms.Label firstLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TextBox thirdTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.Label whereConditionLabel;
        private System.Windows.Forms.Label solveLabel;
        private System.Windows.Forms.ComboBox conditionSelectionComboBox;
        private System.Windows.Forms.Label perYearLastLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

