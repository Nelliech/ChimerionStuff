namespace ChimerionStuffApi.Models
{
    public abstract class BasicEntity
    {
        public Guid Id { get; set; } = new Guid();
        public DateTime CreateDateTime { get; set; }
        public DateTime UpdateDateTime { get; set; }
    }
}
