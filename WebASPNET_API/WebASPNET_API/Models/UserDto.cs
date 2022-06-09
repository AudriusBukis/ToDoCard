namespace WebASPNET_API.Models
{
    public class UserDto
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"User {Name} {LastName}\n   Email: {Email}";
        }
    }
    
}
