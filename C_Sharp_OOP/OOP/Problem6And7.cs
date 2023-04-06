namespace C_Sharp_OOP.OOP
{
    internal class Problem6And7
    {
        public void Solve()
        {
            // overloading
            Area area = new Area();
            area.FindArea(3);
            area.FindArea(2,5);
        
            // overriding
            AreaWithMoreAccuracy circleArea = new AreaWithMoreAccuracy();
            circleArea.FindArea(3);
        }
    }

    // for understanding easily, keep these 2 classes in this file
    public class Area
    {
        public void FindArea(int width, int height)
        {
            Console.WriteLine("Area of rectangle: " + (width * height));
        }
        public virtual void FindArea(int radius)
        {
            Console.WriteLine("Area of circle: " + (3.1416 * radius * radius));
        }
    }

    public class AreaWithMoreAccuracy : Area
    {
        public override void FindArea(int radius)
        {
            Console.WriteLine("Area of circle with more accuracy: " + (3.14159265359 * radius * radius));
        }
    }
}