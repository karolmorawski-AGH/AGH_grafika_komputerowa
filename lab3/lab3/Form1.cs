using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form1 : Form
    {
        //lines
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.White, 3);
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            //sets origin on the middle
            g.TranslateTransform(250, 250);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //line 1
            PointF P1 = new PointF();
            PointF P2 = new PointF();
            P1.X = (float)Double.Parse(x_1.Text);
            P1.Y = (float)Double.Parse(y_1.Text);
            P2.X = (float)Double.Parse(x_2.Text);
            P2.Y = (float)Double.Parse(y_2.Text);
            g.DrawLine(pen1, P1.X, P1.Y, P2.X, P2.Y);

            //line 2
            PointF P3 = new PointF();
            PointF P4 = new PointF();
            P3.X = (float)Double.Parse(x_11.Text);
            P3.Y = (float)Double.Parse(y_11.Text);
            P4.X = (float)Double.Parse(x_22.Text);
            P4.Y = (float)Double.Parse(y_22.Text);
            g.DrawLine(pen1, P3.X, P3.Y, P4.X, P4.Y);


            //rownolegle
            float delta = (P2.X - P1.X) * (P3.Y - P4.Y) - (P3.X - P4.X) * (P2.Y - P1.Y);
            if (delta == 0)
            {
                textBox11.Text = "Proste są rownolegle";
                return;
            }

            float deltami = (P3.X - P1.X) * (P3.Y - P4.Y) - (P3.X - P4.X) * (P3.Y - P1.Y);
            float mi = deltami / delta;

            float x = (1 - mi) * P1.X + mi * P2.X;
            float y = (1 - mi) * P1.Y + mi * P2.Y;
            string msg = "Lines intersect at: (" + x + ", " + y + ")";
            textBox11.Text = msg;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //line 1
            PointF P1 = new PointF();
            PointF P2 = new PointF();
            P1.X = (float)Double.Parse(x_1.Text);
            P1.Y = (float)Double.Parse(y_1.Text);
            P2.X = (float)Double.Parse(x_2.Text);
            P2.Y = (float)Double.Parse(y_2.Text);
            g.DrawLine(pen1, P1.X, P1.Y, P2.X, P2.Y);

            //line 2
            PointF P3 = new PointF();
            PointF P4 = new PointF();
            P3.X = (float)Double.Parse(x_11.Text);
            P3.Y = (float)Double.Parse(y_11.Text);
            P4.X = (float)Double.Parse(x_22.Text);
            P4.Y = (float)Double.Parse(y_22.Text);
            g.DrawLine(pen1, P3.X, P3.Y, P4.X, P4.Y);


            //lengths
            float length1 = (float)(Math.Sqrt((P2.X - P1.X) * (P2.X - P1.X) + (P2.Y - P1.Y) * (P2.Y - P1.Y)));
            float length2 = (float)(Math.Sqrt((P4.X - P3.X) * (P4.X - P3.X) + (P4.Y - P3.Y) * (P4.Y - P3.Y)));

            //kosinusy kierununkowe
            float a = P1.X / length1;
            float b = P1.Y / length1;

            float c = P2.X / length2;
            float d = P2.Y / length2;

            float wzor = (float)Math.Abs(a * c + b * d);
            float arccosin = (float)Math.Acos(wzor);

            float wynik = (float)(arccosin * (180 / Math.PI));


            string msg = "Angle between intersecting lines is: " + wynik + " degrees";
            textBox11.Text = msg;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //line 1
            float a;
            float b;
            a = (float)Double.Parse(a_1.Text);
            b = (float)Double.Parse(b_1.Text);

            //Plaszczyzna: 
            float n = 50;
            float k = 100;

            float mi = (k - n * b) / (n * a);

            string msg = "mi=" + mi;
            textBox11.Text = msg;

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PointF P1 = new PointF();
            PointF P2 = new PointF();
            P1.X = (float)Double.Parse(x_1.Text);
            P1.Y = (float)Double.Parse(y_1.Text);
            float z1 = 5;
            P2.X = (float)Double.Parse(x_2.Text);
            P2.Y = (float)Double.Parse(y_2.Text);
            float z2 = 4;
            //point3
            PointF P3 = new PointF();
            P3.X = 123;
            P3.Y = -120;
            float z3 = 1;

            //vector1
            float vec1x = P2.X - P1.X;
            float vec1y = P2.Y - P1.Y;
            float vec1z = z2-z1;
            //vector2
            float vec2x = P3.X - P1.X;
            float vec2y = P3.X - P1.X;
            float vec2z = z3-z1;

            //(p2-p1)x(p3-p1) = A
            float[] product = { vec1y*vec2z - vec1z*vec2y, vec1z*vec2x - vec1x*vec2z,  vec1x*vec2y - vec1y*vec2x};

            String text = "\n[" + product[0] + ", " + product[1] + ", " + product[2] + "]" + " * [x-" + P1.X + ", x-" + P1.Y + "x-0]=0";

            textBox11.Text = "Given P3 = [" + P3.X + ", " + P3.Y + ", " + z3  +  "]:" + text;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            textBox11.Text = String.Empty;
        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
