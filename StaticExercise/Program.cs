namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in a temp in Fahrenheit and I'll convert it to Celsius:");
            double fTemp = double.Parse(Console.ReadLine());
            Console.WriteLine($"{fTemp} F is equal to {TempConverter.FahrenheitToCelsius(fTemp)} C");
            Console.WriteLine();
            Console.WriteLine("Put in a temp in Celsius and I'll convert it to Fahrenheit:");
            double cTemp = double.Parse(Console.ReadLine());
            Console.WriteLine($"{cTemp} C is equal to {TempConverter.CelsiusToFahrenheit(cTemp)} F");
        }
    }
}
