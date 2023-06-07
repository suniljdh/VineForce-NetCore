using Crud_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_Api
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<Country> country { get; set; }
        public DbSet<States> states { get; set; }
        public DbSet<MessageModel> message { get; set; }

    }
}
