using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int arrayLenght = 30;
            int[] array = new int[arrayLenght];
            Random random = new Random();
            int randomNumberMin = 0;
            int randomNumberMax = 99;
            int arrayIndexMin = 0;
            int arrayIndexMax = array.Length-1;

            for (int arrayIndex = arrayIndexMin; arrayIndex < array.Length; arrayIndex++)
            {
                array[arrayIndex] =random.Next(randomNumberMin, randomNumberMax+1);
            }

            Console.WriteLine("Массив: ");

            for (int arrayIndex = arrayIndexMin; arrayIndex < array.Length; arrayIndex++)
            {
                Console.WriteLine(arrayIndex + ": " + array[arrayIndex]);
            }

            Console.WriteLine();
            Console.WriteLine("Вывод локальных максимумов:");

            if (array[arrayIndexMin]>= array[arrayIndexMin+1])
            {
                Console.WriteLine(arrayIndexMin + ": " + array[arrayIndexMin]);
            }

            for (int arrayIndex = arrayIndexMin+1; arrayIndex < arrayIndexMax-1; arrayIndex++)
            {
                if (array[arrayIndex]>= array[arrayIndex-1] && array[arrayIndex]>= array[arrayIndex+1])
                {
                    Console.WriteLine(arrayIndex + ": " + array[arrayIndex]);
                }
            }

            if (array[arrayIndexMax] >= array[arrayIndexMax - 1])
            {
                Console.WriteLine(arrayIndexMax + ": " + array[arrayIndexMax]);
            }
        }
    }
}