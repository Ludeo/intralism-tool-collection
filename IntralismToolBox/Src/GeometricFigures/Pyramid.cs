namespace IntralismToolBox.GeometricFigures
{
    public class Pyramid
    {
        private double Height { get; set; }

        private double Length { get; set; }

        private double Width { get; set; }

        public Pyramid() {}

        public double GetCenterY(double h) => h / 2;
    }
}
