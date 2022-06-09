using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebASPNET_API.Models;
using WebASPNET_API.Repository;

namespace WebASPNET_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoCardsController : ControllerBase
    {
        private readonly IToDoRepository _toDoRepository;
        public ToDoCardsController(IToDoRepository toDoRepository)
        {
            _toDoRepository = toDoRepository;
        }
        [HttpGet("GetAllToDoCards")]
        public ActionResult<IEnumerable<ToDo>> GetAllToDoCards()
        {
            return Ok(_toDoRepository.GetAllToDoCards());
        }
        [HttpPost("AddNewToDoCard")]
        public ActionResult<ToDo> AddNewToDoCard([FromBody] ToDoDto toDoDto)
        {
            var toDo = _toDoRepository.AddNewToDoCard(toDoDto);
            if (toDo == null) return NotFound();
            return Ok(toDo);
        }
        [HttpPut("UpdateToDoCard/{id}")]
        public ActionResult<ToDo> UpdateToDoCard([FromBody] ToDoDto toDoDto, int id)
        {
            var toDo = _toDoRepository.UpdateToDoCard(toDoDto, id);
            if (toDo == null) return NotFound();
            return Ok(toDo); 
        }
        [HttpDelete("DelateToDoCard/{id}")]
        public ActionResult<ToDo> DelateToDoCard([FromRoute] int id)
        {
            var toDo = _toDoRepository.DeleteToDoCard(id);
            if (toDo == null) return NotFound();
            return Ok(toDo);
        }
    }
}
