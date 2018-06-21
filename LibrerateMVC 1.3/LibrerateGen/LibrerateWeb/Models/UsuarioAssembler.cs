using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CP.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;
namespace LibrerateWeb.Models
{
    public class UsuarioAssembler
    {
        public Usuario ConvertENToModelUI(UsuarioEN en)
        {
            if (en != null)
            {
             



                //PuntuacionCEN p = new PuntuacionCEN();
                Usuario usu = new Usuario();
                
                usu.id = en.Id;
                usu.Nombre = en.Nombre;
                usu.autor = en.Autor;
                usu.administrador = en.Administrador;
                usu.publicaciones = en.Publicacion;
                usu.puntuaciones = en.Puntuacion;
                usu.seguidos = en.Autor_0;
                usu.Imagen = en.Imagen;
                usu.Contrasena = en.Contrasena;
                usu.Email = en.Email;
                usu.Baneado = en.Baneado;
                usu.albumes = en.Album;
                usu.carritos = en.Carrito;
                usu.critica = en.Critica;
                usu.donaciones = en.Donacion;
                usu.librosComprados = en.Libro;
                usu.librosCreados = en.Libro_0;
                usu.fecha = en.Fecha;


                return usu;
            }

            else
            {
                return null;
            }

        }

        public IList<Usuario> ConvertListENToModel(IList<UsuarioEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {

                IList<Usuario> usu = new List<Usuario>();
                foreach (UsuarioEN en in ens)
                {
                    usu.Add(ConvertENToModelUI(en));
                }
                return usu;
            }
            else
            {
                return null;
            }
        }
    }
}