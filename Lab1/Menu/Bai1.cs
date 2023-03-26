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
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_Tinh_Click(object sender, EventArgs e)
        {       
            int sum = 0;
            try
            {
                int m = Int32.Parse(txtb_Sothunhat.Text);
                int n =  Int32.Parse(txtb_Sothuhai.Text);
                
                sum = m + n;
            }
            catch (FormatException ex)
            {
                ex.Source = "Vui lòng nhập vào số nguyên!";
                MessageBox.Show(ex.Source);
            }
           
            txtb_Ketqua.Text = sum.ToString();
            Console.WriteLine(txtb_Ketqua.Text);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txtb_Ketqua.Text = string.Empty;
            txtb_Sothuhai.Text = string.Empty;
            txtb_Sothunhat.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
