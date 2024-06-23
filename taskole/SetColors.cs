using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskole
{
    public static class SetColors
    {
        public static void Red()
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public static void Green()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void Magenta()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
        }
        public static void Yellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
        }

        public static void Cyan()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        public static void Default()
        {
            Console.ResetColor();
        }

    }
}
