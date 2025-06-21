namespace UNICOMTIC_MANAGEMENT.View
{
    partial class RoomForm
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
            this.RoomView = new System.Windows.Forms.DataGridView();
            this.RoomAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.roomname = new System.Windows.Forms.TextBox();
            this.roomtype = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.RoomView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Type";
            // 
            // RoomView
            // 
            this.RoomView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoomView.Location = new System.Drawing.Point(401, 215);
            this.RoomView.Name = "RoomView";
            this.RoomView.Size = new System.Drawing.Size(240, 150);
            this.RoomView.TabIndex = 2;
            this.RoomView.SelectionChanged += new System.EventHandler(this.RoomView_SelectionChanged);
            // 
            // RoomAdd
            // 
            this.RoomAdd.Location = new System.Drawing.Point(252, 215);
            this.RoomAdd.Name = "RoomAdd";
            this.RoomAdd.Size = new System.Drawing.Size(75, 23);
            this.RoomAdd.TabIndex = 3;
            this.RoomAdd.Text = "Add";
            this.RoomAdd.UseVisualStyleBackColor = true;
            this.RoomAdd.Click += new System.EventHandler(this.RoomAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Room Name";
            // 
            // roomname
            // 
            this.roomname.Location = new System.Drawing.Point(237, 168);
            this.roomname.Name = "roomname";
            this.roomname.Size = new System.Drawing.Size(100, 20);
            this.roomname.TabIndex = 5;
            // 
            // roomtype
            // 
            this.roomtype.FormattingEnabled = true;
            this.roomtype.Location = new System.Drawing.Point(252, 125);
            this.roomtype.Name = "roomtype";
            this.roomtype.Size = new System.Drawing.Size(121, 21);
            this.roomtype.TabIndex = 6;
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roomtype);
            this.Controls.Add(this.roomname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomAdd);
            this.Controls.Add(this.RoomView);
            this.Controls.Add(this.label1);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RoomView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView RoomView;
        private System.Windows.Forms.Button RoomAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox roomname;
        private System.Windows.Forms.ComboBox roomtype;
    }
}