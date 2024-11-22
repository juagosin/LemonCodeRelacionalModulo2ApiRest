using Laboratorio.Models;

namespace Laboratorio.Contracts
{
    public interface IEventRepository
    {
        List<Event> GetEvents();
        Event GetEvent(int id);
        void CreateEvent(Event evento);
        void UpdateEvent(Event evento);
        void DeleteEvent(int id);

    }
}
