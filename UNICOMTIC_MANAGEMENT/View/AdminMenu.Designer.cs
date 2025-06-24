namespace UNICOMTIC_MANAGEMENT.View
{
    partial class AdminMenu
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
            this.stuupdate = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menupanal = new System.Windows.Forms.Panel();
            this.btnsubject = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnsubject);
            this.panel1.Controls.Add(this.stuupdate);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 450);
            this.panel1.TabIndex = 0;
            // 
            // stuupdate
            // 
            this.stuupdate.Location = new System.Drawing.Point(3, 424);
            this.stuupdate.Name = "stuupdate";
            this.stuupdate.Size = new System.Drawing.Size(75, 23);
            this.stuupdate.TabIndex = 13;
            this.stuupdate.Text = "Back";
            this.stuupdate.UseVisualStyleBackColor = true;
            this.stuupdate.Click += new System.EventHandler(this.stuupdate_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(32, 199);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "COURSE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(32, 151);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "STUDENT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(32, 103);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "LECTURER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "STAFF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(163, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 19);
            this.panel2.TabIndex = 1;
            // 
            // menupanal
            // 
            this.menupanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menupanal.Location = new System.Drawing.Point(163, 19);
            this.menupanal.Name = "menupanal";
            this.menupanal.Size = new System.Drawing.Size(637, 431);
            this.menupanal.TabIndex = 2;
            this.menupanal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnsubject
            // 
            this.btnsubject.Location = new System.Drawing.Point(32, 250);
            this.btnsubject.Name = "btnsubject";
            this.btnsubject.Size = new System.Drawing.Size(75, 23);
            this.btnsubject.TabIndex = 14;
            this.btnsubject.Text = "SUBJECT";
            this.btnsubject.UseVisualStyleBackColor = true;
            this.btnsubject.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menupanal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.Load += new System.EventHandler(this.AdminMenu_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel menupanal;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button stuupdate;
        private System.Windows.Forms.Button btnsubject;
    }
}