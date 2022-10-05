using System;

namespace AccessArray
{
    class Program
    {
        static void Main(string[] args)
        {


            int hour;
            int minute;
            int second;
            String dayPart;
            int time;

            Console.Write("enter time\n");
            hour = Convert.ToInt32(Console.ReadLine());
            minute = Convert.ToInt32(Console.ReadLine());
            second = Convert.ToInt32(Console.ReadLine());
            dayPart = Console.ReadLine();

            Console.WriteLine(hour + "." + minute + "." + second + dayPart);

            if (dayPart == "PM")
            {
                hour = hour + 12;
                Console.WriteLine(hour + "." + minute + "." + second);


            }
            else
            {
                if (hour < 10)
                {
                    Console.WriteLine("0" + hour + "." + minute + "." + second);
                }
                else
                {
                    Console.WriteLine(hour + "." + minute + "." + second);
                }


            }
        }
    }
}


