namespace UNICOMTIC_MANAGEMENT.View
{
    partial class LecuterDetails
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
            this.dettalis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dettalis)).BeginInit();
            this.SuspendLayout();
            // 
            // dettalis
            // 
            this.dettalis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dettalis.Location = new System.Drawing.Point(12, 123);
            this.dettalis.Name = "dettalis";
            this.dettalis.Size = new System.Drawing.Size(658, 150);
            this.dettalis.TabIndex = 0;
            this.dettalis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dettalis_CellContentClick);
            // 
            // LecuterDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 333);
            this.Controls.Add(this.dettalis);
            this.Name = "LecuterDetails";
            this.Text = "LecuterDetails";
            this.Load += new System.EventHandler(this.LecuterDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dettalis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dettalis;
    }
}