using System;

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

        }

        static void EditFile()
        {
            {

            }
        }
    }
}
