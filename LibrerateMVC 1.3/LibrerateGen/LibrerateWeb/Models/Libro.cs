using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibrerateWeb.Models
{
    public class Libro
    {

        [Display(Prompt = "Nombre del libro", Description = "Nombre del libro", Name = "Nombre ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el libro")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Nombre { get; set; }

        [Display(Prompt = "Precio del libro", Description = "Precio del libro", Name = "Precio ")]
        [Required(ErrorMessage = "Debe indicar un precio para el libro")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 1000, ErrorMessage = "El precio debe ser mayor que cero y menor de 1000")]
        public double Precio { get; set; }

        [ScaffoldColumn(false)]
        public Nullable<DateTime> Fecha { get; set; }

        [Display(Prompt = "Descripción del libro", Description = "Descripción del libro", Name = "Descripción ")]
        [Required(ErrorMessage = "Debe indicar una descripción para el libro")]
        [StringLength(maximumLength: 600, ErrorMessage = "La descripción no puede tener más de 600 caracteres")]
        public string Descripcion { get; set; }

        [Display(Prompt = "Potada del libro", Description = "Portada del libro", Name = "Portada ")]
        [Required(ErrorMessage = "Debe indicar una portada para el libro")]
        public string Portada { get; set; }

        [ScaffoldColumn(false)]
        public int Numpag { get; set; }

        [ScaffoldColumn(false)]
        public string Idioma { get; set; }

        [ScaffoldColumn(false)]
        public int Media { get; set; }

        [ScaffoldColumn(false)]
        public int Cantidadvendida { get; set; }


        public LibrerateGenNHibernate.Enumerated.Librerate.GeneroEnum Genero { get; set; }

        [ScaffoldColumn(false)]
        public int id { get; set; }
    }
}