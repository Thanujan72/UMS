namespace UNICOMTIC_MANAGEMENT.View
{
    partial class frm_Staff
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
            this.staname = new System.Windows.Forms.TextBox();
            this.staaddress = new System.Windows.Forms.TextBox();
            this.stausername = new System.Windows.Forms.TextBox();
            this.stapassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.staffbtnadd = new System.Windows.Forms.Button();
            this.staffbtndelete = new System.Windows.Forms.Button();
            this.staffbtnupdate = new System.Windows.Forms.Button();
            this.stagridview = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.stagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Staff Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adderss";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // staname
            // 
            this.staname.Location = new System.Drawing.Point(127, 91);
            this.staname.Name = "staname";
            this.staname.Size = new System.Drawing.Size(133, 20);
            this.staname.TabIndex = 4;
            // 
            // staaddress
            // 
            this.staaddress.Location = new System.Drawing.Point(127, 128);
            this.staaddress.Name = "staaddress";
            this.staaddress.Size = new System.Drawing.Size(133, 20);
            this.staaddress.TabIndex = 5;
            // 
            // stausername
            // 
            this.stausername.Location = new System.Drawing.Point(127, 169);
            this.stausername.Name = "stausername";
            this.stausername.Size = new System.Drawing.Size(133, 20);
            this.stausername.TabIndex = 6;
            // 
            // stapassword
            // 
            this.stapassword.Location = new System.Drawing.Point(127, 205);
            this.stapassword.Name = "stapassword";
            this.stapassword.PasswordChar = '*';
            this.stapassword.Size = new System.Drawing.Size(133, 20);
            this.stapassword.TabIndex = 7;
            this.stapassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "STAFF DETAILS";
            // 
            // staffbtnadd
            // 
            this.staffbtnadd.Location = new System.Drawing.Point(214, 267);
            this.staffbtnadd.Name = "staffbtnadd";
            this.staffbtnadd.Size = new System.Drawing.Size(75, 23);
            this.staffbtnadd.TabIndex = 9;
            this.staffbtnadd.Text = "ADD";
            this.staffbtnadd.UseVisualStyleBackColor = true;
            this.staffbtnadd.Click += new System.EventHandler(this.staffbtnadd_Click);
            // 
            // staffbtndelete
            // 
            this.staffbtndelete.Location = new System.Drawing.Point(112, 267);
            this.staffbtndelete.Name = "staffbtndelete";
            this.staffbtndelete.Size = new System.Drawing.Size(75, 23);
            this.staffbtndelete.TabIndex = 10;
            this.staffbtndelete.Text = "DELETE";
            this.staffbtndelete.UseVisualStyleBackColor = true;
            this.staffbtndelete.Click += new System.EventHandler(this.staffbtndelete_Click);
            // 
            // staffbtnupdate
            // 
            this.staffbtnupdate.Location = new System.Drawing.Point(12, 267);
            this.staffbtnupdate.Name = "staffbtnupdate";
            this.staffbtnupdate.Size = new System.Drawing.Size(75, 23);
            this.staffbtnupdate.TabIndex = 11;
            this.staffbtnupdate.Text = "UPDATE";
            this.staffbtnupdate.UseVisualStyleBackColor = true;
            this.staffbtnupdate.Click += new System.EventHandler(this.staffbtnupdate_Click);
            // 
            // stagridview
            // 
            this.stagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stagridview.Location = new System.Drawing.Point(305, 79);
            this.stagridview.Name = "stagridview";
            this.stagridview.Size = new System.Drawing.Size(467, 254);
            this.stagridview.TabIndex = 12;
            this.stagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.stagridview_CellContentClick);
            this.stagridview.SelectionChanged += new System.EventHandler(this.stagridview_SelectionChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 384);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 13;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // frm_Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.stagridview);
            this.Controls.Add(this.staffbtnupdate);
            this.Controls.Add(this.staffbtndelete);
            this.Controls.Add(this.staffbtnadd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stapassword);
            this.Controls.Add(this.stausername);
            this.Controls.Add(this.staaddress);
            this.Controls.Add(this.staname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_Staff";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox staname;
        private System.Windows.Forms.TextBox staaddress;
        private System.Windows.Forms.TextBox stausername;
        private System.Windows.Forms.TextBox stapassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button staffbtnadd;
        private System.Windows.Forms.Button staffbtndelete;
        private System.Windows.Forms.Button staffbtnupdate;
        private System.Windows.Forms.DataGridView stagridview;
        private System.Windows.Forms.Button back;
    }
}