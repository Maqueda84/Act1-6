using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity5.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }
    }
    public class BookManager
    {
        public static List<Book> GetBooks()
        {
            var books = new List<Book>();

            books.Add(new Book { BookId = 1, Title = "UNAM", Author = "", CoverImage = "Assets/06unam.jpg" });
            books.Add(new Book { BookId = 2, Title = "FCA", Author = "", CoverImage = "Assets/04FCA.gif" });
            books.Add(new Book { BookId = 3, Title = "Aguila", Author = "", CoverImage = "Assets/01.jpg" });
            books.Add(new Book { BookId = 4, Title = "Huella", Author = "", CoverImage = "Assets/02.gif" });
            books.Add(new Book { BookId = 5, Title = "PUMA", Author = "", CoverImage = "Assets/05puma.png" });
            books.Add(new Book { BookId = 6, Title = "ADIDAS", Author = "", CoverImage = "Assets/03adidas.png" });

            return books;
        }

    }

}
