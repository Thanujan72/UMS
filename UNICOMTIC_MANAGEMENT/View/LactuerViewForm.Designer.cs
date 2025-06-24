namespace UNICOMTIC_MANAGEMENT.View
{
    partial class LactuerViewForm
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
            this.lepanal = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.Timetable = new System.Windows.Forms.Button();
            this.Details = new System.Windows.Forms.Button();
            this.lecpanal = new System.Windows.Forms.Panel();
            this.lblusername = new System.Windows.Forms.Label();
            this.lepanal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lepanal
            // 
            this.lepanal.Controls.Add(this.lblusername);
            this.lepanal.Controls.Add(this.btnback);
            this.lepanal.Controls.Add(this.Timetable);
            this.lepanal.Controls.Add(this.Details);
            this.lepanal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lepanal.Location = new System.Drawing.Point(0, 0);
            this.lepanal.Name = "lepanal";
            this.lepanal.Size = new System.Drawing.Size(108, 450);
            this.lepanal.TabIndex = 0;
            this.lepanal.Paint += new System.Windows.Forms.PaintEventHandler(this.lepanal_Paint);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(12, 415);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(75, 23);
            this.btnback.TabIndex = 2;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // Timetable
            // 
            this.Timetable.Location = new System.Drawing.Point(12, 161);
            this.Timetable.Name = "Timetable";
            this.Timetable.Size = new System.Drawing.Size(75, 23);
            this.Timetable.TabIndex = 1;
            this.Timetable.Text = "Timetable";
            this.Timetable.UseVisualStyleBackColor = true;
            this.Timetable.Click += new System.EventHandler(this.Timetable_Click);
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(12, 216);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(75, 23);
            this.Details.TabIndex = 0;
            this.Details.Text = "Dettails";
            this.Details.UseVisualStyleBackColor = true;
            this.Details.Click += new System.EventHandler(this.Details_Click);
            // 
            // lecpanal
            // 
            this.lecpanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lecpanal.Location = new System.Drawing.Point(108, 0);
            this.lecpanal.Name = "lecpanal";
            this.lecpanal.Size = new System.Drawing.Size(692, 450);
            this.lecpanal.TabIndex = 1;
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Location = new System.Drawing.Point(22, 34);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(0, 13);
            this.lblusername.TabIndex = 3;
            // 
            // LactuerViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lecpanal);
            this.Controls.Add(this.lepanal);
            this.Name = "LactuerViewForm";
            this.Text = "LactuerViewForm";
            this.Load += new System.EventHandler(this.LactuerViewForm_Load);
            this.lepanal.ResumeLayout(false);
            this.lepanal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel lepanal;
        private System.Windows.Forms.Button Timetable;
        private System.Windows.Forms.Button Details;
        private System.Windows.Forms.Panel lecpanal;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label lblusername;
    }
}