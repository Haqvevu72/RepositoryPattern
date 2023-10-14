using Models.Entities.Abstratct;

namespace Models.Entities.Concrete
{
    public class Group:BaseEntity
    {
        public string Name { get; set; }

        public int Id_Faculty { get; set; }

        // Navigation Property
        public virtual Faculty Faculty { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
