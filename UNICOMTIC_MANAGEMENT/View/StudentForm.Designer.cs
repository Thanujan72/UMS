namespace UNICOMTIC_MANAGEMENT.View
{
    partial class StudentFrom
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
            this.label5 = new System.Windows.Forms.Label();
            this.stuname = new System.Windows.Forms.TextBox();
            this.stuadderss = new System.Windows.Forms.TextBox();
            this.stuusername = new System.Windows.Forms.TextBox();
            this.stupassword = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.stuadd = new System.Windows.Forms.Button();
            this.studelete = new System.Windows.Forms.Button();
            this.stuupdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.courseid = new System.Windows.Forms.ComboBox();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "UserName";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "STUDENT DETAILS";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // stuname
            // 
            this.stuname.Location = new System.Drawing.Point(143, 83);
            this.stuname.Name = "stuname";
            this.stuname.Size = new System.Drawing.Size(100, 20);
            this.stuname.TabIndex = 5;
            // 
            // stuadderss
            // 
            this.stuadderss.Location = new System.Drawing.Point(143, 120);
            this.stuadderss.Name = "stuadderss";
            this.stuadderss.Size = new System.Drawing.Size(100, 20);
            this.stuadderss.TabIndex = 6;
            // 
            // stuusername
            // 
            this.stuusername.Location = new System.Drawing.Point(143, 160);
            this.stuusername.Name = "stuusername";
            this.stuusername.Size = new System.Drawing.Size(100, 20);
            this.stuusername.TabIndex = 7;
            // 
            // stupassword
            // 
            this.stupassword.Location = new System.Drawing.Point(143, 200);
            this.stupassword.Name = "stupassword";
            this.stupassword.PasswordChar = '.';
            this.stupassword.Size = new System.Drawing.Size(100, 20);
            this.stupassword.TabIndex = 8;
            this.stupassword.UseSystemPasswordChar = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(299, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(489, 269);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // stuadd
            // 
            this.stuadd.Location = new System.Drawing.Point(216, 287);
            this.stuadd.Name = "stuadd";
            this.stuadd.Size = new System.Drawing.Size(75, 23);
            this.stuadd.TabIndex = 10;
            this.stuadd.Text = "ADD";
            this.stuadd.UseVisualStyleBackColor = true;
            this.stuadd.Click += new System.EventHandler(this.stuadd_Click);
            // 
            // studelete
            // 
            this.studelete.Location = new System.Drawing.Point(106, 287);
            this.studelete.Name = "studelete";
            this.studelete.Size = new System.Drawing.Size(75, 23);
            this.studelete.TabIndex = 11;
            this.studelete.Text = "DELETE";
            this.studelete.UseVisualStyleBackColor = true;
            this.studelete.Click += new System.EventHandler(this.studelete_Click);
            // 
            // stuupdate
            // 
            this.stuupdate.Location = new System.Drawing.Point(12, 287);
            this.stuupdate.Name = "stuupdate";
            this.stuupdate.Size = new System.Drawing.Size(75, 23);
            this.stuupdate.TabIndex = 12;
            this.stuupdate.Text = "UPDATE";
            this.stuupdate.UseVisualStyleBackColor = true;
            this.stuupdate.Click += new System.EventHandler(this.stuupdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Course Name";
            // 
            // courseid
            // 
            this.courseid.FormattingEnabled = true;
            this.courseid.Location = new System.Drawing.Point(143, 232);
            this.courseid.Name = "courseid";
            this.courseid.Size = new System.Drawing.Size(121, 21);
            this.courseid.TabIndex = 14;
            this.courseid.SelectedIndexChanged += new System.EventHandler(this.courseid_SelectedIndexChanged);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(12, 396);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 15;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // StudentFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.courseid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stuupdate);
            this.Controls.Add(this.studelete);
            this.Controls.Add(this.stuadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.stupassword);
            this.Controls.Add(this.stuusername);
            this.Controls.Add(this.stuadderss);
            this.Controls.Add(this.stuname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StudentFrom";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.StudentFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stuname;
        private System.Windows.Forms.TextBox stuadderss;
        private System.Windows.Forms.TextBox stuusername;
        private System.Windows.Forms.TextBox stupassword;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button stuadd;
        private System.Windows.Forms.Button studelete;
        private System.Windows.Forms.Button stuupdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox courseid;
        private System.Windows.Forms.Button back;
    }
}