using Microsoft.EntityFrameworkCore;
using Pokemon.Models;

namespace Pokemon.Data
{
    public class CiudadContext :DbContext
    {
        public DbSet<Ciudad> Ciudades { get; set; }

        public CiudadContext(DbContextOptions dco) : base(dco) {

        }
    }
}