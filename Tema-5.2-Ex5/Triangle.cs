namespace Tema_5._2_Ex5
{
    class Triangle : Shape
    {
        public Triangle(double width, double heigth) : base(width, heigth)
        {

        }

        public override double CallculateSurface()
        {
            return (this.Width * 2) * this.Height;
        }
    }
}
