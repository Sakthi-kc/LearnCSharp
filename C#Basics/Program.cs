namespace C_Basics
{
    public class Program
    {
        enum Day
        {
            Morning, AfterNoon, Evening, Night
        }

        static void Main(string[] args)
        {
            //Printing staatements in C#
            Console.WriteLine("To print statements in C# use Console.Write() or Console.WriteLine()");

            //Comments in C#
            Console.WriteLine("\nTo comment any line in C# use // or /*...*/");

            //Variables in C#
            Console.WriteLine("\nDeclaration syntax for variables in C# as \ndatatype variableName = value;");
            string displayVariable1 = "Hello";
            string displayVariable2 = "Folks!";

            Console.WriteLine();

            /*
             * Printing Variables in output statement in C#
             * Method1
            */
            Console.WriteLine("1. Print variables using String Interpolation -> $\"{}\"\n" +
                               $"Printed {displayVariable1} {displayVariable2} using String Interpolation");

            Console.WriteLine();

            //Method2
            Console.WriteLine("2. Print variables using String.Concat(var1, \'any char\', var2, \"any string\")\n" +
                               String.Concat("Printed ", displayVariable1, ' ', displayVariable2, " using String.Concat()"));

            Console.WriteLine();

            //Method3
            Console.WriteLine("3. Print variables using String.Format(\"{0}\",var1)\n" +
                               String.Format("Printed {0} {1} using String.Format()", displayVariable1, displayVariable2));

            Console.WriteLine();

            //Method4
            Console.WriteLine("4. Print variables in same way as method 3 just without typing String.Format\n" +
                              "Printed {0} {1} without using String.Format", displayVariable1, displayVariable2);


            Console.WriteLine();
            Console.WriteLine("Note: To escape quotation use \\ and to print braces in string interpolation or backslash, double them");

            //Variables in C#
            bool boolValue = true;

            char charValue = 'A';
            string stringValue = "Characters";

            int integerValue = 10;
            long longValue = 2500000000L;

            float floatValue = 13.4567F;
            double doubleValue = 77.89D;
            decimal decimalValue = 0.345678901M;

            Console.WriteLine();

            Console.WriteLine("The data types in C# are below");
            Console.WriteLine($" * bool:    {boolValue,-13} -> Prints the first letter as caps though initialized as true" +
                              $"\n * char:    {charValue,-13} -> Only 1 char" +
                              $"\n * string:  {stringValue,-13} -> A set of chars which can be numbers too" +
                              $"\n * int:     {integerValue,-13} -> Non-decimal numbers" +
                              $"\n * long:    {longValue,-13} -> Ends with L. Used when int is not enough to store the number" +
                              $"\n * float:   {floatValue,-13} -> Ends with F. Takes 6-8 decimal digits" +
                              $"\n * double:  {doubleValue,-13} -> Ends with D. Takes 15 decimal digits" +
                              $"\n * decimal: {decimalValue,-13} -> Ends with M. Takes 29 deimal digits");

            //Text justify in C#
            Console.WriteLine();
            Console.WriteLine("Note: To align as above, give spaces or width with variables as {var, width} and + value for right align and - value for left align");

            //Multiple variable assignment with or without same value in C#
            Console.WriteLine("\nTo assign values to multiple variables use either of the 2 methods" +
                              "\n1. int num1 = 5; num2 = 10; or" +
                              "\n2. int num1,num2;\n   num1 = num2 = 25;");


            //Type casting in C#
            Console.WriteLine();
            Console.WriteLine("Type casting is of two types in C#. First the order of data types is char < int < long < float < double < decimal" +
                              "\nImplicit conversion is automatic and converts smaller data type to larger data type" +
                              "\nExplicit conversion is manual and converts larger data type to smaller data type");

            float actualValue = 22.54F;
            double result = actualValue;
            int resultInt = (int)actualValue;
            Console.WriteLine($"Implicit conversion of float {actualValue} to double is {result}");
            Console.WriteLine($"Explicit converstion of float {actualValue} to int is {resultInt}");

            //String interpolation in variable
            Console.WriteLine();
            Console.WriteLine("Use the same expression of string interpolation in variable");
            string firstName = "Adam";
            string lastName = "Sharov";
            string fullName = $"{firstName} {lastName}";
            Console.WriteLine($"{fullName} is printed using $\"{{firstName}} {{lastName}}\"");

            //Constants in C#
            Console.WriteLine("\nConstants in C# must be assigned value in same line and immutable" +
                              "\nDeclaration syntax for constants in C# as \nconst datatype variableName = value;");
            const float pi = 3.14F;
            Console.WriteLine($"PI = {pi} is a const variable");

            //Enum in C#
            Console.WriteLine();
            Console.WriteLine("Enum itself is a special class in C# and represents group of consts, use . operator to access them");

            Day timeOfTheDay = Day.Evening;
            Console.WriteLine(String.Concat(timeOfTheDay, " - value from the enum list"));

            //Read input from user
            Console.WriteLine();
            Console.WriteLine("To read input from user use Console.ReadLine() in C# which takes only string input, else throws exception" +
                              "\nTo read input of any other data type, use Convert.ToDatatype(Console.ReadLine()) or DataType.Parse(Console.ReadLine()). If wrong input type is passed, throws exception" +
                              "\nIt does not accept any parameters, hence can't pass any prompts in ReadLine(). Instead type statements to user using WriteLine()");

            Console.WriteLine();
            Console.Write("Enter your name: ");
            string? userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}");

            Console.WriteLine();
            Console.WriteLine("Enter your birth year: ");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"You were born in {birthYear}");

            Console.WriteLine();
            Console.WriteLine("And your birth month please: ");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine($"You were born in {birthMonth}");

        }
    }
}
