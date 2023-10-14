using Models.Entities.Abstratct;

namespace Models.Entities.Concrete
{
    public class Teacher:BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Id_Dep { get; set; }

        // Navigation Property
        public virtual Department Department { get; set; }

        public virtual ICollection<T_Card> T_Cards { get; set; }

    }
}
