namespace WebASPNET_API.Models
{
    public class ToDoDto
    {
        public string NameLastName { get; set; }
        public string ToDoType { get; set; }
        public string ToDoContext { get; set; }
        public string EndDateToDo { get; set; }
        public string ToDoDone { get; set; }

        public override string ToString()
        {
           return $"To Do Card\n Type: {ToDoType}\n Context: {ToDoContext}\n End Date: {EndDateToDo}\n Done status: {ToDoDone}";
        }
    }

}
