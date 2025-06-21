namespace UNICOMTIC_MANAGEMENT.View
{
    partial class LecturerFrom
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lecname = new System.Windows.Forms.TextBox();
            this.lecusername = new System.Windows.Forms.TextBox();
            this.lecpassword = new System.Windows.Forms.TextBox();
            this.lecbtnadd = new System.Windows.Forms.Button();
            this.lecbtndelete = new System.Windows.Forms.Button();
            this.lecbtnupdate = new System.Windows.Forms.Button();
            this.lecturergridview = new System.Windows.Forms.DataGridView();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lecturergridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "LECTURER DETAILS";
            // 
            // lecname
            // 
            this.lecname.Location = new System.Drawing.Point(110, 86);
            this.lecname.Name = "lecname";
            this.lecname.Size = new System.Drawing.Size(131, 20);
            this.lecname.TabIndex = 5;
            // 
            // lecusername
            // 
            this.lecusername.Location = new System.Drawing.Point(110, 135);
            this.lecusername.Name = "lecusername";
            this.lecusername.Size = new System.Drawing.Size(131, 20);
            this.lecusername.TabIndex = 7;
            // 
            // lecpassword
            // 
            this.lecpassword.Location = new System.Drawing.Point(110, 174);
            this.lecpassword.Name = "lecpassword";
            this.lecpassword.PasswordChar = '.';
            this.lecpassword.Size = new System.Drawing.Size(131, 20);
            this.lecpassword.TabIndex = 8;
            this.lecpassword.UseSystemPasswordChar = true;
            // 
            // lecbtnadd
            // 
            this.lecbtnadd.Location = new System.Drawing.Point(214, 320);
            this.lecbtnadd.Name = "lecbtnadd";
            this.lecbtnadd.Size = new System.Drawing.Size(75, 23);
            this.lecbtnadd.TabIndex = 9;
            this.lecbtnadd.Text = "ADD";
            this.lecbtnadd.UseVisualStyleBackColor = true;
            this.lecbtnadd.Click += new System.EventHandler(this.lecbtnadd_Click);
            // 
            // lecbtndelete
            // 
            this.lecbtndelete.Location = new System.Drawing.Point(110, 320);
            this.lecbtndelete.Name = "lecbtndelete";
            this.lecbtndelete.Size = new System.Drawing.Size(75, 23);
            this.lecbtndelete.TabIndex = 10;
            this.lecbtndelete.Text = "DELETE";
            this.lecbtndelete.UseVisualStyleBackColor = true;
            this.lecbtndelete.Click += new System.EventHandler(this.lecbtndelete_Click);
            // 
            // lecbtnupdate
            // 
            this.lecbtnupdate.Location = new System.Drawing.Point(15, 320);
            this.lecbtnupdate.Name = "lecbtnupdate";
            this.lecbtnupdate.Size = new System.Drawing.Size(75, 23);
            this.lecbtnupdate.TabIndex = 11;
            this.lecbtnupdate.Text = "UPDATE";
            this.lecbtnupdate.UseVisualStyleBackColor = true;
            this.lecbtnupdate.Click += new System.EventHandler(this.lecbtnupdate_Click);
            // 
            // lecturergridview
            // 
            this.lecturergridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lecturergridview.Location = new System.Drawing.Point(291, 68);
            this.lecturergridview.Name = "lecturergridview";
            this.lecturergridview.Size = new System.Drawing.Size(468, 247);
            this.lecturergridview.TabIndex = 12;
            this.lecturergridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.lecturergridview.SelectionChanged += new System.EventHandler(this.lecturergridview_SelectionChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(15, 403);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 13;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // LecturerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.lecturergridview);
            this.Controls.Add(this.lecbtnupdate);
            this.Controls.Add(this.lecbtndelete);
            this.Controls.Add(this.lecbtnadd);
            this.Controls.Add(this.lecpassword);
            this.Controls.Add(this.lecusername);
            this.Controls.Add(this.lecname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "LecturerFrom";
            this.Text = "Lecturer ";
            this.Load += new System.EventHandler(this.LecturerFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lecturergridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lecname;
        private System.Windows.Forms.TextBox lecusername;
        private System.Windows.Forms.TextBox lecpassword;
        private System.Windows.Forms.Button lecbtnadd;
        private System.Windows.Forms.Button lecbtndelete;
        private System.Windows.Forms.Button lecbtnupdate;
        private System.Windows.Forms.DataGridView lecturergridview;
        private System.Windows.Forms.Button back;
    }
}