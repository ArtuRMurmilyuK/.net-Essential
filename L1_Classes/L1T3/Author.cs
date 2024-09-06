using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1T3
{
    internal class Author
    {
        public string _authorText;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(_authorText);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
