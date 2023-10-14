using Models.Entities.Abstratct;

namespace Models.Entities.Concrete
{
    public class Lib:BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Navigation Property
        public virtual ICollection<S_Card> S_Cards { get; set; }

        public  virtual ICollection<T_Card> T_Cards { get; set; }
    }
}
