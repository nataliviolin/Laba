using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.D1)
                    textBox1.Text += 1;
                else 
                    if (e.KeyCode == Keys.D2)
                        textBox1.Text += 2;
                    else 
                        if (e.KeyCode == Keys.D3)
                            textBox1.Text += 3;
                        else 
                            if (e.KeyCode == Keys.D4)
                                textBox1.Text += 4;
                            else 
                                if (e.KeyCode == Keys.D5)
                                    textBox1.Text += 5;
                                else 
                                    if (e.KeyCode == Keys.D6)
                                        textBox1.Text += 6;
                                    else 
                                        if (e.KeyCode == Keys.D7)
                                            textBox1.Text += 7;
                                        else
                                            if (e.Shift && e.KeyCode == Keys.D8)
                                                ymnog_Click(null, null);
                                            else 
                                            if (e.KeyCode == Keys.D8)
                                                textBox1.Text += 8;
                                            else
                                                if (e.KeyCode == Keys.D9)
                                                    textBox1.Text += 9;
                                                else 
                                                    if (e.KeyCode == Keys.D0)
                                                        textBox1.Text += 0;
                                                    else 
                                                        if (e.KeyCode == Keys.OemMinus)
                                                            minus_Click(null, null);
                                                        else
                                                            if (e.KeyCode == Keys.Back && textBox1.TextLength > 1)
                                                                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                                                            else
                                                                if (e.KeyCode == Keys.Back && textBox1.TextLength == 1)
                                                                    textBox1.Clear();
                                                                else
                                                                    if (e.Shift && e.KeyCode == Keys.OemQuestion)
                                                                        delit_Click(null,null); 
                                                                    else
                                                                    if (e.KeyCode == Keys.OemQuestion)
                                                                        textBox1.Text += ','; 
                                                                    else 
                                                                        if (e.Shift && e.KeyCode == Keys.Oemplus)
                                                                            plus_Click(null, null);
                                                                        else 
                                                                            if (e.KeyCode == Keys.Oemplus)       
                                                                                ravno_Click(null, null);
                                                                            }
 
        int flag = 0, ob;
        double zn = 0, x = 0;

        public double calc(double zn, double x, int ob)
        {
            if (ob == 1)
                zn += x;
            else if (ob == 2)
                zn -= x;
            else if (ob == 3)
                zn *= x;
            else
                zn /= x;
            return zn;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void num0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void zap_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                zn = Convert.ToDouble(textBox1.Text);
                flag = 1;
                ob = 1;
            }
            else
            {
                x = Convert.ToDouble(textBox1.Text);
                zn = calc(zn, x, ob);
                ob = 1;
            }
            textBox1.Clear();
        }

        private void ravno_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            zn = calc(zn, x, ob);
            textBox1.Text = Convert.ToString(zn);
            flag = 0;
        }

        private void minus_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                zn = Convert.ToDouble(textBox1.Text);
                flag = 1;
                ob = 2;
            }
            else
            {
                x = Convert.ToDouble(textBox1.Text);
                zn = calc(zn, x, ob);
                ob = 2;
            }
            textBox1.Clear();
        }

        private void ymnog_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                zn = Convert.ToDouble(textBox1.Text);
                flag = 1;
                ob = 3;
            }
            else
            {
                x = Convert.ToDouble(textBox1.Text);
                zn = calc(zn, x, ob);
                ob = 3;
            }
            textBox1.Clear();
        }

        private void obratn_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            if (x == 0)
            {
                textBox1.Text = "Деление на ноль невозможно";
                zn = 0;
                flag = 0;
                x = 0;
            }
            else
            {
                zn = 1 / x;
                textBox1.Clear();
                textBox1.Text = Convert.ToString(zn);
            }
        }

        private void prozent_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            x = x / 100;
            ob = 3;
            zn = calc(zn, x, ob);
            textBox1.Text = Convert.ToString(zn);
            flag = 0;
        }

        private void delit_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                zn = Convert.ToDouble(textBox1.Text);
                flag = 1;
                ob = 4;
            }
            else
            {
                x = Convert.ToDouble(textBox1.Text);
                zn = calc(zn, x, ob);
                ob = 4;
            }
            textBox1.Clear();
        }

        private void znak_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            x = -x;
            textBox1.Clear();
            textBox1.Text = Convert.ToString(x);
        }

        private void koren_Click(object sender, EventArgs e)
        {
            x = Convert.ToDouble(textBox1.Text);
            if (x < 0)
            {
                textBox1.Text = "Недопустимый ввод";
                zn = 0;
                flag = 0;
                x = 0;
            }
            else
            {
                zn = Math.Sqrt(x);
                textBox1.Clear();
                textBox1.Text = Convert.ToString(zn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.TextLength - 1, 1);
                x = Convert.ToDouble(textBox1.Text);
            }
            else
            {
                textBox1.Clear();
                x = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zn = 0;
            flag = 0;
            x = 0;
            textBox1.Clear();
        }
    }
}
