namespace UNICOMTIC_MANAGEMENT.View
{
    partial class StaffMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmark = new System.Windows.Forms.Button();
            this.btnexam = new System.Windows.Forms.Button();
            this.btntimbletable = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.staffpanal = new System.Windows.Forms.Panel();
            this.btnroom = new System.Windows.Forms.Button();
            this.piback = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.piback)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.piback);
            this.panel1.Controls.Add(this.btnroom);
            this.panel1.Controls.Add(this.btnmark);
            this.panel1.Controls.Add(this.btnexam);
            this.panel1.Controls.Add(this.btntimbletable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnmark
            // 
            this.btnmark.Location = new System.Drawing.Point(33, 196);
            this.btnmark.Name = "btnmark";
            this.btnmark.Size = new System.Drawing.Size(75, 23);
            this.btnmark.TabIndex = 6;
            this.btnmark.Text = "MARK";
            this.btnmark.UseVisualStyleBackColor = true;
            this.btnmark.Click += new System.EventHandler(this.btnmark_Click);
            // 
            // btnexam
            // 
            this.btnexam.Location = new System.Drawing.Point(33, 141);
            this.btnexam.Name = "btnexam";
            this.btnexam.Size = new System.Drawing.Size(75, 23);
            this.btnexam.TabIndex = 5;
            this.btnexam.Text = "EXAM";
            this.btnexam.UseVisualStyleBackColor = true;
            this.btnexam.Click += new System.EventHandler(this.btnexam_Click);
            // 
            // btntimbletable
            // 
            this.btntimbletable.Location = new System.Drawing.Point(12, 98);
            this.btntimbletable.Name = "btntimbletable";
            this.btntimbletable.Size = new System.Drawing.Size(119, 23);
            this.btntimbletable.TabIndex = 4;
            this.btntimbletable.Text = "TIME TABLE";
            this.btntimbletable.UseVisualStyleBackColor = true;
            this.btntimbletable.Click += new System.EventHandler(this.btntimbletable_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(159, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 75);
            this.panel2.TabIndex = 1;
            // 
            // staffpanal
            // 
            this.staffpanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.staffpanal.Location = new System.Drawing.Point(159, 0);
            this.staffpanal.Name = "staffpanal";
            this.staffpanal.Size = new System.Drawing.Size(641, 450);
            this.staffpanal.TabIndex = 1;
            // 
            // btnroom
            // 
            this.btnroom.Location = new System.Drawing.Point(33, 250);
            this.btnroom.Name = "btnroom";
            this.btnroom.Size = new System.Drawing.Size(75, 23);
            this.btnroom.TabIndex = 7;
            this.btnroom.Text = "Room";
            this.btnroom.UseVisualStyleBackColor = true;
            this.btnroom.Click += new System.EventHandler(this.btnroom_Click);
            // 
            // piback
            // 
            this.piback.Image = global::UNICOMTIC_MANAGEMENT.Properties.Resources.R;
            this.piback.Location = new System.Drawing.Point(3, 3);
            this.piback.Name = "piback";
            this.piback.Size = new System.Drawing.Size(49, 37);
            this.piback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.piback.TabIndex = 8;
            this.piback.TabStop = false;
            this.piback.Click += new System.EventHandler(this.piback_Click);
            // 
            // StaffMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.staffpanal);
            this.Controls.Add(this.panel1);
            this.Name = "StaffMenu";
            this.Text = "StaffMenu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.piback)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel staffpanal;
        private System.Windows.Forms.Button btntimbletable;
        private System.Windows.Forms.Button btnexam;
        private System.Windows.Forms.Button btnmark;
        private System.Windows.Forms.Button btnroom;
        private System.Windows.Forms.PictureBox piback;
    }
}