namespace Menu
{
    partial class Bai5
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
            this.btn_zip = new System.Windows.Forms.Button();
            this.btn_extract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_zip
            // 
            this.btn_zip.Location = new System.Drawing.Point(348, 77);
            this.btn_zip.Name = "btn_zip";
            this.btn_zip.Size = new System.Drawing.Size(265, 47);
            this.btn_zip.TabIndex = 0;
            this.btn_zip.Text = "Chọn file nén";
            this.btn_zip.UseVisualStyleBackColor = true;
            this.btn_zip.Click += new System.EventHandler(this.btn_zip_Click);
            // 
            // btn_extract
            // 
            this.btn_extract.Location = new System.Drawing.Point(348, 254);
            this.btn_extract.Name = "btn_extract";
            this.btn_extract.Size = new System.Drawing.Size(265, 47);
            this.btn_extract.TabIndex = 1;
            this.btn_extract.Text = "Chọn file giải nén";
            this.btn_extract.UseVisualStyleBackColor = true;
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.btn_extract);
            this.Controls.Add(this.btn_zip);
            this.Name = "Bai5";
            this.Text = "Bài 5: Nén và giải nén file ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_zip;
        private System.Windows.Forms.Button btn_extract;
    }
}