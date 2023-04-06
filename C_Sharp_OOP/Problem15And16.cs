namespace C_Sharp_OOP
{
    internal class Problem15And16
    {
        int[] intArray = new int[15];
        long[] longArray = new long[15];
        double[] doubleArray = new double[15];
        char[] charArray = new char[15];
        bool[] boolArray = new bool[15];
        string[] stringArray = new string[15];

        public void AssignVlues()
        {
            for(int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = i;

                // scintific notation direct long e use kora jay na, double e kora jay!
                longArray[i] = i * (long)(double)1e15;

                // even hoile true
                boolArray[i] = ((i&1) == 0) ? true : false;

                // random number generate korlam
                Random random = new Random();
                int randomNum = random.Next(0, 26);
                charArray[i] = (char)('a' + randomNum);

                //generates a floating point num in between 0.0 and 1.0
                doubleArray[i] = random.NextDouble();

                string temString = "abcde";
                stringArray[i] = Convert.ToString(i) + temString;
            }
        }

        public void PrintVlaues()
        {
            // using for loop
            for(int i = 0; i < charArray.Length; i++)
            {
                if (i == 5) continue;
                Console.WriteLine(charArray[i]);
                if (i == 10) break;
            }

            // using foreach
            int count = 0;
            foreach(string singleString in stringArray)
            {
                if (count == 5) {
                    count++; 
                    continue;
                }
                Console.WriteLine(singleString);
                if(count == 10) break;
                count++;
            }

            // using while
            int index = 0;
            while (index != boolArray.Length)
            {
                if (index == 5) {index++; continue;}
                Console.WriteLine(boolArray[index++]);
                if (index == 10) break;
            }
        }

        public void Solve()
        {
            AssignVlues();
            PrintVlaues();
        }
    }
}
