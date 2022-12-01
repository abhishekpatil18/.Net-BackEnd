using System.Text.Json.Serialization;

namespace Practice_Project.Model
{
    public class Book
    {
        public int bookId { get; set; }
        public string Title { get; set; }

        [JsonIgnore]
        public Student? student { get; set; }
        public int studentId { get; set; }
    }
}
