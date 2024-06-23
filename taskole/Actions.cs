namespace taskole
{
    public static class Actions
    {
        public static void Initial()
        {
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
