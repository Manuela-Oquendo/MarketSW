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
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }


        //Tampoco entendi nada de lo que hizo aqui ni que es 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); //MOdelBuilder: permite mandar cosas para la base de datos, definicion predeterminada

            //Instrucción para crear el indice al nombre de country, esto no permite agregar valores repetidos y ordena alfabeticamente.

            modelBuilder.Entity<Country>().HasIndex(c=>c.Name).IsUnique(); //Has: expresion de tener, Name: se le especifica que el index se tome por el nombre

        }
    }


}
