using System;

namespace _2
{
    class Content : Class
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{Info}");
            Console.ResetColor();
        }
    }
}
