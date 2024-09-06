using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1T3
{
    internal class Title
    {
        public string _title;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(_title);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
