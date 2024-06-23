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

                string[] words = command.Split(" ").ToArray();


                // TODO : use swich in these 

                if (command == "exit")
                {
                    Exit();
                    break;
                }
                else if (command == "clear")
                {
                    ClearScreen();
                    continue;
                }
                else if (command == "")
                {
                    EmptyCommand();
                    continue;
                }
                else if (words[0] == "task")
                {
                    if (words[1] == "add")
                        AddTask();
                    else if (words[1] == "remove")
                        RemoveTask();
                    else
                        CommandNotValid();
                    continue;
                }
                else
                {
                    CommandNotValid();
                    continue;
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

        public static void ClearScreen()
        {
            Console.Clear();
        }

        public static void CommandNotValid()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Command was not found .........");
            Console.ResetColor();
        }

        public static void EmptyCommand()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("enter a valid command");
            Console.ResetColor();
        }

        public static void RemoveTask()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task was successfully removed ...!");
            Console.ResetColor();
        }

        public static void AddTask()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task was successfully added !");
            Console.ResetColor();
        }

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
    }
}
