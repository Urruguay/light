using System;

namespace _2
{
    class Title : Class
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"Название книги - {Info}");
            Console.ResetColor();
        }
    }
}
