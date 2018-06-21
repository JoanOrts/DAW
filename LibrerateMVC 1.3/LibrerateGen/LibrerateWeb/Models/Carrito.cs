using LibrerateGenNHibernate.EN.Librerate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LibrerateWeb.Models
{
    public class Carrito
    {
        [Display(Prompt = "Lineas de pedido", Description = "Lineas de pedido del carrito", Name = "Lineas de pedido ")]
        public IList<LineaPedidoEN> LineaPedido;


        [ScaffoldColumn(false)]
        public int id { get; set; }

        [Display(Prompt = "Precio del carrito", Description = "Precio total del carrito", Name = "Precio ")]
        [Required(ErrorMessage = "El carrito debe tener un precio")]
        [DataType(DataType.Currency, ErrorMessage = "El precio debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El precio debe ser mayor que cero y menor de 10000")]
        public float Precio { get; set; }



        [Display(Prompt = "Número de artículos", Description = "Número total de artículos que hay en el carrito", Name = "Numerador ")]
        [Required(ErrorMessage = "El carrito debe un número de artículos")]
        [DataType(DataType.Currency, ErrorMessage = "El numerador debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El numerador debe ser mayor que cero y menor de 10000")]
        public int Numerador { get; set; }

        [Display(Prompt = "Número de artículos", Description = "Número total de artículos que hay en el carrito", Name = "Numerador ")]
        [Required(ErrorMessage = "El carrito debe un número de artículos")]
        [DataType(DataType.Currency, ErrorMessage = "El numerador debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 10000, ErrorMessage = "El numerador debe ser mayor que cero y menor de 10000")]
        public bool Estado { get; set; }

        [Display(Prompt = "Nombre de usuario", Description = "Nombre del usuario al que pertenece el carrito", Name = "Usuario ")]
        [Required(ErrorMessage = "El carrito debe un usuario asignado")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre del usuario no puede tener más de 200 caracteres")]
        public string Usuario { get; set; }

        [ScaffoldColumn(false)]
        public int IdUsuario { get; set; }
    }
}