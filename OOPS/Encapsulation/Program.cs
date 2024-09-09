namespace Encapsulation
{
    class Vehicle
    {
        string name = "Auto";
        public string Name
        {
            get { return name; }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation
            Console.WriteLine("Encapsulation is a way to restrict the direct access to some members of the class - fields and methods");
            Console.WriteLine("It makes sure \"sensitive\" data is hidden from the users");
            
            Console.WriteLine();
            Console.WriteLine("By default field of a class is private. Set property for the field to access it outside the class");
            Console.WriteLine("Get method returns the variable, Set method initializes the variable value");

            Vehicle vehicle = new Vehicle();
            Console.WriteLine();
            Console.WriteLine($"name is a private field and is obtained using Get method - {vehicle.Name}");
        }
    }
}
