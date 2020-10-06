using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreFoundationSample
{
    public class Book
    {
        public static Book CreateNewBook() =>
            new Book { BookId = Guid.NewGuid().ToString() };
        public string BookId { get; set; } = null!;
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;
        public string? Publisher { get; set; }
    }
}
