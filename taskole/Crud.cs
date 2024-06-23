using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskole
{
    public static class Crud
    {
        public static void AddTask(string[] msg)
        {
            // TODO : FIX (it don't add text to file)
            if (!Directory.Exists("tasks/"))
                Directory.CreateDirectory("tasks/");
            else
            {
                if (!File.Exists("tasks/task1.txt"))
                    File.Create("tasks/task1.txt");

                File.WriteAllLines("tasks/task1.txt", msg);
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
