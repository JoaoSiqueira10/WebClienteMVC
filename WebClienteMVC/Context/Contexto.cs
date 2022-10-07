using Microsoft.EntityFrameworkCore;
using WebClienteMVC.Models;

namespace WebClienteMVC.Context
{
    public class Contexto : DbContext
    {
        
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }

        public DbSet<ClienteModel> Cliente { get; set; }
    }
}
