using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7w
{
    public partial class Form1 : Form
    {
        private System.Drawing.Graphics g;
        private System.Drawing.Graphics gg;
        System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            gg = pictureBox2.CreateGraphics();
            gg.TranslateTransform(300, 150);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            label1.Text = "R: " + trackBar1.Value.ToString();
            label2.Text = "B: " + trackBar2.Value.ToString();
            label3.Text = "G: " + trackBar3.Value.ToString();
            myBrush.Color = Color.FromArgb(trackBar1.Value, trackBar3.Value, trackBar2.Value);
            g.FillRectangle(myBrush, new Rectangle(0, 0, 300, 300));
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TrackBar2_Scroll(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            label1.Text = "C: : " + trackBar1.Value.ToString();
            label2.Text = "M: " + trackBar2.Value.ToString();
            label3.Text = "Y: " + trackBar3.Value.ToString();
            myBrush.Color = Color.FromArgb(255 - trackBar1.Value, 255 - trackBar3.Value, 255 - trackBar2.Value);
            g.FillRectangle(myBrush, new Rectangle(0, 0, 300, 300));
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            float ra = trackBar1.Value;
            float ba = trackBar2.Value;
            float ga = trackBar3.Value;

            label1.Text = "R: : " + trackBar1.Value.ToString();
            label2.Text = "B: " + trackBar2.Value.ToString();
            label3.Text = "G: " + trackBar3.Value.ToString();

            

            float r = (float)(ra / 255);
            float g = (float)(ga / 255);
            float b = (float)(ba / 255);
            float[] tab = { r, g, b };

            float CMAX = tab.Max();
            float CMIN = tab.Min();
            float delta = CMAX - CMIN;

            //Hue calc
            float h = 0;
            if(delta == 0)
            {
                h = 0;
            }
            if(r == CMAX)
            {
                h = ((g - b) / delta) % 6;
            }
            else if(g==CMAX)
            {
                h = ((b - r) / delta) + 2;
            }
            else if(b == CMAX)
            {
                h = ((r - g) / delta) + 4;
            }

            //Saturation calc
            float s = 0;
            if(CMAX == 0)
            {
                s = 0;
            }
            else
            {
                s = delta / CMAX;
            }

            //Value calc
            float v = CMAX;


            //RGB to HSV


            textBox1.Text = "HSV: (" + h +", " + s + ", " + v + ")";
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //1
            for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    int u = (int)(i * 255.0 / 100);
                    int v = (int)(j * 255.0 / 100);
                    myPen.Color = Color.FromArgb(255 - u, 0, v);
                    gg.DrawRectangle(myPen, 0 + i, 0 + j, 1, 1);
                }
            }


            //2
            for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    int u = (int)(i * 255.0 / 100);
                    int v = (int)(j * 255.0 / 100);
                    myPen.Color = Color.FromArgb(0, 0 + u, 0+v);
                    gg.DrawRectangle(myPen, 0 + i + 101, 0 + j, 1, 1);
                }
            }

            //3
            for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    int u = (int)(i * 255.0 / 100);
                    int v = (int)(j * 255.0 / 100);
                    myPen.Color = Color.FromArgb(0 + u, 255, 0+v);
                    gg.DrawRectangle(myPen, 0 + i+202, 0 + j, 1, 1);
                }
            }

            //4
            for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    int u = (int)(i * 255.0 / 100);
                    int v = (int)(j * 255.0 / 100);
                    myPen.Color = Color.FromArgb(255, 255-u, 0+v);
                    gg.DrawRectangle(myPen, 0 + i-101, 0 + j, 1, 1);
                }
            }

            //5
            for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    int u = (int)(i * 255.0 / 100);
                    int v = (int)(j * 255.0 / 100);
                    //myPen.Color = Color.FromArgb(255-u, 255-v, 0);
                    myPen.Color = Color.FromArgb(255 - u, 0 + v, 255);
                    gg.DrawRectangle(myPen, 0 + i, 0 + j+101, 1, 1);
                }
            }

            //6
            for (int i = 0; i < 101; i++)
            {
                for (int j = 0; j < 101; j++)
                {
                    int u = (int)(i * 255.0 / 100);
                    int v = (int)(j * 255.0 / 100);
                    //myPen.Color = Color.FromArgb(255 - u, 0+v, 255);
                    myPen.Color = Color.FromArgb(255 - u, 255 - v, 0);
                    gg.DrawRectangle(myPen, 0 + i, 0 + j-101, 1, 1);
                }
            }


        }

        

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
