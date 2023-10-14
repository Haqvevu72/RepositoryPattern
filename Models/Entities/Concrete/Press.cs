using Models.Entities.Abstratct;

namespace Models.Entities.Concrete
{
    public class Press:BaseEntity
    {
        public string Name { get; set; }

        // Navigation Property
        public virtual ICollection<Book> Books { get; set; }
    }
}
