using System;

namespace ConsoleApp1
{
    enum WeekDay { Mon, Tue, Wed, Thu, Fri };

    class Hello
    {

        static void Main(string[] args)
        {
            WeekDay startDay = WeekDay.Mon;
            WeekDay endDay = WeekDay.Fri;
            Console.WriteLine("The days of the week we work are:");
            for (int i = (int)startDay; i <= (int)endDay; i++)
            {

                WeekDay day = (WeekDay)i;
                Console.WriteLine(day);
            }
        }

        /* static void Main(string[] args)
         {

             var name = "sameer";
             var num = 123;
             var rbit = true;

             Type a1 = name.GetType();
             Type r1 = rbit.GetType();

             Type n2 = num.GetType();
             Console.WriteLine("Data Type of Name is "+a1);
             Console.WriteLine("Data Types of name with Diff =:"+a1.ToString());
             Console.WriteLine("Data Type of Num is " + n2);
             Console.WriteLine("Data Types of num with Diff =:" + n2.ToString());
             Console.WriteLine("Data Types of rbit with Diff =:" + r1.ToString());

         }*/







    }




}