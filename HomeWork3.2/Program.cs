using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветстую вас в игре Blackjack. Какое количество карт у вас на руках?");
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i=0; i<number; i++ )
            {
                Console.WriteLine(" Введите номинал каждой карты. Обращаю ваше внимание: \n Валет - J \n Дама - Q \n Король - К \n Туз - Т");
                String Index = Console.ReadLine();
                switch (Index)
                    {
                    case "6":
                        sum = + 6;
                        break;
                    case "7":
                        sum = + 7;
                        break;
                    case "8":
                        sum = + 8;
                        break;
                    case "9":
                        sum = + 9;
                        break;
                    case "10":
                        sum = + 10;
                        break;
                    case "J":
                        sum = + 10;
                        break;
                    case "Q":
                        sum = + 10;
                        break;
                    case "K":
                        sum = + 10;
                        break;
                    case "T":
                        sum = + 10;
                        break;
                    default:
                        Console.WriteLine("Таких карт в колоде нет");
                        break;
                    }
            }
            Console.WriteLine($"Сумма значений карт ровна = {sum}");
            Console.ReadKey();
        }
    }
}
