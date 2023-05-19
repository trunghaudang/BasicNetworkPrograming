namespace Menu
{
    partial class Menu
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
            this.button1 = new System.Windows.Forms.Button();
            this.Bai2 = new System.Windows.Forms.Button();
            this.Bai3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Bai5 = new System.Windows.Forms.Button();
            this.Bai6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 54);
            this.button1.TabIndex = 0;
            this.button1.Text = "Bài 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai2
            // 
            this.Bai2.Location = new System.Drawing.Point(481, 60);
            this.Bai2.Name = "Bai2";
            this.Bai2.Size = new System.Drawing.Size(136, 54);
            this.Bai2.TabIndex = 1;
            this.Bai2.Text = "Bài 2";
            this.Bai2.UseVisualStyleBackColor = true;
            this.Bai2.Click += new System.EventHandler(this.Bai2_Click);
            // 
            // Bai3
            // 
            this.Bai3.Location = new System.Drawing.Point(120, 170);
            this.Bai3.Name = "Bai3";
            this.Bai3.Size = new System.Drawing.Size(136, 54);
            this.Bai3.TabIndex = 2;
            this.Bai3.Text = "Bài 3";
            this.Bai3.UseVisualStyleBackColor = true;
            this.Bai3.Click += new System.EventHandler(this.Bai3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(481, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Bài 4";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Bai5
            // 
            this.Bai5.Location = new System.Drawing.Point(120, 299);
            this.Bai5.Name = "Bai5";
            this.Bai5.Size = new System.Drawing.Size(136, 54);
            this.Bai5.TabIndex = 4;
            this.Bai5.Text = "Bài 5";
            this.Bai5.UseVisualStyleBackColor = true;
            this.Bai5.Click += new System.EventHandler(this.Bai5_Click);
            // 
            // Bai6
            // 
            this.Bai6.Location = new System.Drawing.Point(481, 299);
            this.Bai6.Name = "Bai6";
            this.Bai6.Size = new System.Drawing.Size(136, 54);
            this.Bai6.TabIndex = 5;
            this.Bai6.Text = "Bài 6";
            this.Bai6.UseVisualStyleBackColor = true;
            this.Bai6.Click += new System.EventHandler(this.Bai6_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bai6);
            this.Controls.Add(this.Bai5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Bai3);
            this.Controls.Add(this.Bai2);
            this.Controls.Add(this.button1);
            this.Name = "Menu";
            this.Text = "Menu ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bai2;
        private System.Windows.Forms.Button Bai3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Bai5;
        private System.Windows.Forms.Button Bai6;
    }
}

