using CorporateQnA.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CorporateQnA.Data.Context
{
    public class CorporateQnADbContext:DbContext
    {
        public CorporateQnADbContext(DbContextOptions<CorporateQnADbContext> options) : base(options) { }

        public DbSet<AuthUser> UserDetails { get; set; }
        public DbSet<DbQuestion> Questions { get; set; }
        public DbSet<DbCategory> Categories { get; set; }
    }
}
