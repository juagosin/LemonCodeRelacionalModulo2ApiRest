namespace Laboratorio.Models
{
    public class Participant : Entity
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required ICollection<Event> Events { get; set; }

        public Participant(int id, string name, string lastName, string email, ICollection<Event> events)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Email = email;
            Events = events;
            EnsureStateIsValid();
        }
        public void UpdateName(string name)
        {
            Name = name;
            EnsureStateIsValid();
        }
        public void UpdateLastName(string lastName)
        {
            LastName = lastName;
            EnsureStateIsValid();
        }
        public void UpdateEmail(string email)
        {
            Email = email;
            EnsureStateIsValid();
        }

        protected override void EnsureStateIsValid()
        {
            if (string.IsNullOrWhiteSpace(Name) || Name.Length > 100)
            {
                AddValidationError("Name should contains between 1 and 100 characters, and cannot be empty.");
            }
            if (string.IsNullOrWhiteSpace(LastName) || LastName.Length > 100)
            {
                AddValidationError("LastName should contains between 1 and 100 characters, and cannot be empty.");
            }
            // TODO validate email format
            if (string.IsNullOrWhiteSpace(Email) || Email.Length > 100)
            {                
                AddValidationError("Email should contains between 1 and 100 characters, and cannot be empty.");
            }
            Validate();
        }
    }
}
