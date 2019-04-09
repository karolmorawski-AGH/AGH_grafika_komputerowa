using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cwiczenie3
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

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            textBox5.Text = String.Empty;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
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
            float delta = (P2.X - P1.X)*(P3.Y-P4.Y)-(P3.X-P4.X)*(P2.Y-P1.Y);
            if(delta == 0)
            {
                textBox5.Text = "Proste są rownolegle";
                return;
            }

            float deltami = (P3.X - P1.X) * (P3.Y - P4.Y) - (P3.X - P4.X) * (P3.Y - P1.Y);
            float mi = deltami / delta;

            float x = (1 - mi) * P1.X + mi * P2.X;
            float y = (1 - mi) * P1.Y + mi * P2.Y;
            string msg = "Lines intersect at: (" + x + ", " + y + ")";
            textBox5.Text = msg;

        }

        private void Label13_Click(object sender, EventArgs e)
        {

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
            textBox5.Text = msg;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //line 1
            float a;
            float b;
            a = (float)Double.Parse(x_1.Text);
            b = (float)Double.Parse(y_1.Text);

            //Plaszczyzna: 
            float n = 50;
            float k = 100;

            float mi = (k - n * b) / (n * a);

            string msg = "mi=" + mi;
            textBox5.Text = msg;

        }

        private void Label15_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            PointF P1 = new PointF();
            PointF P2 = new PointF();
            P1.X = (float)Double.Parse(x_1.Text);
            P1.Y = (float)Double.Parse(y_1.Text);
            P2.X = (float)Double.Parse(x_2.Text);
            P2.Y = (float)Double.Parse(y_2.Text);
            //point3
            PointF P3 = new PointF();
            P3.X = 123;
            P3.Y = -120;

            //vector1
            float vec1a = P2.X - P1.X;
            float vec1b = P2.Y - P1.Y;
            //vector2
            float vec2a = P3.X - P1.X;
            float vec2b = P3.X - P1.X;



            float product = vec1a * vec2b - vec1b - vec2a;

            
        }
    }
}
