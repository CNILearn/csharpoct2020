using System;

namespace InitOnlySetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book { BookId = 1, Title = "Professional C#" };

            // book.Title = "new value";
        }
    }
}
