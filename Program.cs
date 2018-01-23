using System;

namespace Calculator_Hmwk
{
    class Program
    {
        static void Main(string[] args)
        {
            int first_Num;
            int sec_Num;                     //Variables for equation
            string operation;
            int answer;


            Console.WriteLine(" Menu Driven Program aka a Basic Calculator");
            Console.ReadLine();

            Console.WriteLine("Enter the first number in the equations:");
            first_Num = Convert.ToInt32(Console.ReadLine());

            //user input for equation

            Console.WriteLine("Enter the second number in your equation:");
            sec_Num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter your operation (x, /, +, -) ");
            operation = (Console.ReadLine());

            if (operation == "x")
            {
                answer = first_Num * sec_Num;
                Console.WriteLine(first_Num + "x" + sec_Num + "=" + answer);
                Console.ReadLine();
            }
            //Getting Answers
            else if (operation == "/")
            {
                answer = first_Num / sec_Num;
                Console.WriteLine(first_Num + "/" + sec_Num + "=" + answer);
                Console.ReadLine();
            }
            else if (operation == "+")
            {
                //answer = first_Num + sec_Num;
                answer = add(first_Num, sec_Num);
                Console.WriteLine(first_Num + "+" + sec_Num + "=" + answer);
                Console.ReadLine();
            }
            else if (operation == "-")
            {
                //answer = first_Num - sec_Num;
                answer = sub(first_Num, sec_Num);
                Console.WriteLine(first_Num + "-" + sec_Num + "=" + answer);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Sorry Invalid Input");
                Console.ReadLine();
            }
        }
        static int add(int a, int b)
        {
            return a + b;
        }
        static int sub(int a, int b)
        {
            return a - b;
        }
    }
}