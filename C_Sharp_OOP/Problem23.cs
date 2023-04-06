using System.Text;

namespace C_Sharp_OOP
{
    internal class Problem23
    {
        public void Solve()
        {
            StringBuilder location = new StringBuilder("Gazipur");
            location[0] = 'C';
            location[1] = 'h';
            location[2] = 'a';
            location[3] = 'd';
            Console.WriteLine(location);
        }
    }
}
