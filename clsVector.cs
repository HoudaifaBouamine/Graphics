using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_Engine
{
    internal class clsVector
    {
        public float x, y, z;

        public clsVector(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public clsVector move(float x, float y, float z)
        {

            this.x += x;
            this.y += y;
            this.z += z;

            return this;
        }
        public void rotate_ox(clsVector originPoint, float angleOX)
        {
            float dy = this.y - originPoint.y;
            float dz = this.z - originPoint.z;

            float new_dy = Convert.ToSingle(dy * Math.Cos(angleOX) - dz * Math.Sin(angleOX));
            float new_dz = Convert.ToSingle(dy * Math.Sin(angleOX) + dz * Math.Cos(angleOX));

            this.y = originPoint.y + new_dy;
            this.z = originPoint.z + new_dz;
        }

        public void rotate_oy(clsVector originPoint, float angleOY)
        {

            float dx = this.x - originPoint.x;
            float dz = this.z - originPoint.z;

            float new_dx = Convert.ToSingle(dx * Math.Cos(angleOY) - dz * Math.Sin(angleOY));
            float new_dz = Convert.ToSingle(dx * Math.Sin(angleOY) + dz * Math.Cos(angleOY));

            this.x = originPoint.x + new_dx;
            this.z = originPoint.z + new_dz;
        }

        public void rotate_oz(clsVector originPoint, float angleOZ)
        {
            float dx = this.x - originPoint.x;
            float dy = this.y - originPoint.y;

            float new_dx = Convert.ToSingle(dx * Math.Cos(angleOZ) - dy * Math.Sin(angleOZ));
            float new_dy = Convert.ToSingle(dx * Math.Sin(angleOZ) + dy * Math.Cos(angleOZ));

            this.x = originPoint.x + new_dx;
            this.y = originPoint.y + new_dy;
        }

        public clsVector rotatePoint(clsVector originPoint, float angleOX, float angleOY, float angleOZ)
        {


            rotate_ox(originPoint, angleOX);
            rotate_oy(originPoint, angleOY);
            rotate_oz(originPoint, angleOZ);

            return this;
        }
    
    }
}
