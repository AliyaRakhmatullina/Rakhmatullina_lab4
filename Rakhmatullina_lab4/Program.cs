using System.Security.Cryptography;
using System;

namespace ConsoleApp1
{
    internal class Program
    {

        static int CalculateSum(params int[] numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            return sum;
        }


        static void CalculateArrayInfo(ref long product, out double average, params int[] numbers)
        {
            product = 1;
            double sum = 0;
            int count = numbers.Length;

            foreach (int number in numbers)
            {
                product *= number;
                sum += number;
            }

            average = count > 0 ? sum / count : 0;
        }

        static void PrintArray(int[] array)
        {
            foreach (int number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            Console.WriteLine("1 задание");
            //Вывести на экран массив из 20 случайных чисел. Ввести два числа из этого массива,
            //которые нужно поменять местами. Вывести на экран получившийся массив.
            Random random = new Random();
            int[] numbers = new int[20];


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }


            Console.WriteLine("Исходный массив:");
            PrintArray(numbers);


            Console.WriteLine("Введите индекс первого элемента для обмена (0-19):");
            int index1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите индекс второго элемента для обмена (0-19):");
            int index2 = int.Parse(Console.ReadLine());


            if (index1 < 0 || index1 >= numbers.Length || index2 < 0 || index2 >= numbers.Length)
            {
                Console.WriteLine("Ошибка: Индексы должны быть в диапазоне от 0 до 19.");
                return;
            }


            int temp = numbers[index1];
            numbers[index1] = numbers[index2];
            numbers[index2] = temp;


            Console.WriteLine("Массив после обмена:");
            PrintArray(numbers);

            Console.WriteLine("2 задание");
            //Написать метод, где в качества аргумента будет передан массив (ключевое слово
            //params). Вывести сумму элементов массива(вернуть). Вывести(ref) произведение
            //массива.Вывести(out) среднее арифметическое в массиве.
            long product = 1;
            double average;

            int sum = CalculateSum(1, 2, 3, 4, 5);


            CalculateArrayInfo(ref product, out average, 1, 2, 3, 4, 5);


            Console.WriteLine($"Сумма элементов массива: {sum}");
            Console.WriteLine($"Произведение элементов массива: {product}");
            Console.WriteLine($"Среднее арифметическое элементов массива: {average}");
        }

    }

}
