namespace UNICOMTIC_MANAGEMENT.View
{
    partial class StudentViewForm
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
            this.studentManu = new System.Windows.Forms.Panel();
            this.studentmain = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.studentManu.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentManu
            // 
            this.studentManu.Controls.Add(this.button4);
            this.studentManu.Controls.Add(this.button3);
            this.studentManu.Controls.Add(this.button2);
            this.studentManu.Controls.Add(this.button1);
            this.studentManu.Dock = System.Windows.Forms.DockStyle.Left;
            this.studentManu.Location = new System.Drawing.Point(0, 0);
            this.studentManu.Name = "studentManu";
            this.studentManu.Size = new System.Drawing.Size(95, 450);
            this.studentManu.TabIndex = 1;
            // 
            // studentmain
            // 
            this.studentmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentmain.Location = new System.Drawing.Point(95, 0);
            this.studentmain.Name = "studentmain";
            this.studentmain.Size = new System.Drawing.Size(705, 450);
            this.studentmain.TabIndex = 2;
            this.studentmain.Paint += new System.Windows.Forms.PaintEventHandler(this.studentmain_Paint);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mark";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 193);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Time Table";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 237);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exam";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // StudentViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.studentmain);
            this.Controls.Add(this.studentManu);
            this.Name = "StudentViewForm";
            this.Text = "StudentViewForm";
            this.Load += new System.EventHandler(this.StudentViewForm_Load);
            this.studentManu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel studentManu;
        private System.Windows.Forms.Panel studentmain;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}