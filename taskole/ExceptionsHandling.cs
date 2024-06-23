using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskole
{
    public static class ExceptionsHandling
    {
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
    }
}
