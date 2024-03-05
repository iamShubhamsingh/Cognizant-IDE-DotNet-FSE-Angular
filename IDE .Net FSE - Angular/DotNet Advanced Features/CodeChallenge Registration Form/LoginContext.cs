using Microsoft.EntityFrameworkCore;

namespace ASPNET6_Template.Models
{
    public class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) : base(options)
        {
        }

        //Implement your code here
        
        public DbSet<Registration> Registrations { get; set; }
    }
}
