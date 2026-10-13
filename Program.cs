using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program53
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Температура воды (°C): ");
            if (double.TryParse(Console.ReadLine(), out double t))
            {
                string state;
                if (t <= 0) state = "Лед";
                else if (t < 100) state = "Жидкость";
                else state = "Пар";

                Console.WriteLine(state);
            }
            else
            {
                Console.WriteLine("Ошибка ввода.");
            }
        }
    }
}