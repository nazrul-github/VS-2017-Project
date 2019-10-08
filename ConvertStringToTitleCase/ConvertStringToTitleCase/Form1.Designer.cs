namespace ConvertStringToTitleCase
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
            this.addQuoteTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.normaliseButton = new System.Windows.Forms.Button();
            this.mainListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.autoRadioButton = new System.Windows.Forms.RadioButton();
            this.manualRadioButton = new System.Windows.Forms.RadioButton();
            this.idInpuTextBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.clrSeachLabel = new System.Windows.Forms.Label();
            this.clrSearchButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // addQuoteTextBox
            // 
            this.addQuoteTextBox.Location = new System.Drawing.Point(184, 15);
            this.addQuoteTextBox.Name = "addQuoteTextBox";
            this.addQuoteTextBox.Size = new System.Drawing.Size(242, 22);
            this.addQuoteTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please Enter Your Quote";
            // 
            // normaliseButton
            // 
            this.normaliseButton.Location = new System.Drawing.Point(15, 209);
            this.normaliseButton.Name = "normaliseButton";
            this.normaliseButton.Size = new System.Drawing.Size(242, 51);
            this.normaliseButton.TabIndex = 4;
            this.normaliseButton.Text = "Convert Text And Add";
            this.normaliseButton.UseVisualStyleBackColor = true;
            this.normaliseButton.Click += new System.EventHandler(this.normaliseButton_Click);
            // 
            // mainListView
            // 
            this.mainListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.mainListView.FullRowSelect = true;
            this.mainListView.GridLines = true;
            this.mainListView.HideSelection = false;
            this.mainListView.Location = new System.Drawing.Point(443, 15);
            this.mainListView.Name = "mainListView";
            this.mainListView.Size = new System.Drawing.Size(446, 204);
            this.mainListView.TabIndex = 3;
            this.mainListView.UseCompatibleStateImageBehavior = false;
            this.mainListView.View = System.Windows.Forms.View.Details;
            this.mainListView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.mainListView_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quote";
            this.columnHeader2.Width = 342;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please select how you want to add the id?";
            // 
            // autoRadioButton
            // 
            this.autoRadioButton.AutoSize = true;
            this.autoRadioButton.Location = new System.Drawing.Point(15, 117);
            this.autoRadioButton.Name = "autoRadioButton";
            this.autoRadioButton.Size = new System.Drawing.Size(112, 21);
            this.autoRadioButton.TabIndex = 1;
            this.autoRadioButton.TabStop = true;
            this.autoRadioButton.Text = "Automatically";
            this.autoRadioButton.UseVisualStyleBackColor = true;
            // 
            // manualRadioButton
            // 
            this.manualRadioButton.AutoSize = true;
            this.manualRadioButton.Location = new System.Drawing.Point(151, 117);
            this.manualRadioButton.Name = "manualRadioButton";
            this.manualRadioButton.Size = new System.Drawing.Size(85, 21);
            this.manualRadioButton.TabIndex = 2;
            this.manualRadioButton.TabStop = true;
            this.manualRadioButton.Text = "Manually";
            this.manualRadioButton.UseVisualStyleBackColor = true;
            this.manualRadioButton.CheckedChanged += new System.EventHandler(this.manualRadioButton_CheckedChanged);
            // 
            // idInpuTextBox
            // 
            this.idInpuTextBox.Location = new System.Drawing.Point(15, 166);
            this.idInpuTextBox.Name = "idInpuTextBox";
            this.idInpuTextBox.Size = new System.Drawing.Size(247, 22);
            this.idInpuTextBox.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(773, 234);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(116, 38);
            this.removeButton.TabIndex = 6;
            this.removeButton.Text = "Remove Quote";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search via quote or ID";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(17, 371);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(247, 22);
            this.searchTextBox.TabIndex = 5;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            // 
            // clrSeachLabel
            // 
            this.clrSeachLabel.AutoSize = true;
            this.clrSeachLabel.Location = new System.Drawing.Point(563, 525);
            this.clrSeachLabel.Name = "clrSeachLabel";
            this.clrSeachLabel.Size = new System.Drawing.Size(123, 17);
            this.clrSeachLabel.TabIndex = 14;
            this.clrSeachLabel.Text = "Clear The Search ";
            // 
            // clrSearchButton
            // 
            this.clrSearchButton.Location = new System.Drawing.Point(709, 518);
            this.clrSearchButton.Name = "clrSearchButton";
            this.clrSearchButton.Size = new System.Drawing.Size(122, 30);
            this.clrSearchButton.TabIndex = 7;
            this.clrSearchButton.Text = "Clear";
            this.clrSearchButton.UseVisualStyleBackColor = true;
            this.clrSearchButton.Click += new System.EventHandler(this.clrSearchButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Please enter an ID number for your qoute";
            // 
            // searchListView
            // 
            this.searchListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.searchListView.GridLines = true;
            this.searchListView.HideSelection = false;
            this.searchListView.Location = new System.Drawing.Point(443, 289);
            this.searchListView.Name = "searchListView";
            this.searchListView.Size = new System.Drawing.Size(446, 204);
            this.searchListView.TabIndex = 18;
            this.searchListView.UseCompatibleStateImageBehavior = false;
            this.searchListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "ID";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Quote";
            this.columnHeader4.Width = 342;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 557);
            this.Controls.Add(this.searchListView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clrSearchButton);
            this.Controls.Add(this.clrSeachLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.idInpuTextBox);
            this.Controls.Add(this.manualRadioButton);
            this.Controls.Add(this.autoRadioButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.mainListView);
            this.Controls.Add(this.normaliseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addQuoteTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addQuoteTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button normaliseButton;
        private System.Windows.Forms.ListView mainListView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton autoRadioButton;
        private System.Windows.Forms.RadioButton manualRadioButton;
        private System.Windows.Forms.TextBox idInpuTextBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label clrSeachLabel;
        private System.Windows.Forms.Button clrSearchButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView searchListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

