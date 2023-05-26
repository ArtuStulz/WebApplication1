using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models; 

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {


        }

        public DbSet<CDipartimento> Dipartimento { get; set; }
        public DbSet<Persona> Persona { get; set; }

    }
}
