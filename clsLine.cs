using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_Engine
{
    internal class clsLine
    {

        public int p1, p2;

        public clsLine(System.Drawing.Graphics g, Pen pen, int p1, int p2)
        {
            this.p1 = p1;
            this.p2 = p2;
            _g = g;
            _pen = pen;
        }

        public void draw(clsVector p1, clsVector p2)
        {

            _g.DrawLine(_pen, p1.x, p1.y, p2.x, p2.y);

        }

        private System.Drawing.Graphics _g;
        private Pen _pen;
    }
}
