using Models.Entities.Abstratct;

namespace Models.Entities.Concrete
{
    public class Department:BaseEntity
    {
        public string Name { get; set; }

        // Navigation Property
        public virtual ICollection<Teacher> Teachers { get; set; }

    }
}
