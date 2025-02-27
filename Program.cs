using System;
using System.IO; // StreamWriter();

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the text editor! Select below which option you want to perform:");
            Console.WriteLine();

            Console.WriteLine("1 => Open file");
            Console.WriteLine("2 => Create new file");
            Console.WriteLine("0 => Exit");

            Console.WriteLine();
            Console.Write("Enter your choice: ");
            short option = short.Parse(Console.ReadLine());
            
            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: OpenFile(); break;
                case 2: EditFile(); break;
                default: Menu(); break;
            }
        }

        static void OpenFile()
        {
            Console.Clear();
            Console.Write("> Enter the path of the file you want to open: ");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine($"File {path} was read successfully!");
            Console.WriteLine("Press [Enter] to continue.");

            Console.ReadLine();
            Menu();
        }

        static void EditFile()
        {
            Console.Clear();
            Console.WriteLine("Type anything below or press [ENTER + ESC] to exit.");
            Console.WriteLine("===================================================");

            string text = "";

            do
            {
                text += Console.ReadLine();
                text += Environment.NewLine;
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Save(text);
        }

        static void Save(string text)
        {
            Console.Clear();
            Console.Write("=> Enter the path where you want to save your file: ");
            var path = Console.ReadLine();
            
            using(var file = new StreamWriter(path))
            {
                file.Write(text);
            }

            Console.WriteLine($"The file {path} was saved successfully!");
            Console.WriteLine("Press [Enter] to continue.");

            Console.ReadLine();
            Menu();
        }
    }
}
