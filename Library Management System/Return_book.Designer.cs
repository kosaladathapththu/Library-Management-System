namespace Library_Management_System
{
    partial class ReturnBooks
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtReturnID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtreturn = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMembername = new System.Windows.Forms.TextBox();
            this.dttoday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbookname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbIssueID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Return Id";
            // 
            // txtReturnID
            // 
            this.txtReturnID.Location = new System.Drawing.Point(194, 32);
            this.txtReturnID.Multiline = true;
            this.txtReturnID.Name = "txtReturnID";
            this.txtReturnID.Size = new System.Drawing.Size(213, 46);
            this.txtReturnID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Want to Return";
            // 
            // dtreturn
            // 
            this.dtreturn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtreturn.Location = new System.Drawing.Point(194, 221);
            this.dtreturn.Name = "dtreturn";
            this.dtreturn.Size = new System.Drawing.Size(187, 22);
            this.dtreturn.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(217, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fine";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(294, 294);
            this.txtFine.Multiline = true;
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(213, 46);
            this.txtFine.TabIndex = 9;
            // 
            // btnreturn
            // 
            this.btnreturn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Location = new System.Drawing.Point(194, 420);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(204, 63);
            this.btnreturn.TabIndex = 10;
            this.btnreturn.Text = "Return";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(591, 420);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(204, 63);
            this.btnclose.TabIndex = 12;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(485, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Issue Id";
            // 
            // txtMembername
            // 
            this.txtMembername.Location = new System.Drawing.Point(194, 120);
            this.txtMembername.Multiline = true;
            this.txtMembername.Name = "txtMembername";
            this.txtMembername.Size = new System.Drawing.Size(213, 50);
            this.txtMembername.TabIndex = 15;
            // 
            // dttoday
            // 
            this.dttoday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttoday.Location = new System.Drawing.Point(645, 211);
            this.dttoday.Name = "dttoday";
            this.dttoday.Size = new System.Drawing.Size(187, 22);
            this.dttoday.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(472, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Today Date";
            // 
            // txtbookname
            // 
            this.txtbookname.Location = new System.Drawing.Point(619, 120);
            this.txtbookname.Multiline = true;
            this.txtbookname.Name = "txtbookname";
            this.txtbookname.Size = new System.Drawing.Size(213, 50);
            this.txtbookname.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(446, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 18;
            this.label7.Text = "Book Name";
            // 
            // cmbIssueID
            // 
            this.cmbIssueID.FormattingEnabled = true;
            this.cmbIssueID.Location = new System.Drawing.Point(619, 42);
            this.cmbIssueID.Name = "cmbIssueID";
            this.cmbIssueID.Size = new System.Drawing.Size(176, 24);
            this.cmbIssueID.TabIndex = 20;
            this.cmbIssueID.SelectedIndexChanged += new System.EventHandler(this.cmbIssueID_SelectedIndexChanged);
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 504);
            this.Controls.Add(this.cmbIssueID);
            this.Controls.Add(this.txtbookname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dttoday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMembername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.txtFine);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtreturn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtReturnID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ReturnBooks";
            this.Text = "Return_book";
            this.Load += new System.EventHandler(this.ReturnBooks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReturnID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtreturn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMembername;
        private System.Windows.Forms.DateTimePicker dttoday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbookname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbIssueID;
    }
}