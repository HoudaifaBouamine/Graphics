using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Render
{
    public partial class frm_Screen : Form
    {
        public frm_Screen()
        {
            InitializeComponent();
        }

        struct stPoint
        {
            public float x, y, z;

           public stPoint(float x,float y,float z)
            {   
                this.x = x;
                this.y = y;
                this.z = z;
            }


            public stPoint move(float x, float y, float z)
            {
                this.x += x;
                this.y += y;
                this.z += z;

                return this;
            }
            public void rotate_ox(stPoint originPoint, float angleOX)
            {
                float dy = this.y - originPoint.y;
                float dz = this.z - originPoint.z;

                float new_dy = Convert.ToSingle(dy * Math.Cos(angleOX) - dz * Math.Sin(angleOX));
                float new_dz = Convert.ToSingle(dy * Math.Sin(angleOX) + dz * Math.Cos(angleOX));

                this.y = originPoint.y + new_dy;
                this.z = originPoint.z + new_dz;
            }

            public void rotate_oy(stPoint originPoint, float angleOY)
            {

                float dx = this.x - originPoint.x;
                float dz = this.z - originPoint.z;

                float new_dx =  Convert.ToSingle(dx * Math.Cos(angleOY) - dz * Math.Sin(angleOY));
                float new_dz = Convert.ToSingle(dx * Math.Sin(angleOY) + dz * Math.Cos(angleOY));

                this.x = originPoint.x + new_dx;
                this.z = originPoint.z + new_dz;
            }

            public void rotate_oz(stPoint originPoint, float angleOZ)
            {
                float dx = this.x - originPoint.x;
                float dy = this.y - originPoint.y;

                float new_dx = Convert.ToSingle(dx * Math.Cos(angleOZ) - dy * Math.Sin(angleOZ));
                float new_dy = Convert.ToSingle(dx * Math.Sin(angleOZ) + dy * Math.Cos(angleOZ));

                this.x = originPoint.x + new_dx;
                this.y = originPoint.y + new_dy;
            }

            public stPoint rotatePoint(stPoint originPoint, float angleOX, float angleOY, float angleOZ)
            {


                rotate_ox(originPoint, angleOX);
                rotate_oy(originPoint, angleOY);
                rotate_oz(originPoint, angleOZ);

                return this;
            }
        }

        

        struct stShap
        {

            

            public List<stPoint> points;

            public stShap(Graphics g,Pen pen)
            {
                points = new List<stPoint>();
                _g = g;
                _pen = pen;
            }

            public void draw()
            {
                for (int i = 0;i < points.Count; i++)
                {
                    _g.DrawRectangle(_pen, points[i].x, points[i].y, 1, 1);
                }
            }

            public void rotate(stPoint origin,float angleOX,float angleOY,float angleOZ)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    points[i] = points[i].rotatePoint(origin, angleOX,  angleOY,  angleOZ);
                }
            }

            public void move(float x,float y,float z)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    points[i] = points[i].move(x,y,z);
                }
            }

            
            
            private Graphics _g;
            private Pen _pen;
        }
        struct stApp
        {
            public Graphics gfx;
            public Pen pen;
            public Pen background;
            public Bitmap screen;

            public void clear()
            {
                gfx.Clear(background.Color);
            }

            public List<stShap> shaps;
        }

        stApp app;


        stShap Cube;
        private void Form1_Load(object sender, EventArgs e)
        {

            app = new stApp();

            app.screen = new Bitmap(pb_drawing.Width, pb_drawing.Height);

            app.gfx = Graphics.FromImage(app.screen);
            app.gfx.FillRectangle(Brushes.Black, 0, 0, pb_drawing.Width, pb_drawing.Height);
            app.pen = new Pen(Color.White, 3);
            app.background = new Pen(Color.Black, 3);

            Cube = new stShap(app.gfx, app.pen);
            float cube_size = 100;
            stPoint pos = new stPoint(100, 100, 0);
            Cube.rotate(new stPoint(150, 150, 50),0.2f,0.2f,0.2f);

            Cube.points.Add(new stPoint(pos.x, pos.y, pos.z));
            Cube.points.Add(new stPoint(pos.x + cube_size, pos.y, pos.z));
            Cube.points.Add(new stPoint(pos.x, pos.y + cube_size, pos.z));
            Cube.points.Add(new stPoint(pos.x + cube_size, pos.y + cube_size, pos.z));


            Cube.points.Add(new stPoint(pos.x, pos.y, pos.z + cube_size));
            Cube.points.Add(new stPoint(pos.x + cube_size, pos.y, pos.z + cube_size));
            Cube.points.Add(new stPoint(pos.x, pos.y + cube_size, pos.z + cube_size));
            Cube.points.Add(new stPoint(pos.x + cube_size, pos.y + cube_size, pos.z + cube_size));

            app.gfx.Clear(Color.Black);
            app.clear();
            Cube.draw();

            pb_drawing.Image = app.screen;

            Fram.Start();

        }
        int counter = 0;

        private void Fram_Tick(object sender, EventArgs e)
        {
            counter++;
            Cube.rotate(new stPoint(150, 150, 50), 0.01f, -0.01f, 0.005f);
            //Cube.move(1, 1, 1);
            app.clear();
            Cube.draw();
           // label2.Text = string.Format( "x = {0}, y = {1}", Cube.points[0].x, Cube.points[0].y);
            //label1.Text = counter.ToString();

            pb_drawing.Image = app.screen;

        }

        private stShap CreateCube (stPoint pos,float cube_size)
        {
            stShap Cube = new stShap(app.gfx,app.pen);

            Cube.points.Add(new stPoint(pos.x, pos.y, pos.z));
            Cube.points.Add(new stPoint(pos.x + cube_size, pos.y, pos.z));
            Cube.points.Add(new stPoint(pos.x, pos.y + cube_size, pos.z));
            Cube.points.Add(new stPoint(pos.x + cube_size, pos.y + cube_size, pos.z));


            Cube.points.Add(new stPoint(pos.x, pos.y, pos.z + cube_size));
            Cube.points.Add(new stPoint(pos.x + cube_size, pos.y, pos.z + cube_size));
            Cube.points.Add(new stPoint(pos.x, pos.y + cube_size, pos.z + cube_size));
            Cube.points.Add(new stPoint(pos.x + cube_size, pos.y + cube_size, pos.z + cube_size));

            return Cube;
        }

   

        private void pb_draw_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_MousePos.Text = string.Format( "[{0},{1}]",e.Location.X,e.Location.Y );
        }
    }
}
