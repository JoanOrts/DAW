using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateWeb.Models
{
    public class Publicacion
    {


        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private string nombre;
        [Display(Prompt = "Nombre de la publicacion", Description = "Nombre de la publicacion", Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre para la publicacion")]
        [StringLength(maximumLength: 50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; }


        [Display(Prompt = "Numero Paginas de la publicacion", Description = "Paginas de la publicacion", Name = "Paginas")]
        [Required(ErrorMessage = "Debe indicar un numero de paginas")]
        public int NumPag { get; set; }


        [Display(Prompt = "Usuario", Description = "Usuario", Name = "Usuario")]
        public UsuarioEN usuario { get; set; }

        [Display(Prompt = "Libro de la publicacion", Description = "Libro de la publicacion", Name = "Libro")]
        public LibroEN libro { get; set; }

    }
}