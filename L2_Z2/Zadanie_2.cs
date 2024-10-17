using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace L2_Z2
{
    internal class Zadanie_2 //22.	Дана последовательность целых чисел, за которой следует 0.
                             //Найти сумму элементов с нечетными номерами из этой последовательности.
    {
        static void Main(string[] args)
        {
            int maxiZnach= 2147483647;
            int miniZnach = -247483648;
            bool isNormalDiapozon=true;
            bool emptySequnce = false;
            int elementOfSequence = 0;//Элементы послед-ти
            int itemCounter = 1;//Проверка номеров элементов 
            int elementCounter = 1;//Счётчик номеров элементов
            bool isNumber = false;//Отвечает за проверку на целые числа элементов послед-ти 
            int summOfNumver = 0;//сумма элементов послед-ти стоящих н нечёт местах
            Console.WriteLine("Я программа, которая находит сумму элементов с нечетными номерами последовательности.");
            while (true)//Пока элемент не равен 0
            {
                do
                {
                    Console.WriteLine($"Ведите целое не отрицательное число n - {elementCounter}-ый элемент послед-ти");
                    Console.WriteLine("При вводе 0, программа начинает подсчёт и выводит результат");
                    isNumber = int.TryParse(Console.ReadLine(), out elementOfSequence);
                    if (!isNumber)
                    {
                        Console.WriteLine("Введено неправильное значение, попробуйте ещё раз");
                    }
                    if (itemCounter % 2 == 1 && elementOfSequence + summOfNumver > maxiZnach)
                    {
                        isNormalDiapozon = false;
                        Console.WriteLine("Введите число поменьше, так как сумма будет слишком большая");
                    }
                    if (itemCounter % 2 == 1 && elementOfSequence + summOfNumver < miniZnach)
                    {
                        isNormalDiapozon = false;
                        Console.WriteLine("Введите число побольше, так как сумма будет слишком маленькая");
                    }
                } while (!isNumber || !isNormalDiapozon); // проверка на не целое число
                if (elementOfSequence == 0)//проверка на конец послед-ти
                {
                    if (elementCounter == 1)//проверка на пустую послед-ть
                    {
                        emptySequnce = true;
                        Console.WriteLine("Последовательность пустая");
                    }
                    break;
                }
                if (itemCounter % 2 == 1)//проверка на нечёт номер элемента после-ти
                {
                    summOfNumver = elementOfSequence + summOfNumver;//поиск суммы
                }
                elementCounter++;
                itemCounter++;


            }
            if (!emptySequnce)
            {
                Console.WriteLine($"Сумма элементов с нечётными номерами равна {summOfNumver}");
            }
        }   
    }
}
