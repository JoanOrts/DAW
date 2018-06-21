using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateWeb.Models
{
    public class Usuario
    {

        [ScaffoldColumn(false)]
        public int id { get; set; }

        //private string nombre;
        [Display(Prompt = "Nombre del usuario", Description = "Nombre del usuario", Name = "Nombre")]
        [Required(ErrorMessage = "Debe indicar un nombre para el usuario")]
        [StringLength(maximumLength: 50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; }

       

        //private String contrasena;
        [Display(Prompt = "Contrasena del usuario", Description = "Contrasena del usuario", Name = "Contrasena")]
        [Required(ErrorMessage = "Debe indicar una edad para el usuario")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        //private String contrasena;
        [Display(Prompt = "Imagen del usuario", Description = "Imagen del usuario", Name = "Imagen")]
        [Required(ErrorMessage = "Debe indicar una Imagen para el usuario")]
        public string Imagen { get; set; }

        //private string email;
        [Display(Prompt = "Email del usuario", Description = "Email del usuario", Name = "Email")]
        [Required(ErrorMessage = "Debe indicar una email para el usuario")]
        public string Email { get; set; }

        [Display(Prompt = "Baneado", Description = "Baneado", Name = "Baneado")]
        public bool Baneado { get; set; }

        [Display(Prompt = "Publicaciones del usuario", Description = "Publicaciones del usuario", Name = "Publicaciones")]
        public IList<PublicacionEN> publicaciones { get; set; }

        [Display(Prompt = "LineasPedido del usuario", Description = "LineasdePedido del usuario", Name = "LineasdePedido")]
        public IList<LineaPedidoEN> lineasPedido { get; set; }

        [Display(Prompt = "Donaciones del usuario", Description = "Donaciones del usuario", Name = "Donaciones")]
        public IList<DonacionEN> donaciones{ get; set; }


        [Display(Prompt = "Albumes del usuario", Description = "Albumes del usuario", Name = "Albumes")]
        public IList<AlbumEN> albumes{ get; set; }

        [Display(Prompt = "Libros del usuario", Description = "Libros del usuario", Name = "Libros")]
        public IList<LibroEN> librosCreados { get; set; }

        [Display(Prompt = "Libros comprados por el usuario", Description = "Libros comprados por el usuario", Name = "LibrosComprados")]
        public IList<LibroEN> librosComprados { get; set; }


        [Display(Prompt = "Autores seguidos del usuario", Description = "Autores seguidos del usuario", Name = "Autores seguidos")]

        public IList<AutorEN> seguidos{ get; set; }

        [Display(Prompt = "Carritos del usuario", Description = "Carritos del usuario", Name = "Carrito")]
        public IList<CarritoEN> carritos{ get; set; }

        [Display(Prompt = "Criticas del usuario", Description = "Criticas del usuario", Name = "Criticas")]
        public IList<CriticaEN> critica { get; set; }

        [Display(Prompt = "Puntuaciones del usuario", Description = "Puntuaciones del usuario", Name = "Puntuaciones")]
        public IList<PuntuacionEN> puntuaciones { get; set; }

       

        [Display(Prompt = "Cuenta administrador del usuario", Description = "Cuenta Administrador del usuario", Name = "Administrador")]
        public AdministradorEN administrador { get; set; }

        [Display(Prompt = "Cuenta autor del usuario", Description = "Cuenta autor del usuario", Name = "Administrador")]
        public AutorEN autor { get; set; }

        [Display(Prompt = "Fecha del usuario", Description = "Fecha del usuario", Name = "Fecha")]
        public DateTime? fecha { get; set; }

    }
}