namespace UNICOMTIC_MANAGEMENT.View
{
    partial class ExamForm
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
            this.ExamDatetime = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.examdelete = new System.Windows.Forms.Button();
            this.ExamGridView = new System.Windows.Forms.DataGridView();
            this.examadd = new System.Windows.Forms.Button();
            this.examupdate = new System.Windows.Forms.Button();
            this.subjectname = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.room = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExamGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date of Time";
            // 
            // ExamDatetime
            // 
            this.ExamDatetime.Location = new System.Drawing.Point(137, 165);
            this.ExamDatetime.Name = "ExamDatetime";
            this.ExamDatetime.Size = new System.Drawing.Size(200, 20);
            this.ExamDatetime.TabIndex = 5;
            this.ExamDatetime.ValueChanged += new System.EventHandler(this.ExamDatetime_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(229, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "EXAM";
            // 
            // examdelete
            // 
            this.examdelete.Location = new System.Drawing.Point(126, 227);
            this.examdelete.Name = "examdelete";
            this.examdelete.Size = new System.Drawing.Size(75, 23);
            this.examdelete.TabIndex = 9;
            this.examdelete.Text = "DELETE";
            this.examdelete.UseVisualStyleBackColor = true;
            // 
            // ExamGridView
            // 
            this.ExamGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExamGridView.Location = new System.Drawing.Point(334, 191);
            this.ExamGridView.Name = "ExamGridView";
            this.ExamGridView.Size = new System.Drawing.Size(258, 229);
            this.ExamGridView.TabIndex = 10;
            this.ExamGridView.SelectionChanged += new System.EventHandler(this.ExamGridView_SelectionChanged);
            // 
            // examadd
            // 
            this.examadd.Location = new System.Drawing.Point(232, 227);
            this.examadd.Name = "examadd";
            this.examadd.Size = new System.Drawing.Size(75, 23);
            this.examadd.TabIndex = 11;
            this.examadd.Text = "ADD";
            this.examadd.UseVisualStyleBackColor = true;
            this.examadd.Click += new System.EventHandler(this.examadd_Click);
            // 
            // examupdate
            // 
            this.examupdate.Location = new System.Drawing.Point(19, 227);
            this.examupdate.Name = "examupdate";
            this.examupdate.Size = new System.Drawing.Size(75, 23);
            this.examupdate.TabIndex = 12;
            this.examupdate.Text = "UPDATE";
            this.examupdate.UseVisualStyleBackColor = true;
            this.examupdate.Click += new System.EventHandler(this.examupdate_Click);
            // 
            // subjectname
            // 
            this.subjectname.FormattingEnabled = true;
            this.subjectname.Location = new System.Drawing.Point(137, 95);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(121, 21);
            this.subjectname.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Room";
            // 
            // room
            // 
            this.room.FormattingEnabled = true;
            this.room.Location = new System.Drawing.Point(137, 128);
            this.room.Name = "room";
            this.room.Size = new System.Drawing.Size(121, 21);
            this.room.TabIndex = 15;
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.Controls.Add(this.room);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.subjectname);
            this.Controls.Add(this.examupdate);
            this.Controls.Add(this.examadd);
            this.Controls.Add(this.ExamGridView);
            this.Controls.Add(this.examdelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ExamDatetime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "ExamForm";
            this.Text = "ExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExamGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker ExamDatetime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button examdelete;
        private System.Windows.Forms.DataGridView ExamGridView;
        private System.Windows.Forms.Button examadd;
        private System.Windows.Forms.Button examupdate;
        private System.Windows.Forms.ComboBox subjectname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox room;
    }
}