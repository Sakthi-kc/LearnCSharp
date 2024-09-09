Console.WriteLine("Write filePath using @quotation{Path}");
Console.WriteLine("File.WriteAllText - creates new file with file path and content. While File.WriteAllTextAsync().Wait() - overwrites file");

string filePath = @"..\..\..\FileHandling.txt";

bool checkFile = File.Exists(filePath);

if(!checkFile)
{
    string content = "Hello, World!";

    File.WriteAllTextAsync(filePath, content).Wait();
}

File.ReadAllText(filePath);

try
{
    Console.WriteLine();
    Console.Write("Please enter your age: ");
    int age = int.Parse(Console.ReadLine());
    if (age < 18) 
        throw new ArithmeticException("Age Limit is below the standard");
    else 
        Console.WriteLine("You're allowed");

    int[] myNumbers = { 1, 2, 3 };
    Console.WriteLine("The 5th element of array[3] is {0}", myNumbers[4]);
}

catch (Exception exception)
{
    Console.WriteLine(exception.Message);
}

finally
{
    Console.WriteLine();
    Console.WriteLine("Program stops and comes to finally when an exception occurs.\nThe 'try catch' is finished.");
}