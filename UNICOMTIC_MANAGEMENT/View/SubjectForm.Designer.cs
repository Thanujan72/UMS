namespace UNICOMTIC_MANAGEMENT.View
{
    partial class SubjectForm
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
            this.SubjectTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSubdeete = new System.Windows.Forms.Button();
            this.btnSubUpdate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.subjectdatagridview = new System.Windows.Forms.DataGridView();
            this.coursename = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.subjectdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Name";
            // 
            // SubjectTxt
            // 
            this.SubjectTxt.Location = new System.Drawing.Point(354, 160);
            this.SubjectTxt.Name = "SubjectTxt";
            this.SubjectTxt.Size = new System.Drawing.Size(100, 20);
            this.SubjectTxt.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(422, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSubdeete
            // 
            this.btnSubdeete.Location = new System.Drawing.Point(320, 253);
            this.btnSubdeete.Name = "btnSubdeete";
            this.btnSubdeete.Size = new System.Drawing.Size(75, 23);
            this.btnSubdeete.TabIndex = 3;
            this.btnSubdeete.Text = "DELETE";
            this.btnSubdeete.UseVisualStyleBackColor = true;
            this.btnSubdeete.Click += new System.EventHandler(this.btnSubdeete_Click);
            // 
            // btnSubUpdate
            // 
            this.btnSubUpdate.Location = new System.Drawing.Point(217, 253);
            this.btnSubUpdate.Name = "btnSubUpdate";
            this.btnSubUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnSubUpdate.TabIndex = 4;
            this.btnSubUpdate.Text = "UPDATE";
            this.btnSubUpdate.UseVisualStyleBackColor = true;
            this.btnSubUpdate.Click += new System.EventHandler(this.btnSubUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Subject Dettails";
            // 
            // subjectdatagridview
            // 
            this.subjectdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.subjectdatagridview.Location = new System.Drawing.Point(514, 90);
            this.subjectdatagridview.Name = "subjectdatagridview";
            this.subjectdatagridview.Size = new System.Drawing.Size(240, 150);
            this.subjectdatagridview.TabIndex = 6;
            this.subjectdatagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectdatagridview_CellContentClick);
            this.subjectdatagridview.SelectionChanged += new System.EventHandler(this.subjectdatagridview_SelectionChanged);
            // 
            // coursename
            // 
            this.coursename.FormattingEnabled = true;
            this.coursename.Location = new System.Drawing.Point(354, 206);
            this.coursename.Name = "coursename";
            this.coursename.Size = new System.Drawing.Size(121, 21);
            this.coursename.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Course Name";
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.coursename);
            this.Controls.Add(this.subjectdatagridview);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSubUpdate);
            this.Controls.Add(this.btnSubdeete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SubjectTxt);
            this.Controls.Add(this.label1);
            this.Name = "SubjectForm";
            this.Text = "SubjectForm";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.subjectdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SubjectTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSubdeete;
        private System.Windows.Forms.Button btnSubUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView subjectdatagridview;
        private System.Windows.Forms.ComboBox coursename;
        private System.Windows.Forms.Label label3;
    }
}