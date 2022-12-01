namespace Practice_Project.Model
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int CurrentYear { get; set; }
        public List<Book> Books { get; set; }


    }
}
