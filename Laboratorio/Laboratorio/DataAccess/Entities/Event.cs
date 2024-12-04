using Laboratorio.Models;
using Laboratorio.Models.Abstractions;

namespace Laboratorio.DataAccess.Entities
{
    public class Event : IIdentifiable
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public required string Description { get; set; }

        public required ICollection<Participant> Participants { get; set; }
    }
}
