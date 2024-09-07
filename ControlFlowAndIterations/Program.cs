namespace ControlFlowAndIterations
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Conditional statements
            Console.WriteLine("Conditional flow in C# - if..else if..else");
            Console.WriteLine("Eligiblity to vote - 18. Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge <= 13)
                Console.WriteLine("You're too young for voting");
            else if (userAge > 14 && userAge < 18)
                Console.WriteLine("You're not eligible");
            else
                Console.WriteLine("You're eligible for voting");


            //Switch statement
            Console.WriteLine();
            Console.WriteLine("In new switch range is allowed, convert condition to bool allowed while these were not allowed in traditional switch");
            Console.WriteLine("Default is optional and default can have break statement");
            Console.WriteLine("Declaration of switch: \nDataType VariableName = CaseVar switch {\nConditionOrRange => Value,\n_ => Value\n};");

            Console.WriteLine("\nEnter an hour in the day");
            int hours = int.Parse(Console.ReadLine());
            string day = hours switch
            {
                > 0 and < 6 => "Morning",
                > 10 and < 16 => "Afternoon",
                > 16 and < 20 => "Evening",
                > 20 and < 25 => "Night",
                _ => "Invalid Hour of the Day"
            };

            Console.WriteLine(day.Contains("Invalid") ? day : $"Good {day} Folks!");

            //Switch with tuples
            Console.WriteLine();
            Console.WriteLine("We can write switch for tuples too: The condition or range can be like [1,3] or [var x, var y] when x == y");
            int[] indices = { 0, 4 };
            string indicesLine = indices switch
            {
                [0,0] => "It's on the origin",
                [_,0] => "On the X-Axis",
                [0,_] => "On the Y-axis",
                [var x, var y] when x == y => "On the line of y=x",
                _ => "Somewhere on the graph"
            };

            Console.WriteLine($"[{indices[0]}, {indices[1]}] -> {indicesLine}");


            //Loops
            //for loop
            Console.WriteLine();
            Console.WriteLine("C# Supports the following looping concepts: for, foreach, while, do-while");
            int multiple = 7, multiplier = 5;

            Console.Write("Printed using for loop: ");
            
            for(int iteration = 1; iteration <= multiplier; iteration++)
            {
                Console.Write( iteration * multiple + " ");
            }

            
            //foreach loop
            Console.WriteLine();
            string[] fruits = new string[3] { "Apple", "Banana", "Orange" };

            Console.Write("\nPrinted using foreach loop: ");

            foreach (string fruit in fruits)
            {
                Console.Write(fruit + " ");
            }

            
            //while loop
            Console.WriteLine();
            Console.WriteLine("\n\nPlease enter a number lesser than 10");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            while (userChoice > 10)
            {
                Console.WriteLine("You've entered an invalid number. Please enter any value lesser than 10");
                userChoice = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Great! {0} is a valid number", userChoice);

            
            //do-while loop
            Console.WriteLine("\n");
            string actualString = "hello";
            string? userInput;
            
            do
            {
                Console.WriteLine($"Please type \'{actualString}\' and enter");
                userInput = Console.ReadLine();

            } while (userInput != actualString);

            Console.WriteLine("Yeah! That's correct\n");

        }
    }
}
