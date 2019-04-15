using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            PointF p0 = new PointF(20, 150);
            PointF p3 = new PointF(210,135);

            PointF p1 = new PointF();
            PointF p2 = new PointF();

            PointF temp = new PointF();
            PointF temp2 = new PointF();

            temp2.X = p0.X;
            temp2.Y = p0.Y;

            p1.X = (float)Double.Parse(textBox1.Text);
            p1.Y = (float)Double.Parse(textBox2.Text);
            p2.X = (float)Double.Parse(textBox3.Text);
            p2.Y = (float)Double.Parse(textBox4.Text);


            for (double t = 0; t<1; t = t + 0.01)
            {


                temp.X = (float)((1-t)*(1-t)*(1-t)*p0.X + 3*t*(1-t)*(1-t)*p1.X + 3 * t * t * (1 - t) * p2.X + t * t * t * p3.X);
                temp.Y = (float)((1 - t) * (1 - t) * (1 - t) * p0.Y + 3 * t * (1 - t) * (1 - t) * p1.Y + 3 * t * t * (1 - t) * p2.Y + t * t * t * p3.Y);

                g.DrawLine(pen1, temp2.X, temp2.Y, temp.X, temp.Y);

                temp2.X = temp.X;
                temp2.Y = temp.Y;


            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PointF p0 = new PointF(20, 150);
            PointF p3 = new PointF(210, 135);

            PointF r0 = new Point();
            PointF r3 = new PointF();

            PointF temp = new PointF();
            PointF temp2 = new PointF();

            temp2.X = p0.X;
            temp2.Y = p0.Y;

            r0.X = (float)Double.Parse(textBox8.Text);
            r0.Y = (float)Double.Parse(textBox7.Text);
            r3.X = (float)Double.Parse(textBox6.Text);
            r3.Y = (float)Double.Parse(textBox5.Text);


            for (double t = 0; t < 1; t = t + 0.01)
            {

                temp.X = (float)((2*t*t*t-3*t*t+1)*p0.X + (-2*t*t*t+3*t*t)*p3.X + (t*t*t-2*t*t+t)*r0.X + (t*t*t-t*t)*r3.X);
                temp.Y = (float)((2 * t * t * t - 3 * t * t + 1) * p0.Y + (-2 * t * t * t + 3 * t * t) * p3.Y + (t * t * t - 2 * t * t + t) * r0.Y + (t * t * t - t * t) * r3.Y);

                //temp.X = (float)((1 - t) * (1 - t) * (1 - t) * p0.X + 3 * t * (1 - t) * (1 - t) * p1.X + 3 * t * t * (1 - t) * p2.X + t * t * t * p3.X);
                //temp.Y = (float)((1 - t) * (1 - t) * (1 - t) * p0.Y + 3 * t * (1 - t) * (1 - t) * p1.Y + 3 * t * t * (1 - t) * p2.Y + t * t * t * p3.Y);

                g.DrawLine(pen1, temp2.X, temp2.Y, temp.X, temp.Y);

                temp2.X = temp.X;
                temp2.Y = temp.Y;


            }
        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            PointF temp = new PointF();
            PointF temp2 = new PointF();

            PointF p0 = new PointF(-100,-100);
            PointF p1 = new PointF(-70, 0);
            PointF p2 = new PointF(-20,  -20);
            PointF p3 = new PointF(0, 30);
            PointF p4 = new PointF(120, -90);
            PointF p5 = new PointF(100,-70);

            PointF[] points = { p0, p1, p2, p3, p4, p5 };

            /*
                for (double t = 0; t < 1; t = t + 0.01)
                {

                    temp.X = (float)((((1-t)*(1-t)*(1-t))/6) * points[3].X + ((3*t*t*t - 6*t*t +4)/6)*points[i-2].X + ((-3*t*t*t + 3*t*t + 3*t +1)/6)*points[i-1].X + (t*t*t/6)*points[0].X);
                    temp.X = (float)((((1 - t) * (1 - t) * (1 - t)) / 6) * points[3].Y + ((3 * t * t * t - 6 * t * t + 4) / 6) * points[2].Y + ((-3 * t * t * t + 3 * t * t + 3 * t + 1) / 6) * points[0].Y + (t * t * t / 6) * points[0].Y);

                    g.DrawLine(pen1, temp2.X, temp2.Y, temp.X, temp.Y);

                    temp2.X = temp.X;
                    temp2.Y = temp.Y;


                }
            */
        }
    }
}
