using System;

namespace RecordsSample
{
    public record Book1
    {
        public string Title { get; init; }
        public string Publisher { get; init; }
    }

    public record Book2(string Title, string Publisher)
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            var b1 = new Book1 { Title = "Professional C#", Publisher = "Wrox Press" };

            var b2 = new Book2("a title", "a publisher");
            var b3 = new Book2("a title", "a publisher");
            if (!object.ReferenceEquals(b2, b3))
            {
                Console.WriteLine("not the same references");
            }

            var b4 = b3 with { Title = "a new title"};
            Console.WriteLine($"{b4.Title} {b4.Publisher}");

            if (b2 == b3)
            {
                Console.WriteLine("the same values");
            }

            (string title, string publisher) = b3;  // uses Deconstruct
            Console.WriteLine(title);
        }
    }
}
