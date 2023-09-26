using Market.API.Data;
using Market.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Market.API.Controllers
{
    [ApiController]
    [Route("/api/countries")]
    public class CountriesController : ControllerBase
    {
        private readonly DataContext _context;

        public CountriesController(DataContext context)
        {
            _context = context;
        }

        //Https protocolo se seguridad de las paginas


        //Lista de paises
        [HttpGet]  //protocolo http (buscar)
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Countries.ToListAsync());
        }


        //Get por parametro -- id
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);

            if (country == null)
            {
                return NotFound(); //404


            }
            return Ok(country);   //200
        }




        //insertar un registro, Post -> insert
        [HttpPost]
        public async Task<ActionResult> Post(Country country)
        {
            _context.Add(country); //agrega un nuevo pais
            await _context.SaveChangesAsync(); //esta intruccion Save... me salva o me guarda lo que se ingrese
            return Ok(country); //200 si guarda el pais seria un 200, muestra un resumen de lo que se guardo
        }




        //actualizacion de tablas
        [HttpPut]
        public async Task<ActionResult> Put(Country country)
        {
            _context.Update(country); //aqui ya no estamos agregando sino actualizando los registros
            await _context.SaveChangesAsync(); //guarda los cambios en la tabla
            return Ok(country); //200 -> muestra un resumen de lo que se actualizo
        }



        //delete -> borrado de datos
        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(int id)
        {
            var filaafectada = await _context.Countries
                .Where(c => c.Id == id)
                .ExecuteDeleteAsync();

            if(filaafectada == 0) //aqui se le esta preguntando si no existe el registro
            {

                return NotFound(); //404


            }
            return NoContent();//204 -> borre pero no me muestre que borro, NO MUESTRA UN RESUMEN, ningun contenido

        }




    }
}
