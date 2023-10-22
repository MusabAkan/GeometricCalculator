namespace GeometricCalculator
{
    class GeometricCalculator
    {
        public static double CalculateArea(string shape, double[] sides)
        {
            switch (shape.ToLower())
            {
                case "daire":
                    double radius = sides[default(int)];
                    return Math.PI * radius * radius;
                case "üçgen":
                    double a = sides[default(int)];
                    double b = sides[1];
                    double c = sides[2];
                    double s = (a + b + c) / 2;
                    return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                case "kare":
                    double side = sides[default(int)];
                    return side * side;
                case "dikdörtgen":
                    double width = sides[default(int)];
                    double height = sides[1];
                    return width * height;
                default:
                    throw new ArgumentException("Geçersiz geometrik şekil.");
            }
        }

        public static double CalculatePerimeter(string shape, double[] sides)
        {
            switch (shape.ToLower())
            {
                case "daire":
                    double radius = sides[default(int)];
                    return 2 * Math.PI * radius;
                case "üçgen":
                    double a = sides[default(int)];
                    double b = sides[1];
                    double c = sides[2];
                    return a + b + c;
                case "kare":
                    double side = sides[default(int)];
                    return 4 * side;
                case "dikdörtgen":
                    double width = sides[default(int)];
                    double height = sides[1];
                    return 2 * (width + height);
                default:
                    throw new ArgumentException("Geçersiz geometrik şekil.");
            }
        }
    }
}
