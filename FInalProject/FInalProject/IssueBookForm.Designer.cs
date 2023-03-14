namespace FInalProject
{
    partial class IssueBookForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIssue = new System.Windows.Forms.Button();
            this.cbbBookName = new System.Windows.Forms.ComboBox();
            this.dtpIssue = new System.Windows.Forms.DateTimePicker();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.imgStudent = new System.Windows.Forms.PictureBox();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(584, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Yellow;
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.txtBookID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtSID);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.btnIssue);
            this.panel3.Controls.Add(this.cbbBookName);
            this.panel3.Controls.Add(this.dtpIssue);
            this.panel3.Controls.Add(this.txtSEmail);
            this.panel3.Controls.Add(this.txtSPhone);
            this.panel3.Controls.Add(this.txtFaculty);
            this.panel3.Controls.Add(this.txtSName);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(584, 474);
            this.panel3.TabIndex = 2;
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(147, 330);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(163, 20);
            this.txtBookID.TabIndex = 64;
            this.txtBookID.TextChanged += new System.EventHandler(this.txtBookID_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Book ID";
            // 
            // txtSID
            // 
            this.txtSID.Location = new System.Drawing.Point(147, 93);
            this.txtSID.Name = "txtSID";
            this.txtSID.Size = new System.Drawing.Size(163, 20);
            this.txtSID.TabIndex = 61;
            this.txtSID.TextChanged += new System.EventHandler(this.txtSID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Student ID";
            // 
            // btnIssue
            // 
            this.btnIssue.Location = new System.Drawing.Point(428, 425);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(122, 23);
            this.btnIssue.TabIndex = 60;
            this.btnIssue.Text = "Issue Book";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // cbbBookName
            // 
            this.cbbBookName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBookName.FormattingEnabled = true;
            this.cbbBookName.Location = new System.Drawing.Point(147, 303);
            this.cbbBookName.Name = "cbbBookName";
            this.cbbBookName.Size = new System.Drawing.Size(163, 21);
            this.cbbBookName.TabIndex = 59;
            this.cbbBookName.SelectedIndexChanged += new System.EventHandler(this.cbbBookName_SelectedIndexChanged);
            // 
            // dtpIssue
            // 
            this.dtpIssue.CustomFormat = "dd-MM-yyy";
            this.dtpIssue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpIssue.Location = new System.Drawing.Point(147, 358);
            this.dtpIssue.Name = "dtpIssue";
            this.dtpIssue.Size = new System.Drawing.Size(163, 20);
            this.dtpIssue.TabIndex = 58;
            // 
            // txtSEmail
            // 
            this.txtSEmail.Location = new System.Drawing.Point(147, 266);
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(163, 20);
            this.txtSEmail.TabIndex = 56;
            this.txtSEmail.TextChanged += new System.EventHandler(this.txtSEmail_TextChanged);
            // 
            // txtSPhone
            // 
            this.txtSPhone.Location = new System.Drawing.Point(147, 233);
            this.txtSPhone.Name = "txtSPhone";
            this.txtSPhone.Size = new System.Drawing.Size(163, 20);
            this.txtSPhone.TabIndex = 55;
            this.txtSPhone.TextChanged += new System.EventHandler(this.txtSPhone_TextChanged);
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(147, 187);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(163, 20);
            this.txtFaculty.TabIndex = 53;
            this.txtFaculty.TextChanged += new System.EventHandler(this.txtFaculty_TextChanged);
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(147, 138);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(163, 20);
            this.txtSName.TabIndex = 5;
            this.txtSName.TextChanged += new System.EventHandler(this.txtSName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Book Issue";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Book Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "Student Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Student Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Faculty";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Student Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.imgStudent);
            this.panel1.Location = new System.Drawing.Point(400, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 150);
            this.panel1.TabIndex = 65;
            // 
            // imgStudent
            // 
            this.imgStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgStudent.Location = new System.Drawing.Point(0, 0);
            this.imgStudent.Name = "imgStudent";
            this.imgStudent.Size = new System.Drawing.Size(150, 150);
            this.imgStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgStudent.TabIndex = 0;
            this.imgStudent.TabStop = false;
            // 
            // IssueBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 574);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Name = "IssueBookForm";
            this.Text = "IssueBookForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgStudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtpIssue;
        private System.Windows.Forms.TextBox txtSPhone;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbbBookName;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.TextBox txtSID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSEmail;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imgStudent;
    }
}