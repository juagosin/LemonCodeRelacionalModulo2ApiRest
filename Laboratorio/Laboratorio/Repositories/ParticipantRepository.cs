using Laboratorio.Contracts;
using Laboratorio.DataAccess;
using Laboratorio.Models;
using Microsoft.EntityFrameworkCore;

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
            _context.Participants.Add(participant);
            _context.SaveChanges();
        }

        public void DeleteParticipant(int id)
        {
            var participant = _context.Participants.FirstOrDefault(p => p.Id == id);
            if (participant != null)
            {
                _context.Participants.Remove(participant);
                _context.SaveChanges();
            }
        }

        public Participant GetParticipant(int id)
        {
            return _context.Participants.FirstOrDefault(p => p.Id == id);
        }

        public List<Participant> GetParticipants()
        {
            return _context.Participants.ToList();
        }

        public void UpdateParticipant(Participant participant)
        {
            _context.Participants.Update(participant);
            _context.SaveChanges();
        }


    }


}
