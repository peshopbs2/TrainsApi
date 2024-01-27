using System.ComponentModel.DataAnnotations.Schema;

namespace TrainsApi.Data.Entities
{
    public class Timetable : BaseEntity
    {
        [ForeignKey(nameof(Train))]
        public int TrainId { get; set; }
        public virtual Train? Train { get; set; }
        public DateTime Date { get; set; }
        public virtual List<TimetableEntry>? Entries { get; set; }
    }
}
