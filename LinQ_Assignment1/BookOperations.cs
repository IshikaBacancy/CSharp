using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ_Assignment1
{
    public class BookOperations
    {
        public void QueryGetBooksAbovePrice(List<Book> books, double price)
        {
            var Books = from book in books
                        where book.Price > 300
                        select book;

            Console.WriteLine("The books which have price greater than 300");
            foreach (var book in Books)
            {
                Console.WriteLine($"{book.Title} - {book.Price}");
            }
        }

        public void MethodGetBooksAbovePrice(List<Book> books, double price)
        {
            //var Books = books.Where(book => book.Price > 300);
            //foreach (var book in Books)
            //{
            //    Console.WriteLine($"{book.Title} - {book.Price}");
            //}
        }

        public void QueryGetTitleAndPrice(List<Book> books)
        {
            var Book1 = from book in books
                        select new { book.Title, book.Price };

            Console.WriteLine("Retrieving the title and price by anonymous type");
            foreach (var book in Book1)
            {
                Console.WriteLine($"{book.Title} - {book.Price}");
            }
        }

        public void MethodGetTitleAndPrice(List<Book> books)
        {
            //var Book1 = books.Select(book => new { book.Title, book.Price });
            //Console.WriteLine("Retrieving the title and price by anonymous type");

            //foreach (var book in Book1)
            //{
            //    Console.WriteLine($"{book.Title} - {book.Price}");
            //}
        }

        public void QueryGroupByGenre(List<Book> books)
        {
            var Book2 = from book in books
                        group book by book.Genres into bookgroup
                        select bookgroup;

            foreach (var group in Book2)
            {
                Console.WriteLine($"Genre: {group.Key}");

                foreach (var book in group)
                    Console.WriteLine($"{book.Title} - {book.Price}");
            }
        }

        public void MethodGroupByGenre(List<Book> books)
        {
            //var Book2 = books.GroupBy(book => book.Genres);

            //foreach (var group in Book2)
            //{
            //    Console.WriteLine($"Genre: {group.Key}");

            //    foreach (var book in group)
            //    {
            //        Console.WriteLine($"  {book.Title} - {book.Price}");
            //    }
            //}

        }

        public void QueryGetDistinctAuthors(List<Book> books)
        {
            var Book3 = (from book in books
                         select book.Author)
                        .Distinct();

            Console.WriteLine("Retrieving distinct authors");
            foreach (var author in Book3)
            {
                Console.WriteLine(author);
            }
        }

        public void MethodGetDistinctAuthors(List<Book> books)
        {
            //var Book3 = books.Select(book => book.Author).Distinct();

            //Console.WriteLine("Retrieving distinct authors");
            //foreach (var author in Book3)
            //{
            //    Console.WriteLine(author);
            //}
        }

        public void QueryGetTotalPrice(List<Book> books)
        {
            var totalPrice = (from book in books
                             select book.Price).Sum();

            Console.WriteLine($"The total price of all the books is: {totalPrice}");

        }

        public void MethodGetTotalPrice(List<Book> books)
        {
            //var totalPrice = books.Sum(book => book.Price);

            //Console.WriteLine($"The total price of all the books is: {totalPrice}");
        }

        public void QueryGetMinMaxPrice(List<Book> books)
        {
            var cheapestPrice = (from book in books
                                 select book.Price).Min();

            var MaximumPrice = (from book in books
                                select book.Price).Max();
            
            Console.WriteLine($"The cheapest price of all the books is: {cheapestPrice}");
            Console.WriteLine($"The expensive price of all the books is:{MaximumPrice}");


        }

        public void MethodGetMinMaxPrice(List<Book> books)
        {
            //var MinimumPrice = books.Min(book => book.Price);

            //Console.WriteLine($"The cheapest price of among all the books is:{MinimumPrice}");

            //var MaximumPrice = books.Max(book => book.Price);

            //Console.WriteLine($"The expensive price among all the books is: {MaximumPrice}");
        }

        public void QueryGetBooksWithMultipleGenres(List<Book> books)
        {
            var booksWithMultipleGenres = from book in books
                                          where book.Genres.Count > 1
                                          select book;

            Console.WriteLine("Books with multiple genres:");
            foreach (var book in booksWithMultipleGenres)
            {
                Console.WriteLine($"{book.Title} - Genres: {string.Join(", ", book.Genres)}");
            }
        }

        public void MethodGetBooksWithMultipleGenres(List<Book> books)
        {
            //var booksWithMultipleGenres = books.Where(book => book.Genres.Count > 1);

            //Console.WriteLine("Books with multiple genres:");
            //foreach (var book in booksWithMultipleGenres)
            //{
            //    Console.WriteLine($"{book.Title} - Genres: {string.Join(", ", book.Genres)}");
            //}
        }

        public void QueryOrderByTitleAndThenByPrice(List<Book> books)
        {
            var orderedBooks = from book in books
                               orderby book.Price, book.Title
                               select book;

            Console.WriteLine("Books ordered by Price and then by Title:");
            foreach (var book in orderedBooks)
            {
                Console.WriteLine($"{book.Title} - Price: {book.Price}");
            }
        }

        public void MethodOrderByTitleAndThenByPrice(List<Book> books)
        {
            //var orderedBooks = books.OrderBy(book => book.Price).ThenBy(book => book.Title);

            //Console.WriteLine("Books ordered by Price and then by Title:");
            //foreach (var book in orderedBooks)
            //{
            //    Console.WriteLine($"{book.Title} - Price: {book.Price}");
            //}
        }

        public void QueryCountBookInEachGenre(List<Book> books)
        {
            var genreCounts = from genres in books.SelectMany(book => book.Genres)
                              group genres by genres into genreGroup
                              select new { Genre = genreGroup.Key, Count = genreGroup.Count() };

            Console.WriteLine("Count of books in each genre:");
            foreach (var genres in genreCounts)
            {
                Console.WriteLine($"{genres.Genre}: {genres.Count}");
            }
        }

        public void MethodCountBookInEachGenre(List<Book> books)
        {
            //var genreCounts = books.SelectMany(book => book.Genres)
            //           .GroupBy(genre => genre)
            //           .Select(genreGroup => new { Genre = genreGroup.Key, Count = genreGroup.Count() });

            //Console.WriteLine("Count of books in each genre:");
            //foreach (var genre in genreCounts)
            //{
            //    Console.WriteLine($"{genre.Genre}: {genre.Count}");
            //}
        }

        public void QueryGetBooksWithNullValue(List<Book> books)
        {
            var booksWithNullPrice = from book in books
                                     where book.Price == null
                                     select book;

            Console.WriteLine("Books with null price:");
            foreach (var book in booksWithNullPrice)
            {
                Console.WriteLine($"{book.Title} - Price: NULL");
            }
        }

        public void MethodGetBooksWithNullValue(List<Book> books)
        {
            //var booksWithNullPrice = books.Count(book => book.Price == null);


            //Console.WriteLine($"The books where price is null: {booksWithNullPrice}");
        }
    }
}
