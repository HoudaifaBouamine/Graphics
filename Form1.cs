using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

        struct stLine
        {
            public int p1, p2;

            public stLine(Graphics g,Pen pen,int p1,int p2)
            {
                this.p1 = p1;
                this.p2 = p2;
                _g = g;
                _pen = pen;
            }

            public void draw(stPoint p1,stPoint p2)
            {

                _g.DrawLine(_pen, p1.x, p1.y, p2.x, p2.y);
                
            }

            private Graphics _g;
            private Pen _pen;
        }

        struct stShap
        {

            

            public List<stPoint> points;
            public List<stLine> lines;

            public stShap(Graphics g,Pen pen)
            {
                lines = new List<stLine>();
                points = new List<stPoint>();
                _g = g;
                _pen = pen;
            }

            public void draw()
            {
                // Drawing Lines;

                for(int i = 0; i < lines.Count; i++)
                {
                    lines[i].draw(points[lines[i].p1], points[lines[i].p2]);
                }

                // Drawing Points
                //for (int i = 0;i < points.Count; i++)
                //{
                //    _g.DrawRectangle(_pen, points[i].x, points[i].y, 1, 1);
                //}
            }

            public void link(int point_1_index, int point_2_index)
            {

                lines.Add(new stLine(_g, _pen, point_1_index, point_2_index));

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
            public PictureBox pictureBox;
            public void clear()
            {
                gfx.Clear(background.Color);
            }

            public void draw()
            {
                pictureBox.Image = screen;

                foreach(stShap shap in shaps)
                {
                    shap.draw();
                }
            }

            public static  stApp initApp(PictureBox pictureBox)
            {
                
                stApp app = new stApp();

                app.pictureBox = pictureBox;
                app.screen = new Bitmap(app.pictureBox.Width, app.pictureBox.Height);

                app.gfx = Graphics.FromImage(app.screen);
                app.gfx.FillRectangle(Brushes.Black, 0, 0, pictureBox.Width, pictureBox.Height);
                app.pen = new Pen(Color.White, 3);
                app.background = new Pen(Color.Black, 3);
                app.shaps = new List<stShap>();

                return app;
            }

            public List<stShap> shaps;


        }

        stApp app;
        private void Form1_Load(object sender, EventArgs e)
        {

            app = stApp.initApp(pb_drawing);

            app.shaps.Add(CreateCube(new stPoint(100, 100, 100), 100));
            app.shaps.Add(CreateCuboid(new stPoint(250, 300, 100), 100,50,30));

            Fram.Start();

        }
        int counter = 0;

        private void Fram_Tick(object sender, EventArgs e)
        {
            app.clear();


            app.shaps[0].rotate(new stPoint(150, 150, 150), 0.01f, -0.01f, 0.005f);
            app.shaps[1].rotate(new stPoint(270, 320, 130), 0.01f, 0.02f, 0.01f);

            app.draw();
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

            Cube.link(0, 1);
            Cube.link(2, 3);
            Cube.link(0, 2);
            Cube.link(1, 3);

            Cube.link(0 + 4, 1 + 4);
            Cube.link(2 + 4, 3 + 4);
            Cube.link(0 + 4, 2 + 4);
            Cube.link(1 + 4, 3 + 4);

            Cube.link(0, 4);
            Cube.link(1, 5);
            Cube.link(2, 6);
            Cube.link(3, 7);

            return Cube;
        }

        private stShap CreateCuboid(stPoint pos, float width,float hight,float depth)
        {
            stShap Cube = new stShap(app.gfx, app.pen);

            Cube.points.Add(new stPoint(pos.x, pos.y, pos.z));
            Cube.points.Add(new stPoint(pos.x + width, pos.y, pos.z));
            Cube.points.Add(new stPoint(pos.x, pos.y + hight, pos.z));
            Cube.points.Add(new stPoint(pos.x + width, pos.y + hight, pos.z));


            Cube.points.Add(new stPoint(pos.x, pos.y, pos.z + depth));
            Cube.points.Add(new stPoint(pos.x + width, pos.y, pos.z + depth));
            Cube.points.Add(new stPoint(pos.x, pos.y + hight, pos.z + depth));
            Cube.points.Add(new stPoint(pos.x + width, pos.y + hight, pos.z + depth));

            Cube.link(0, 1);
            Cube.link(2, 3);
            Cube.link(0, 2);
            Cube.link(1, 3);

            Cube.link(0 + 4, 1 + 4);
            Cube.link(2 + 4, 3 + 4);
            Cube.link(0 + 4, 2 + 4);
            Cube.link(1 + 4, 3 + 4);

            Cube.link(0, 4);
            Cube.link(1, 5);
            Cube.link(2, 6);
            Cube.link(3, 7);

            return Cube;
        }



        private void pb_draw_MouseMove(object sender, MouseEventArgs e)
        {
        }
    }
}
