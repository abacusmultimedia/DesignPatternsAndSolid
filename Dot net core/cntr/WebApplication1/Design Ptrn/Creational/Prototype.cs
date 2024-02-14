namespace WebApplication1.Design_Ptrn.Creational
{
    // Prototype interface
    public interface ICloneableShape
    {
        ICloneableShape Clone();
    }

    // Concrete prototype - Circle
    public class Circle : ICloneableShape
    {
        public int Radius { get; set; }

        public Circle(int radius)
        {
            Radius = radius;
        }

        public ICloneableShape Clone()
        {
            // Shallow copy, can be modified based on requirements
            return (ICloneableShape)MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Circle with radius {Radius}");
        }
    }

    // Concrete prototype - Rectangle
    public class Rectangle : ICloneableShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public ICloneableShape Clone()
        {
            // Shallow copy, can be modified based on requirements
            return (ICloneableShape)MemberwiseClone();
        }

        public void Display()
        {
            Console.WriteLine($"Rectangle with width {Width} and height {Height}");
        }
    }

    // Client code
    class Program
    {
        static void Main()
        {
            // Create prototypes
            Circle circlePrototype = new Circle(5);
            Rectangle rectanglePrototype = new Rectangle(10, 8);

            // Clone prototypes
            Circle clonedCircle = (Circle)circlePrototype.Clone();
            Rectangle clonedRectangle = (Rectangle)rectanglePrototype.Clone();

            // Display original and cloned objects
            Console.WriteLine("Original objects:");
            circlePrototype.Display();
            rectanglePrototype.Display();

            Console.WriteLine("\nCloned objects:");
            clonedCircle.Display();
            clonedRectangle.Display();
        }
    }
}
