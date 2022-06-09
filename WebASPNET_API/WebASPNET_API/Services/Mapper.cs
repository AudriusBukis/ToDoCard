using WebASPNET_API.Models;

namespace WebASPNET_API.Services
{
    public class Mapper : IMapper
    {
        public ToDo MapToDoDtoWithToDo(ToDoDto toDoDto)
        {
            return new ToDo(toDoDto.NameLastName,
                            toDoDto.ToDoType,
                            toDoDto.ToDoContext,
                            toDoDto.EndDateToDo,
                            toDoDto.ToDoDone);
        }

        public User MapUserDtoWithUser(UserDto userDto)
        {
            return new User(userDto.Name,
                            userDto.LastName,
                            userDto.Email);
        }
    }
}
