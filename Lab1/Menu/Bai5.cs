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
    public partial class Bai5 : Form
    {
        public Bai5()
        {
            InitializeComponent();
        }

        private void btn_Tinhtoan_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtb_SoA.Text);
            int b = int.Parse(txtb_SoB.Text);
            long tongA = 0;
            long  tongB = 0;
            long  giaithuaA = 1;
            long  giaithuaB = 1;
            double  AluythuaB = 0;
            for(int i = 1; i <= a; i++)
            {
                giaithuaA *= i;
            }
            for(int j = 1; j <= b; j++)
            {
                giaithuaB *= j;
            }
            for(int i = 1;i <= a; i++)
            {
                tongA += i;
            }
            for (int j = 1; j <= b; j++)
            {
                tongB += j;
            }

            
            
            for (int j = 1; j <= b; j++)
            {
                AluythuaB += Math.Pow(a, j);
            }
            
                

            txtb_A_gt.Text = giaithuaA.ToString();
            txtb_B_gt.Text= giaithuaB.ToString();
            txtb_S1.Text = tongA.ToString();
            txtb_S2.Text = tongB.ToString();
            txtb_S3.Text = AluythuaB.ToString();
            Console.WriteLine(txtb_S1.Text);
            Console.WriteLine(txtb_S2.Text);
            Console.WriteLine(txtb_A_gt.Text);
            Console.WriteLine(txtb_B_gt.Text);
            Console.WriteLine(txtb_S3.Text);
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            txtb_A_gt.Text = string.Empty;
            txtb_B_gt.Text = string.Empty;
            txtb_S1.Text= string.Empty;
            txtb_S2.Text= string.Empty;
            txtb_S3.Text= string.Empty;
            txtb_SoA.Text= string.Empty;
            txtb_SoB.Text= string.Empty;
        }
    }
}
