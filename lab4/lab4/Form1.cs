using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class Form1 : Form
    {
        //lines
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.White, 1);
        //radius
        private System.Drawing.Pen pen2 = new System.Drawing.Pen(Color.Red, 1);
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            //sets origin on the middle
            g.TranslateTransform(200, 200);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            //Okrag
            double r = 100;
            //number of lines circle consists of
            double lines = 100;
            //alfa and dalfa
            double alfa = 0.0;
            double dalfa = (2 * Math.PI) / lines;
            //for loop
            float tx = float.Parse(textBox1.Text);
            float ty = float.Parse(textBox2.Text);
            for (float i = 0; i < lines; i = i + 1)
            {
                alfa = alfa + dalfa;
                g.DrawLine(pen1, (float)(r * Math.Cos(dalfa * i)), (float)(r * Math.Sin(dalfa * i)), (float)(r * Math.Cos(dalfa * (i + 1))), (float)(r * Math.Sin(dalfa * (i + 1))));
                g.DrawLine(pen2, (float)(r * Math.Cos(dalfa * i)+tx), (float)(r * Math.Sin(dalfa * i)+ty), (float)(r * Math.Cos(dalfa * (i + 1))+tx), (float)(r * Math.Sin(dalfa * (i + 1))+ty));

            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            double sc = double.Parse(textBox8.Text);
            float scale = (float)(sc);

            //Okrag
            double r = 100;
            //number of lines circle consists of
            double lines = 100;
            //alfa and dalfa
            double alfa = 0.0;
            double dalfa = (2 * Math.PI) / lines;
            //for loop
            float tx = float.Parse(textBox3.Text);
            float ty = float.Parse(textBox7.Text);
            for (float i = 0; i < lines; i = i + 1)
            {
                alfa = alfa + dalfa;
                g.DrawLine(pen1, (float)(r * Math.Cos(dalfa * i)), (float)(r * Math.Sin(dalfa * i)), (float)(r * Math.Cos(dalfa * (i + 1))), (float)(r * Math.Sin(dalfa * (i + 1))));
                g.DrawLine(pen2, (float)(scale * r * Math.Cos(dalfa * i) + tx), (float)(scale * r * Math.Sin(dalfa * i) + ty), (float)(scale * r * Math.Cos(dalfa * (i + 1)) + tx), (float)(scale * r * Math.Sin(dalfa * (i + 1)) + ty));

            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //Kwadrat
            PointF p1 = new PointF();
            PointF p2 = new PointF();
            p1.X = 100;
            p1.Y = 100;
            p2.X = 100;
            p2.Y = -100;

            PointF p3 = new PointF();
            PointF p4 = new PointF();
            p3.X = 100;
            p3.Y = -100;
            p4.X = -100;
            p4.Y = -100;

            PointF p5 = new PointF();
            PointF p6 = new PointF();
            p5.X = -100;
            p5.Y = 100;
            p6.X = 100;
            p6.Y = 100;

            PointF p7 = new PointF();
            PointF p8 = new PointF();
            p7.X = -100;
            p7.Y = -100;
            p8.X = -100;
            p8.Y = 100;


            float input = float.Parse(textBox4.Text);
            float degrees = (float)(Math.PI / 180) * input;

            //coeff
            float cx1 = (float)(Math.Cos(degrees));
            float cy1 = (float)(-Math.Sin(degrees));
            float cx2 = (float)(Math.Sin(degrees));
            float cy2 = (float)(Math.Cos(degrees));


            //kwadrat
            g.DrawLine(pen1, p1, p2);
            g.DrawLine(pen1, p3, p4);
            g.DrawLine(pen1, p5, p6);
            g.DrawLine(pen1, p7, p8);

            //[x] = [xcos+ysin]
            //[y] = [-xsin + ycos] 

            //kwadrat rotated
            g.DrawLine(pen2, p1.X*cx1 + p1.Y*cx2, p1.X * cy1 + p1.Y*cy2, p2.X * cx1 + p2.Y * cx2, p2.X * cy1 + p2.Y * cy2);
            g.DrawLine(pen2, p3.X * cx1 + p3.Y * cx2, p3.X * cy1 + p3.Y * cy2, p4.X * cx1 + p4.Y * cx2, p4.X * cy1 + p4.Y * cy2);
            g.DrawLine(pen2, p5.X * cx1 + p5.Y * cx2, p5.X * cy1 + p5.Y * cy2, p6.X * cx1 + p6.Y * cx2, p6.X * cy1 + p6.Y * cy2);
            g.DrawLine(pen2, p7.X * cx1 + p7.Y * cx2, p7.X * cy1 + p7.Y * cy2, p8.X * cx1 + p8.Y * cx2, p8.X * cy1 + p8.Y * cy2);

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            double sc = double.Parse(textBox6.Text);
            float scale = (float)(sc);
            
            //trójkąt
            PointF p1 = new PointF();
            PointF p2 = new PointF();
            p1.X = 100;
            p1.Y = 100;
            p2.X = 100;
            p2.Y = -100;

            PointF p3 = new PointF();
            PointF p4 = new PointF();
            p3.X = 100;
            p3.Y = -100;
            p4.X = -100;
            p4.Y = -100;

            PointF p5 = new PointF();
            PointF p6 = new PointF();
            p5.X = -100;
            p5.Y = -100;
            p6.X = 100;
            p6.Y = 100;



            g.DrawLine(pen1, p1, p2);
            g.DrawLine(pen1, p3, p4);
            g.DrawLine(pen1, p5, p6);

            //scaled one
            g.DrawLine(pen2, p1.X * scale, p1.Y * scale, p2.X *scale, p2.Y * scale);
            g.DrawLine(pen2, p3.X * scale, p3.Y * scale, p4.X * scale, p4.Y * scale);
            g.DrawLine(pen2, p5.X * scale, p5.Y * scale, p6.X * scale, p6.Y * scale);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            //Kwadrat
            PointF p1 = new PointF();
            PointF p2 = new PointF();
            p1.X = 100;
            p1.Y = 100;
            p2.X = 100;
            p2.Y = -100;

            PointF p3 = new PointF();
            PointF p4 = new PointF();
            p3.X = 100;
            p3.Y = -100;
            p4.X = -100;
            p4.Y = -100;

            PointF p5 = new PointF();
            PointF p6 = new PointF();
            p5.X = -100;
            p5.Y = 100;
            p6.X = 100;
            p6.Y = 100;

            PointF p7 = new PointF();
            PointF p8 = new PointF();
            p7.X = -100;
            p7.Y = -100;
            p8.X = -100;
            p8.Y = 100;


            float input = float.Parse(textBox5.Text);
            float degrees = (float)(Math.PI / 180) * input;

            //x-10 //y-9
            float tx = float.Parse(textBox10.Text);
            float ty = float.Parse(textBox9.Text);

            //coeff
            float cx1 = (float)(Math.Cos(degrees));
            float cy1 = (float)(-Math.Sin(degrees));
            float cx2 = (float)(Math.Sin(degrees));
            float cy2 = (float)(Math.Cos(degrees));


            //kwadrat
            g.DrawLine(pen1, p1, p2);
            g.DrawLine(pen1, p3, p4);
            g.DrawLine(pen1, p5, p6);
            g.DrawLine(pen1, p7, p8);

            //[x] = [xcos+ysin]
            //[y] = [-xsin + ycos] 

            //kwadrat rotated
            g.DrawLine(pen2, (p1.X * cx1 + p1.Y * cx2)+tx, (p1.X * cy1 + p1.Y * cy2)+ty, (p2.X * cx1 + p2.Y * cx2)+tx, (p2.X * cy1 + p2.Y * cy2)+ty);
            g.DrawLine(pen2, (p3.X * cx1 + p3.Y * cx2) + tx, (p3.X * cy1 + p3.Y * cy2) + ty, (p4.X * cx1 + p4.Y * cx2) + tx, (p4.X * cy1 + p4.Y * cy2) + ty);
            g.DrawLine(pen2, (p5.X * cx1 + p5.Y * cx2) + tx, (p5.X * cy1 + p5.Y * cy2) + ty, (p6.X * cx1 + p6.Y * cx2) + tx, (p6.X * cy1 + p6.Y * cy2) + ty);
            g.DrawLine(pen2, (p7.X * cx1 + p7.Y * cx2) + tx, (p7.X * cy1 + p7.Y * cy2) + ty, (p8.X * cx1 + p8.Y * cx2) + tx, (p8.X * cy1 + p8.Y * cy2) + ty);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            double sc = double.Parse(textBox11.Text);
            float scale = (float)(sc);

            float input = float.Parse(textBox12.Text);
            float degrees = (float)(Math.PI / 180) * input;

            //trójkąt
            PointF p1 = new PointF();
            PointF p2 = new PointF();
            p1.X = 100;
            p1.Y = 100;
            p2.X = 100;
            p2.Y = -100;

            PointF p3 = new PointF();
            PointF p4 = new PointF();
            p3.X = 100;
            p3.Y = -100;
            p4.X = -100;
            p4.Y = -100;

            PointF p5 = new PointF();
            PointF p6 = new PointF();
            p5.X = -100;
            p5.Y = -100;
            p6.X = 100;
            p6.Y = 100;

            g.DrawLine(pen1, p1, p2);
            g.DrawLine(pen1, p3, p4);
            g.DrawLine(pen1, p5, p6);

            //coeff
            float cx1 = (float)(Math.Cos(degrees));
            float cy1 = (float)(-Math.Sin(degrees));
            float cx2 = (float)(Math.Sin(degrees));
            float cy2 = (float)(Math.Cos(degrees));

            //[x] = [xcos+ysin]
            //[y] = [-xsin + ycos] 

            //scaled one
            g.DrawLine(pen2, (p1.X * cx1 + p1.Y * cx2) * scale, (p1.X * cy1 + p1.Y * cy2) * scale, (p2.X * cx1 + p2.Y * cx2) *scale, (p2.X * cy1 + p2.Y * cy2) *scale);
            g.DrawLine(pen2, (p3.X * cx1 + p3.Y * cx2) * scale, (p3.X * cy1 + p3.Y * cy2) * scale, (p4.X * cx1 + p4.Y * cx2) * scale, (p4.X * cy1 + p4.Y * cy2) * scale);
            g.DrawLine(pen2, (p5.X * cx1 + p5.Y * cx2) * scale, (p5.X * cy1 + p5.Y * cy2) * scale, (p6.X * cx1 + p6.Y * cx2) * scale, (p6.X * cy1 + p6.Y * cy2) * scale);



        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox12_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
