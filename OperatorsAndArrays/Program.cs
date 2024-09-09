namespace OperatorsAndArrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Operators in C#
            Console.WriteLine("The following are arithmetic operators in C# -> +, -, *, /, %, ++, --");
            Console.WriteLine("The following are relational operators in C# -> <, >, <=, >=, ==, !=");
            Console.WriteLine("The following are bitwise operators in C#    -> &, |, ^, ~, <<, >> ");
            Console.WriteLine("The following are logical operators in C#    -> &&, ||, !");
            Console.WriteLine("The following are assignment operators in C# -> +=, -=, ... <<=, >>=");

            //Arrays
            Console.WriteLine();
            Console.WriteLine("Array initialization is of following methods" +
                              "\n1. int[] array = new int[5]" +
                              "\n2. int[] array = new int[5] {6,12,18,24,30}" +
                              "\n3. int[] array = new int[] {6,12,18,24,30}" +
                              "\n4. int[] array = {6,12,18,24,30}");

            int[] array = new int[5] { 6, 12, 18, 24, 30 };
            Console.WriteLine("Array has some built in methods like Min(), Max(), Sum(), Average(), Resize(),Length");
            Console.WriteLine("Resize and sort syntax is Array.Resize(ref arrayName, len), Array.Sort(arrayName) and others arrayName.Function");

            Console.WriteLine($"\nThe length of array is {array.Length}" +
                              $"\nThe max of array is {array.Max()}" +
                              $"\nThe min of array is {array.Min()}" +
                              $"\nThe sum of array is {array.Sum()}");

            int avgCalculated = (array.Sum() / array.Length);
            int avg = (int)array.Average();
            
            Array.Resize(ref array, 7);
            array[5] = avgCalculated;
            array[6] = avg;
            Array.Sort(array);

            Console.WriteLine("{array} - Prints type of elements name bcoz WriteLine cant convert array to readable strings");

            //Printing arrays
            Console.WriteLine("To print arrays use one of the following methods" +
                              "\n1. Use default for or foreach loop" +
                              "\n2. Use String.Join(\' \', arrayName)" +
                              "\n3. Use Array.ForEach(arrayName, x => Console.Write(x + \' \'))");

            Console.Write("\nThe array values using Array.Foreach - ");
            Array.ForEach(array, x => Console.Write(x + " "));
            Console.WriteLine();

            //Enumerabe in C#
            Console.WriteLine();
            Console.WriteLine("In C# we can create a var object using Enumerable.Range(start, count) to generate sequence");

            var enumerableSeq = Enumerable.Range(1, 5);
            Console.Write("Enumerable range is ");
            foreach(int x in enumerableSeq) Console.Write(x + " ");

            //Aggregate
            Console.WriteLine();
            Console.WriteLine("\nC# supports Aggregate using var name = arrayName.Aggreate(initial, ((accumulator, currentValue) => accumlator *= currentItem))");
            Console.WriteLine("Where initial can be 1 coz 1 multiplied to anything is same, accumulator stores the result");

            var aggregateResult = enumerableSeq.Aggregate(0, ((accumlator,currentValue) => accumlator += currentValue)); 
            Console.WriteLine($"Sum of above enumerable seq is {aggregateResult}");

            //HashSet
            Console.WriteLine("\nHashset in C# takes array as input and removes duplicates from array" +
                              "\nDeclaration for hashset is HashSet<DataType> name = new HashSet<DataType> (arrayName)");
            HashSet<int> set = new HashSet<int> (array);
            Console.Write("\nThe hashSet values using foreach loop - ");
            foreach(int value in set) Console.Write(value + " ");
            Console.WriteLine();

            //Multi-dimensional array
            Console.WriteLine("\nDeclartion for 2D array is DataType[,] name = {{ {{}},{{}} }}");
            int[,] numbers = { { 1, 2, 3 }, { 3, 2, 1 } };

            Console.WriteLine("Foreach prints elements in row wise manner. Access element using name[x,y]");
            foreach(int num in numbers) Console.Write(num + " ");
            Console.WriteLine("\nThe second element i.e [0,2] is {0}", numbers[0,2]);

        }
    }
}
