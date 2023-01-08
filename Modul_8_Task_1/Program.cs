using System;
using System.IO;

namespace Modul_8_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите полный адрес очищаемой папки");
            string sourceDirectory = Console.ReadLine();
            if (Directory.Exists(sourceDirectory))
            {
                var di = new DirectoryInfo(sourceDirectory);
                foreach (FileInfo file in di.GetFiles())
                {
                    if (true)
                    {
                        TimeSpan.FromMinutes(30);
                        file.Delete();
                        Console.WriteLine("Файл удалён");
                    }
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    if (true)
                    {
                        TimeSpan.FromMinutes(30);
                        dir.Delete(true);
                        Console.WriteLine("Папка удалена");
                    }
                }
            }
            else
            {
                Console.WriteLine("Папка не найдена. \nВведите корректный адрес папки");
            }
        }
    }
}