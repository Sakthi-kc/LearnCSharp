namespace ClassesAndObjects
{
    public class Fruit
    {
        //field or attribute
        public string name;
        public int quantity;

        //property
        public string color {  get; set; }

        //constructor
        public Fruit()
        {
            quantity = 2;
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class is a template for objects, and an object is an instance of a class.\nClass can have attributes and methods. These are often called members of the class");
            Console.WriteLine("When a variable is declared directly in a class, it is often referred to as a field (or attribute)");

            //Object of a class
            Console.WriteLine();
            Console.WriteLine("Class is like an object constructor, or a \"blueprint\" for creating objects");
            Console.WriteLine("An object is created with className objName = new className. One class can have multiple objects");
            Console.WriteLine("When induvidual object is created, it inherits all the variables and methods of its class using \'.\' operator");

            Fruit apple = new Fruit();
            apple.color = "Red";
            apple.name = "Apple";
            Console.WriteLine($"{apple.name} is {apple.color.ToLower()} in color");

            
            //Constructor
            Console.WriteLine();
            Console.WriteLine("Constructor is a special method of a class used to initialize attributes");
            Console.WriteLine("The advantage of a constructor, is that it is called when an object of a class is created");
            Console.WriteLine("Declaration of the constructor is accessModifier className() {}");

            Fruit fruitNum = new Fruit(); //calls the constructor
            Console.WriteLine($"{fruitNum.quantity} kgs - value was initalized in the constructor");

        }
    }
}
