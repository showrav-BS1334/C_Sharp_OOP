namespace C_Sharp_OOP.Problem14
{
    internal class Problem14
    {
        public void Solve()
        {
            OriginalClass originalClass = new OriginalClass();
            originalClass.vlaue = 1;

            // the vlaue of reference type value will be changed
            TempClass tempClass = new TempClass();
            tempClass.ChangeReferenceValue(originalClass);
            Console.WriteLine(originalClass.vlaue); // 2

            // the value of premitive type won't be changed
            int number = 100;
            tempClass.changePremitiveValue(100);
            Console.WriteLine(number); // remains same!
        }
    }
}
