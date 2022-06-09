using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebASPNET_API.Models;
using WebASPNET_API.Repository;

namespace WebASPNET_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("GetAllUsers")]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            return Ok(_userRepository.GetAllUsers());
        }
        [HttpPost("AddNewUser")]
        public ActionResult<User> AddNewUser([FromBody] UserDto userDto)
        {
            var user = _userRepository.AddNewUser(userDto);
            if(user == null) return NotFound();
            return Ok(user);
        }
        [HttpPut("UpdateUser/{id}")]
        public ActionResult<User> UpdateUser([FromBody] UserDto userDto, int id)
        {
            var user = _userRepository.UpdateUser(userDto, id);
            if (user == null) return NotFound();
            return Ok(user);
        }
        [HttpDelete("DelateUser/{id}")]
        public ActionResult<User> DelateUser([FromRoute] int id)
        {
            var user = _userRepository.DeleteUser(id);
            if (user == null) return NotFound();
            return Ok(user);
        }
    }
}
