using Models.Entities.Abstratct;

namespace Models.Entities.Concrete
{
    public class Author:BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Navigation Property
        public virtual ICollection<Book> Books { get; set; }
    }
}
