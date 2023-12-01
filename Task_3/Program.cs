// Задача 3: Задайте массив из вещественных чисел с
// ненулевой дробной частью. Найдите разницу между
// максимальным и минимальным элементов массива. 

using System;
class Program
{
    static void Main()
    {
        // Задаем массив из вещественных чисел с ненулевой дробной частью
        double[] array = { 10.5, 7.2, 15.8, 20.3, 12.6, 18.7, 25.1, 8.9, 11.4, 30.2 };

        // Находим максимальный и минимальный элементы массива
        double maxElement = array[0];
        double minElement = array[0];

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }

            if (array[i] < minElement)
            {
                minElement = array[i];
            }
        }

        // Находим разницу между максимальным и минимальным элементами
        double difference = maxElement - minElement;

        Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {difference}");
    }
}