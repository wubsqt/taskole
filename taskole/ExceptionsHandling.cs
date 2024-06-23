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
            SetColors.Yellow();
            Console.WriteLine("Command was not found .........");
            SetColors.Default();
        }

        public static void EmptyCommand()
        {
            SetColors.Red();
            Console.WriteLine("enter a valid command");
            SetColors.Default();
        }
    }
}
