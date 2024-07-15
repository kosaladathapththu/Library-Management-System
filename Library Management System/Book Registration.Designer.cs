namespace Library_Management_System
{
    partial class Book_Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book_Registration));
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgernre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbyn = new System.Windows.Forms.ComboBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Name = "label1";
            // 
            // txtid
            // 
            resources.ApplyResources(this.txtid, "txtid");
            this.txtid.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtid.Name = "txtid";
            // 
            // txttitle
            // 
            resources.ApplyResources(this.txttitle, "txttitle");
            this.txttitle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txttitle.Name = "txttitle";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Name = "label2";
            // 
            // txtauthor
            // 
            resources.ApplyResources(this.txtauthor, "txtauthor");
            this.txtauthor.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtauthor.Name = "txtauthor";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Name = "label3";
            // 
            // txtgernre
            // 
            resources.ApplyResources(this.txtgernre, "txtgernre");
            this.txtgernre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtgernre.Name = "txtgernre";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Name = "label5";
            // 
            // cmbyn
            // 
            resources.ApplyResources(this.cmbyn, "cmbyn");
            this.cmbyn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cmbyn.ForeColor = System.Drawing.Color.Red;
            this.cmbyn.FormattingEnabled = true;
            this.cmbyn.Items.AddRange(new object[] {
            resources.GetString("cmbyn.Items"),
            resources.GetString("cmbyn.Items1")});
            this.cmbyn.Name = "cmbyn";
            // 
            // btnsave
            // 
            resources.ApplyResources(this.btnsave, "btnsave");
            this.btnsave.BackColor = System.Drawing.Color.Lime;
            this.btnsave.Name = "btnsave";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btnclear
            // 
            resources.ApplyResources(this.btnclear, "btnclear");
            this.btnclear.BackColor = System.Drawing.Color.Blue;
            this.btnclear.Name = "btnclear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            resources.ApplyResources(this.btnclose, "btnclose");
            this.btnclose.BackColor = System.Drawing.Color.Red;
            this.btnclose.Name = "btnclose";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // Book_Registration
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.cmbyn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtgernre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtauthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Book_Registration";
            this.Load += new System.EventHandler(this.Book_Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgernre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbyn;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
    }
}