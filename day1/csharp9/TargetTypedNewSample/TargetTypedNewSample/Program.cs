using System;

namespace TargetTypedNewSample
{
    class Program
    {
        private Book theBook = new("a", "b");

        static void Main(string[] args)
        {
            var b = new Book("title", "pub");
            Book b2 = new("title", "pub");

        }
    }
}
