using System;
using Basicsprogram;

namespace MainProject{
    class MainProgram {
        static void Main() {
            Console.Clear();
            Console.WriteLine("                                             /Welcome to Basics!/");
            HelpMenu(2);
            HelpMenu(3);
            while(true){
                //Console.WriteLine("Enter a valid operation: ('add', 'strlen', 'multiply', 'divide', 'root', 'contains', 'subtract', 'howmany', 'maxnum', 'minnum', 'addall', 'exit')");
                string option = Console.ReadLine();
                if(option.ToLower() == "1"){
                    Console.WriteLine("Input your first number:");
                    string num1 = Console.ReadLine();
                    Console.WriteLine("Input your second number:");
                    string num2 = Console.ReadLine();
                    int n1 = Convert.ToInt32(num1);
                    int n2 = Convert.ToInt32(num2);
                    int cout = Basics.Add(n1, n2);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your result is: {cout}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "2"){
                    Console.WriteLine("Input a string:");
                    string str1 = Console.ReadLine();
                    int cout2 = Basics.StrLen(str1);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your strings length: {cout2}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "3"){
                    Console.WriteLine("Input your first number:");
                    string num3 = Console.ReadLine();
                    Console.WriteLine("Input your second number:");
                    string num4 = Console.ReadLine();
                    int n3 = Convert.ToInt32(num3);
                    int n4 = Convert.ToInt32(num4);
                    int cout3 = Basics.Multiply(n3, n4);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your result is: {cout3}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "4"){
                    Console.WriteLine("Input your first number:");
                    string num5 = Console.ReadLine();
                    Console.WriteLine("Input your second number:");
                    string num6 = Console.ReadLine();
                    int n5 = Convert.ToInt32(num5);
                    int n6 = Convert.ToInt32(num6);
                    int cout4 = Basics.Divide(n5, n6);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your result is: {cout4}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "5"){
                    Console.WriteLine("Input a number:");
                    string num7 = Console.ReadLine();
                    int n7 = Convert.ToInt32(num7);
                    double cout5 = Basics.Root(n7);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your result is: {cout5}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "6"){
                    Console.WriteLine("Input a string:");
                    string str2 = Console.ReadLine();
                    Console.WriteLine("Input a substring:");
                    string str3 = Console.ReadLine();
                    char str4 = Convert.ToChar(str3);
                    bool cout6 = Basics.Contains(str2, str4);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your result is: {cout6}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "7"){
                    Console.WriteLine("Input your first number:");
                    string num8 = Console.ReadLine();
                    Console.WriteLine("Input your second number:");
                    string num9 = Console.ReadLine();
                    int n8 = Convert.ToInt32(num8);
                    int n9 = Convert.ToInt32(num9);
                    int cout7 = Basics.Subtract(n8, n9);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your result is: {cout7}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "8"){
                    Console.WriteLine("Input a string:");
                    string str5 = Console.ReadLine();
                    Console.WriteLine("Input a substring:");
                    string str6 = Console.ReadLine();
                    char str7 = Convert.ToChar(str6);
                    int cout8 = Basics.HowMany(str5, str7);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your result is: {cout8}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "9"){
                    Console.WriteLine("Input 3 numbers");
                    List<int> InputList = new List<int>();
                    for(int i = 0;i<3;i++){
                        Console.WriteLine($"Number {i}:");
                        string inputstr = Console.ReadLine();
                        int inputint = Convert.ToInt32(inputstr);
                        InputList.Add(inputint);
                    }
                    int cout9 = Basics.MaxNum(InputList);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your result is: {cout9}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "10"){
                    Console.WriteLine("Input 3 numbers");
                    List<int> InputList = new List<int>();
                    for(int i = 0;i<3;i++){
                        Console.WriteLine($"Number {i}:");
                        string inputstr = Console.ReadLine();
                        int inputint = Convert.ToInt32(inputstr);
                        InputList.Add(inputint);
                        }
                    int cout10 = Basics.MinNum(InputList);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your result is: {cout10}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "11"){
                    Console.WriteLine("Input 3 numbers");
                    List<int> InputList = new List<int>();
                    for(int i = 0;i<3;i++){
                        Console.WriteLine($"Number {i}:");
                        string inputstr = Console.ReadLine();
                        int inputint = Convert.ToInt32(inputstr);
                        InputList.Add(inputint);
                    }
                    int cout11 = Basics.AddAll(InputList);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your result is: {cout11}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "12"){
                    Console.WriteLine("Input 3 numbers");
                    List<int> InputList = new List<int>();
                    for(int i = 0;i<3;i++){
                        Console.WriteLine($"Number {i}:");
                        string inputstr = Console.ReadLine();
                        int inputint = Convert.ToInt32(inputstr);
                        InputList.Add(inputint);
                    }
                    int cout12 = Basics.SubtractAll(InputList);
                    Console.Clear();
                    HelpMenu(1);
                    Console.WriteLine($"Your result is: {cout12}");
                    HelpMenu(3);
                }
                else if(option.ToLower() == "13"){
                    Console.WriteLine("Exiting program...");
                    break;
                }
                else{
                    Console.Clear();
                    Console.WriteLine("Wrong input, please try again");
                    HelpMenu(2);
                    HelpMenu(3);
                }
            }
        }
        public static int HelpMenu(int option)
        {
            if(option == 1){
                Console.WriteLine("                                   ________________________________________");
                Console.WriteLine("                                   |           Select an option:          |");
                Console.WriteLine("                                   |           1. Add                     |");
                Console.WriteLine("                                   |           2. String lengt            |");
                Console.WriteLine("                                   |           3. Multiply                |");
                Console.WriteLine("                                   |           4. Divide                  |");
                Console.WriteLine("                                   |           5. Root                    |");
                Console.WriteLine("                                   |           6. Contains                |");
                Console.WriteLine("                                   |           7. Subtract                |");
                Console.WriteLine("                                   |           8. Howmany                 |");
                Console.WriteLine("                                   |           9. Maxnum                  |");
                Console.WriteLine("                                   |           10. Minnum                 |");
                Console.WriteLine("                                   |           11. Addall                 |");
                Console.WriteLine("                                   |           12. Subtractall            |");
                Console.WriteLine("                                   |           13. Exit                   |");
                Console.WriteLine("                                   ________________________________________");
                Console.WriteLine(" ");
                Console.WriteLine("      - Output -");
                Console.WriteLine("   ---------------");
            }
            else if(option == 2){                                     
                Console.WriteLine("                                   ________________________________________");
                Console.WriteLine("                                   |           Select an option:          |");
                Console.WriteLine("                                   |           1. Add                     |");
                Console.WriteLine("                                   |           2. String lengt            |");
                Console.WriteLine("                                   |           3. Multiply                |");
                Console.WriteLine("                                   |           4. Divide                  |");
                Console.WriteLine("                                   |           5. Root                    |");
                Console.WriteLine("                                   |           6. Contains                |");
                Console.WriteLine("                                   |           7. Subtract                |");
                Console.WriteLine("                                   |           8. Howmany                 |");
                Console.WriteLine("                                   |           9. Maxnum                  |");
                Console.WriteLine("                                   |           10. Minnum                 |");
                Console.WriteLine("                                   |           11. Addall                 |");
                Console.WriteLine("                                   |           12. Subtractall            |");
                Console.WriteLine("                                   |           13. Exit                   |");
                Console.WriteLine("                                   ________________________________________");
                Console.WriteLine(" ");
            }
            else if(option == 3){
                Console.WriteLine(" ");
                Console.WriteLine("      - Input -");
                Console.WriteLine("   ---------------");
                Console.WriteLine(" ");
            }
            return 0;
        }
    }
}