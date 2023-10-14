using Models.Entities.Abstratct;

namespace Models.Entities.Concrete
{
    public class Faculty:BaseEntity
    {
        public string Name { get; set; }

        // Navigation Property
        public virtual ICollection<Group> Groups { get; set; }
    }
}
