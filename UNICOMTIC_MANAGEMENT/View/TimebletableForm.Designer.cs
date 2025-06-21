namespace UNICOMTIC_MANAGEMENT.View
{
    partial class TimebletableForm
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
            this.comboroom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timbletabletimeslot = new System.Windows.Forms.TextBox();
            this.combosubeject = new System.Windows.Forms.ComboBox();
            this.Timetable = new System.Windows.Forms.DataGridView();
            this.timetableadd = new System.Windows.Forms.Button();
            this.timetabledelete = new System.Windows.Forms.Button();
            this.timetableupdate = new System.Windows.Forms.Button();
            this.timetableroom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject ";
            // 
            // comboroom
            // 
            this.comboroom.AutoSize = true;
            this.comboroom.Location = new System.Drawing.Point(62, 130);
            this.comboroom.Name = "comboroom";
            this.comboroom.Size = new System.Drawing.Size(35, 13);
            this.comboroom.TabIndex = 1;
            this.comboroom.Text = "Room";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Time Slot";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "TIME TABLE";
            // 
            // timbletabletimeslot
            // 
            this.timbletabletimeslot.Location = new System.Drawing.Point(133, 177);
            this.timbletabletimeslot.Name = "timbletabletimeslot";
            this.timbletabletimeslot.Size = new System.Drawing.Size(100, 20);
            this.timbletabletimeslot.TabIndex = 6;
            // 
            // combosubeject
            // 
            this.combosubeject.FormattingEnabled = true;
            this.combosubeject.Location = new System.Drawing.Point(133, 67);
            this.combosubeject.Name = "combosubeject";
            this.combosubeject.Size = new System.Drawing.Size(121, 21);
            this.combosubeject.TabIndex = 7;
            // 
            // Timetable
            // 
            this.Timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Timetable.Location = new System.Drawing.Point(298, 75);
            this.Timetable.Name = "Timetable";
            this.Timetable.Size = new System.Drawing.Size(428, 150);
            this.Timetable.TabIndex = 9;
            this.Timetable.SelectionChanged += new System.EventHandler(this.Timetable_SelectionChanged);
            // 
            // timetableadd
            // 
            this.timetableadd.Location = new System.Drawing.Point(248, 272);
            this.timetableadd.Name = "timetableadd";
            this.timetableadd.Size = new System.Drawing.Size(75, 23);
            this.timetableadd.TabIndex = 10;
            this.timetableadd.Text = "ADD";
            this.timetableadd.UseVisualStyleBackColor = true;
            this.timetableadd.Click += new System.EventHandler(this.timetableadd_Click);
            // 
            // timetabledelete
            // 
            this.timetabledelete.Location = new System.Drawing.Point(133, 272);
            this.timetabledelete.Name = "timetabledelete";
            this.timetabledelete.Size = new System.Drawing.Size(75, 23);
            this.timetabledelete.TabIndex = 11;
            this.timetabledelete.Text = "DELETE";
            this.timetabledelete.UseVisualStyleBackColor = true;
            this.timetabledelete.Click += new System.EventHandler(this.timetabledelete_Click);
            // 
            // timetableupdate
            // 
            this.timetableupdate.Location = new System.Drawing.Point(33, 272);
            this.timetableupdate.Name = "timetableupdate";
            this.timetableupdate.Size = new System.Drawing.Size(75, 23);
            this.timetableupdate.TabIndex = 12;
            this.timetableupdate.Text = "UPDATE";
            this.timetableupdate.UseVisualStyleBackColor = true;
            this.timetableupdate.Click += new System.EventHandler(this.timetableupdate_Click);
            // 
            // timetableroom
            // 
            this.timetableroom.FormattingEnabled = true;
            this.timetableroom.Location = new System.Drawing.Point(133, 122);
            this.timetableroom.Name = "timetableroom";
            this.timetableroom.Size = new System.Drawing.Size(121, 21);
            this.timetableroom.TabIndex = 8;
            // 
            // TimebletableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.timetableupdate);
            this.Controls.Add(this.timetabledelete);
            this.Controls.Add(this.timetableadd);
            this.Controls.Add(this.Timetable);
            this.Controls.Add(this.timetableroom);
            this.Controls.Add(this.combosubeject);
            this.Controls.Add(this.timbletabletimeslot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboroom);
            this.Controls.Add(this.label1);
            this.Name = "TimebletableForm";
            this.Text = "Timbletable";
            this.Load += new System.EventHandler(this.TimebletableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Timetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label comboroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox timbletabletimeslot;
        private System.Windows.Forms.ComboBox combosubeject;
        private System.Windows.Forms.DataGridView Timetable;
        private System.Windows.Forms.Button timetableadd;
        private System.Windows.Forms.Button timetabledelete;
        private System.Windows.Forms.Button timetableupdate;
        private System.Windows.Forms.ComboBox timetableroom;
    }
}