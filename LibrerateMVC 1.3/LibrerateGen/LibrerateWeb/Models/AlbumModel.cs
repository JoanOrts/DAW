using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateWeb.Models
{
    public class Album
    {


        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private string nombre;
        [Display(Prompt = "Titulo del album", Description = "Titulo del album", Name = "titulo del album")]
        [Required(ErrorMessage = "Debe indicar un titulo para el album")]
        [StringLength(maximumLength: 50, ErrorMessage = "El titulo no puede tener más de 50 caracteres")]
        public string titulo { get; set; }

        [Display(Prompt = "Descripcion del album", Description = "Descripcion del album", Name = "Descripcion del album")]
        [StringLength(maximumLength: 50, ErrorMessage = "El titulo no puede tener más de 50 caracteres")]
        public string descripcion { get; set; }


        [Display(Prompt = "Numero de libros del album", Description = "Libros del album", Name = "CantidadLibros")]
        
        public int cantidad { get; set; }


        [Display(Prompt = "Usuario", Description = "Usuario", Name = "Usuario")]
        public UsuarioEN usuario { get; set; }

        [Display(Prompt = "Libros del album", Description = "Libros del album", Name = "Libros")]
        public IList<LibroEN> librosCreados { get; set; }
    }
}