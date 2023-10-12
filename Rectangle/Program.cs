using Rectangle;

var num = new Rectangle();

namespace Rectangle.rectangle
{
    internal class Rectangle
    {
        public Rectangle(POINT a, POINT b,  POINT c, POINT d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public POINT A { get; set; }
        public POINT B { get; set; }
        public POINT C { get; set; }
        public POINT D { get; set; }

        private double GetLength(POINT A, POINT B)
        {
            return Math.Sqrt(Math.Pow(A.x - B.x, 2) + Math.Pow(B.y - A.y, 2));
        }
    }
}