using System.Runtime.Intrinsics.Arm;

namespace StructAndClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sturct - Instance of the struct are stored on stack." +
                              "\nCopied by value - When function takes a struct as argument, a copy is made. This means changes to the new instance don't affect the original.");

            //Instance of struct
            StructureA s1 = new StructureA();
            s1.num2 = 10;
            s1.bool2 = default; //which is False

            void StructReAssign(StructureA s2)
            {
                s2.num2 = 5;
                s2.bool2 = true;
                Console.WriteLine($"Value of struct variables: {s2.num2} and {s2.bool2}");
            }

            Console.WriteLine();
            Console.WriteLine($"Initial values of struct: {s1.num2} and {s1.bool2}");
            StructReAssign(s1);
            Console.WriteLine($"Value after reassigning stuct value in function: {s1.num2} and {s1.bool2}");

            //Class
            Console.WriteLine();
            Console.WriteLine("Class - Instance of the class are stored on heap." +
                              "\nCopied by reference - When function takes class argument, only the reference (or address) is copied. So, changes to the new instance affect the original object.");

            //Instance of the class
            ClassA c1 = new ClassA();
            c1.num1 = 10;
            c1.bool1 = false;

            void ClassReAssign(ClassA c2)
            {
                c2.num1 = 5;
                c2.bool1 = true;
                Console.WriteLine($"Value of struct variables: {c2.num1} and {c2.bool1}");
            }

            Console.WriteLine();
            Console.WriteLine($"Initial values of struct: {c1.num1} and {c1.bool1}");
            ClassReAssign(c1);
            Console.WriteLine($"Value after reassigning stuct value in function: {c1.num1} and {c1.bool1}");

        }
    }

    public class ClassA
    {
        public int num1;
        public bool bool1;
    }

    struct StructureA
    {
        public int num2;
        public bool bool2;
    }
}
