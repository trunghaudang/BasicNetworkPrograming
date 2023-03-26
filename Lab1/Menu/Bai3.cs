using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btn_Doc_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtb_Nhap.Text);




            if (n >= 0 && n <= 9)
            {

                switch (n)
                {
                    case 0:
                        txtb_Ketqua.Text = "Không";
                        Console.WriteLine(txtb_Ketqua.Text);
                        break;

                    case 1:
                        txtb_Ketqua.Text = "Một";
                        Console.WriteLine(txtb_Ketqua.Text);
                        break;

                    case 2:
                        txtb_Ketqua.Text = "Hai";
                        Console.WriteLine(txtb_Ketqua.Text);
                        break;

                    case 3:
                        txtb_Ketqua.Text = "Ba";
                        Console.WriteLine(txtb_Ketqua.Text);
                        break;

                    case 4:
                        txtb_Ketqua.Text = "Bốn";
                        Console.WriteLine(txtb_Ketqua.Text);
                        break;

                    case 5:
                        txtb_Ketqua.Text = "Năm";
                        Console.WriteLine(txtb_Ketqua.Text);
                        break;
                    case 6:
                        txtb_Ketqua.Text = "Sáu";
                        Console.WriteLine(txtb_Ketqua.Text);
                        break;
                    case 7:
                        txtb_Ketqua.Text = "Bảy";
                        Console.WriteLine(txtb_Ketqua.Text);
                        break;
                    case 8:
                        txtb_Ketqua.Text = "Tám";
                        Console.WriteLine(txtb_Ketqua.Text);
                        break;
                    case 9:
                        txtb_Ketqua.Text = "Chín";
                        Console.WriteLine(txtb_Ketqua.Text);
                        break;


                }
            }
            else
            {

                MessageBox.Show("Hãy nhập số từ 0 đến 9!");
            }




        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txtb_Ketqua.Text = String.Empty;
            txtb_Nhap.Text = String.Empty;
            
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
