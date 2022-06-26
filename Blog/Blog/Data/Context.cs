using Microsoft.EntityFrameworkCore;

namespace Blog.Data
{
    public class Context : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)   
        {

        }
    }
}
