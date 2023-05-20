using System;
using Basicsprogram;

namespace MainProject{
    class MainProgram {
        static void Main() {
            while(true){
                Console.WriteLine("Enter a valid operation: ('add', 'strlen', 'multiply', 'divide', 'root', 'contains', 'exit')");
                string input = Console.ReadLine();
                if(input.ToLower() == "add"){
                    Console.WriteLine("Input your first number:");
                    string num1 = Console.ReadLine();
                    Console.WriteLine("Input your second number:");
                    string num2 = Console.ReadLine();
                    int n1 = Convert.ToInt32(num1);
                    int n2 = Convert.ToInt32(num2);
                    int cout = Basics.Add(n1, n2);
                    Console.WriteLine($"Your result is: {cout}");
                }
                else if(input.ToLower() == "strlen"){
                    Console.WriteLine("Input a string:");
                    string str1 = Console.ReadLine();
                    int cout2 = Basics.Strlen(str1);
                    Console.WriteLine($"Your strings length: {cout2}");
                }
                else if(input.ToLower() == "multiply"){
                    Console.WriteLine("Input your first number:");
                    string num3 = Console.ReadLine();
                    Console.WriteLine("Input your second number:");
                    string num4 = Console.ReadLine();
                    int n3 = Convert.ToInt32(num3);
                    int n4 = Convert.ToInt32(num4);
                    int cout3 = Basics.Multiply(n3, n4);
                    Console.WriteLine($"Your result is: {cout3}");
                }
                else if(input.ToLower() == "divide"){
                    Console.WriteLine("Input your first number:");
                    string num5 = Console.ReadLine();
                    Console.WriteLine("Input your second number:");
                    string num6 = Console.ReadLine();
                    int n5 = Convert.ToInt32(num5);
                    int n6 = Convert.ToInt32(num6);
                    int cout4 = Basics.Divide(n5, n6);
                    Console.WriteLine($"Your result is: {cout4}");
                }
                else if(input.ToLower() == "root"){
                    Console.WriteLine("Input a number:");
                    string num7 = Console.ReadLine();
                    int n7 = Convert.ToInt32(num7);
                    double cout5 = Basics.Root(n7);
                    Console.WriteLine($"Your result is: {cout5}");
                }
                else if(input.ToLower() == "contains"){
                    Console.WriteLine("Input a string:");
                    string str2 = Console.ReadLine();
                    Console.WriteLine("Input a substring:");
                    string str3 = Console.ReadLine();
                    char str4 = Convert.ToChar(str3);
                    bool cout6 = Basics.Contains(str2, str4);
                    Console.WriteLine($"Your result is: {cout6}");
                }
                else if(input.ToLower() == "exit"){
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Wrong input, please try again");
                }
            }
        }
    }
}