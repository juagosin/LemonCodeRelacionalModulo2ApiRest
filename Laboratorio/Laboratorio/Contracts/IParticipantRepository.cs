using Laboratorio.Models;

namespace Laboratorio.Contracts
{
    public interface IParticipantRepository
    {
        List<Participant> GetParticipants();
        Participant GetParticipant(int id);
        void CreateParticipant(Participant participant);
        void UpdateParticipant(Participant participant);
        void DeleteParticipant(int id);

    }
}
