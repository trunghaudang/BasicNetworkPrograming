namespace Menu
{
    partial class Bai2
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
            this.richTextBox_view = new System.Windows.Forms.RichTextBox();
            this.btn_read = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label_size = new System.Windows.Forms.Label();
            this.label_URL = new System.Windows.Forms.Label();
            this.label_line = new System.Windows.Forms.Label();
            this.label_word = new System.Windows.Forms.Label();
            this.label_char = new System.Windows.Forms.Label();
            this.richTextBox_filename = new System.Windows.Forms.RichTextBox();
            this.richTextBox_size = new System.Windows.Forms.RichTextBox();
            this.richTextBox_URL = new System.Windows.Forms.RichTextBox();
            this.richTextBox_line = new System.Windows.Forms.RichTextBox();
            this.richTextBox_word = new System.Windows.Forms.RichTextBox();
            this.richTextBox_char = new System.Windows.Forms.RichTextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox_view
            // 
            this.richTextBox_view.Location = new System.Drawing.Point(512, 4);
            this.richTextBox_view.Name = "richTextBox_view";
            this.richTextBox_view.Size = new System.Drawing.Size(609, 502);
            this.richTextBox_view.TabIndex = 0;
            this.richTextBox_view.Text = "";
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(167, 21);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(125, 47);
            this.btn_read.TabIndex = 1;
            this.btn_read.Text = "Read from file";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(12, 101);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(82, 20);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "File name ";
            // 
            // label_size
            // 
            this.label_size.AutoSize = true;
            this.label_size.Location = new System.Drawing.Point(12, 155);
            this.label_size.Name = "label_size";
            this.label_size.Size = new System.Drawing.Size(40, 20);
            this.label_size.TabIndex = 3;
            this.label_size.Text = "Size";
            // 
            // label_URL
            // 
            this.label_URL.AutoSize = true;
            this.label_URL.Location = new System.Drawing.Point(12, 208);
            this.label_URL.Name = "label_URL";
            this.label_URL.Size = new System.Drawing.Size(42, 20);
            this.label_URL.TabIndex = 4;
            this.label_URL.Text = "URL";
            // 
            // label_line
            // 
            this.label_line.AutoSize = true;
            this.label_line.Location = new System.Drawing.Point(12, 256);
            this.label_line.Name = "label_line";
            this.label_line.Size = new System.Drawing.Size(87, 20);
            this.label_line.TabIndex = 5;
            this.label_line.Text = "Line count ";
            // 
            // label_word
            // 
            this.label_word.AutoSize = true;
            this.label_word.Location = new System.Drawing.Point(12, 305);
            this.label_word.Name = "label_word";
            this.label_word.Size = new System.Drawing.Size(103, 20);
            this.label_word.TabIndex = 6;
            this.label_word.Text = "Words count ";
            // 
            // label_char
            // 
            this.label_char.AutoSize = true;
            this.label_char.Location = new System.Drawing.Point(12, 360);
            this.label_char.Name = "label_char";
            this.label_char.Size = new System.Drawing.Size(123, 20);
            this.label_char.TabIndex = 7;
            this.label_char.Text = "Character count";
            // 
            // richTextBox_filename
            // 
            this.richTextBox_filename.Location = new System.Drawing.Point(142, 92);
            this.richTextBox_filename.Name = "richTextBox_filename";
            this.richTextBox_filename.Size = new System.Drawing.Size(364, 29);
            this.richTextBox_filename.TabIndex = 8;
            this.richTextBox_filename.Text = "";
            // 
            // richTextBox_size
            // 
            this.richTextBox_size.Location = new System.Drawing.Point(142, 146);
            this.richTextBox_size.Name = "richTextBox_size";
            this.richTextBox_size.Size = new System.Drawing.Size(364, 29);
            this.richTextBox_size.TabIndex = 9;
            this.richTextBox_size.Text = "";
            // 
            // richTextBox_URL
            // 
            this.richTextBox_URL.Location = new System.Drawing.Point(142, 199);
            this.richTextBox_URL.Name = "richTextBox_URL";
            this.richTextBox_URL.Size = new System.Drawing.Size(364, 29);
            this.richTextBox_URL.TabIndex = 10;
            this.richTextBox_URL.Text = "";
            // 
            // richTextBox_line
            // 
            this.richTextBox_line.Location = new System.Drawing.Point(142, 247);
            this.richTextBox_line.Name = "richTextBox_line";
            this.richTextBox_line.Size = new System.Drawing.Size(364, 29);
            this.richTextBox_line.TabIndex = 11;
            this.richTextBox_line.Text = "";
            // 
            // richTextBox_word
            // 
            this.richTextBox_word.Location = new System.Drawing.Point(142, 302);
            this.richTextBox_word.Name = "richTextBox_word";
            this.richTextBox_word.Size = new System.Drawing.Size(364, 29);
            this.richTextBox_word.TabIndex = 12;
            this.richTextBox_word.Text = "";
            // 
            // richTextBox_char
            // 
            this.richTextBox_char.Location = new System.Drawing.Point(142, 360);
            this.richTextBox_char.Name = "richTextBox_char";
            this.richTextBox_char.Size = new System.Drawing.Size(364, 29);
            this.richTextBox_char.TabIndex = 13;
            this.richTextBox_char.Text = "";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(167, 435);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(125, 47);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 506);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.richTextBox_char);
            this.Controls.Add(this.richTextBox_word);
            this.Controls.Add(this.richTextBox_line);
            this.Controls.Add(this.richTextBox_URL);
            this.Controls.Add(this.richTextBox_size);
            this.Controls.Add(this.richTextBox_filename);
            this.Controls.Add(this.label_char);
            this.Controls.Add(this.label_word);
            this.Controls.Add(this.label_line);
            this.Controls.Add(this.label_URL);
            this.Controls.Add(this.label_size);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.richTextBox_view);
            this.Name = "Bai2";
            this.Text = "Bài 2: Đọc thông tin file ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_view;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label_size;
        private System.Windows.Forms.Label label_URL;
        private System.Windows.Forms.Label label_line;
        private System.Windows.Forms.Label label_word;
        private System.Windows.Forms.Label label_char;
        private System.Windows.Forms.RichTextBox richTextBox_filename;
        private System.Windows.Forms.RichTextBox richTextBox_size;
        private System.Windows.Forms.RichTextBox richTextBox_URL;
        private System.Windows.Forms.RichTextBox richTextBox_line;
        private System.Windows.Forms.RichTextBox richTextBox_word;
        private System.Windows.Forms.RichTextBox richTextBox_char;
        private System.Windows.Forms.Button btn_exit;
    }
}