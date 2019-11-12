namespace Tema_5._2_Ex5
{
    class Square : Shape
    {
        public Square(double width) : base(width, width)
        {

        }

        public override double CallculateSurface()
        {
            return this.Width * this.Height;
        }
    }
}
