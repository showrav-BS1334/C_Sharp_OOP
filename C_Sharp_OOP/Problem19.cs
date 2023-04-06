namespace C_Sharp_OOP
{
    internal class Problem19
    {
        public void Solve()
        {
            List<int> intList = new List<int>();
            List<double> doubleList = new List<double>();
            List<String> stringList = new List<String>();

            intList.Add(10);
            intList.Add(20);
            intList.Clear();

            intList.Add(0);

            intList.AddRange(new int[] {1, 2, 3});

            // add 100 at 0th index
            intList.Insert(0, 100);

            //add the array at 1th index
            intList.InsertRange(1, new int[] { 999, 999, 999 });
            foreach(int num in intList)
            {
                Console.WriteLine(num);
            }

            // first occurence ta remove hobe
            intList.Remove(999);

            Console.WriteLine("-----");
            foreach (int num in intList)
            {
                Console.WriteLine(num);
            }


            // 0th index er ta remove
            intList.RemoveAt(0);

            Console.WriteLine( intList.Count() );

                                                                                                               

            Console.WriteLine("-----");
            foreach (int num in intList)
            {
                Console.WriteLine(num);
            }

            bool isPresent = intList.Contains(999);
            Console.WriteLine(isPresent);
        }
    }
}