using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Shared.Entities
{
    public class State
    {

        public int Id { get; set; } //ID llave primaria
        [Required] //requerido
        [Display(Name = "Estado/Departamento")] //Como se va a llamar ese atributo
        [MaxLength(100)] //Para que no se pase de una longitud

        public string Name { get; set; }
        public Country Country { get; set; } //Para que erede todas las propiedades
        public int CountryId  { get; set; } //Llave foranea de Country, para poder acceder a Country
    }
}
