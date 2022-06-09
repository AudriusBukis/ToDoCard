namespace WebASPNET_API.Models
{
    public class ToDo
    {
        public int Id { get; private set; }
        public string NameLastName { get; set; }
        public string ToDoType { get; set; }
        public string ToDoContext { get; set; }
        public string EndDateToDo { get; set; }
        public string ToDoDone { get; set; }

        public override string ToString()
        {
            return $"To Do Card\n Type: {ToDoType}\n Context: {ToDoContext}\n End Date: {EndDateToDo}\n Done status: {ToDoDone}";
        }
        public ToDo(string nameLastName, string toDoType, string toDoContext, string endDateToDo, string toDoDone)
        { 
            NameLastName = nameLastName;
            ToDoType = toDoType;
            ToDoContext = toDoContext;
            EndDateToDo = endDateToDo;
            ToDoDone = toDoDone;
        }
    }
}
