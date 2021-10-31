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
                    if (Index == "J" || Index == "Q" || Index == "K" || Index == "T")
                    {
                        sum =+ 10;
                    }
                    else
                    {
                        int card = Convert.ToInt32(Index);
                        sum = + card;
                    }
            }
            Console.WriteLine($"Сумма значений карт ровна = {sum}");
            Console.ReadKey();
        }
    }
}
