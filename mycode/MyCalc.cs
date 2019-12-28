using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class Myconsole
    {
        public static String GetString(String que)
        {
            Console.WriteLine(que);
            return Console.ReadLine();
        }
        public static int GetNumber(String que) => int.Parse(GetString(que));
        public static Double Getdouble(String que) => int.Parse(GetString(que));

    }



    class MyCalc
    {

        static void Main(string[] args)
        {
            menuFun();
            //Console.WriteLine("calsi");
        }

        private static void menuFun()
        {
            String stmt = " press 1 for Add \n press 2 for Sub \n press 3 for Mul \n Press any Key for Div......\n";
           // int process = 1;
            do
            {
                int choice = Myconsole.GetNumber(stmt);

                processOperation(choice);
       


            } while (true);
        }

        private static void processOperation(int choice)
        {
            double first = Myconsole.Getdouble("Enter First Value");
            double second = Myconsole.Getdouble("Enter Second Value");
            
            switch(choice)
            {
                case 1:
                    addfun(first, second);
                    break;
                case 2:
                    subfun(first, second);
                    break;
                case 3:
                    mulfun(first, second);
                    break;
                
                default:
                    divfun(first, second);
                    break;
                    

            }



        }

        private static void divfun(double first, double second)
        {
            double res = first / second;
            Console.WriteLine($"Division is : {res}");
        }

        private static void mulfun(double first, double second)
        {
            double res = first * second;
            Console.WriteLine($"Multiplication is : {res}");
        }

        private static void subfun(double first, double second)
        {
            double res = first - second;
            Console.WriteLine($"Substration is : {res}");
        }

        private static void addfun(double first, double second)
        {
            double res = first + second;
            Console.WriteLine($"Addation is : {res}");
        }
    }
}
