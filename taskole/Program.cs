namespace taskole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Initial();

            while (true)
            {
                Console.Write("> ");
                var command = Console.ReadLine();

                if (command == "exit")
                {
                    Exit();
                    break;
                }
            }

            // TODO : remove this for the realease time
            Console.ReadKey();
        }

        public static void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"logout on {DateTime.Now} ...");
            Console.ResetColor();
        }

        public static void Initial()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Taskole Is Running ");

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(50);
                Console.Write(".");
            }

            Console.WriteLine("\n");
            Console.ResetColor();
        }
    }
}
