using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace LinQ_Assignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Book> books = Book.GetBooks();

            //Q1 Query syntax for get books priced above 300

            var Books = from book in books
                        where book.Price > 300
                        select book;

            Console.WriteLine("The books which have price greater than 300");
            foreach (var book in Books)
            {
                Console.WriteLine($"{book.Title} - {book.Price}");
            }

            //Q1.2 Method syntax for get books priced above 300
            //var Books = books.Where(book => book.Price > 300);
            //foreach (var book in Books)
            //{
            //    Console.WriteLine($"{book.Title} - {book.Price}");
            //}

            //Q 2 Query syntax: For Retrieve only the title and price of books using an anonymous type.
           var Book1 = from book in books
                       select new { book.Title, book.Price };

            Console.WriteLine("Retrieving the title and price by anonymous type");
            foreach (var book in Book1)
            {
                Console.WriteLine($"{book.Title} - {book.Price}");
            }

            //Q2.1 Method Syntax for Retrieve only the title and price of books using an anonymous type.
            //var Book1 = books.Select(book => new { book.Title, book.Price });
            //Console.WriteLine("Retrieving the title and price by anonymous type");

            //foreach (var book in Book1)
            //{
            //    Console.WriteLine($"{book.Title} - {book.Price}");
            //}

            //Q3 Query Syntax for retrieving books grouped by genres

           var Book2 = from book in books
                       group book by book.Genres into bookgroup
                       select bookgroup;

            foreach (var group in Book2)
            {
                Console.WriteLine($"Genre: {group.Key}");

                foreach (var book in group)
                    Console.WriteLine($"{book.Title} - {book.Price}");
            }

            // Q3.1 Method Syntax for retrieving books grouped by genres
            //var Book2 = books.GroupBy(book => book.Genres);

            //foreach (var group in Book2)
            //{
            //    Console.WriteLine($"Genre: {group.Key}");

            //    foreach (var book in group)
            //    {
            //        Console.WriteLine($"  {book.Title} - {book.Price}");
            //    }
            //}

            //Q4 Query Syntax: Retrieve all distinct authors
            var Book3 = (from book in books
                         select book.Author)
                        .Distinct();

            Console.WriteLine("Retrieving distinct authors");
            foreach (var author in Book3)
            {
                Console.WriteLine(author);
            }

            //// Q4.1 Method Syntax: Retrieve all distinct authors
            //var Book3 = books.Select(book => book.Author).Distinct();

            //Console.WriteLine("Retrieving distinct authors");
            //foreach (var author in Book3)
            //{
            //    Console.WriteLine(author);
            //}

            //Q5 Query Syntax : Finding total price of all the books
            var totalPrice = (from book in books
                              select book.Price).Sum();

            Console.WriteLine($"The total price of all the books is: {totalPrice}");

            //Q5.1 Method Syntax: Finding total price of all the books
            //var totalPrice = books.Sum(book => book.Price);

            //Console.WriteLine($"The total price of all the books is: {totalPrice}");

            //Q6 Query syntax: Finding the cheapest and most expensive book price
            var cheapestPrice = (from book in books
                                 select book.Price).Min();

            Console.WriteLine($"The cheapest price of all the books is: {cheapestPrice}");

            var MaximumPrice = (from book in books
                                select book.Price).Max();
            Console.WriteLine($"The expensive price of all the books is:{MaximumPrice}");

            //Q6.1 Method Syntax: Finding the cheapest and most expensive book price
            //var MinimumPrice = books.Min(book => book.Price);

            //Console.WriteLine($"The cheapest price of among all the books is:{MinimumPrice}");

            //var MaximumPrice = books.Max(book => book.Price);

            //Console.WriteLine($"The expensive price among all the books is: {MaximumPrice}");

            //Q7 Query Syntax: GetBooks with multiple genre using selectMany
            var booksWithMultipleGenres = from book in books
                                          where book.Genres.Count > 1
                                          select book;

            Console.WriteLine("Books with multiple genres:");
            foreach (var book in booksWithMultipleGenres)
            {
                Console.WriteLine($"{book.Title} - Genres: {string.Join(", ", book.Genres)}");
            }

            ////Q7.1 Method Syntax: GetBooks with multiple genre using selectMany
            //var booksWithMultipleGenres = books.Where(book => book.Genres.Count > 1);

            //Console.WriteLine("Books with multiple genres:");
            //foreach (var book in booksWithMultipleGenres)
            //{
            //    Console.WriteLine($"{book.Title} - Genres: {string.Join(", ", book.Genres)}");
            //}

            //Q8 Query Syntax: OrderBooks by price and then by title
            var orderedBooks = from book in books
                               orderby book.Price, book.Title
                               select book;

            Console.WriteLine("Books ordered by Price and then by Title:");
            foreach (var book in orderedBooks)
            {
                Console.WriteLine($"{book.Title} - Price: {book.Price}");
            }

            //Q8.1 Method Syntax: OrderBooks by price and then by title
            //var orderedBooks = books.OrderBy(book => book.Price).ThenBy(book => book.Title);

            //Console.WriteLine("Books ordered by Price and then by Title:");
            //foreach (var book in orderedBooks)
            //{
            //    Console.WriteLine($"{book.Title} - Price: {book.Price}");
            //}

            //Q9 Query Syntax: Count book in genre
            var genreCounts = from genres in books.SelectMany(book => book.Genres)
                              group genres by genres into genreGroup
                              select new { Genre = genreGroup.Key, Count = genreGroup.Count() };

            Console.WriteLine("Count of books in each genre:");
            foreach (var genres in genreCounts)
            {
                Console.WriteLine($"{genres.Genre}: {genres.Count}");
            }

            // Q9.1 Method Syntax: Count book in genre
            //var genreCounts = books.SelectMany(book => book.Genres)
            //           .GroupBy(genre => genre)
            //           .Select(genreGroup => new { Genre = genreGroup.Key, Count = genreGroup.Count() });

            //Console.WriteLine("Count of books in each genre:");
            //foreach (var genre in genreCounts)
            //{
            //    Console.WriteLine($"{genre.Genre}: {genre.Count}");
            //}

            //Q10 Query Syntax: Find books where price is null
            var booksWithNullPrice = from book in books
                                     where book.Price == null
                                     select book;

            Console.WriteLine("Books with null price:");
            foreach (var book in booksWithNullPrice)
            {
                Console.WriteLine($"{book.Title} - Price: NULL");
            }

            //Q 10.1 Method Syntax: Find books where price is null
            //var booksWithNullPrice = books.Count(book => book.Price == null);


            //Console.WriteLine($"The books where price is null: {booksWithNullPrice}");





        }
    }
}
