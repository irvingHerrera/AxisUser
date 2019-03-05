using AxisUser.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AxisUser.Data.Context
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

    }
}
