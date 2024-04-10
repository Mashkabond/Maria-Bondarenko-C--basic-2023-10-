using System.IO;
using System.Text;

namespace Homework10
{
    internal class Program
    {
        private static readonly int FilesCount = 10;

        private static readonly string TestDir1 = "c:\\Otus\\TestDir1";
        private static readonly string TestDir2 = "c:\\Otus\\TestDir2";

        static void Main(string[] args)
        {
            CreateDirectory(TestDir1);
            CreateDirectory(TestDir2);

            for (int i = 1; i <= FilesCount; i++)
            {
                string path1 = Path.Combine(TestDir1, $"File{i}");
                string path2 = Path.Combine(TestDir2, $"File{i}");
                CreateFile(path1);
                CreateFile(path2);
            }

            WriteFilenameToFiles(TestDir1);
            WriteFilenameToFiles(TestDir2);

            WriteCurrentDateToFiles(TestDir1);
            WriteCurrentDateToFiles(TestDir2);

            PrintFiles(TestDir1);
            PrintFiles(TestDir2);
        }

        private static void CreateDirectory(string path)
        {
            try
            {
                var directoryInfo = new DirectoryInfo(path);
                if (!directoryInfo.Exists)
                {
                    Console.WriteLine($"Создаю директорию - {path}");
                    directoryInfo.Create();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void CreateFile(string path)
        {
            try
            {
                Console.WriteLine($"Создаю файл - {path}");
                File.Create(path).Close();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void WriteFilenameToFiles(string path)
        {
            var directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles();
                foreach (var file in files)
                {
                    try
                    {
                        var writer = file.AppendText();
                        writer.WriteLine(file.Name, Encoding.UTF8);
                        writer.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("Указанная директория не существует");
            }
        }

        public static void WriteCurrentDateToFiles(string path)
        {
            var directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles();
                foreach (var file in files)
                {
                    try
                    {
                        var writer = file.AppendText();
                        writer.WriteLine(DateTime.Now.ToString(), Encoding.UTF8);
                        writer.Close();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("Указанная директория не существует");
            }
        }

        public static void PrintFiles(string path)
        {
            var directoryInfo = new DirectoryInfo(path);
            if (directoryInfo.Exists)
            {
                var files = directoryInfo.GetFiles();
                foreach (var file in files)
                {
                    var writer = file.OpenText();
                    Console.WriteLine($"{file.FullName}: {writer.ReadToEnd()}");
                    writer.Close();
                }
            }
            else
            {
                Console.WriteLine("Указанная директория не существует");
            }
        }
    }
}