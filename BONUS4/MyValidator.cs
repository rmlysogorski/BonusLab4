using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BONUS4
{
    class MyValidator : OOValidator
    {
        public string GetRequiredString(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return input;
        }

        public string GetChoiceString(string prompt, string s1, string s2)
        {
            string input = GetRequiredString(prompt);
            
            if(input == s1 || input == s2)
            {
                return input;
            }
            else
            {
                Console.WriteLine("Invalid Input. Please try again.");
                return GetChoiceString(prompt, s1, s2);
            }
        }
    }
}
