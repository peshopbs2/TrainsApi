namespace TrainsApi.Data.Entities
{
    public class Locomotive : BaseEntity
    {
        public string SerialNumber { get; set; }
        public virtual List<Train>? Trains { get; set; }
    }
}
