namespace C_Sharp_OOP
{
    internal class Problem12
    {
        public string name { get; set; }

        // constructor
        public Problem12(string name) 
        {
            this.name = name; 
        }

        // a method
        public void Solve()
        {
            Console.WriteLine(name);
        }
    }
}
