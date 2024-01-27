using TrainsApi.Data.Enums;

namespace TrainsApi.Data.Entities
{
    public class Wagon : BaseEntity
    {
        public WagonType Type { get; set; }
        public int SittingCapacity { get; set; }
        public int StandingCapacity { get; set; }
        public virtual List<Train>? Trains { get; set; }
    }
}
