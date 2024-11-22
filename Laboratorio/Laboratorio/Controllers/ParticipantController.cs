using Laboratorio.Contracts;
using Laboratorio.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipantController : ControllerBase
    {
        private readonly IParticipantRepository _participantRepository;
        public ParticipantController(IParticipantRepository participantRepository)
        {
            _participantRepository = participantRepository;
        }

        [HttpGet]
        public ActionResult<List<Participant>> Get()
        {
            var participants = _participantRepository.GetParticipants();
            return Ok(participants);
        }
    }
}
