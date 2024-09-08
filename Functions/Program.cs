namespace Functions
{
    public class Program
    {
        static string Hello()
        {
            return "Hello. This function was invoked from main without arguments";
        }

        public static void Add(int num1, int num2=20)
        {
            string output = $"{num1} + {num2} = {num1 + num2}";
            Console.WriteLine(num2 == 20 ? $"Added with default value\n{output}": $"Added with argument values\n{output}");
        }

        static void YoungestChild(string child1, string child3, string child2)
        {
            Console.WriteLine($"{child3} is the youngest of {child1}, {child2} and {child3}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Functions can be called with and without arguments in C#");
            Console.WriteLine("The values passed while invoking a function is args and value in method paranthesis is parameters");
            Console.WriteLine("If a method has defaultValue for any param, it is optional parameter and not mandatory as an argument");

            //Calling method without arguments
            Console.WriteLine();
            Console.WriteLine(Hello());

            //Calling method with arguments
            Console.WriteLine();
            Add(5, 10);
            Add(5);

            //Passing named arguments
            Console.WriteLine();
            Console.WriteLine("Arguments can be passed as named-value pair and args,parameters can be in any order");
            Console.WriteLine("\nExample: YoungestKid(child2: \"Lia\", child1: \"Roy\", child3: \"Adam\")");
            Console.WriteLine("static void YoungestKid(string child1, string child3, string child2");
            YoungestChild(child2: "Lia", child1: "Roy", child3: "Adam");

            //Method overloading
            Console.WriteLine() ;
            Console.WriteLine("Method Overloading -> multiple methods with same name but different params.");
            Console.WriteLine("Eg: Add(int a, int b) and Add(float a, float b)");
        }
    }
}
