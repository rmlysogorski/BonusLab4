using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BONUS4
{
    class ValidatorTestApp
    {
        public static void TestEverything()
        {
            MyValidator tester = new MyValidator();
            int intTest;
            double doubleTest;
            string stringTest;

            Console.WriteLine("Welcome to the Validation Tester Application\n");
            Console.WriteLine("Int Test");
            intTest = tester.GetIntWithinRange("Enter an integer between -100 and 100: ", -100, 100);
            Console.WriteLine($"You entered {intTest}.\n");

            Console.WriteLine("\nDouble Test");
            doubleTest = tester.GetDoubleWithinRange("Enter any number between -100 and 100: ", -100, 100);
            Console.WriteLine($"You entered {doubleTest:0.00}.\n");

            Console.WriteLine("String Test");
            stringTest = tester.GetChoiceString("Please enter 'yes' or 'no': ", "yes", "no");
            Console.WriteLine($"You entered {stringTest}");
        }
    }
}
