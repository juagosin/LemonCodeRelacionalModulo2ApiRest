using Laboratorio.Contracts;
using Laboratorio.Models;
using Laboratorio.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventRepository _eventRepository;
        public EventController(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }
        [HttpGet]
        public ActionResult<List<Event>> Get()
        {
            var events = _eventRepository.GetEvents();
            return Ok(events);
        }
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Event> Get(int id)
        {
            var evento = _eventRepository.GetEvent(id);
            if (evento == null)
            {
                return NotFound();
            }
            return Ok(evento);
        }
        [HttpPost]
        public ActionResult Post([FromBody] Event evento)
        {
            _eventRepository.CreateEvent(evento);
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPut]
        public ActionResult Put([FromBody] Event evento)
        {
            _eventRepository.UpdateEvent(evento);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            _eventRepository.DeleteEvent(id);
            return Ok();
        }
    }
}
