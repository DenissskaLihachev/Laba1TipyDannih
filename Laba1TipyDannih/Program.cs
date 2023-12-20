using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: "); int N = Convert.ToInt32(Console.ReadLine()); Console.Clear();
        int[] massive = new int[N];

        while (true)
        {
            Console.WriteLine("1) - Вывод массива");
            Console.WriteLine("2) - Заполнить массив рандомными числами");
            Console.Write("Выбор: "); int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        ShowMassive(massive);
                        break;
                    }
                case 2:
                    {
                        GetRandomMassive(massive);
                        break;
                    }
            }
            Console.Clear();
        }
    }
    static void GetRandomMassive(int[] array)
    {
        Random rand = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = rand.Next(1, 100);
        }
    }
    static void ShowMassive(int[] array)
    {
        Console.Write("Массив: [ ");
        for (int i = 0; i < array.Length; i++)
            Console.Write(array[i] + " ");
        Console.WriteLine("]");
        Console.ReadKey();
    }
}