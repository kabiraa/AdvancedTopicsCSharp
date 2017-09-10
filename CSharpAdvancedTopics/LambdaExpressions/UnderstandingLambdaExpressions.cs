using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvancedTopics.LambdaExpressions
{
    class UnderstandingLambdaExpressions
    {
        public UnderstandingLambdaExpressions()
        {
            //Syntax:: args => expression. Eg.s

            //() => ... empty arg
            //x => ... single arg
            //(x,y,z) => ... multiple args

            //Func<int, int> sqaure = number => number * number;
            //Console.WriteLine("Sqaure of 5:" + sqaure(5));
            //Console.ReadLine();
            var books = new BookRepository().GetBooks();
            var cheapBooks = books.FindAll(book => book.Price < 10);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.Title);
            }
            Console.Read();
            //Func<int,List<Book>> cheapBooks = bookPrice => bookPrice < books.Select
        }
    }
}
