using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }

        private void btn_Chuyendoi_Click(object sender, EventArgs e)
        {
            float so_tien_sau_chuyen_doi = 0;           
            float sotien = float.Parse(txtb_Sotien.Text.Trim());

                if (sotien <= 0)
                {
                    MessageBox.Show("Nhập chưa đúng!");
                    txtb_Sotien.Text = string.Empty;
                    txtb_Tiendadoi.Text = string.Empty;
                    txtb_chitietquydoi.Text = string.Empty;
                }


                if (cbo_Donvitien.SelectedItem == null)
                {
                    MessageBox.Show("Vui lòng chọn đơn vị tiền muốn đổi!");
                    return;
                }

                if (cbo_Donvitien.SelectedItem.ToString() == "USD (Đô-la Mỹ)")
                {
                    so_tien_sau_chuyen_doi = sotien * 22772;
                    txtb_Tiendadoi.Text = so_tien_sau_chuyen_doi.ToString();
                    txtb_chitietquydoi.Text = "1 USD = 22,772 VNĐ";
                }
                else if (cbo_Donvitien.SelectedItem.ToString() == "EUR")
                {
                    so_tien_sau_chuyen_doi = sotien * 28132;
                    txtb_Tiendadoi.Text = so_tien_sau_chuyen_doi.ToString();
                    txtb_chitietquydoi.Text = "1 EUR = 28,132 VNĐ";
                }
                else if (cbo_Donvitien.SelectedItem.ToString() == "GBP")
                {
                    so_tien_sau_chuyen_doi = sotien * 31538;
                    txtb_Tiendadoi.Text = so_tien_sau_chuyen_doi.ToString();
                    txtb_chitietquydoi.Text = "1 GBP = 31,538 VNĐ";
                }
                else if (cbo_Donvitien.SelectedItem.ToString() == "SGD")
                {
                    so_tien_sau_chuyen_doi = sotien * 17286;
                    txtb_Tiendadoi.Text = so_tien_sau_chuyen_doi.ToString();
                    txtb_chitietquydoi.Text = "1 SGD = 17,286 VNĐ";
                }
                else if (cbo_Donvitien.SelectedItem.ToString() == "JPY")
                {
                    so_tien_sau_chuyen_doi = sotien * 214;
                    txtb_Tiendadoi.Text = so_tien_sau_chuyen_doi.ToString();
                    txtb_chitietquydoi.Text = "1 JPY = 214 VNĐ";
                }
       
            Console.WriteLine(txtb_Tiendadoi.Text);
            Console.WriteLine(txtb_chitietquydoi.Text);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
