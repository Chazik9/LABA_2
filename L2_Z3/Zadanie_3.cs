using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Z3
{
    internal class Zadanie_3 //Вывести количество цифр в числе k
    {
        static void Main(string[] args)
        {
            double kDouble;//Число в формате Double
            int kInt;//Число в формате Int
            int lengthOfNumber;//Длина Числа
            bool isNumberInt;//Проверка строки на преобразования в Int
            bool isNumberDouble;//Проверка строки на преобразования в Double
            string kString;//Входная строка
            string kResStr;//Строка преобразованная для подсчёта длины(конечная)
            do
            {
                Console.WriteLine("Я программа которая считает кол-во цифр в числе k.");
                Console.WriteLine("Введите число k");
                kString = Console.ReadLine();
                isNumberInt = int.TryParse(kString, out kInt);//Проверка на преобразования в Int
                isNumberDouble = double.TryParse(kString.Replace(".", ","), out kDouble);//Проверка на преобразования в Double. С возможным вводом как через ",", так и через "."
                if (!isNumberInt && !isNumberDouble)//Проверка на не число + вывод
                {
                    Console.WriteLine("Введено неправильное значение, попробуйте ещё раз");
                }
            } while (!isNumberInt && !isNumberDouble);//Проверка на не число
            if (isNumberInt) 
            {
                kResStr = kInt.ToString();//Итоговоя строка если из типа Int
            }
            else
            {
                kResStr = kDouble.ToString();//Итоговоя строка если из типа Double
            }
            lengthOfNumber = kResStr.Replace("-", "").Replace(",", "").Length;//Убираем лишние знаки для подсчёта
            Console.WriteLine($"Количество цифр в числе {lengthOfNumber}");
        }
    }
}
