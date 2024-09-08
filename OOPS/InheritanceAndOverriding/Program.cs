namespace InheritanceAndOverriding
{
    class Animal
    {
        public string sound = "Animals makes different sounds";
        public virtual void print()
        {
            Console.WriteLine(sound);
        }
    }

    class Dog: Animal
    {
        public string sound = "Dog barks!";
        public override void print()
        {
            Console.WriteLine(sound);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Inheritance
            Console.WriteLine("Inheritance allows a class to inherit the properties (has get,set method), methods and fields of another class");
            Console.WriteLine("There are generally 2 classes - Derived class which inherits from the base class. To inherit, use \':\'");
            Console.WriteLine("The base class has virtual keyword while derived class has override before method name");
            Console.WriteLine("If you don't want other classes to inherit from a class, use the sealed keyword");


            //Method overriding
            Console.WriteLine();
            Console.WriteLine("If derived class defined same method as in base class is called method overriding");
            Console.WriteLine("Overriding allows a subclass to customize or completely change the behavior of a method inherited from the base class");
            Console.WriteLine("\nExample: Define an Animal class with print() and Dog: Animal class with same print()");

            Animal animal = new Animal();
            Dog dog = new Dog();
            Console.WriteLine($"{animal.sound} (Animal print()) from {dog.sound} (Dog print())");

        }
    }
}
