namespace Laboratorio.Models
{
    public class Event
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public ICollection<Participant>? Participants { get; set; }
    }
}
