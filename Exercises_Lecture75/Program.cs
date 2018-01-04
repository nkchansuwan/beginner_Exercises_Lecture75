using System;
using System.IO;
using System.Reflection;

namespace Exercises_Lecture75
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
            Exercise2();
        }

        public static void Exercise1()
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "TestFile.txt");

            var allWord = File.ReadAllText(path);

            var separator = new char[] { '_', '-', '/', '.', ',', ' ' };

            var words = allWord.Trim().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(words.Length);
        }

        public static void Exercise2()
        {
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "TestFile.txt");

            var allWord = File.ReadAllText(path);

            var separator = new char[] { '_', '-', '/', '.', ',', ' ' };

            var words = allWord.Trim().Split(separator, StringSplitOptions.RemoveEmptyEntries);

            var longestWord = "";

            foreach (var item in words)
            {
                if (item.Length>longestWord.Length)
                {
                    longestWord = item;
                }
            }

            Console.WriteLine(longestWord);
        }
    }
}
