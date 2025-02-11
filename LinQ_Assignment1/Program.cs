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


            BookOperations bookoperations = new BookOperations();
            bookoperations.QueryGetBooksAbovePrice(books, 300);
            bookoperations.MethodGetBooksAbovePrice(books, 300);
            bookoperations.QueryGetTitleAndPrice(books);
            bookoperations.MethodGetTitleAndPrice(books);
            bookoperations.QueryGroupByGenre(books);
            bookoperations.MethodGroupByGenre(books);
            bookoperations.QueryGetDistinctAuthors(books);
            bookoperations.MethodGetDistinctAuthors(books);
            bookoperations.QueryGetTotalPrice(books);
            bookoperations.MethodGetTotalPrice(books);
            bookoperations.QueryGetMinMaxPrice(books);
            bookoperations.MethodGetMinMaxPrice(books);
            bookoperations.QueryGetBooksWithMultipleGenres(books);
            bookoperations.MethodGetBooksWithMultipleGenres(books);
            bookoperations.QueryOrderByTitleAndThenByPrice(books);
            bookoperations.MethodOrderByTitleAndThenByPrice(books);
            bookoperations.QueryCountBookInEachGenre(books);
            bookoperations.MethodCountBookInEachGenre(books);
            bookoperations.QueryGetBooksWithNullValue(books);
            bookoperations.MethodGetBooksWithNullValue(books};
          }                                               
    }
}
