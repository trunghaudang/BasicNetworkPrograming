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
            this.lb_SoA = new System.Windows.Forms.Label();
            this.lbl_SoB = new System.Windows.Forms.Label();
            this.txtb_SoA = new System.Windows.Forms.TextBox();
            this.txtb_SoB = new System.Windows.Forms.TextBox();
            this.btn_Tinhtoan = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.Grb_Ketqua = new System.Windows.Forms.GroupBox();
            this.txtb_S3 = new System.Windows.Forms.TextBox();
            this.txtb_S2 = new System.Windows.Forms.TextBox();
            this.txtb_S1 = new System.Windows.Forms.TextBox();
            this.txtb_B_gt = new System.Windows.Forms.TextBox();
            this.txtb_A_gt = new System.Windows.Forms.TextBox();
            this.lb_S3 = new System.Windows.Forms.Label();
            this.lb_S2 = new System.Windows.Forms.Label();
            this.lb_S1 = new System.Windows.Forms.Label();
            this.lb_B_Gt = new System.Windows.Forms.Label();
            this.lb_A_gt = new System.Windows.Forms.Label();
            this.Grb_Ketqua.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_SoA
            // 
            this.lb_SoA.AutoSize = true;
            this.lb_SoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoA.Location = new System.Drawing.Point(49, 50);
            this.lb_SoA.Name = "lb_SoA";
            this.lb_SoA.Size = new System.Drawing.Size(140, 29);
            this.lb_SoA.TabIndex = 0;
            this.lb_SoA.Text = "Nhập Số A: ";
            // 
            // lbl_SoB
            // 
            this.lbl_SoB.AutoSize = true;
            this.lbl_SoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SoB.Location = new System.Drawing.Point(608, 50);
            this.lbl_SoB.Name = "lbl_SoB";
            this.lbl_SoB.Size = new System.Drawing.Size(141, 29);
            this.lbl_SoB.TabIndex = 1;
            this.lbl_SoB.Text = "Nhập Số B: ";
            // 
            // txtb_SoA
            // 
            this.txtb_SoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_SoA.Location = new System.Drawing.Point(200, 50);
            this.txtb_SoA.Name = "txtb_SoA";
            this.txtb_SoA.Size = new System.Drawing.Size(245, 28);
            this.txtb_SoA.TabIndex = 2;
            this.txtb_SoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtb_SoB
            // 
            this.txtb_SoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_SoB.Location = new System.Drawing.Point(771, 50);
            this.txtb_SoB.Name = "txtb_SoB";
            this.txtb_SoB.Size = new System.Drawing.Size(245, 28);
            this.txtb_SoB.TabIndex = 3;
            this.txtb_SoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Tinhtoan
            // 
            this.btn_Tinhtoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tinhtoan.Location = new System.Drawing.Point(54, 148);
            this.btn_Tinhtoan.Name = "btn_Tinhtoan";
            this.btn_Tinhtoan.Size = new System.Drawing.Size(391, 47);
            this.btn_Tinhtoan.TabIndex = 4;
            this.btn_Tinhtoan.Text = "Tính các giá trị";
            this.btn_Tinhtoan.UseVisualStyleBackColor = true;
            this.btn_Tinhtoan.Click += new System.EventHandler(this.btn_Tinhtoan_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(710, 148);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(122, 44);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa ";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(918, 148);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(122, 44);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Grb_Ketqua
            // 
            this.Grb_Ketqua.Controls.Add(this.txtb_S3);
            this.Grb_Ketqua.Controls.Add(this.txtb_S2);
            this.Grb_Ketqua.Controls.Add(this.txtb_S1);
            this.Grb_Ketqua.Controls.Add(this.txtb_B_gt);
            this.Grb_Ketqua.Controls.Add(this.txtb_A_gt);
            this.Grb_Ketqua.Controls.Add(this.lb_S3);
            this.Grb_Ketqua.Controls.Add(this.lb_S2);
            this.Grb_Ketqua.Controls.Add(this.lb_S1);
            this.Grb_Ketqua.Controls.Add(this.lb_B_Gt);
            this.Grb_Ketqua.Controls.Add(this.lb_A_gt);
            this.Grb_Ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grb_Ketqua.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Grb_Ketqua.Location = new System.Drawing.Point(28, 219);
            this.Grb_Ketqua.Name = "Grb_Ketqua";
            this.Grb_Ketqua.Size = new System.Drawing.Size(1055, 316);
            this.Grb_Ketqua.TabIndex = 7;
            this.Grb_Ketqua.TabStop = false;
            this.Grb_Ketqua.Text = "KẾT QUẢ:";
            // 
            // txtb_S3
            // 
            this.txtb_S3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtb_S3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtb_S3.Location = new System.Drawing.Point(615, 246);
            this.txtb_S3.Name = "txtb_S3";
            this.txtb_S3.ReadOnly = true;
            this.txtb_S3.Size = new System.Drawing.Size(355, 39);
            this.txtb_S3.TabIndex = 9;
            this.txtb_S3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtb_S2
            // 
            this.txtb_S2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtb_S2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtb_S2.Location = new System.Drawing.Point(465, 182);
            this.txtb_S2.Name = "txtb_S2";
            this.txtb_S2.ReadOnly = true;
            this.txtb_S2.Size = new System.Drawing.Size(398, 39);
            this.txtb_S2.TabIndex = 8;
            this.txtb_S2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtb_S1
            // 
            this.txtb_S1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtb_S1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtb_S1.Location = new System.Drawing.Point(465, 120);
            this.txtb_S1.Name = "txtb_S1";
            this.txtb_S1.ReadOnly = true;
            this.txtb_S1.Size = new System.Drawing.Size(398, 39);
            this.txtb_S1.TabIndex = 7;
            this.txtb_S1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtb_B_gt
            // 
            this.txtb_B_gt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtb_B_gt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtb_B_gt.Location = new System.Drawing.Point(615, 52);
            this.txtb_B_gt.Name = "txtb_B_gt";
            this.txtb_B_gt.ReadOnly = true;
            this.txtb_B_gt.Size = new System.Drawing.Size(248, 39);
            this.txtb_B_gt.TabIndex = 6;
            this.txtb_B_gt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtb_A_gt
            // 
            this.txtb_A_gt.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtb_A_gt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.txtb_A_gt.Location = new System.Drawing.Point(115, 52);
            this.txtb_A_gt.Name = "txtb_A_gt";
            this.txtb_A_gt.ReadOnly = true;
            this.txtb_A_gt.Size = new System.Drawing.Size(248, 39);
            this.txtb_A_gt.TabIndex = 5;
            this.txtb_A_gt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_S3
            // 
            this.lb_S3.AutoSize = true;
            this.lb_S3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_S3.Location = new System.Drawing.Point(43, 253);
            this.lb_S3.Name = "lb_S3";
            this.lb_S3.Size = new System.Drawing.Size(551, 32);
            this.lb_S3.TabIndex = 4;
            this.lb_S3.Text = "S3 = A^1 + A^2 + A^3 + A^4 +...+ A^B = ";
            // 
            // lb_S2
            // 
            this.lb_S2.AutoSize = true;
            this.lb_S2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_S2.Location = new System.Drawing.Point(43, 189);
            this.lb_S2.Name = "lb_S2";
            this.lb_S2.Size = new System.Drawing.Size(373, 32);
            this.lb_S2.TabIndex = 3;
            this.lb_S2.Text = "S2 = 1 + 2 + 3 + 4 +...+ B =";
            // 
            // lb_S1
            // 
            this.lb_S1.AutoSize = true;
            this.lb_S1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_S1.Location = new System.Drawing.Point(43, 123);
            this.lb_S1.Name = "lb_S1";
            this.lb_S1.Size = new System.Drawing.Size(373, 32);
            this.lb_S1.TabIndex = 2;
            this.lb_S1.Text = "S1 = 1 + 2 + 3 + 4 +...+ A =";
            // 
            // lb_B_Gt
            // 
            this.lb_B_Gt.AutoSize = true;
            this.lb_B_Gt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_B_Gt.Location = new System.Drawing.Point(533, 60);
            this.lb_B_Gt.Name = "lb_B_Gt";
            this.lb_B_Gt.Size = new System.Drawing.Size(76, 32);
            this.lb_B_Gt.TabIndex = 1;
            this.lb_B_Gt.Text = "B! = ";
            // 
            // lb_A_gt
            // 
            this.lb_A_gt.AutoSize = true;
            this.lb_A_gt.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lb_A_gt.Location = new System.Drawing.Point(43, 60);
            this.lb_A_gt.Name = "lb_A_gt";
            this.lb_A_gt.Size = new System.Drawing.Size(76, 32);
            this.lb_A_gt.TabIndex = 0;
            this.lb_A_gt.Text = "A! = ";
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 572);
            this.Controls.Add(this.Grb_Ketqua);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Tinhtoan);
            this.Controls.Add(this.txtb_SoB);
            this.Controls.Add(this.txtb_SoA);
            this.Controls.Add(this.lbl_SoB);
            this.Controls.Add(this.lb_SoA);
            this.Name = "Bai5";
            this.Text = "Tính giai thừa ";
            this.Grb_Ketqua.ResumeLayout(false);
            this.Grb_Ketqua.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_SoA;
        private System.Windows.Forms.Label lbl_SoB;
        private System.Windows.Forms.TextBox txtb_SoA;
        private System.Windows.Forms.TextBox txtb_SoB;
        private System.Windows.Forms.Button btn_Tinhtoan;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.GroupBox Grb_Ketqua;
        private System.Windows.Forms.Label lb_S3;
        private System.Windows.Forms.Label lb_S2;
        private System.Windows.Forms.Label lb_S1;
        private System.Windows.Forms.Label lb_B_Gt;
        private System.Windows.Forms.Label lb_A_gt;
        private System.Windows.Forms.TextBox txtb_B_gt;
        private System.Windows.Forms.TextBox txtb_A_gt;
        private System.Windows.Forms.TextBox txtb_S3;
        private System.Windows.Forms.TextBox txtb_S2;
        private System.Windows.Forms.TextBox txtb_S1;
    }
}