using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        //lines
        private System.Drawing.Graphics g;
        private System.Drawing.Pen pen1 = new System.Drawing.Pen(Color.White, 1);
        //radius
        private System.Drawing.Pen pen2 = new System.Drawing.Pen(Color.Red, 2);

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();
            //sets origin on the middle
            g.TranslateTransform(200, 200);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void Button8_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            //circle radius
            g.DrawLine(pen2, -150, 0, 150, 0); //|r| == 150
            //number of lines circle consists of
            double lines = 1000;
            //alfa and dalfa
            double alfa = 0.0;
            double dalfa = (2 * Math.PI) / lines;
            //for loop
            for(float i = 0; i<lines; i = i + 1)
            {
                alfa = alfa + dalfa;
                //manipulate to change origin
                float rcos = (float)(150 * Math.Cos(alfa));
                float rsin = (float)(150 * Math.Sin(alfa));
                g.DrawLine(pen1, rcos, rsin, rcos + 1, rsin + 1);
            }
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            //circle radius
            g.DrawLine(pen2, -150, 0, 150, 0); //|r| == 150
            double r = 150;
            //number of lines circle consists of
            double lines = 100;
            //alfa and dalfa
            double alfa = 0.0;
            double dalfa = (2 * Math.PI) / lines;
            //for loop
            for (float i = 0; i < lines; i = i + 1)
            {
                alfa = alfa + dalfa;
                g.DrawLine(pen1, (float)(r*Math.Cos(dalfa*i)), (float)(r * Math.Sin(dalfa * i)), (float)(r * Math.Cos(dalfa * (i+60))), (float)(r * Math.Sin(dalfa * (i+60))));
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            //max radius of spiral (value)
            double r = 150;
            //max radius of spiral (visual representation)
            g.DrawLine(pen2, -150, 0, 150, 0); //|r| == 150
            //number of lines representing the spiral
            double lines = 1000;
            //number of coils
            double n = 6;
            //alfa and dalfa
            double alfa = 0.0;
            double dalfa = (2 * Math.PI) / lines;
            //number of iterations nn
            double nn = lines * n;
            //rr number thingy
            double rr = r / nn;

            for (float i = 0; i < nn; i = i + 1)
            {
                alfa = alfa + dalfa;
                float rb = (float)(rr * i);

                //sin + cos
                float sin = (float)(Math.Sin(alfa));
                float cos = (float)(Math.Cos(alfa));

                g.DrawLine(pen1, rb * cos, rb * sin, rb * cos + 1, rb * sin + 1);
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {

            //number of lines circle consists of
            double lines = 1000;
            //number of elipses (vertical and horizontal)
            float elinum = 4;
            //circle radius
           // g.DrawLine(pen2, (elinum-1) * -15, 0, (elinum-1)*15, 0); //|r| == 150
            //alfa and dalfa
            double alfa = 0.0;
            double dalfa = (2 * Math.PI) / lines;
            //for loop
            float r1 = 50;
            float r2 = 70;
            for (float k=0; k<elinum; k++)
            {
              
                for (float i = 0; i < lines; i = i + 1)
                {
                  

                    alfa = alfa + dalfa;
                    //vertical
                    float rcos = (float)(r1 * Math.Cos(alfa));
                    float rsin = (float)(r2 * Math.Sin(alfa));
                    g.DrawLine(pen1, rcos, rsin, rcos + 1, rsin + 1);
                    //horizontal
                    float rcos2 = (float)(r2 * Math.Cos(alfa));
                    float rsin2 = (float)(r1  * Math.Sin(alfa));
                    g.DrawLine(pen1, rcos2, rsin2, rcos2 + 1, rsin2 + 1);

                 

                }
                r1 = r2;
                r2 = r2 + 20;

            }

            alfa = 0.0;
            //for loop
            for (float i = 0; i < lines; i = i + 1)
            {
                alfa = alfa + dalfa;
                //manipulate to change origin
                float rcos = (float)(130 * Math.Cos(alfa));
                float rsin = (float)(130 * Math.Sin(alfa));
                g.DrawLine(pen1, rcos, rsin, rcos + 1, rsin + 1);
            }


        }

        private void Button6_Click(object sender, EventArgs e)
        {
            //max radius of spiral (value)
            double r = 150;
            //max radius of spiral (visual representation)
            g.DrawLine(pen2, -150, 0, 150, 0); //|r| == 300
            //number of lines representing the spiral
            double lines = 700;
            //number of coils
            double n = 2;
            //alfa and dalfa
            double alfa = 0.0;
            double dalfa = (2 * Math.PI) / lines;
            //number of iterations nn
            double nn = lines * n;
            //rr number thingy
            double rr = r / nn;

            for (float i = 0; i < nn; i = i + 1)
            {
                alfa = alfa + dalfa;
                float rb = (float)(rr * i);

                //sin + cos
                float sin = (float)((Math.Sin(alfa)));
                float cos = (float)((Math.Cos(alfa)));
                for(int j=0; j<4; j++)
                {
                    g.DrawLine(pen1, rb * cos, rb * sin, rb * cos + 1, rb * sin + 1);
                    g.RotateTransform(0+j*90);
                }
            }
            //IMPORTANT change origin orientation back to normal
            g.RotateTransform(0);
            //Draw circle
            for (float i = 0; i < lines; i = i + 1)
            {
                alfa = alfa + dalfa;
                //manipulate to change origin
                float rcos = (float)(150 * Math.Cos(alfa));
                float rsin = (float)(150 * Math.Sin(alfa));
                g.DrawLine(pen1, rcos, rsin, rcos + 1, rsin + 1);
            }

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ////circle radius
            //g.DrawLine(pen2, -150, 0, 150, 0); //|r| == 150
            //double r = 15;
            ////number of lines circle consists of
            //double lines = 20;
            ////alfa and dalfa
            //double alfa = 0.0;
            //double dalfa = (2 * Math.PI) / lines;
            ////for loop
            //for (int j = 0; j < 10; j++)
            //{
            //    for (float i = 0; i < lines; i = i + 1)
            //    {
            //        alfa = alfa + dalfa;
            //        g.DrawLine(pen1, (float)(r * Math.Cos(dalfa * i)), (float)(r * Math.Sin(dalfa * i)), (float)(r * Math.Cos(dalfa * (i + 1))), (float)(r * Math.Sin(dalfa * (i + 1))));
            //    }
            //    r = r + 15;
            //}

            float n = 30;
            float thinc = (float)(2 * Math.PI / n);
            float theta = 0.0f;

            Point[] parray = new Point[30];

            for(int i=0; i<n; n++)
            {
                parray[i].X = (int)(6 * Math.Cos(theta * i));
                parray[i].Y = (int)(6 * Math.Sin(theta * i));

                Point temp = new Point();

                temp.X = parray[i].X + 5;
                temp.Y = parray[i].Y + 5;
                g.DrawLine(pen1, parray[i], temp);
            }




        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            //version 1
            //for (int i = 25; i > 0; i--)
            //{
            //    float k = (float)(i * 0.01);
            //    g.DrawLine(pen1, -200 * k, 200 * k, 200 * k, 200 * k);
            //    g.DrawLine(pen1, -200 * k, -200 * k, 200 * k, -200 * k);
            //    g.DrawLine(pen1, -200 * k, -200 * k, -200 * k, 200 * k);
            //    g.DrawLine(pen1, 200 * k, -200 * k, 200 * k, 200 * k);
            //    g.RotateTransform(360/9);
            //}
            //g.RotateTransform(0);

            //g.DrawLine(pen1, -150, 150, 150, 150);
            //g.DrawLine(pen1, -150, -150, 150, -150);
            //g.DrawLine(pen1, -150, -150, -150, 150);
            //g.DrawLine(pen1, 150, -150, 150, 150);


            g.DrawLine(pen1, -150, 150, 150, 150);
            g.DrawLine(pen1, -150, -150, 150, -150);
            g.DrawLine(pen1, -150, -150, -150, 150);
            g.DrawLine(pen1, 150, -150, 150, 150);

            //20 squares and mi value
            float smu = 0.1f;
            float rmu = 1 - smu;


        }
    }
}
