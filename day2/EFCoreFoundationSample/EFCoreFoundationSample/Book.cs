using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreFoundationSample
{
    public class Book
    {
        public int BookId { get; set; }
        [StringLength(50)]
        public string Title { get; set; } = string.Empty;
        public string? Publisher { get; set; }
    }
}
