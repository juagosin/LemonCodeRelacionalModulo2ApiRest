using Laboratorio.Contracts;
using Laboratorio.DataAccess;
using Laboratorio.Models;

namespace Laboratorio.Repositories
{
    public class ParticipantRepository : IParticipantRepository
    {
        private readonly AplicationDbContext _context;

        public ParticipantRepository(AplicationDbContext context)
        {
            _context = context;
        }

        public void CreateParticipant(Participant participant)
        {
            throw new NotImplementedException();
        }

        public void DeleteParticipant(int id)
        {
            throw new NotImplementedException();
        }

        public Participant GetParticipant(int id)
        {
            throw new NotImplementedException();
        }

        public List<Participant> GetParticipants()
        {
            return _context.Participants.ToList();
        }

        public void UpdateParticipant(Participant participant)
        {
            throw new NotImplementedException();
        }


    }


}
