namespace Tema_5._2_Ex5
{
    public abstract class Shape
    {
        public double Width;
        public double Height;


        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public abstract double CallculateSurface();
    }
}
