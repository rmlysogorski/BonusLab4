using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BONUS4
{
    class OOValidator
    {
        public int GetInt(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if(int.TryParse(input, out int userInt))
            {
                return userInt;
            }
            else
            {
                Console.WriteLine("Error! Invalid integer value. Try again.");
                return GetInt(prompt);
            }
        }

        public int GetIntWithinRange(string prompt, int min, int max)
        {
            int input = GetInt(prompt);

            if(input > max)
            {
                Console.WriteLine($"Error! Number must be less than {max + 1}");
                return GetIntWithinRange(prompt, min, max);
            }
            if(input < min)
            {
                Console.WriteLine($"Error! Number must be higher than {min - 1}");
                return GetIntWithinRange(prompt, min, max);
            }
            else
            {
                return input;
            }

        }

        public double GetDouble(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();

            if (double.TryParse(input, out double userDouble))
            {
                return userDouble;
            }
            else
            {
                Console.WriteLine("Error! Invalid decimal value. Try again.");
                return GetDouble(prompt);
            }
        }

        public double GetDoubleWithinRange(string prompt, double min, double max)
        {
            double input = GetDouble(prompt);

            if (input > max)
            {
                Console.WriteLine($"Error! Number must be less than {max + 1}");
                return GetDoubleWithinRange(prompt, min, max);
            }
            if (input < min)
            {
                Console.WriteLine($"Error! Number must be higher than {min - 1}");
                return GetDoubleWithinRange(prompt, min, max);
            }
            else
            {
                return input;
            }
        }
    }
}
