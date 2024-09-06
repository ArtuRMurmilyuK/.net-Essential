using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1T3
{
    internal class Content 
    {
        public string _content;

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(_content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
