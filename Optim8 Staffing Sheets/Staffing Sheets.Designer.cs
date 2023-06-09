﻿namespace Optim8_Staffing_Sheets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.checkBoxSortRR = new System.Windows.Forms.CheckBox();
            this.btnVersionChk = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.highlight15 = new System.Windows.Forms.CheckBox();
            this.trainingChkBox = new System.Windows.Forms.CheckBox();
            this.callinsBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Company:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Username:";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(96, 74);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(132, 22);
            this.txtPass.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(96, 41);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(96, 7);
            this.txtCompany.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(132, 22);
            this.txtCompany.TabIndex = 20;
            this.txtCompany.Text = "sfsl";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 149);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(16, 130);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 29;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(264, 15);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(265, 22);
            this.dtpDate.TabIndex = 30;
            // 
            // checkBoxSortRR
            // 
            this.checkBoxSortRR.AutoSize = true;
            this.checkBoxSortRR.Checked = true;
            this.checkBoxSortRR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSortRR.Location = new System.Drawing.Point(281, 44);
            this.checkBoxSortRR.Name = "checkBoxSortRR";
            this.checkBoxSortRR.Size = new System.Drawing.Size(185, 20);
            this.checkBoxSortRR.TabIndex = 31;
            this.checkBoxSortRR.Text = "Sort Restrooms into Areas";
            this.checkBoxSortRR.UseVisualStyleBackColor = true;
            // 
            // btnVersionChk
            // 
            this.btnVersionChk.Location = new System.Drawing.Point(13, 189);
            this.btnVersionChk.Margin = new System.Windows.Forms.Padding(4);
            this.btnVersionChk.Name = "btnVersionChk";
            this.btnVersionChk.Size = new System.Drawing.Size(293, 28);
            this.btnVersionChk.TabIndex = 32;
            this.btnVersionChk.Text = "Check ChromeDriver Version";
            this.btnVersionChk.UseVisualStyleBackColor = true;
            this.btnVersionChk.Click += new System.EventHandler(this.btnVersionChk_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(499, 189);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(100, 28);
            this.btnAbout.TabIndex = 33;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // highlight15
            // 
            this.highlight15.AutoSize = true;
            this.highlight15.Checked = true;
            this.highlight15.CheckState = System.Windows.Forms.CheckState.Checked;
            this.highlight15.Location = new System.Drawing.Point(281, 122);
            this.highlight15.Name = "highlight15";
            this.highlight15.Size = new System.Drawing.Size(179, 20);
            this.highlight15.TabIndex = 34;
            this.highlight15.Text = "Highlight 14-15 Year Olds";
            this.highlight15.UseVisualStyleBackColor = true;
            // 
            // trainingChkBox
            // 
            this.trainingChkBox.AutoSize = true;
            this.trainingChkBox.Location = new System.Drawing.Point(281, 70);
            this.trainingChkBox.Name = "trainingChkBox";
            this.trainingChkBox.Size = new System.Drawing.Size(124, 20);
            this.trainingChkBox.TabIndex = 35;
            this.trainingChkBox.Text = "Include Training";
            this.trainingChkBox.UseVisualStyleBackColor = true;
            // 
            // callinsBox
            // 
            this.callinsBox.AutoSize = true;
            this.callinsBox.Checked = true;
            this.callinsBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.callinsBox.Location = new System.Drawing.Point(281, 96);
            this.callinsBox.Name = "callinsBox";
            this.callinsBox.Size = new System.Drawing.Size(119, 20);
            this.callinsBox.TabIndex = 36;
            this.callinsBox.Text = "Include Call-Ins";
            this.callinsBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 230);
            this.Controls.Add(this.callinsBox);
            this.Controls.Add(this.trainingChkBox);
            this.Controls.Add(this.highlight15);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnVersionChk);
            this.Controls.Add(this.checkBoxSortRR);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Park Services Staffing Sheets";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox checkBoxSortRR;
        private System.Windows.Forms.Button btnVersionChk;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.CheckBox highlight15;
        private System.Windows.Forms.CheckBox trainingChkBox;
        private System.Windows.Forms.CheckBox callinsBox;
    }
}

