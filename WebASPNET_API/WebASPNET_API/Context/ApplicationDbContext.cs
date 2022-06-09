using Microsoft.EntityFrameworkCore;
using WebASPNET_API.Models;

namespace WebASPNET_API.Context
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ToDo> ToDos { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }
    }
}
