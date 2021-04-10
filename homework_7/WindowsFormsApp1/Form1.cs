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
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.6;
        double per2 = 0.7;
        Pen pen = Pens.Black;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object colorType = comboBox1.SelectedItem;//颜色类型
            if (colorType.ToString() == "Black")
            {
                this.pen = Pens.Black;
            }
            if (colorType.ToString() == "Blue")
            {
                this.pen = Pens.Blue;
            }
            if (colorType.ToString() == "Red")
            {
                this.pen = Pens.Red;
            }
            if (colorType.ToString() == "Green")
            {
                this.pen = Pens.Green;
            }

            int num = int.Parse(textBox1.Text);//递归深度
            double length = double.Parse(textBox2.Text);//主干长度
            this.th1 = double.Parse(textBox4.Text) * Math.PI / 180;//右分支长度比
            this.th2 = double.Parse(textBox3.Text) * Math.PI / 180;//左分支长度比
            this.per1 = double.Parse(textBox6.Text);//右分支角度
            this.per2 = double.Parse(textBox5.Text);//左分支角度
            if (graphics == null) graphics = panel1.CreateGraphics();
            DrawCayleyTree(num, 200, 400, length, -Math.PI / 2);
        }

        void DrawCayleyTree(int n,double x0,double y0,double leng,double th) 
        {
            if (n == 0) return;
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            

            DrawLine(x0, y0, x1, y1);

            DrawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            DrawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        void DrawLine(double x0,double y0,double x1,double y1)
        {
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
