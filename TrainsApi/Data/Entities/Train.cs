using TrainsApi.Data.Enums;

namespace TrainsApi.Data.Entities
{
    public class Train : BaseEntity
    {
        public TrainType Type { get; set; }
        public string Number { get; set; }
        public virtual List<Locomotive>? Locomotives { get; set; }
        public virtual List<Wagon>? Wagons { get; set; }
        public virtual List<Employee>? Brigade { get; set; }
        public virtual List<Employee>? Conductors { get; set; }
    }
}
