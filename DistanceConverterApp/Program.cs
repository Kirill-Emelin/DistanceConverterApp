namespace DistanceConverterApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Мили в километры");
            Console.WriteLine("2. Километры в мили");

            // Считываем выбор операции от пользователя
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Введите скорость в милях/час: ");
                double milesPerHour = Convert.ToDouble(Console.ReadLine());
                double kilometersPerHour = DistanceConverter.MilesToKilometers(milesPerHour);
                Console.WriteLine($"{milesPerHour} миль/час = {kilometersPerHour} км/ч");
            }
            else if (choice == 2)
            {
                Console.Write("Введите скорость в километрах/час: ");
                double kilometersPerHour = Convert.ToDouble(Console.ReadLine());
                double milesPerHour = DistanceConverter.KilometersToMiles(kilometersPerHour);
                Console.WriteLine($"{kilometersPerHour} км/ч = {milesPerHour} миль/час");
            }
            else
            {
                Console.WriteLine("Неверный выбор.");
            }
        }
    }

    public static class DistanceConverter
    {
        public static double MilesToKilometers(double distanceMiles)
        {
            double miles = distanceMiles;

            // Конвертируем мили в километры.
            double kilometers = miles * 1.60934;

            return kilometers;
        }

        public static double KilometersToMiles(double distanceKilometers)
        {
            double kilometers = distanceKilometers;

            // Конвертируем километры в мили.
            double miles = kilometers / 1.60934;

            return miles;
        }
    }
}