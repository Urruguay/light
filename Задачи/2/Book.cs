using System;

namespace _2
{
    class Book : Class
    {
        public Title Title { get; set; }
        public Author Author { get; set; }
        public Content Content { get; set; }
        public override void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{Info}");
            Title.Show();
            Author.Show();
            Content.Show();
            Console.ResetColor();
        }
    }
}
