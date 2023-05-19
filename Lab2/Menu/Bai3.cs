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
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }


        static double Evaluation(string expression)
        {
            Stack<char> operators = new Stack<char>();
            Stack<double> operands = new Stack<double>();
            double operand = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                char chars = expression[i];

                if (chars == '(')
                {
                    operators.Push(chars);
                }
                else if (chars == ')')
                {
                    while (operators.Peek() != '(')
                    {
                        Calculation(operators, operands);
                    }
                    operators.Pop();
                }
                else if (IsOperator(chars))
                {
                    while (operators.Count > 0 && Priority(operators.Peek()) >= Priority(chars))
                    {
                        Calculation(operators, operands);
                    }
                    operators.Push(chars);
                }
                else if (char.IsDigit(chars))
                {
                    operand = (operand * 10) + (chars - '0');

                    if (i + 1 == expression.Length || !char.IsDigit(expression[i + 1]))
                    {
                        operands.Push(operand);
                        operand = 0;
                    }
                }
            }

            while (operators.Count > 0)
            {
                Calculation(operators, operands);
            }

            return operands.Pop();
        }

        static void Calculation(Stack<char> operators, Stack<double> operands)
        {
            char ops = operators.Pop();
            double b = operands.Pop();
            double a = operands.Pop();
            double result;

            switch (ops)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    throw new InvalidOperationException("Invalid operand!");
            }

            operands.Push(result);
        }

        static int Priority(char op)
        {
            switch (op)
            {
                case '(':
                case ')':
                    return 0;
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                default:
                    throw new InvalidOperationException("Invalid operand!");
            }
        }

        static bool IsOperator(char ch)
        {
            return ch == '+' || ch == '-' || ch == '*' || ch == '/';
        }

        private void btn_read_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(fs);
            string str = read.ReadToEnd();
            rtxt_content.Text = str;
            Console.WriteLine(str);


        }
        private void btn_write_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd2 = new OpenFileDialog();
            ofd2.ShowDialog();
            FileStream fs = new FileStream(ofd2.FileName, FileMode.Open, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);
            sr.Write(rtxt_result.Text);
            sr.Close();
            MessageBox.Show("Calculated and wrote into file output3.txt !");
        }

        private void btn_cal_Click(object sender, EventArgs e)
        {
            string str = rtxt_content.Text;
            string[] strings = str.Split('\n');

            for (int i = 0; i < strings.Length; i++)
            {
                double result = Evaluation(strings[i]);
                rtxt_result.AppendText(strings[i] + " = " + result.ToString());
                rtxt_result.Text += "\n";

            }
        }

        private void btn_read_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read);
            StreamReader read = new StreamReader(fs);
            string str = read.ReadToEnd();
            rtxt_content.Text = str;
            Console.WriteLine(str);

        }
    }
}
