using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateWeb.Models
{
    public class Donacion
    {

        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Display(Prompt = "Cantidad de la donacion", Description = "Cantidad de la donacion", Name = "Cantidad")]
        [Required(ErrorMessage = "Debe indicar una cantidad para la donacion")]
        [DataType(DataType.Currency, ErrorMessage = "La donacion debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "La donacion debe ser mayor que cero y menor de 10000")]
        public float cantidad { get; set; }

        [Display(Prompt = "Usuario", Description = "Usuario", Name = "Usuario")]
        public UsuarioEN usuario { get; set; }

        [Display(Prompt = "Autor", Description = "Autor", Name = "Autor")]
        public AutorEN autor { get; set; }

    }
}