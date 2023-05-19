namespace Menu
{
    partial class Bai3
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
            this.rtxt_content = new System.Windows.Forms.RichTextBox();
            this.rtxt_result = new System.Windows.Forms.RichTextBox();
            this.label_content = new System.Windows.Forms.Label();
            this.label_result = new System.Windows.Forms.Label();
            this.btn_read = new System.Windows.Forms.Button();
            this.btn_write = new System.Windows.Forms.Button();
            this.btn_cal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtxt_content
            // 
            this.rtxt_content.Location = new System.Drawing.Point(44, 79);
            this.rtxt_content.Name = "rtxt_content";
            this.rtxt_content.Size = new System.Drawing.Size(454, 349);
            this.rtxt_content.TabIndex = 0;
            this.rtxt_content.Text = "";
            // 
            // rtxt_result
            // 
            this.rtxt_result.Location = new System.Drawing.Point(641, 79);
            this.rtxt_result.Name = "rtxt_result";
            this.rtxt_result.Size = new System.Drawing.Size(454, 349);
            this.rtxt_result.TabIndex = 1;
            this.rtxt_result.Text = "";
            // 
            // label_content
            // 
            this.label_content.AutoSize = true;
            this.label_content.Location = new System.Drawing.Point(211, 27);
            this.label_content.Name = "label_content";
            this.label_content.Size = new System.Drawing.Size(92, 20);
            this.label_content.TabIndex = 2;
            this.label_content.Text = "File content";
            // 
            // label_result
            // 
            this.label_result.AutoSize = true;
            this.label_result.Location = new System.Drawing.Point(833, 37);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(55, 20);
            this.label_result.TabIndex = 3;
            this.label_result.Text = "Result";
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(160, 460);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(178, 35);
            this.btn_read.TabIndex = 4;
            this.btn_read.Text = "Read file ";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click_1);
            // 
            // btn_write
            // 
            this.btn_write.Location = new System.Drawing.Point(837, 460);
            this.btn_write.Name = "btn_write";
            this.btn_write.Size = new System.Drawing.Size(178, 35);
            this.btn_write.TabIndex = 5;
            this.btn_write.Text = "Write into file ";
            this.btn_write.UseVisualStyleBackColor = true;
            this.btn_write.Click += new System.EventHandler(this.btn_write_Click);
            // 
            // btn_cal
            // 
            this.btn_cal.Location = new System.Drawing.Point(478, 460);
            this.btn_cal.Name = "btn_cal";
            this.btn_cal.Size = new System.Drawing.Size(178, 35);
            this.btn_cal.TabIndex = 6;
            this.btn_cal.Text = "Calculate";
            this.btn_cal.UseVisualStyleBackColor = true;
            this.btn_cal.Click += new System.EventHandler(this.btn_cal_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 528);
            this.Controls.Add(this.btn_cal);
            this.Controls.Add(this.btn_write);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.label_content);
            this.Controls.Add(this.rtxt_result);
            this.Controls.Add(this.rtxt_content);
            this.Name = "Bai3";
            this.Text = "Bài 3: Đọc - ghi file và tính toán";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtxt_content;
        private System.Windows.Forms.RichTextBox rtxt_result;
        private System.Windows.Forms.Label label_content;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Button btn_write;
        private System.Windows.Forms.Button btn_cal;
    }
}