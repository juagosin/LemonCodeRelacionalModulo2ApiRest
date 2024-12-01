namespace Laboratorio.Models
{
    public class Event : Entity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public required string Description { get; set; }
        public required ICollection<Participant> Participants { get; set; }

        public Event(int id, string name, DateTime stardate, DateTime enddate, string description, ICollection<Participant> participants)
        {
            Id = id;
            Name = name;
            StartDate = stardate;
            EndDate = enddate;
            Description = description;            
            Participants = participants;
            EnsureStateIsValid();
        }

        public void UpdateName(string name)
        {
            Name = name;
            EnsureStateIsValid();
        }

        protected override void EnsureStateIsValid()
        {
            if (string.IsNullOrWhiteSpace(Name) || Name.Length > 100)
            {
                AddValidationError("Name should contains between 1 and 100 characters, and cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(Description) || Description.Length > 100)
            {
                AddValidationError("Description should contains between 10 and 500 characters, and cannot be empty.");
            }
            // TODO validate Startdate

            Validate();
        }

    }
}
