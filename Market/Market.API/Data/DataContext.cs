using Market.Shared.Entities;
using Microsoft.EntityFrameworkCore;



namespace Market.API.Data
{
    public class DataContext:DbContext //los dos puntos (:) indican que la clase DataContext heredara de DbContext
    {

        //utilizar las propiedades y opciones de DbContext (no entendi que hizo o para que es eso)
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        


        }

        //Tampoco entendi nada de lo que hizo aqui ni que es 
        public DbSet<Country>Countries { get; set; }


        //Tampoco entendi nada de lo que hizo aqui ni que es 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }


}
