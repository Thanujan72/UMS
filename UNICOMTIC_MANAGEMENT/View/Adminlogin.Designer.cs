namespace UNICOMTIC_MANAGEMENT.View
{
    partial class Adminlogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.adminusername = new System.Windows.Forms.TextBox();
            this.adminpassword = new System.Windows.Forms.TextBox();
            this.btnadminlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Admin User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ADMIN LIGIN";
            // 
            // adminusername
            // 
            this.adminusername.Location = new System.Drawing.Point(302, 100);
            this.adminusername.Name = "adminusername";
            this.adminusername.Size = new System.Drawing.Size(162, 20);
            this.adminusername.TabIndex = 7;
            this.adminusername.TextChanged += new System.EventHandler(this.adminusername_TextChanged);
            // 
            // adminpassword
            // 
            this.adminpassword.Location = new System.Drawing.Point(302, 149);
            this.adminpassword.Name = "adminpassword";
            this.adminpassword.Size = new System.Drawing.Size(162, 20);
            this.adminpassword.TabIndex = 8;
            this.adminpassword.TextChanged += new System.EventHandler(this.adminpassword_TextChanged);
            // 
            // btnadminlogin
            // 
            this.btnadminlogin.Location = new System.Drawing.Point(372, 257);
            this.btnadminlogin.Name = "btnadminlogin";
            this.btnadminlogin.Size = new System.Drawing.Size(92, 23);
            this.btnadminlogin.TabIndex = 9;
            this.btnadminlogin.Text = "LOGIN";
            this.btnadminlogin.UseVisualStyleBackColor = true;
            this.btnadminlogin.Click += new System.EventHandler(this.btnadminlogin_Click);
            // 
            // Adminlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnadminlogin);
            this.Controls.Add(this.adminpassword);
            this.Controls.Add(this.adminusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Adminlogin";
            this.Text = "Adminlogin";
            this.Load += new System.EventHandler(this.Adminlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox adminusername;
        private System.Windows.Forms.TextBox adminpassword;
        private System.Windows.Forms.Button btnadminlogin;
    }
}