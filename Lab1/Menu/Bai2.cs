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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            var a = float.Parse(txtb_Sothunhat.Text);
            var b =  float.Parse(txtb_Sothuhai.Text);
            var c = float.Parse(txtb_Sothuba.Text);
            float max = a;
            float min = b;
            if(b > max)
            {
                max = b;
            }
            if(c > max) 
            { 
                max = c;
            }
            if(a < min)
            {
                min = a;
            }
            if(c < min)
            {
                min = c;
            }
            txtb_Max.Text = max.ToString();
            txtb_Min.Text = min.ToString();
            Console.WriteLine(txtb_Min.Text);
            Console.WriteLine(txtb_Max.Text);
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txtb_Max.Text = string.Empty;
            txtb_Min.Text = string.Empty;
            txtb_Sothuba.Text = string.Empty;
            txtb_Sothuhai.Text  = string.Empty;
            txtb_Sothunhat.Text = string.Empty;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
