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
            this.lb_Sothunhat = new System.Windows.Forms.Label();
            this.lb_Sothuhai = new System.Windows.Forms.Label();
            this.lb_Sothuba = new System.Windows.Forms.Label();
            this.txtb_Sothunhat = new System.Windows.Forms.TextBox();
            this.txtb_Sothuhai = new System.Windows.Forms.TextBox();
            this.txtb_Sothuba = new System.Windows.Forms.TextBox();
            this.btn_Tim = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.txtb_Max = new System.Windows.Forms.TextBox();
            this.txtb_Min = new System.Windows.Forms.TextBox();
            this.lb_Max = new System.Windows.Forms.Label();
            this.lb_Min = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_Sothunhat
            // 
            this.lb_Sothunhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sothunhat.Location = new System.Drawing.Point(37, 48);
            this.lb_Sothunhat.Name = "lb_Sothunhat";
            this.lb_Sothunhat.Size = new System.Drawing.Size(130, 31);
            this.lb_Sothunhat.TabIndex = 0;
            this.lb_Sothunhat.Text = "Số thứ nhất:";
            // 
            // lb_Sothuhai
            // 
            this.lb_Sothuhai.AutoSize = true;
            this.lb_Sothuhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sothuhai.Location = new System.Drawing.Point(381, 51);
            this.lb_Sothuhai.Name = "lb_Sothuhai";
            this.lb_Sothuhai.Size = new System.Drawing.Size(116, 26);
            this.lb_Sothuhai.TabIndex = 1;
            this.lb_Sothuhai.Text = "Số thứ hai:";
            // 
            // lb_Sothuba
            // 
            this.lb_Sothuba.AutoSize = true;
            this.lb_Sothuba.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Sothuba.Location = new System.Drawing.Point(729, 51);
            this.lb_Sothuba.Name = "lb_Sothuba";
            this.lb_Sothuba.Size = new System.Drawing.Size(111, 26);
            this.lb_Sothuba.TabIndex = 2;
            this.lb_Sothuba.Text = "Số thứ ba:";
            // 
            // txtb_Sothunhat
            // 
            this.txtb_Sothunhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Sothunhat.Location = new System.Drawing.Point(173, 49);
            this.txtb_Sothunhat.Name = "txtb_Sothunhat";
            this.txtb_Sothunhat.Size = new System.Drawing.Size(164, 30);
            this.txtb_Sothunhat.TabIndex = 3;
            // 
            // txtb_Sothuhai
            // 
            this.txtb_Sothuhai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Sothuhai.Location = new System.Drawing.Point(495, 49);
            this.txtb_Sothuhai.Name = "txtb_Sothuhai";
            this.txtb_Sothuhai.Size = new System.Drawing.Size(164, 30);
            this.txtb_Sothuhai.TabIndex = 4;
            // 
            // txtb_Sothuba
            // 
            this.txtb_Sothuba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Sothuba.Location = new System.Drawing.Point(838, 49);
            this.txtb_Sothuba.Name = "txtb_Sothuba";
            this.txtb_Sothuba.Size = new System.Drawing.Size(164, 30);
            this.txtb_Sothuba.TabIndex = 5;
            // 
            // btn_Tim
            // 
            this.btn_Tim.AutoSize = true;
            this.btn_Tim.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tim.Location = new System.Drawing.Point(173, 177);
            this.btn_Tim.Name = "btn_Tim";
            this.btn_Tim.Size = new System.Drawing.Size(136, 54);
            this.btn_Tim.TabIndex = 6;
            this.btn_Tim.Text = "Tìm";
            this.btn_Tim.UseVisualStyleBackColor = true;
            this.btn_Tim.Click += new System.EventHandler(this.btn_Tim_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(495, 177);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(136, 54);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.BackColor = System.Drawing.Color.IndianRed;
            this.btn_Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Thoat.Location = new System.Drawing.Point(838, 177);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(136, 54);
            this.btn_Thoat.TabIndex = 8;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = false;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // txtb_Max
            // 
            this.txtb_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Max.Location = new System.Drawing.Point(173, 313);
            this.txtb_Max.Name = "txtb_Max";
            this.txtb_Max.ReadOnly = true;
            this.txtb_Max.Size = new System.Drawing.Size(164, 30);
            this.txtb_Max.TabIndex = 9;
            this.txtb_Max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtb_Min
            // 
            this.txtb_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtb_Min.Location = new System.Drawing.Point(838, 313);
            this.txtb_Min.Name = "txtb_Min";
            this.txtb_Min.ReadOnly = true;
            this.txtb_Min.Size = new System.Drawing.Size(164, 30);
            this.txtb_Min.TabIndex = 10;
            this.txtb_Min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_Max
            // 
            this.lb_Max.AutoSize = true;
            this.lb_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Max.Location = new System.Drawing.Point(37, 315);
            this.lb_Max.Name = "lb_Max";
            this.lb_Max.Size = new System.Drawing.Size(128, 26);
            this.lb_Max.TabIndex = 11;
            this.lb_Max.Text = "Số lớn nhất:";
            // 
            // lb_Min
            // 
            this.lb_Min.AutoSize = true;
            this.lb_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Min.Location = new System.Drawing.Point(702, 315);
            this.lb_Min.Name = "lb_Min";
            this.lb_Min.Size = new System.Drawing.Size(141, 26);
            this.lb_Min.TabIndex = 12;
            this.lb_Min.Text = "Số nhỏ nhất: ";
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 397);
            this.Controls.Add(this.lb_Min);
            this.Controls.Add(this.lb_Max);
            this.Controls.Add(this.txtb_Min);
            this.Controls.Add(this.txtb_Max);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Tim);
            this.Controls.Add(this.txtb_Sothuba);
            this.Controls.Add(this.txtb_Sothuhai);
            this.Controls.Add(this.txtb_Sothunhat);
            this.Controls.Add(this.lb_Sothuba);
            this.Controls.Add(this.lb_Sothuhai);
            this.Controls.Add(this.lb_Sothunhat);
            this.Name = "Bai2";
            this.Text = "Số lớn nhất, số nhỏ nhất";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Sothunhat;
        private System.Windows.Forms.Label lb_Sothuhai;
        private System.Windows.Forms.Label lb_Sothuba;
        private System.Windows.Forms.TextBox txtb_Sothunhat;
        private System.Windows.Forms.TextBox txtb_Sothuhai;
        private System.Windows.Forms.TextBox txtb_Sothuba;
        private System.Windows.Forms.Button btn_Tim;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.TextBox txtb_Max;
        private System.Windows.Forms.TextBox txtb_Min;
        private System.Windows.Forms.Label lb_Max;
        private System.Windows.Forms.Label lb_Min;
    }
}