using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Z3V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNumberN = false; //Отвечает за проверку на целое 
            int n; // Число
            int count=0; // счётчик цифр в числе
            Console.WriteLine("Я программа которая считает кол-во цифр в числе n.");
            do
            {
                Console.WriteLine("Ведите целое число n");
                isNumberN = int.TryParse(Console.ReadLine(), out n);//Проверка на преобразования в Int
                if (!isNumberN)
                {
                    Console.WriteLine("Введено неправильное значение, попробуйте ещё раз");
                }
            } while (!isNumberN);
            while(n!= 0)
            {
                count++;//Счётчик +1
                n = n / 10;//целочисленное деление на 10(убираем одну цифру последнюю)
                Console.WriteLine(n);

            }
            Console.WriteLine($"Количество цифр в введённом числе равно {count}");
        }
    }
}
