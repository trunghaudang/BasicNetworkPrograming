using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd_input1 = new OpenFileDialog();
            ofd_input1.ShowDialog();

            FileStream fs = new FileStream(ofd_input1.FileName, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string str = sr.ReadToEnd();
            richTextBox_view.Text = str;
            Console.WriteLine(richTextBox_view.Text);
            sr.Close();
        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            string str = richTextBox_view.Text;

            OpenFileDialog ofd_output1 = new OpenFileDialog();
            ofd_output1.ShowDialog();

            StreamWriter sr = new StreamWriter(ofd_output1.FileName);
            sr.Write(str.ToUpper());
            sr.Close();
            MessageBox.Show("Ghi thành công vào file Output1!");

        }
    }
}
