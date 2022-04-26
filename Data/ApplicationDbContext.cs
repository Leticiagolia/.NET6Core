using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulltyBookWeb.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
