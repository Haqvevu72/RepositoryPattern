using Models.Entities.Abstratct;

namespace Models.Entities.Concrete
{
    public class Book:BaseEntity
    {
        public string Name { get; set; }

        public int Pages { get; set; }

        public int YearPress { get; set; }

        public int Id_Themes { get; set; }

        public int Id_Category { get; set; }

        public int Id_Author { get; set; }

        public int Id_Press { get; set; }

        public string Comment { get; set; }

        public int Quantity { get; set; }

        // Navigation Property
        public virtual Category Category { get; set; }

        public virtual  Author Author { get; set; }

        public virtual Press Press { get; set; }

        public virtual Theme Theme { get; set; }

        public virtual ICollection<S_Card> S_Cards { get; set; }

        public virtual ICollection<T_Card> T_Cards { get; set; }
    }
}
