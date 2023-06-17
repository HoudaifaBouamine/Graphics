using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_Engine
{
    internal class clsShap
    {
        public static int counter = 1;
        public string name = "shap";
        public clsVector center;
        public List<clsVector> points;
        public List<clsLine> lines;
        public clsUpdate update_args;
        public System.Drawing.Graphics gfx;
        public Pen pen;

        public clsShap(System.Drawing.Graphics g, Pen pen, clsUpdate update_args)
        {
            this.name = "shap" + Convert.ToString(counter++);
            this.lines = new List<clsLine>();
            this.points = new List<clsVector>();
            this.gfx = g;
            this.pen = pen;
            this.update_args = update_args;
            this.center = new clsVector(0, 0, 0);
        }

        public void draw()
        {
            // Drawing Lines;

            for (int i = 0; i < lines.Count; i++)
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

            lines.Add(new clsLine(gfx, pen, point_1_index, point_2_index));

        }
        public void rotate(clsVector origin, float angleOX, float angleOY, float angleOZ)
        {

           

                for (int i = 0; i < points.Count; i++)
                {
                    points[i] = points[i].rotatePoint(origin, angleOX, angleOY, angleOZ);
                }

                center = center.rotatePoint(origin, angleOX, angleOY, angleOZ);
            


         
        }

        public void move(float x, float y, float z)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = points[i].move(x, y, z);
            }

            center = center.move(x, y, z);
        }

        public void update()
        {
            move(update_args.dx, update_args.dy, update_args.dz);

            if (this.update_args.b_rotate_center)
            {
                rotate(center, update_args.dc_angle_ox, update_args.dc_angle_oy, update_args.dc_angle_oz);
            }

            if (this.update_args.b_rotate_point)
            {
                rotate(update_args.rotate_point, update_args.d_angle_ox, update_args.d_angle_oy, update_args.d_angle_oz);
            }
        }

        public static clsShap CreateCuboid(clsVector pos, float width, float hight, float depth, clsUpdate update_args)
        {
            clsShap Ciboid = new clsShap(clsApp.app.gfx, clsApp.app.pen, update_args);

            Ciboid.points.Add(new clsVector(pos.x, pos.y, pos.z));
            Ciboid.points.Add(new clsVector(pos.x + width, pos.y, pos.z));
            Ciboid.points.Add(new clsVector(pos.x, pos.y + hight, pos.z));
            Ciboid.points.Add(new clsVector(pos.x + width, pos.y + hight, pos.z));


            Ciboid.points.Add(new clsVector(pos.x, pos.y, pos.z + depth));
            Ciboid.points.Add(new clsVector(pos.x + width, pos.y, pos.z + depth));
            Ciboid.points.Add(new clsVector(pos.x, pos.y + hight, pos.z + depth));
            Ciboid.points.Add(new clsVector(pos.x + width, pos.y + hight, pos.z + depth));

            Ciboid.center = new clsVector(pos.x + width / 2, pos.y + hight / 2, pos.z + depth / 2);

            Ciboid.link(0, 1);
            Ciboid.link(2, 3);
            Ciboid.link(0, 2);
            Ciboid.link(1, 3);

            Ciboid.link(0 + 4, 1 + 4);
            Ciboid.link(2 + 4, 3 + 4);
            Ciboid.link(0 + 4, 2 + 4);
            Ciboid.link(1 + 4, 3 + 4);

            Ciboid.link(0, 4);
            Ciboid.link(1, 5);
            Ciboid.link(2, 6);
            Ciboid.link(3, 7);
            return Ciboid;
        }


        public static clsShap CreateCuboid(clsVector pos, clsVector size,clsUpdate update)
        {
            return CreateCuboid(pos, size.x, size.y,size.z, update);
        }

    }
}
