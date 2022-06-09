using System.Collections.Generic;
using WebASPNET_API.Models;

namespace WebASPNET_API.Repository
{
    public interface IToDoRepository
    {
        public IEnumerable<ToDo> GetAllToDoCards();
        public ToDo AddNewToDoCard(ToDoDto toDo);
        public ToDo UpdateToDoCard(ToDoDto toDo, int id);
        public ToDo DeleteToDoCard(int id);

    }
}
