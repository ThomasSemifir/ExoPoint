using System;

namespace fr.dessin
{
    class Program
    {
        static void Main(string[] args)
        {
            Point2D p1 = new Point2D();
            Point2D p2 = new Point2D(1,2);
            Point3D p3 = new Point3D(3, 3, 3);
            Point3Dbis p3b = new Point3Dbis(p2, 3);

            p1.Afficher();
            p2.Afficher();
            p3.Afficher();
            Console.WriteLine(p3b.ToString());

            p1.Translater(1, 2);
            p2.Translater(3, 4);
            p3.Translater(1, 1, 1);
            p3b.Translater(1, 2, 3);

            p1.Afficher();
            p2.Afficher();
            p3.Afficher();
            Console.WriteLine(p3b.ToString());

            Console.WriteLine(Point2D.GetCompteur());
        }
    }
}
