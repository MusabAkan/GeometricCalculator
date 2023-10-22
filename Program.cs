 class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Geometrik şekli girin (Daire, Üçgen, Kare, Dikdörtgen): ");
            string shape = Console.ReadLine();

            Console.Write("Kenar bilgilerini virgülle ayırarak girin (Örnek: 2,3,4): ");
            string sidesInput = Console.ReadLine();
            double[] sides = Array.ConvertAll(sidesInput.Split(','), double.Parse);

            Console.Write("Hesaplanmak istenen boyutu girin (Çevre, Alan): ");
            string calculationType = Console.ReadLine();

            if (calculationType.ToLower() == "alan")
            {
                double area = GeometricCalculator.GeometricCalculator.CalculateArea(shape, sides);
                Console.WriteLine($"Sonuç: {area:F2}");
            }
            else if (calculationType.ToLower() == "çevre")
            {
                double perimeter = GeometricCalculator.GeometricCalculator.CalculatePerimeter(shape, sides);
                Console.WriteLine($"Sonuç: {perimeter:F2}");
            }
            else
            {
                Console.WriteLine("Geçersiz hesaplama tipi.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz giriş.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
