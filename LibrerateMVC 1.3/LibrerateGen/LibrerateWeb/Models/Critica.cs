using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibrerateWeb.Models
{
    public class Critica
    {

        [Display(Prompt = "Titulo para la critica", Description = "Titulo para la critica", Name = "Titulo ")]
        [Required(ErrorMessage = "Debe indicar un titulo para la critica")]
        [StringLength(maximumLength: 400, ErrorMessage = "El Titulo no puede tener más de 400 caracteres")]
        public string Titulo { get; set; }

        [Display(Prompt = "Contenido de la critica", Description = "Contenido de la critica", Name = "Texto ")]
        [Required(ErrorMessage = "Debe indicar contenido para la critica")]
        [StringLength(maximumLength: 8000, ErrorMessage = "La critica no puede tener más de 8000 caracteres")]
        public string Texto { get; set; }


        [ScaffoldColumn(false)]
        public int id { get; set; }
    }
}