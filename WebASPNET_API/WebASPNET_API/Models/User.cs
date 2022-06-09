namespace WebASPNET_API.Models
{
    public class User
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public User(string name, string lastName, string email)
        {
            Name = name;
            LastName = lastName;
            Email = email;
        }
        public override string ToString()
        {
            return $"User {Name} {LastName}\n   Email: {Email}";
        }
    }
}
