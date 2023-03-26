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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Bai1_Click(object sender, EventArgs e)
        {
            Bai1 form2 = new Bai1();
            form2.Show();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            Bai2 form3 = new Bai2();
            form3.Show();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
           Bai3 form4 = new Bai3();
            form4.Show();
        }

        private void btn_Bai4_Click(object sender, EventArgs e)
        {
            Bai4 form5 = new Bai4();
            form5.Show();
        }

        private void btn_Bai5_Click(object sender, EventArgs e)
        {
            Bai5 form6 = new Bai5();
            form6.Show();
        }

        
    }
}
