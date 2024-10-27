namespace GradingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numeric or letter grade: ");
            string? sInput = Console.ReadLine();

            string output = "";
            double numericValue;
            if (double.TryParse(sInput, out numericValue))
            {
                if (numericValue <= 59)
                {
                    output = "f";
                }
                else if (numericValue <= 69)
                {
                    output = "d";
                }
                else if (numericValue <= 79)
                {
                    output = "c";
                }
                else if (numericValue <= 89)
                {
                    output = "b";
                }
                else if (numericValue <= 100)
                {
                    output = "a";
                }
                else
                {
                    output = "out of range";
                }
                Console.WriteLine(output.ToUpper());
                Console.ReadLine();
            }
            else
            {
                if (sInput == null)
                {
                    return;
                }
                switch (sInput.ToLower())
                {
                    case "f":
                        output = "0-59";
                        break;
                    case "d":
                        output = "60-69";
                        break;
                    case "c":
                        output = "70-79";
                        break;
                    case "b":
                        output = "80-89";
                        break;
                    case "a":
                        output = "90-100";
                        break;
                    default:
                        output = "invalid input";
                        break;
                }
                Console.WriteLine(output);
                Console.ReadLine();
            }
        }
    }
}
