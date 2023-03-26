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
            this.txtb_Sothunhat = new System.Windows.Forms.TextBox();
            this.txtb_Sothuhai = new System.Windows.Forms.TextBox();
            this.lb_Sothunhat = new System.Windows.Forms.Label();
            this.lb_Sothuhai = new System.Windows.Forms.Label();
            this.txtb_Ketqua = new System.Windows.Forms.TextBox();
            this.lb_Ketqua = new System.Windows.Forms.Label();
            this.btn_Tinh = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtb_Sothunhat
            // 
            this.txtb_Sothunhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Sothunhat.Location = new System.Drawing.Point(299, 75);
            this.txtb_Sothunhat.Name = "txtb_Sothunhat";
            this.txtb_Sothunhat.Size = new System.Drawing.Size(310, 30);
            this.txtb_Sothunhat.TabIndex = 0;
            this.txtb_Sothunhat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtb_Sothuhai
            // 
            this.txtb_Sothuhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Sothuhai.Location = new System.Drawing.Point(299, 181);
            this.txtb_Sothuhai.Name = "txtb_Sothuhai";
            this.txtb_Sothuhai.Size = new System.Drawing.Size(310, 30);
            this.txtb_Sothuhai.TabIndex = 1;
            this.txtb_Sothuhai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Sothunhat
            // 
            this.lb_Sothunhat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Sothunhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sothunhat.Location = new System.Drawing.Point(83, 73);
            this.lb_Sothunhat.Name = "lb_Sothunhat";
            this.lb_Sothunhat.Size = new System.Drawing.Size(145, 35);
            this.lb_Sothunhat.TabIndex = 2;
            this.lb_Sothunhat.Text = "Số thứ nhất: ";
            this.lb_Sothunhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Sothuhai
            // 
            this.lb_Sothuhai.AutoSize = true;
            this.lb_Sothuhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sothuhai.Location = new System.Drawing.Point(83, 183);
            this.lb_Sothuhai.Name = "lb_Sothuhai";
            this.lb_Sothuhai.Size = new System.Drawing.Size(122, 26);
            this.lb_Sothuhai.TabIndex = 3;
            this.lb_Sothuhai.Text = "Số thứ hai: ";
            // 
            // txtb_Ketqua
            // 
            this.txtb_Ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Ketqua.Location = new System.Drawing.Point(299, 276);
            this.txtb_Ketqua.Name = "txtb_Ketqua";
            this.txtb_Ketqua.ReadOnly = true;
            this.txtb_Ketqua.Size = new System.Drawing.Size(310, 30);
            this.txtb_Ketqua.TabIndex = 4;
            this.txtb_Ketqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Ketqua
            // 
            this.lb_Ketqua.AutoSize = true;
            this.lb_Ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Ketqua.Location = new System.Drawing.Point(83, 278);
            this.lb_Ketqua.Name = "lb_Ketqua";
            this.lb_Ketqua.Size = new System.Drawing.Size(99, 26);
            this.lb_Ketqua.TabIndex = 5;
            this.lb_Ketqua.Text = "Kết quả: ";
            // 
            // btn_Tinh
            // 
            this.btn_Tinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tinh.Location = new System.Drawing.Point(253, 356);
            this.btn_Tinh.Name = "btn_Tinh";
            this.btn_Tinh.Size = new System.Drawing.Size(97, 39);
            this.btn_Tinh.TabIndex = 6;
            this.btn_Tinh.Text = "Tính";
            this.btn_Tinh.UseVisualStyleBackColor = true;
            this.btn_Tinh.Click += new System.EventHandler(this.btn_Tinh_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(414, 356);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(97, 39);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(575, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Tinh);
            this.Controls.Add(this.lb_Ketqua);
            this.Controls.Add(this.txtb_Ketqua);
            this.Controls.Add(this.lb_Sothuhai);
            this.Controls.Add(this.lb_Sothunhat);
            this.Controls.Add(this.txtb_Sothuhai);
            this.Controls.Add(this.txtb_Sothunhat);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Bai1";
            this.Text = "Tính tổng hai số nguyên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtb_Sothunhat;
        private System.Windows.Forms.TextBox txtb_Sothuhai;
        private System.Windows.Forms.Label lb_Sothunhat;
        private System.Windows.Forms.Label lb_Sothuhai;
        private System.Windows.Forms.TextBox txtb_Ketqua;
        private System.Windows.Forms.Label lb_Ketqua;
        private System.Windows.Forms.Button btn_Tinh;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Button button1;
    }
}