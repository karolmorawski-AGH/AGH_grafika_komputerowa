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

        double determineSide(PointF a, PointF b, PointF c)
        {
            double wynik = 0;
            wynik = a.X * b.Y + b.X * c.Y + c.X * a.Y - b.Y * c.X - c.Y * a.X - a.Y * b.X;
            return wynik;
        }
        private void Button3_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            double px = double.Parse(textBox1.Text);
            float pointx = (float)(px);

            double py = double.Parse(textBox2.Text);
            float pointy = (float)(py);

            //line
            PointF p1 = new PointF();
            PointF p2 = new PointF();
            p1.X = -100;
            p1.Y = 100;
            p2.X = 100;
            p2.Y = -100;
            g.DrawLine(pen1, p1, p2);

            PointF p = new PointF();
            p.X = pointx;
            p.Y = pointy;

            //Draw point
            int radius = 2;
            Rectangle rect = new Rectangle((int)(p.X - radius), (int)(p.Y - radius), radius * 2, radius * 2);
            g.DrawEllipse(pen2, rect);

            //Side determination
            double side = determineSide(p1, p2, p);

            if (side > 0)
            {
              richTextBox1.Text = "Right side";
            }
            else if (side == 0)
            {
                richTextBox1.Text = "Collinear";
            }
            else {
                richTextBox1.Text = "Left side";
            }

        }

        bool isCrossing(PointF a, PointF b, PointF c, PointF d)
        {
            double side1 = Math.Sign(determineSide(a, b, c));
            double side2 = Math.Sign(determineSide(a, b, d));
            double side3 = Math.Sign(determineSide(c, d, a));
            double side4 = Math.Sign(determineSide(c, d, b));

            if(belongsTo(a,b,c) || belongsTo(a, b, d) || belongsTo(c, d, a) || belongsTo(c, d, b))
            {
                return true;
            }
            else if (side1 != side2 && side3 != side4) {
                return true;
            }
            else
            {
                return false;
            }

        }

        bool belongsTo(PointF a, PointF b, PointF c)
        {
            if (determineSide(a, b, c) == 0 && a.X <= c.X && c.X <= b.X && a.Y <= c.Y && c.Y <= b.Y)
            {
                return true;
            }
            return false;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            //line
            double l1px = double.Parse(textBox8.Text);
            float line1x = (float)(l1px);

            double l1py = double.Parse(textBox7.Text);
            float line1y = (float)(l1py);

            double l2px = double.Parse(textBox14.Text);
            float line2x = (float)(l2px);

            double l2py = double.Parse(textBox13.Text);
            float line2y = (float)(l2py);

            //stock line
            PointF p3 = new PointF();
            PointF p4 = new PointF();
            p3.X = line1x;
            p3.Y = line1y;
            p4.X = line2x;
            p4.Y = line2y;

            richTextBox1.Text = "1x: " + line1x;

            //stock line
            PointF p1 = new PointF();
            PointF p2 = new PointF();
            p1.X = -50;
            p1.Y = 100;
            p2.X = -100;
            p2.Y = 50;

            g.DrawLine(pen1, p1, p2);
            g.DrawLine(pen1, p3, p4);

            if(isCrossing(p1,p2,p3,p4))
            {
                richTextBox1.Text = "Lines crossing";
            }
            else
            {
                richTextBox1.Text = "Lines not crossing";
            }

            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            double px = double.Parse(textBox10.Text);
            float pointx = (float)(px);

            double py = double.Parse(textBox9.Text);
            float pointy = (float)(py);

            PointF p = new PointF();
            p.X = pointx;
            p.Y = pointy;

            //Draw point
            int radius = 2;
            Rectangle rect = new Rectangle((int)(p.X - radius), (int)(p.Y - radius), radius * 2, radius * 2);
            g.DrawEllipse(pen2, rect);
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            //Point 1
            double p1x = double.Parse(textBox4.Text);
            float pointx1 = (float)(p1x);

            double p1y = double.Parse(textBox3.Text);
            float pointy1 = (float)(p1y);

            //Point 2
            double p2x = double.Parse(textBox12.Text);
            float pointx2 = (float)(p2x);

            double p2y = double.Parse(textBox11.Text);
            float pointy2 = (float)(p2y);

            //line
            PointF p1 = new PointF();
            PointF p2 = new PointF();
            p1.X = -100;
            p1.Y = 100;
            p2.X = 100;
            p2.Y = -100;
            g.DrawLine(pen1, p1, p2);

            //Points
            PointF pu1 = new PointF();
            pu1.X = pointx1;
            pu1.Y = pointy1;

            PointF pu2 = new PointF();
            pu2.X = pointx2;
            pu2.Y = pointy2;

            //Draw point
            int radius = 2;
            Rectangle point1 = new Rectangle((int)(pu1.X - radius), (int)(pu1.Y - radius), radius * 2, radius * 2);
            Rectangle point2 = new Rectangle((int)(pu2.X - radius), (int)(pu2.Y - radius), radius * 2, radius * 2);
            g.DrawEllipse(pen2, point1);
            g.DrawEllipse(pen2, point2);
            
            //Side determination
            double side1 = determineSide(p1, p2, pu1);
            double side2 = determineSide(p1, p2, pu2);

            if ((side1 > 0 && side2 > 0) || (side1 == 0 && side2 == 0) || (side1 < 0 && side2 < 0)) 
            {
                richTextBox1.Text = "Same side";
            }
            else
            {
                richTextBox1.Text = "Not same side";
            }
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";

            double px = double.Parse(textBox6.Text);
            float pointx = (float)(px);

            double py = double.Parse(textBox5.Text);
            float pointy = (float)(py);

            //line
            PointF p1 = new PointF();
            PointF p2 = new PointF();
            p1.X = -100;
            p1.Y = 100;
            p2.X = 100;
            p2.Y = -100;
            g.DrawLine(pen1, p1, p2);

            PointF p = new PointF();
            p.X = pointx;
            p.Y = pointy;

            //Draw point
            int radius = 2;
            Rectangle rect = new Rectangle((int)(p.X - radius), (int)(p.Y - radius), radius * 2, radius * 2);
            g.DrawEllipse(pen2, rect);

            //Side determination
            double side = determineSide(p1, p2, p);

            //TODO
            if (side == 0 && p.X >= p1.X && p.X < p2.X && p.Y >= p2.Y && p.Y <= p1.Y)
            {
                richTextBox1.Text = "Point belongs to line";
            }
            else
            {
                richTextBox1.Text = "Point does not belong to line";
            }
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox9_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
