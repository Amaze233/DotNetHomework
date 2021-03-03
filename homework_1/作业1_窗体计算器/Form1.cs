using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            object type = comboBox1.SelectedItem;//声明选择栏
            int num1 = int.Parse(textBox1.Text);//进行变量的声明
            double num2 = double.Parse(textBox2.Text);
            if (type.ToString() == "+")//判断comnoBox1中的值为+
            {
                textBox3.Text = (num1 + num2).ToString();
            }
            if (type.ToString() == "-")//判断comnoBox1中的值为-
            {
                textBox3.Text = (num1 - num2).ToString();
            }
            if (type.ToString() == "×")//判断comnoBox1中的值为×
            {
                textBox3.Text = (num1 * num2).ToString();
            }
            if (type.ToString() == "÷")//判断comnoBox1中的值为÷
            {
                if (textBox1.Text == "0" | textBox2.Text == "0")//除数不能为零
                {
                    MessageBox.Show("输入错误", "提示");//否则提示输入错误
                }
                textBox3.Text = (num1 / num2).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            comboBox1.Text = " ";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
