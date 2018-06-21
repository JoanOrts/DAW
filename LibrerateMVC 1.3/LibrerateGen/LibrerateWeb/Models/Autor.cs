using LibrerateGenNHibernate.EN.Librerate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibrerateWeb.Models
{
    public class Autor
    {


        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Display(Prompt = "Autor", Description = "Nombre del autor", Name = "Nombre ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el autor")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Nombre { get; set; }



        [Display(Prompt = "Ganancias del autor", Description = "Dinero que ha ganado el autor", Name = "Ganancias ")]
        [Required(ErrorMessage = "Debe indicar un número de ganancias para el autor")]
        [DataType(DataType.Currency, ErrorMessage = "La ganancia debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "La ganancia debe ser mayor que cero y menor de 10000")]
        public float Ganancias { get; set; }

        [Display(Prompt = "Fecha de nacimiento", Description = "Fecha de nacimiento del autor", Name = "Fecha ")]
        public DateTime? Fecha { get; set; }

        [Display(Prompt = "Correo del autor", Description = "Correo que utiliza el autor", Name = "Correo ")]
        [Required(ErrorMessage = "Debe indicar un correo para el autor")]
        [StringLength(maximumLength: 200, ErrorMessage = "El correo no puede tener más de 200 caracteres")]
        public string Email { get; set; }

        [ScaffoldColumn(false)]
        public UsuarioEN Usuario { get; set; }

        /*
        [ScaffoldColumn(false)]
        public IList<Donacion> Donacion { get; set; }
         */

        [Display(Prompt = "Donaciones", Description = "Donaciones de otros usuarios", Name = "Donacion ")]
        public IList<DonacionEN> Donacion;

        [Display(Prompt = "Seguidores", Description = "Usuarios que le siguen", Name = "Seguidores ")]
        public IList<UsuarioEN> seguidores { get; set; }

        
    }
}