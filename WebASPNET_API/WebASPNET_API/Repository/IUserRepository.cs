using System.Collections.Generic;
using WebASPNET_API.Models;

namespace WebASPNET_API.Repository
{
    public interface IUserRepository 
    {
        public IEnumerable<User> GetAllUsers();
        public User AddNewUser(UserDto userDto);
        public User UpdateUser(UserDto userDto, int id);
        public User DeleteUser(int id);
    }
}
