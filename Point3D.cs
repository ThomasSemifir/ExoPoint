using System;
using System.Collections.Generic;
using System.Text;

namespace fr.dessin
{
    class Point3D : Point2D
    {
        private int z;

        public Point3D(): this(0,0,0)
        {
            
        }

        public Point3D(int x, int y, int z) :base(x, y)
        {
            this.z = z;
        }

        public int GetZ()
        {
            return this.z;
        }

        public void SetZ(int z)
        {
            this.z = z;
        }

        public void Translater(int dX, int dY, int dZ)
        {
            this.SetX(GetX() + dX);
            this.SetY(GetY() + dY);
            this.SetZ(GetZ() + dZ);
        }

        public new void Afficher()
        {
            Console.WriteLine($"[{GetX()}, {GetY()}, {GetZ()}]");
        }
    }
}
