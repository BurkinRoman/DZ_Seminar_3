class Program
{
    static void Main()
    {
        // Задаем массив из 10 целых чисел
        int[] arr = { 5, 12, 7, 14, 23, 30, 18, 42, 56, 91 };

        // Находим количество четных чисел в массиве
        int countEven = 0;

        foreach (int num in arr)
        {
            if (num % 2 == 0)
            {
                countEven++;
            }
        }

        Console.WriteLine($"Количество четных чисел в массиве: {countEven}");
    }
}