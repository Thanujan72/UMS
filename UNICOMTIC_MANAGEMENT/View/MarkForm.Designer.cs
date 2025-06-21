namespace UNICOMTIC_MANAGEMENT.View
{
    partial class MarkForm
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
            this.lable1 = new System.Windows.Forms.Label();
            this.btnmarkadd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.markscore = new System.Windows.Forms.TextBox();
            this.examname = new System.Windows.Forms.ComboBox();
            this.btnmarkdelete = new System.Windows.Forms.Button();
            this.btnmarkupdate = new System.Windows.Forms.Button();
            this.markGridView = new System.Windows.Forms.DataGridView();
            this.studentname = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.markGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(29, 88);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(84, 13);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Student Name :-";
            // 
            // btnmarkadd
            // 
            this.btnmarkadd.Location = new System.Drawing.Point(203, 291);
            this.btnmarkadd.Name = "btnmarkadd";
            this.btnmarkadd.Size = new System.Drawing.Size(75, 23);
            this.btnmarkadd.TabIndex = 2;
            this.btnmarkadd.Text = "ADD";
            this.btnmarkadd.UseVisualStyleBackColor = true;
            this.btnmarkadd.Click += new System.EventHandler(this.btnmarkadd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Exam Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Score";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "MARKS";
            // 
            // markscore
            // 
            this.markscore.Location = new System.Drawing.Point(119, 186);
            this.markscore.Name = "markscore";
            this.markscore.Size = new System.Drawing.Size(100, 20);
            this.markscore.TabIndex = 8;
            // 
            // examname
            // 
            this.examname.FormattingEnabled = true;
            this.examname.Location = new System.Drawing.Point(119, 137);
            this.examname.Name = "examname";
            this.examname.Size = new System.Drawing.Size(121, 21);
            this.examname.TabIndex = 9;
            // 
            // btnmarkdelete
            // 
            this.btnmarkdelete.Location = new System.Drawing.Point(108, 291);
            this.btnmarkdelete.Name = "btnmarkdelete";
            this.btnmarkdelete.Size = new System.Drawing.Size(75, 23);
            this.btnmarkdelete.TabIndex = 10;
            this.btnmarkdelete.Text = "DELETE";
            this.btnmarkdelete.UseVisualStyleBackColor = true;
            this.btnmarkdelete.Click += new System.EventHandler(this.btnmarkdelete_Click);
            // 
            // btnmarkupdate
            // 
            this.btnmarkupdate.Location = new System.Drawing.Point(12, 291);
            this.btnmarkupdate.Name = "btnmarkupdate";
            this.btnmarkupdate.Size = new System.Drawing.Size(75, 23);
            this.btnmarkupdate.TabIndex = 11;
            this.btnmarkupdate.Text = "UPDATE";
            this.btnmarkupdate.UseVisualStyleBackColor = true;
            this.btnmarkupdate.Click += new System.EventHandler(this.btnmarkupdate_Click);
            // 
            // markGridView
            // 
            this.markGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markGridView.Location = new System.Drawing.Point(341, 63);
            this.markGridView.Name = "markGridView";
            this.markGridView.Size = new System.Drawing.Size(412, 185);
            this.markGridView.TabIndex = 12;
            this.markGridView.SelectionChanged += new System.EventHandler(this.markGridView_SelectionChanged);
            // 
            // studentname
            // 
            this.studentname.FormattingEnabled = true;
            this.studentname.Location = new System.Drawing.Point(119, 85);
            this.studentname.Name = "studentname";
            this.studentname.Size = new System.Drawing.Size(121, 21);
            this.studentname.TabIndex = 13;
            // 
            // MarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentname);
            this.Controls.Add(this.markGridView);
            this.Controls.Add(this.btnmarkupdate);
            this.Controls.Add(this.btnmarkdelete);
            this.Controls.Add(this.examname);
            this.Controls.Add(this.markscore);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnmarkadd);
            this.Controls.Add(this.lable1);
            this.Name = "MarkForm";
            this.Text = "MarkForm";
            this.Load += new System.EventHandler(this.MarkForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.markGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.Button btnmarkadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox markscore;
        private System.Windows.Forms.ComboBox examname;
        private System.Windows.Forms.Button btnmarkdelete;
        private System.Windows.Forms.Button btnmarkupdate;
        private System.Windows.Forms.DataGridView markGridView;
        private System.Windows.Forms.ComboBox studentname;
    }
}