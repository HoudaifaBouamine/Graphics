using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Engine
{
    internal class clsApp
    {


        static float SCREEN_WIDTH;
        static float SCREEN_HEIGHT;
        public System.Drawing.Graphics gfx;
        public Pen pen;
        public Pen background;
        public Bitmap screen;
        public PictureBox pictureBox;
        public clsFlags flags;
        public void clear()
        {
            gfx.Clear(background.Color);
        }

        public void draw()
        {
            pictureBox.Image = screen;

            foreach (clsShap shap in shaps)
            {
                shap.draw();
            }
        }

        public clsApp(PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
            this.screen = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);

            SCREEN_HEIGHT = pictureBox.Height;
            SCREEN_WIDTH = pictureBox.Width;

            this.flags = new clsFlags();
            this.gfx = System.Drawing.Graphics.FromImage(this.screen);
            this.gfx.FillRectangle(Brushes.Black, 0, 0, pictureBox.Width, pictureBox.Height);
            this.pen = new Pen(Color.White, 3);
            this.background = new Pen(Color.Black, 3);
        }

        public void update()
        {

            foreach (clsShap shap in shaps)
            {
                shap.update();
            }

        }

        public List<clsShap> shaps= new List<clsShap> ();

        static public clsApp app ;

    }


}

