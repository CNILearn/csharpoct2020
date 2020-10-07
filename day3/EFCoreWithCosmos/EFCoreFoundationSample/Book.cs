using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreFoundationSample
{
    public class Book
    {
        public Book(string bookId, string title, string publisher)
        {
            BookId = bookId;
            Title = title;
            Publisher = publisher;
            //if (Chapters is List<Chapter> myChapters)
            //{
            //    myChapters.AddRange(chapters);
            //}

        }
        public string BookId { get; set; } = null!;
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;
        public string? Publisher { get; set; }

        public IEnumerable<Chapter> Chapters { get; set; } = new List<Chapter>();
    }
}
