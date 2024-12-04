using Laboratorio.Contracts;
using Laboratorio.DataAccess;
using Laboratorio.Models;

namespace Laboratorio.Repositories
{
    public class EventRepository : IEventRepository
    {
        private readonly AplicationDbContext _context;

        public EventRepository(AplicationDbContext context)
        {
            _context = context;
        }
        public void CreateEvent(Event evento)
        {
            _context.Events.Add(evento);
            _context.SaveChanges();
        }

        public void DeleteEvent(int id)
        {
            var evento = _context.Events.FirstOrDefault(p => p.Id == id);
            if (evento != null)
            {
                _context.Events.Remove(evento);
                _context.SaveChanges();
            }
        }

        public Event GetEvent(int id)
        {
            return _context.Events.FirstOrDefault(p => p.Id == id);
        }

        public List<Event> GetEvents()
        {
            return _context.Events.ToList();
        }

        public void UpdateEvent(Event evento)
        {
            _context.Events.Update(evento);
            _context.SaveChanges();
        }
    }
}
