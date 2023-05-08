using System;
namespace EX06
{
    class Program
    {
        int n;
        public Program(int a)
        {
            this.n = a;
            Console.WriteLine("This is a parameterized constructor");
            Console.WriteLine("The value is " + this.n);
        }
        public Program()
        {
            this.n = 12;
            Console.WriteLine("This is a default constructor \n The value is " + this.n);
        }
        public static bool operator ==(Program p1, Program p2)
        {
            return p1.Equals(p2);
        }
        public static bool operator !=(Program p1, Program p2)
        {
            return !p1.Equals(p2);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program(12);
            Program p4 = new Program();
            if (p4 == p1)
            {
                Console.WriteLine("They both are equal");
            }
            else if (p1 != p4)
            {
                Console.WriteLine("They both are different ");
            }
        }
    }
}




