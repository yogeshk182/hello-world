using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "yogesh";
            string secondName = "j";
            string name = string.Concat(firstName, secondName);
            Console.WriteLine(name);
        }
    }
}
