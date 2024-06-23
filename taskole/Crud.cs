using System.Text;

namespace taskole
{
    public static class Crud
    {
        public static void AddTask(string[] msg)
        {
            string path = "tasks/";
            string file = "test1.txt";
            StringBuilder message = new StringBuilder();

            foreach (var word in msg)
            {
                message.Append(word);
                message.Append(' ');
            }

            using (StreamWriter sw = new StreamWriter(path + file))
            {
                sw.WriteLine(message);
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task was successfully added !");
            Console.ResetColor();
        }

        public static void RemoveTask()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Task was successfully removed ...!");
            Console.ResetColor();
        }
    }
}
