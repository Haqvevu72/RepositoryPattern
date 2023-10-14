using Models.Entities.Abstratct;

namespace Models.Entities.Concrete
{
    public class Student:BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id_Group { get; set; }

        public int Term { get; set; }

        // Navigation Property
        public virtual Group Group { get; set; }

        public  virtual ICollection<S_Card> S_Cards { get; set; }
    }
}
