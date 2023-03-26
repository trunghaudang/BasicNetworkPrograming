namespace Menu
{
    partial class Bai4
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
            this.lb_Sotien = new System.Windows.Forms.Label();
            this.txtb_Sotien = new System.Windows.Forms.TextBox();
            this.cbo_Donvitien = new System.Windows.Forms.ComboBox();
            this.lb_Tiendadoi = new System.Windows.Forms.Label();
            this.txtb_Tiendadoi = new System.Windows.Forms.TextBox();
            this.lb_tygiaquydoi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Chuyendoi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_chitietquydoi = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Sotien
            // 
            this.lb_Sotien.AutoSize = true;
            this.lb_Sotien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sotien.Location = new System.Drawing.Point(27, 77);
            this.lb_Sotien.Name = "lb_Sotien";
            this.lb_Sotien.Size = new System.Drawing.Size(178, 29);
            this.lb_Sotien.TabIndex = 0;
            this.lb_Sotien.Text = "Số tiền cần đổi:";
            this.lb_Sotien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_Sotien
            // 
            this.txtb_Sotien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Sotien.Location = new System.Drawing.Point(225, 71);
            this.txtb_Sotien.Name = "txtb_Sotien";
            this.txtb_Sotien.Size = new System.Drawing.Size(208, 35);
            this.txtb_Sotien.TabIndex = 1;
            // 
            // cbo_Donvitien
            // 
            this.cbo_Donvitien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Donvitien.FormattingEnabled = true;
            this.cbo_Donvitien.Items.AddRange(new object[] {
            "USD (Đô-la Mỹ)",
            "EUR",
            "GBP",
            "SGD",
            "JPY"});
            this.cbo_Donvitien.Location = new System.Drawing.Point(439, 71);
            this.cbo_Donvitien.Name = "cbo_Donvitien";
            this.cbo_Donvitien.Size = new System.Drawing.Size(208, 37);
            this.cbo_Donvitien.TabIndex = 2;
            // 
            // lb_Tiendadoi
            // 
            this.lb_Tiendadoi.AutoSize = true;
            this.lb_Tiendadoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tiendadoi.Location = new System.Drawing.Point(27, 279);
            this.lb_Tiendadoi.Name = "lb_Tiendadoi";
            this.lb_Tiendadoi.Size = new System.Drawing.Size(167, 29);
            this.lb_Tiendadoi.TabIndex = 4;
            this.lb_Tiendadoi.Text = "Số tiền đã đổi:";
            // 
            // txtb_Tiendadoi
            // 
            this.txtb_Tiendadoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Tiendadoi.Location = new System.Drawing.Point(225, 273);
            this.txtb_Tiendadoi.Name = "txtb_Tiendadoi";
            this.txtb_Tiendadoi.ReadOnly = true;
            this.txtb_Tiendadoi.Size = new System.Drawing.Size(292, 35);
            this.txtb_Tiendadoi.TabIndex = 5;
            this.txtb_Tiendadoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_tygiaquydoi
            // 
            this.lb_tygiaquydoi.AutoSize = true;
            this.lb_tygiaquydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tygiaquydoi.Location = new System.Drawing.Point(27, 366);
            this.lb_tygiaquydoi.Name = "lb_tygiaquydoi";
            this.lb_tygiaquydoi.Size = new System.Drawing.Size(169, 29);
            this.lb_tygiaquydoi.TabIndex = 6;
            this.lb_tygiaquydoi.Text = "Tỷ giá quy đổi:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 12;
            // 
            // btn_Chuyendoi
            // 
            this.btn_Chuyendoi.AutoSize = true;
            this.btn_Chuyendoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chuyendoi.Location = new System.Drawing.Point(32, 185);
            this.btn_Chuyendoi.Name = "btn_Chuyendoi";
            this.btn_Chuyendoi.Size = new System.Drawing.Size(401, 39);
            this.btn_Chuyendoi.TabIndex = 8;
            this.btn_Chuyendoi.Text = "Chuyển Đổi";
            this.btn_Chuyendoi.UseVisualStyleBackColor = true;
            this.btn_Chuyendoi.Click += new System.EventHandler(this.btn_Chuyendoi_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 11;
            // 
            // txtb_chitietquydoi
            // 
            this.txtb_chitietquydoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_chitietquydoi.Location = new System.Drawing.Point(225, 366);
            this.txtb_chitietquydoi.Name = "txtb_chitietquydoi";
            this.txtb_chitietquydoi.ReadOnly = true;
            this.txtb_chitietquydoi.Size = new System.Drawing.Size(292, 35);
            this.txtb_chitietquydoi.TabIndex = 10;
            this.txtb_chitietquydoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_thoat
            // 
            this.btn_thoat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(650, 367);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(95, 41);
            this.btn_thoat.TabIndex = 13;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = false;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.txtb_chitietquydoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Chuyendoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_tygiaquydoi);
            this.Controls.Add(this.txtb_Tiendadoi);
            this.Controls.Add(this.lb_Tiendadoi);
            this.Controls.Add(this.cbo_Donvitien);
            this.Controls.Add(this.txtb_Sotien);
            this.Controls.Add(this.lb_Sotien);
            this.Name = "Bai4";
            this.Text = "Đổi tiền";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Sotien;
        private System.Windows.Forms.TextBox txtb_Sotien;
        private System.Windows.Forms.ComboBox cbo_Donvitien;
        private System.Windows.Forms.Label lb_Tiendadoi;
        private System.Windows.Forms.TextBox txtb_Tiendadoi;
        private System.Windows.Forms.Label lb_tygiaquydoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Chuyendoi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_chitietquydoi;
        private System.Windows.Forms.Button btn_thoat;
    }
}