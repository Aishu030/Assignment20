using System;
using System.Collections.Generic;
namespace Booklib
{
    public class Book
    { 
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsAvailable { get; set; }
    }
}
