using System;
using System.Collections.Generic;
using System.Text;

namespace fr.dessin
{
    public class Point2D
    {
        private int x;
        private int y;
        protected static int compteur;

        public Point2D() : this(0,0)
        {

        }

        public Point2D(int x, int y)
        {
            this.x = x;
            this.y = y;
            compteur++;
        }

        public void SetX(int valX)
        {
            this.x = valX;
        }

        public void SetY(int valY)
        {
            this.y = valY;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

        public void Afficher()
        {
            Console.WriteLine($"[{GetX()}, {GetY()}]");
        }

        public void Translater(int dX, int dY)
        {
            SetX(GetX() + dX);
            SetY(GetY() + dY);
        }

        public static int GetCompteur()
        {
            return compteur;
        }
    }
}
