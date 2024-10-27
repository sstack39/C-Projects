namespace TemperatureConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter temperature value: ");
            string? sInput = Console.ReadLine();
            Console.WriteLine("Enter C for Celsius, enter F for Fahrenheit: ");
            char type = (char)Console.Read();
            Console.ReadLine();
            if (type == 'c')
            {
                double temperatureInput;
                if (double.TryParse(sInput, out temperatureInput))
                {
                    double f = ((9 / 5) * temperatureInput) + 32;
                    Console.WriteLine($"{temperatureInput} Celsius is {f} Fahrenheit");
                    Console.ReadLine();
                }

            }
            else if (type == 'f')
            {
                double temperatureInput;
                if (double.TryParse(sInput, out temperatureInput))
                {
                    double c = ((temperatureInput - 32) * (5 / 9));
                    Console.WriteLine($"{temperatureInput} Fahrenheit is {c} Celsius");
                    Console.ReadLine();
                }
            }
        }
    }
}
