using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book()
            {
                Info = "Роман",
                Author = new Author() { Info = "Александр Романович Беляев" },
                Title = new Title() { Info = "Человек-амфибия" },
                Content = new Content() { Info = "Человек-амфиибия — научно-фантастический роман о человеке, способном жить под водой, написанный Александром Беляевым в 1927 году." }
            };
            book.Show();
            ReadLine();
        }
    }
}
