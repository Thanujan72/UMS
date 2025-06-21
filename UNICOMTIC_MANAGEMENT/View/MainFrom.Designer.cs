namespace UNICOMTIC_MANAGEMENT.View
{
    partial class MainFrom
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
            this.admin = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.admin);
            this.panel1.Controls.Add(this.user);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 450);
            this.panel1.TabIndex = 0;
            // 
            // admin
            // 
            this.admin.Location = new System.Drawing.Point(25, 147);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(105, 23);
            this.admin.TabIndex = 1;
            this.admin.Text = "ADMIN LOGIN";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            // 
            // user
            // 
            this.user.Location = new System.Drawing.Point(25, 99);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(105, 23);
            this.user.TabIndex = 0;
            this.user.Text = "USER LOGIN";
            this.user.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.user.UseVisualStyleBackColor = true;
            this.user.UseWaitCursor = true;
            this.user.Click += new System.EventHandler(this.user_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(153, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 46);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button3.Location = new System.Drawing.Point(41, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(540, 28);
            this.button3.TabIndex = 1;
            this.button3.TabStop = false;
            this.button3.Text = "UNICOM TIC MANAGEMENT";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(153, 46);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(647, 404);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // MainFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MainFrom";
            this.Text = "MainFrom";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
    }
}