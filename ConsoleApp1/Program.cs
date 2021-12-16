using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());

            if (hours == 12 || hours == 24)
            {
                Console.WriteLine("Угол между минутной и часовой стрелкой равен 0.");
            }
            else if (hours > 0 && hours <= 6)
            {
                Console.WriteLine($"Угол между минутной и часовой стрелкой равен {hours * 30}.");
            }
            else if (hours > 6 && hours <12)
            {
                Console.WriteLine($"Угол между минутной и часовой стрелкой равен {360 - (hours * 30)}.");
            }
            else if (hours > 12 && hours <= 18)
            {
                Console.WriteLine($"Угол между минутной и часовой стрелкой равен {(hours-12) * 30}.");
            }
            else if (hours > 18 && hours < 24)
            {
                Console.WriteLine($"Угол между минутной и часовой стрелкой равен {360 - ((hours-12) * 30)}.");
            }
            else Console.WriteLine("Некорректное значение времени");
        }
    }
}
