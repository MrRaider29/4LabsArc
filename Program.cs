using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите колличество папок, в которых хотите посчитать колличество файлов:");
        int folderSearch;

        while (!int.TryParse(Console.ReadLine(), out folderSearch))
        {
            Console.WriteLine("Ошибка, введите цифру пожалуйста");
        }

        for (int i = 1; i <= folderSearch; i++)
        {
            Console.WriteLine($"Введите путь к папке {i}:");
            string folderPath = Console.ReadLine();

            Console.WriteLine("Выберите тип файлов для подсчета:");
            Console.WriteLine("1. Только файлы .exe");
            Console.WriteLine("2. Только файлы .txt");
            Console.WriteLine("3. Все файлы");
            Console.Write("Введите номер варианта: ");
            int option;
            while (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Ошибка, введите цифру пожалуйста");
            }
         
            string searchPattern = "*"; // По умолчанию ищем все файлы

            if (option == 1)
            {
                searchPattern = "*.exe";
            }
            else if (option == 2)
            {
                searchPattern = "*.txt";
            }



            try
            {
                int folderCount = Directory.GetFiles(folderPath).Length;
                Console.WriteLine("Количество файлов: " + folderCount);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
                Environment.Exit(-1);
            }
        }


        Console.ReadLine();
    }
}





