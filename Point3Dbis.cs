using System;
using System.Collections.Generic;
using System.Text;

namespace fr.dessin
{
    public class Point3Dbis
    {
        private int x;
        private int y;
        private int z;
        public Point3Dbis(Point2D point, int z)
        {
            this.x = point.GetX();
            this.y = point.GetY();
            this.z = z;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public int GetZ()
        {
            return this.z;
        }

        public void SetX(int x)
        {
            this.x = x;
        }

        public void SetY(int y)
        {
            this.y = y;
        }

        public void SetZ(int z)
        {
            this.z = z;
        }

        public override string ToString()
        {
            return $"[{GetX()}, {GetY()}, {GetZ()}]";
        }

        public void Translater(int dX, int dY, int dZ)
        {
            SetX(GetX() + dX);
            SetY(GetY() + dY);
            SetZ(GetZ() + dZ);
        }
    }
}
