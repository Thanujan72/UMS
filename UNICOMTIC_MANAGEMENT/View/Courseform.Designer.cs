using System.Windows.Forms;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class Courseform : Form
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
            this.couname = new System.Windows.Forms.TextBox();
            this.coursegridview = new System.Windows.Forms.DataGridView();
            this.coubtnadd = new System.Windows.Forms.Button();
            this.coubtndelete = new System.Windows.Forms.Button();
            this.coubtnupdate = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.coursegridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(190, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "COURSE DETAILS";
            // 
            // couname
            // 
            this.couname.Location = new System.Drawing.Point(169, 92);
            this.couname.Name = "couname";
            this.couname.Size = new System.Drawing.Size(100, 20);
            this.couname.TabIndex = 3;
            // 
            // coursegridview
            // 
            this.coursegridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coursegridview.Location = new System.Drawing.Point(24, 270);
            this.coursegridview.Name = "coursegridview";
            this.coursegridview.Size = new System.Drawing.Size(504, 168);
            this.coursegridview.TabIndex = 5;
            this.coursegridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.coursegridview.SelectionChanged += new System.EventHandler(this.coursegridview_SelectionChanged_1);
            // 
            // coubtnadd
            // 
            this.coubtnadd.Location = new System.Drawing.Point(230, 215);
            this.coubtnadd.Name = "coubtnadd";
            this.coubtnadd.Size = new System.Drawing.Size(75, 23);
            this.coubtnadd.TabIndex = 6;
            this.coubtnadd.Text = "ADD";
            this.coubtnadd.UseVisualStyleBackColor = true;
            this.coubtnadd.Click += new System.EventHandler(this.coubtnadd_Click);
            // 
            // coubtndelete
            // 
            this.coubtndelete.Location = new System.Drawing.Point(126, 215);
            this.coubtndelete.Name = "coubtndelete";
            this.coubtndelete.Size = new System.Drawing.Size(75, 23);
            this.coubtndelete.TabIndex = 7;
            this.coubtndelete.Text = "DELETE";
            this.coubtndelete.UseVisualStyleBackColor = true;
            this.coubtndelete.Click += new System.EventHandler(this.coubtndelete_Click);
            // 
            // coubtnupdate
            // 
            this.coubtnupdate.Location = new System.Drawing.Point(34, 215);
            this.coubtnupdate.Name = "coubtnupdate";
            this.coubtnupdate.Size = new System.Drawing.Size(75, 23);
            this.coubtnupdate.TabIndex = 8;
            this.coubtnupdate.Text = "UPDATE";
            this.coubtnupdate.UseVisualStyleBackColor = true;
            this.coubtnupdate.Click += new System.EventHandler(this.coubtnupdate_Click);
            // 
            // back
            // 
            this.back.Location = new System.Drawing.Point(561, 399);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(75, 23);
            this.back.TabIndex = 9;
            this.back.Text = "Back";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Courseform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.coubtnupdate);
            this.Controls.Add(this.coubtndelete);
            this.Controls.Add(this.coubtnadd);
            this.Controls.Add(this.coursegridview);
            this.Controls.Add(this.couname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Courseform";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.coursegridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox couname;
        private System.Windows.Forms.DataGridView coursegridview;
        private System.Windows.Forms.Button coubtnadd;
        private System.Windows.Forms.Button coubtndelete;
        private System.Windows.Forms.Button coubtnupdate;
        private Button back;
    }
}