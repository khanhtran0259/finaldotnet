﻿namespace FInalProject
{
    partial class ReturnBookForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.txtSEmail = new System.Windows.Forms.TextBox();
            this.txtSPhone = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txtBookName);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtBookID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtSID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnIssue);
            this.panel2.Controls.Add(this.dtpReturn);
            this.panel2.Controls.Add(this.txtSEmail);
            this.panel2.Controls.Add(this.txtSPhone);
            this.panel2.Controls.Add(this.txtFaculty);
            this.panel2.Controls.Add(this.txtSName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 441);
            this.panel2.TabIndex = 1;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(113, 267);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(337, 20);
            this.txtBookName.TabIndex = 84;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(113, 100);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(337, 20);
            this.txtID.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "ID";
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(113, 293);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(337, 20);
            this.txtBookID.TabIndex = 81;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 80;
            this.label4.Text = "Book ID";
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(113, 128);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(337, 20);
            this.txtSID.TabIndex = 78;
            this.txtSID.TextChanged += new System.EventHandler(this.txtSID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 79;
            this.label1.Text = "Student ID";
            // 
            // btnIssue
            // 
            this.btnIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Location = new System.Drawing.Point(199, 377);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(122, 23);
            this.btnIssue.TabIndex = 77;
            this.btnIssue.Text = "Return Book";
            this.btnIssue.UseVisualStyleBackColor = false;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // dtpReturn
            // 
            this.dtpReturn.CustomFormat = "dd-MM-yyy";
            this.dtpReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturn.Location = new System.Drawing.Point(113, 319);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(337, 20);
            this.dtpReturn.TabIndex = 75;
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(113, 241);
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(337, 20);
            this.txtSEmail.TabIndex = 74;
            // 
            // txtSPhone
            // 
            this.txtSPhone.Location = new System.Drawing.Point(113, 215);
            this.txtSPhone.Name = "txtSPhone";
            this.txtSPhone.Size = new System.Drawing.Size(337, 20);
            this.txtSPhone.TabIndex = 73;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(113, 185);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(337, 20);
            this.txtFaculty.TabIndex = 72;
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(113, 159);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(337, 20);
            this.txtSName.TabIndex = 65;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 71;
            this.label2.Text = "Book Issue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 70;
            this.label3.Text = "Book Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Student Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 68;
            this.label5.Text = "Student Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Faculty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Student Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(164, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 36);
            this.label10.TabIndex = 86;
            this.label10.Text = "Return Books";
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 441);
            this.Controls.Add(this.panel2);
            this.Name = "ReturnBookForm";
            this.Text = "ReturnBookForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtBookName;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.TextBox txtBookID;
        public System.Windows.Forms.TextBox txtSID;
        public System.Windows.Forms.Button btnIssue;
        public System.Windows.Forms.DateTimePicker dtpReturn;
        public System.Windows.Forms.TextBox txtSEmail;
        public System.Windows.Forms.TextBox txtSPhone;
        public System.Windows.Forms.TextBox txtFaculty;
        public System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label10;
    }
}