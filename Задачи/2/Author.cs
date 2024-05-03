using System;

namespace _2
{
    class Author : Class
    {
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"Автор книги - {Info}");
            Console.ResetColor();
        }
    }
}
