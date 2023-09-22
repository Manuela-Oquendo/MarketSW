using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market.Shared.Entities
{
    public class Country
    {

        public int Id { get; set; } //no recuerdo que es el {get, set ; ser la llave primaria al poner Id ; lo toma como la llave primaria, internamente le pone el nombre de la tabla a la izquierda del Id


        //Las reestricciones son para evitar que en la base de datos guardados de cualquier manera, o que permitan meter cualquier cosa en los campos
        [Display (Name="Pais") ] //etiqueta que restringe el campo a que lo llenen como quieran ; como un titulo al campo
        [MaxLength (100,ErrorMessage = "El campo {0} debe contener únicamente 100 caracteres")] //etiqueta maximo caraceteres que podran digitar^; el {0} hace referencia al campo 0 que es Name, es como sumarle al mensaje la variable a la que hago referencia
        [Required(ErrorMessage = "El campo {0} es obligatorio")] //LONGITUD: etiqueta que hace el campo obligatorio
        public string? Name { get; set; } // el ? hace un salto de nulos, los ignora

    }
}
