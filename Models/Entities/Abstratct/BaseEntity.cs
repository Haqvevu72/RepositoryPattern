namespace Models.Entities.Abstratct
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime UpddatedTime { get; set; }

        public BaseEntity()
        {
            CreatedTime = DateTime.MinValue;
        }
    }
}
