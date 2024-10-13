using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L2_Z1
{
    internal class Zadanie_1 //13.	Дана последовательность из n целых чисел.
                             //Найти количество четных элементов этой последовательности.
    {
        static void Main(string[] args)
        {
            bool isNumberN = false; //Отвечает за проверку на целое не отрицательно n
            bool isNumberS = false; //Отвечает за проверку на целые числа в послд-ти 
            int n; //длина послед-тм
            int count = 0;//количестов четных элементов
            int chisloOfString;//Элементы послед-ти - целое число
            string elementOfSequence;//Элементы послед-ти - срока

            Console.WriteLine("Я программа, которая находит количество четных элементов в последовательности.");
            do
            {
                Console.WriteLine("Ведите целое не отрицательное число n - длина послед-ти");
                isNumberN = int.TryParse(Console.ReadLine(), out n);
                if (!isNumberN || n < 0)
                {
                    Console.WriteLine("Введено неправильное значение, попробуйте ещё раз");
                }
            } while (!isNumberN || n < 0); // Проверка на целое не отрицательное число n(Длина послед-ти) 
            if (n == 0)//Проверка на пустую послед-ть
            {
                Console.Write("Пустая последовательность => ");
            }
            for (int i = 0; i != n; i++)//перебор элементов строки
            {
                Console.WriteLine("Введите элементы числовой последовательность через ENTER");
                do
                {
                    Console.WriteLine($"Ведите целое не отрицательное число, {i + 1}-ый элемент послед-ти");
                    elementOfSequence = Console.ReadLine();//нашли i-ый элемент поcлед-ти
                    isNumberS = int.TryParse(elementOfSequence, out chisloOfString);
                    if (!isNumberS)//Проверка на соответсвие целому числу
                    {
                        Console.WriteLine("Введено неправильное значение, попробуйте ещё раз");
                    }
                } while (!isNumberS);//Проверка на целое число
                if (chisloOfString % 2 == 0)//проверка на чётность
                {
                    count++;
                }
            }
            Console.WriteLine($"Количество чётных элементов последовательности: {count}");
        }
    }
}
