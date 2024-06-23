namespace taskole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Initial();



            Console.ReadLine();
            Console.ReadKey();
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
            Console.Write("> ");
        }
    }
}
