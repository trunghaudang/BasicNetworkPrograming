namespace Menu
{
    partial class Bai1
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
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.richTextBox_view = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(67, 54);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(166, 58);
            this.btn_read.TabIndex = 0;
            this.btn_read.Text = "Đọc file";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(67, 318);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(166, 58);
            this.btn_write.TabIndex = 1;
            this.btn_write.Text = "Ghi file";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // richTextBox_view
            // 
            this.richTextBox_view.Location = new System.Drawing.Point(339, 1);
            this.richTextBox_view.Name = "richTextBox_view";
            this.richTextBox_view.Size = new System.Drawing.Size(728, 449);
            this.richTextBox_view.TabIndex = 2;
            this.richTextBox_view.Text = "";
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 450);
            this.Controls.Add(this.richTextBox_view);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_read);
            this.Name = "Bai1";
            this.Text = "Bài 1: Đọc - ghi file ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.RichTextBox richTextBox_view;
    }
}