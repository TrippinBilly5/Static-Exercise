namespace StaticExercise
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double tempF)
        {
            return (tempF - 32) / 1.8;
        }
        public static double CelsiusToFahrenheit(double tempC)
        {
            return (tempC * 1.8) + 32;
        }
    }
}
