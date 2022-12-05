using Microsoft.IdentityModel.Tokens;
using Practice_Project.Model;

namespace Practice_Project.Functions
{
    public class BooksTestFunctions
    {
        public BooksTestFunctions() { }

        public List<Book> FindByBookName(string name, List<Book>? books)
        {
            var book = books.Where(c => c.Title == name).ToList();
            if (book.IsNullOrEmpty())
            {
                return null;
            }
            else
            {
                return book;
            }
        }

        public List<Book> FindByBookID(int id, List<Book>? books)
        {
            var book = books.Where(c => c.studentId == id).ToList();
            if (book.IsNullOrEmpty())
            {
                return null;
            }
            else
            {
                return book;
            }
        }

    }
}
