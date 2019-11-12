namespace Tema_5._2_Ex5
{
    class Rectangle : Shape
    {
        public Rectangle(double width, double heigth) : base(width, heigth)
        {

        }

        public override double CallculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
