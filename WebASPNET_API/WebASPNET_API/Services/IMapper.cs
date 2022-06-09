using WebASPNET_API.Models;

namespace WebASPNET_API.Services
{
    public interface IMapper
    {
        public ToDo MapToDoDtoWithToDo(ToDoDto toDoDto);
        public User MapUserDtoWithUser(UserDto userDto);
    }
}
