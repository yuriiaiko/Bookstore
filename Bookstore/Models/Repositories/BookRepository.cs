
namespace Bookstore.Models.Repositories
{
    public class BookRepository : IBookstoreRepository<Book>
    {
        IList<Book> books;
        public BookRepository()
        {
            books = new List<Book>();
            new Book
            {
                Id = 1,
                Title = "C# Programming",
                Description = "Description"
            };

            new Book
            {
                Id = 2,
                Title = "Python programming",
                Description = "No description"
            };

            new Book
            {
                Id = 3,
                Title = "ASP.NET Programming",
                Description = "Description"
            };
        }
        public void Add(Book entity)
        {
            books.Add(entity);  
        }

        public void Delete(int id)
        {
            var book = Find(id);
            books.Remove(book);

        }

        public Book Find(int id)
        {
            var book = books.SingleOrDefault(b => b.Id == id);
            return book;
        }

        public IList<Book> List()
        {
            return books;
        }

        public void Update(int id, Book newBook)
        {
            var book = Find(id);
            book.Title = newBook.Title;
            book.Description = newBook.Description;
            book.author = newBook.author;
        }
    }
}
