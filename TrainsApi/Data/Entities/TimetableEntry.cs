using System.ComponentModel.DataAnnotations.Schema;

namespace TrainsApi.Data.Entities
{
    public class TimetableEntry : BaseEntity
    {
        [ForeignKey(nameof(Location))]
        public int LocationId { get; set; }
        public virtual Location? Location { get; set; }
        [ForeignKey(nameof(Timetable))]
        public int TimetableId { get; set; }
        public virtual Timetable? Timetable { get; set; }
        public DateTime Arrive { get; set; }
        public DateTime Depart { get; set; }
    }
}
