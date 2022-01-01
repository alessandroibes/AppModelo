using DevIO.AppModelo.Site.Models;
using Microsoft.EntityFrameworkCore;

namespace DevIO.AppModelo.Site.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}