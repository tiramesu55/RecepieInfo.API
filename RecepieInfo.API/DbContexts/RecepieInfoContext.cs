using Microsoft.EntityFrameworkCore;
using RecepieInfo.API.Entities;

namespace RecepieInfo.API.DbContexts
{
    public class RecepieInfoContext:DbContext
    {
        public DbSet<Recepie> Recepies { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;

        public RecepieInfoContext( DbContextOptions<RecepieInfoContext> options) : base (options)
        {

        }
    }
}
