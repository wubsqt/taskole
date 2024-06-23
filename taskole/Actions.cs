using System.IO;

namespace taskole
{
    public static class Actions
    {
        public static void Initial()
        {
            string _path = "tasks/";
            string _file = "test1.txt";

            void CreateSavingPlace(string path)
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }

            if (!Checkers.IsSavingPlaceExist(_path))
                CreateSavingPlace(_path);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Taskole Is Running ");

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(50);
                Console.Write(".");
            }

            Console.WriteLine("\n");
            Console.ResetColor();
        }

        public static void ClearScreen()
        {
            Console.Clear();
        }

        public static void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"logout on {DateTime.Now} ...");
            Console.ResetColor();
        }

    }
}
