﻿namespace UsingListView
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
            this.listViewPeople = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLast = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDOB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewPeople
            // 
            this.listViewPeople.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chLast,
            this.chDOB});
            this.listViewPeople.FullRowSelect = true;
            this.listViewPeople.GridLines = true;
            this.listViewPeople.HideSelection = false;
            this.listViewPeople.Location = new System.Drawing.Point(110, 123);
            this.listViewPeople.Name = "listViewPeople";
            this.listViewPeople.Size = new System.Drawing.Size(551, 300);
            this.listViewPeople.TabIndex = 0;
            this.listViewPeople.UseCompatibleStateImageBehavior = false;
            this.listViewPeople.View = System.Windows.Forms.View.Details;
            this.listViewPeople.SelectedIndexChanged += new System.EventHandler(this.listViewPeople_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "First Name";
            this.chID.Width = 100;
            // 
            // chLast
            // 
            this.chLast.Text = "Last Name";
            this.chLast.Width = 100;
            // 
            // chDOB
            // 
            this.chDOB.Text = "Date Of Birth";
            this.chDOB.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "List Of People";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewPeople);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewPeople;
        private System.Windows.Forms.ColumnHeader chID;
        private System.Windows.Forms.ColumnHeader chLast;
        private System.Windows.Forms.ColumnHeader chDOB;
        private System.Windows.Forms.Label label1;
    }
}

