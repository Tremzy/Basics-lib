using System;
using Basicsprogram;

namespace MainProject{
    class MainProgram {
        static void Main() {
            Console.WriteLine("Input your first number:");
            string num1 = Console.ReadLine();
            Console.WriteLine("Input your second number:");
            string num2 = Console.ReadLine();
            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);
            int cout = Basics.Add(n1, n2);
            Console.WriteLine($"Your result is: {cout}");
            Console.WriteLine("Input a string:");
            string str1 = Console.ReadLine();
            int cout2 = Basics.Strlen(str1);
            Console.WriteLine($"Your strings length: {cout2}");
            Console.WriteLine("Input your first number:");
            string num3 = Console.ReadLine();
            Console.WriteLine("Input your second number:");
            string num4 = Console.ReadLine();
            int n3 = Convert.ToInt32(num3);
            int n4 = Convert.ToInt32(num4);
            int cout3 = Basics.Multiply(n3, n4);
            Console.WriteLine($"Your result is: {cout3}");
            Console.WriteLine("Input your first number:");
            string num5 = Console.ReadLine();
            Console.WriteLine("Input your second number:");
            string num6 = Console.ReadLine();
            int n5 = Convert.ToInt32(num5);
            int n6 = Convert.ToInt32(num6);
            int cout4 = Basics.Divide(n5, n6);
            Console.WriteLine($"Your result is: {cout4}");
            Console.WriteLine("Input a number:");
            string num7 = Console.ReadLine();
            int n7 = Convert.ToInt32(num7);
            double cout5 = Basics.Root(n7);
            Console.WriteLine($"Your result is: {cout5}");
            Console.WriteLine("Press any key to exit... ");
            Console.ReadKey();
        }
    }
}
