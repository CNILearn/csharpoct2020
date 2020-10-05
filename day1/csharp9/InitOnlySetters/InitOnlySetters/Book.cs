using System;
using System.Collections.Generic;
using System.Text;

namespace InitOnlySetters
{
    public class Book
    {
        public int BookId { get; init; }
        public string Title { get; init; }
    }
}
