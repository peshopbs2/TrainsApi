namespace TrainsApi.Data.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string JobTitle { get; set; }
        
        public virtual List<Train>? BrigadeTrains { get; set; }
        public virtual List<Train>? ConductorTrains { get; set; }
    }
}
