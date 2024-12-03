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
        [HttpGet]
        [Route("{id}")]
        public ActionResult<Participant> Get(int id)
        {
            var participant = _participantRepository.GetParticipant(id);
            if (participant == null)
            {
                return NotFound();
            }
            return Ok(participant);
        }
        [HttpPost]
        public ActionResult Post([FromBody] Participant participant)
        {
            _participantRepository.CreateParticipant(participant);
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPut]
        public ActionResult Put([FromBody] Participant participant)
        {
            _participantRepository.UpdateParticipant(participant);
            return Ok();
        }
        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            _participantRepository.DeleteParticipant(id);
            return Ok();
        }

    }
}
