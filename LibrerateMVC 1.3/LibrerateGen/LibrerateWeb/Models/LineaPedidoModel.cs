using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateWeb.Models
{
    public class LineaPedido
    {


        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Display(Prompt = "Cantidad de libros del mismo tipo", Description = "Número total de libros del mismo tipo en la línea de pedido", Name = "Cantidad")]
        [Required(ErrorMessage = "La línea de pedido debe tener una cantidad de libros del mismo tipo")]
        [DataType(DataType.Currency, ErrorMessage = "La cantidad debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "La cantidad debe ser mayor que cero y menor de 10000")]
        public int cantidad { get; set; }


        public UsuarioEN usuario { get; set; }

        public LibroEN libro { get; set; }

        public CarritoEN carrito { get; set; }
    }
}