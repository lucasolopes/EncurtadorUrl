using EncurtadorUrl.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EncurtadorUrl.Data.Context
{
    public class EncurtadorContext : DbContext
    {
        public EncurtadorContext(DbContextOptions<EncurtadorContext> options) : base(options) { }

        public DbSet<Encurtador> Encurtadors { get; set; }
    }
}
