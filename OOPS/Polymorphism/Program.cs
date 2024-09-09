namespace Polymorphism
{
    public class Shape
    {
        public virtual string sides()
        {
           return "Displays the no. of sides for the shape";
        }
    }

    public class Triangles : Shape
    {
        public override string sides()
        {
            return "Triangles have 3 sides of different length";
        }
    }

    public class Squares: Shape
    {
        public override string sides()
        {
            return "Squares have 4 sides of equal length";
        }
    }

    public class Rhombus : Shape
    {
        public override string sides()
        {
            return "Rhombus have 4 sides whose opposite sides have equal length";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism
            Console.WriteLine("Polymorphism means \"many forms\", it occurs when we have many classes that are related to each other by inheritance");
            Console.WriteLine("Use when you want to work with the base class type, allowing polymorphism - same method having different operations");

            Shape shape = new Shape();
            Triangles triangle = new Triangles();
            Squares square = new Squares();
            Rhombus rhombus = new Rhombus();

            Console.WriteLine();
            Console.WriteLine(shape.sides());
            Console.WriteLine(triangle.sides());
            Console.WriteLine(square.sides());
            Console.WriteLine(rhombus.sides());

        }
    }
}
