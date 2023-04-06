using System.Text;
namespace C_Sharp_OOP
{
    class Problem24
    {
        public void Solve()
        {
            StringBuilder letters = new StringBuilder("abcde");
            StringBuilder digits = new StringBuilder("012");

            letters.Append("fghij");
            letters.AppendLine("klmn");
            Console.Write(letters);

            digits.Clear();
            Console.WriteLine(digits.Length);

            char[] vowels = new char[5];
            letters.CopyTo(1, vowels, 0, 3);
            foreach (char ch in vowels)
            {
                Console.WriteLine(ch);
            }

            string stringLetters = letters.ToString();
            Console.WriteLine(stringLetters);

            // Flase. karon same value holeo obj alada.
            Console.WriteLine(stringLetters.Equals(letters));

            letters.Remove(0, letters.Length);
            Console.WriteLine(letters.Length);

            StringBuilder jobDetails = new StringBuilder(
                "He is Rahim. " +
                "Rahim is a .NET developer. " +
                "Rahim works fine!"
                );
            jobDetails.Replace("Rahim", "Showrav");
            Console.WriteLine(jobDetails);
        }
    }
}