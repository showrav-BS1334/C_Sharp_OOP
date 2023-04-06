using System.Net.Security;

namespace C_Sharp_OOP
{
    internal class Problem13
    {
        struct Edge
        {
            public int source { get; set; }
            public int destination { get; set; }
            public int cost { get; set; }
            public void printFromEdge()
            {
                Console.WriteLine("Source: " + source + "\nDestination: " + destination + "\nCost: " + cost);
            }
        }
        public void Solve()
        {
            Edge newEdge = new Edge();
            newEdge.source = 1;
            newEdge.destination = 2;
            newEdge.cost = 100;
            newEdge.printFromEdge();
        }
    }
}
