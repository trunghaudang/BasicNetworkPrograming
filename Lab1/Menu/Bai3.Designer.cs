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
            this.lb_Nhapso = new System.Windows.Forms.Label();
            this.txtb_Nhap = new System.Windows.Forms.TextBox();
            this.txtb_Ketqua = new System.Windows.Forms.TextBox();
            this.lb_ketqua = new System.Windows.Forms.Label();
            this.btn_Doc = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Nhapso
            // 
            this.lb_Nhapso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Nhapso.Location = new System.Drawing.Point(12, 32);
            this.lb_Nhapso.Name = "lb_Nhapso";
            this.lb_Nhapso.Size = new System.Drawing.Size(341, 44);
            this.lb_Nhapso.TabIndex = 0;
            this.lb_Nhapso.Text = "Nhập vào số nguyên từ 0 đến 9: ";
            this.lb_Nhapso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtb_Nhap
            // 
            this.txtb_Nhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Nhap.Location = new System.Drawing.Point(344, 38);
            this.txtb_Nhap.Name = "txtb_Nhap";
            this.txtb_Nhap.Size = new System.Drawing.Size(189, 32);
            this.txtb_Nhap.TabIndex = 1;
            this.txtb_Nhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtb_Ketqua
            // 
            this.txtb_Ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Ketqua.Location = new System.Drawing.Point(17, 195);
            this.txtb_Ketqua.Name = "txtb_Ketqua";
            this.txtb_Ketqua.ReadOnly = true;
            this.txtb_Ketqua.Size = new System.Drawing.Size(251, 32);
            this.txtb_Ketqua.TabIndex = 2;
            this.txtb_Ketqua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_ketqua
            // 
            this.lb_ketqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ketqua.Location = new System.Drawing.Point(12, 139);
            this.lb_ketqua.Name = "lb_ketqua";
            this.lb_ketqua.Size = new System.Drawing.Size(107, 28);
            this.lb_ketqua.TabIndex = 3;
            this.lb_ketqua.Text = "Kết quả:";
            this.lb_ketqua.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_Doc
            // 
            this.btn_Doc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Doc.Location = new System.Drawing.Point(644, 44);
            this.btn_Doc.Name = "btn_Doc";
            this.btn_Doc.Size = new System.Drawing.Size(97, 65);
            this.btn_Doc.TabIndex = 4;
            this.btn_Doc.Text = "Đọc ";
            this.btn_Doc.UseVisualStyleBackColor = true;
            this.btn_Doc.Click += new System.EventHandler(this.btn_Doc_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(644, 144);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(97, 65);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(644, 240);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(97, 65);
            this.btn_Thoat.TabIndex = 6;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 351);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Doc);
            this.Controls.Add(this.lb_ketqua);
            this.Controls.Add(this.txtb_Ketqua);
            this.Controls.Add(this.txtb_Nhap);
            this.Controls.Add(this.lb_Nhapso);
            this.Name = "Bai3";
            this.Text = "Đọc số";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nhapso;
        private System.Windows.Forms.TextBox txtb_Nhap;
        private System.Windows.Forms.TextBox txtb_Ketqua;
        private System.Windows.Forms.Label lb_ketqua;
        private System.Windows.Forms.Button btn_Doc;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
    }
}