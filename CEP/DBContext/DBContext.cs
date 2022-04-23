using CEP.Models;
using Microsoft.EntityFrameworkCore;

namespace CEP.Context
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }
        public virtual DbSet<Cep> Cep { get; set; } = null!;

    }
}
