using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_OOP.OOP
{
    internal class Problem3
    {
        public void Solve()
        {
            MSWord word = new MSWord();
            word.PrintMSOffice();

            BlankPage blankPage = new BlankPage();
            blankPage.PrintMSOffice();
        }
    }
}

// Single inheritance
// Multi-level inheritance
// Hierarchical Inheritance
public class MSOffice
{
    public void PrintMSOffice()
    {
        Console.WriteLine("I'm from MSOffice");
    }
}
// single inheritance
public class MSWord : MSOffice
{
    public void PrintMSWord()
    {
        Console.WriteLine("I'm from MSWord");
    }
}
// multi-level inheritance
public class BlankPage : MSWord
{
    public void PrintBlankPage()
    {
        Console.WriteLine("I'm from BlankPage");
    }
}
// Hierarchical Inheritance [2 classes are inheriting the first class]
public class MSExcel : MSOffice
{
    public void PrintMSExcel()
    {
        Console.WriteLine("I'm from MSExcel");
    }
}