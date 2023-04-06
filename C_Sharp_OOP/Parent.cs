public class Parent
{
    protected int x = 100;
    protected void Print()
    {
        Console.WriteLine("hello");
    }
}

public class Child : Parent
{
    public void PrintX() {
        Console.WriteLine(x);
    } 
}
