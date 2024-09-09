namespace AbstractionAndInterface
{
    abstract public class Sum
    {
        public int num1 = 5;
        public abstract int num2 
        {
            set;  get;
        }

        public abstract int Calculate(int num1, int num2);

        public void Print()
        {
            Console.WriteLine("The sum of abstract class fields are: {0}", Calculate(num1, num2));
        }

    }

    public class CalcSum: Sum
    {
        int _num2;
        public override int num2
        {
            set {  _num2 = value; }
            get { return _num2; }
        }

        public override int Calculate(int num1, int num2)
        {
            return num1 + num2;
        }

    }

    public interface IValues
    {
        public int num1 { get; set; }
        public int num2 { get; set; }
    }

    public interface IDifference
    {
        public int diff(int num1, int num2);
    }

    public class CalcDiff : IValues, IDifference
    {
        int x, y;
        public int num1
        {
            set { x = value; }
            get { return x; }
        }

        public int num2
        {
            set { y = value; }
            get { return y; }
        }

        public int diff(int x, int y)
        {
            return x - y;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //Abstraction
            Console.WriteLine("Data abstraction is the process of hiding implementation details and showing only essential information to the user.");
            Console.WriteLine("Abstract class can have abstract and non-abstract methods, properties but only non-abstract fields");

            Console.WriteLine();
            Console.WriteLine("Object cant be created for abstract class and abstract method in abstract class cant have body");
            Console.WriteLine("To access abstract class fields or methods, create a derived class and define there - use override for all");
            Console.WriteLine("When assigning value for property, assign in Main method and create a temp variable in derived class\nset { _temp = value;} get{ return _temp;}");

            CalcSum calcSum = new CalcSum();
            calcSum.num2 = 7;

            Console.WriteLine();
            calcSum.Print();

            //Interface
            Console.WriteLine();
            Console.WriteLine("Interface is complete abstract class and can have only abstact methods and abstract properties (without bodies). No fields allowed");
            Console.WriteLine("Use keyword \"interface\" instead of \"class\". Override keyword is not required for interface");
            Console.WriteLine("Derived class can have multiple interfaces. Seperate them by \',\'");

            CalcDiff calcDiff = new CalcDiff();
            int x = calcDiff.num1 = 7;
            int y = calcDiff.num2 = 5;

            Console.WriteLine();
            Console.WriteLine("The difference of interface fields are: {0}", calcDiff.diff(x,y));


        }
    }
}
