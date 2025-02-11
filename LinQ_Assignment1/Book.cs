using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Assignment1
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double? Price { get; set; }

        public List<string> Genres { get; set; }

        public Book()
        {
            Console.WriteLine("The Book constructor is called");
        }

        public Book( int id, string title, string author,double? price,List<string>genres)
        {
            Id = id;
            Title = title;
            Author = author;
            Price = price;
            Genres = genres;
            

        }

        public static List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", null, new List<string>{"Classic", "Novel"}),
                new Book(2, "To Kill a Mockingbird", "Harper Lee", null, new List<string>{"Classic", "Drama"}),
                new Book(3, "1984", "George Orwell", 519.99, new List<string>{"Dystopian", "Sci-Fi"}),
                new Book(4, "Moby-Dick", "Herman Melville", 615.75, new List<string>{"Adventure", "Classic"}),
                new Book(5, "Pride and Prejudice", "Jane Austen", 108.99, new List<string>{"Romance", "Classic"}),
                new Book(6, "The Catcher in the Rye", "J.D. Salinger", 811.25, new List<string>{"Fiction", "Drama"}),
                new Book(7, "The Hobbit", "J.R.R. Tolkien", 314.99, new List<string>{"Fantasy", "Adventure"}),
                new Book(8, "Fahrenheit 451", "Ray Bradbury", 913.49, new List<string>{"Dystopian", "Sci-Fi"}),
                new Book(9, "Brave New World", "Aldous Huxley", 210.49, new List<string>{"Dystopian", "Sci-Fi"}),
                new Book(10, "Crime and Punishment", "Fyodor Dostoevsky", 816.00, new List<string>{"Classic", "Philosophical"}),
                new Book(11, "War and Peace", "Leo Tolstoy", 619.99, new List<string>{"Classic", "Historical"}),
                new Book(12, "The Alchemist", "Paulo Coelho", 899.49, new List<string>{"Fiction", "Philosophical"}),
                new Book(13, "The Lord of the Rings", "J.R.R. Tolkien", 625.00, new List<string>{"Fantasy", "Adventure"}),
                new Book(14, "Dracula", "Bram Stoker", 510.99, new List<string>{"Horror", "Classic"}),
                new Book(15, "The Picture of Dorian Gray", "Oscar Wilde", 412.99, new List<string>{"Classic", "Philosophical"}),
                new Book(16, "Les Misérables", "Victor Hugo", 118.50, new List<string>{"Classic", "Historical"}),
                new Book(17, "The Shining", "Stephen King", 114.75, new List<string>{"Horror", "Thriller"}),
                new Book(18, "Dune", "Frank Herbert", 717.99, new List<string>{"Sci-Fi", "Adventure"}),
                new Book(19, "The Road", "Cormac McCarthy", 113.25, new List<string>{"Post-Apocalyptic", "Drama"}),
                new Book(20, "Jane Eyre", "Charlotte Brontë", 711.50, new List<string>{"Classic", "Romance"})
            };
        }







    }
}
