using Microsoft.IdentityModel.Tokens;
using Practice_Project.Model;

namespace Practice_Project.Functions
{
    public class TestFunctions
    {
        public TestFunctions() { }

        public List<Book> FindByBookName(string title, List<Book>? books)
        {
            var book = books.Where(f => f.Title == title).ToList();
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
