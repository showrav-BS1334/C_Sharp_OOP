using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP
{
    internal class Problem22
    {
        public void Solve()
        {
            string aboutPerson = "    This is Karim.       ";
            Console.WriteLine(aboutPerson.Length);
            Console.WriteLine(aboutPerson.ToUpper());
            Console.WriteLine(aboutPerson.ToLower());
            Console.WriteLine(aboutPerson.TrimEnd());
            Console.WriteLine(aboutPerson.TrimStart());
            aboutPerson = aboutPerson.Trim();

            // from 0 index, select 3 chars
            Console.WriteLine(aboutPerson.Substring(0, 3));

            // from 2nd index, selet all chars
            Console.WriteLine(aboutPerson.Substring(2));

            Console.WriteLine(aboutPerson.Replace("Karim", "Showrav"));

            Console.WriteLine(aboutPerson.Contains("is"));
            Console.WriteLine(aboutPerson.Contains('I'));

            aboutPerson += " And he is a competitive programmer!";
            Console.WriteLine(aboutPerson + "\n-----------------------------------------\n");


            // splitting by char or string both are possible! joss to!!
            string[] words = aboutPerson.Split("is");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            // split er reverse work
            string joinedString = string.Join("is", words);
            Console.WriteLine(joinedString);

            Console.WriteLine(joinedString.StartsWith("He"));
            Console.WriteLine(joinedString.EndsWith('!'));
        }
    }
}
