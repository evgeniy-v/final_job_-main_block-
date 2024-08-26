//Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string[] inputArray;
        int arraySize;
            // Ввод количества строк в массиве с проверкой на корректность
        while (true)
        {
            Console.WriteLine("Введите количество строк в массиве:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out arraySize) && arraySize > 0)
            {
                break; // Ввод корректен, выходим из цикла
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите корректное положительное число.");
            }
        }

            // Создание массива заданного размера
            inputArray = new string[arraySize];

            // Ввод строк
            for (int i = 0; i < arraySize; i++)
            {
                Console.WriteLine($"Введите строку {i + 1}:");
                inputArray[i] = Console.ReadLine();
            }

        // Вызов метода для формирования нового массива
        string[] resultArray = FilterArray(inputArray);

        Console.WriteLine();
        Console.WriteLine("Результат:");
        // Вывод результата
        Console.WriteLine("[\"" + string.Join("\", \"", inputArray) + "\"] -> [\"" + string.Join("\", \"", resultArray) + "\"]");

        Console.ReadKey();
    }

    static string[] FilterArray(string[] array)
    {
        // Подсчитываем количество элементов с длиной <= 3
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив необходимого размера
        string[] result = new string[count];

        // Заполняем новый массив подходящими элементами
        int index = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Length <= 3)
            {
                result[index] = array[i];
                index++;
            }
        }

        return result;
    }
}
