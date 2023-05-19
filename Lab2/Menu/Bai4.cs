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
using static Menu.Bai4;

namespace Menu
{
    public partial class Bai4 : Form
    { 
        private List<Sinhvien> dssinhvien = new List<Sinhvien>();
        public class Sinhvien
        {
            public string name { get; set; }
            public string phone { get; set; }
            public int ID { get; set; }
            public float score1 { get; set; }
            public float score2 { get; set; }
            public float score3 { get; set; }
            public float dtb { get; set; }

        }
        
        public Bai4()
        {
            InitializeComponent();
        }


        

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Length != 8)
            {
                MessageBox.Show("MSSV phải có 8 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_phone.Text.Length != 10 || txt_phone.Text[0] != '0')
            {

                MessageBox.Show("Điện thoại phải có 10 chữ số và phải bắt đầu bằng chữ số 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Sinhvien sv = new Sinhvien();
            sv.ID = Int32.Parse(txt_ID.Text);
            sv.name = txt_name.Text;
            sv.phone = txt_phone.Text;
            sv.score1 = float.Parse(txt_course1.Text);
            sv.score2 = float.Parse(txt_course2.Text);
            sv.score3 = float.Parse( txt_course3.Text);
            //sv.dtb = float.Parse(txt_average.Text);
            

            dssinhvien.Add(sv);

            txt_ID.Clear();
            txt_name.Clear();
            txt_phone.Clear();
            txt_course1.Clear();
            txt_course2.Clear();
            txt_course3.Clear();
            txt_average.Clear();
            

            MessageBox.Show("Thêm sinh viên thành công!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.Title = "Save File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Sinhvien sv in dssinhvien)
                    {
                        writer.WriteLine(sv.ID + ";" + sv.name + ";" + sv.phone + ";" + sv.score1 + ";" + sv.score2 + ";" + sv.score3);
                    }
                }
                MessageBox.Show("Lưu file thành công!");

            }
   }    }
}
