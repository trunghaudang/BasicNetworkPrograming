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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();

            //get filename
            richTextBox_filename.Text = Path.GetFileName(ofd.FileName);

            //get file size
            FileInfo fi = new FileInfo(ofd.FileName);
            richTextBox_size.Text = fi.Length.ToString() + " bytes";

            //get file full path
            richTextBox_URL.Text = Path.GetFullPath(ofd.FileName);

            //count number of line
            int lines = File.ReadAllLines(ofd.FileName).Length;
            richTextBox_line.Text = lines.ToString();

            //count number of word
            string filePath = Path.GetFullPath(ofd.FileName);
            int wordCount = 0;
            StreamReader sr = new StreamReader(filePath);
            string content = sr.ReadToEnd();
            wordCount = content.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
            richTextBox_word.Text = wordCount.ToString();

            //count number of char
            int numberofcharacter = File.ReadAllText(filePath).Length;
            richTextBox_char.Text = numberofcharacter.ToString();

            richTextBox_view.Text = content;
            Console.WriteLine(richTextBox_view.Text);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
