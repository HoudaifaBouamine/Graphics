using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_Engine
{
    internal class clsUpdate
    {

        public float dx, dy, dz;

        public float d_angle_ox, d_angle_oy, d_angle_oz;
        public float dc_angle_ox, dc_angle_oy, dc_angle_oz;

        public clsVector rotate_point;
        public bool b_rotate_center;
        public bool b_rotate_point;

        public clsUpdate(clsVector velocity, clsVector rotation, clsVector rotation_center)
        {
            this.dx = velocity.x;
            this.dy = velocity.y;
            this.dz = velocity.z;
            this.d_angle_ox = rotation.x;
            this.d_angle_oy = rotation.y;
            this.d_angle_oz = rotation.z;

            this.dc_angle_ox = rotation_center.x;
            this.dc_angle_oy = rotation_center.y;
            this.dc_angle_oz = rotation_center.z;

            this.b_rotate_center = false;
            this.b_rotate_point = true;

        }
        static public clsUpdate no()
        {
            clsUpdate u = new clsUpdate();
            u.dx = 0;
            u.dy = 0;
            u.dz = 0;
            u.d_angle_ox = 0;
            u.d_angle_oy = 0;
            u.d_angle_oz = 0;
            u.rotate_point = new clsVector(0, 0, 0);
            u.b_rotate_point = false;
            u.b_rotate_center = false;

            return u;
        }



        public clsUpdate()
        {

        }
    }
}
