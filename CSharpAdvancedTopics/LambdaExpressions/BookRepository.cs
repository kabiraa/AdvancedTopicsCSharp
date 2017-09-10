using System.Collections.Generic;


namespace CSharpAdvancedTopics.LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks() {
            return new List<Book>
            {
                new Book() { Title = "ABC", Price = 5},
                new Book() { Title = "MNO", Price = 7},
                new Book() { Title = "XYZ", Price = 12}
            };
        }
    }
}
