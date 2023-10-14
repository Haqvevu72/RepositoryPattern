using Models.Entities.Abstratct;

namespace Models.Entities.Concrete
{
    public class T_Card:BaseEntity
    {
        public int Id_Teacher { get; set; }

        public int Id_Book { get; set; }

        public int Id_Lib { get; set; }

        public DateTime DateOut { get; set; }

        public DateTime? DateIn { get; set; }

        // Navigation Property
        public virtual Teacher Teacher { get; set; }

        public virtual Book Book { get; set; }

        public virtual Lib Lib { get; set; }
    }
}
