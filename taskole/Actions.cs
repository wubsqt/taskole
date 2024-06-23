using System.IO;

namespace taskole
{
    public static class Actions
    {
        public static void Initial()
        {
            string _path = "tasks/";

            void CreateSavingPlace(string path)
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }

            if (!Checkers.IsSavingPlaceExist(_path))
                CreateSavingPlace(_path);

            ClearScreen();
            SetColors.Magenta();
            Console.Write("Taskole Is Running ");

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(50);
                Console.Write(".");
            }

            Console.WriteLine("\n");
            SetColors.Default();
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
