using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CP.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;


namespace LibrerateWeb.Models
{
    public class AlbumAssembler
    {

        public Album ConvertENToModelUI(AlbumEN en)
        {
            if (en != null)
            {

                Album alb= new Album();

                alb.id = en.Id;
                alb.cantidad= en.Cantidad;
                alb.descripcion = en.Descripcion;
                alb.titulo= en.Titulo;
                alb.usuario = en.Usuario;
                alb.librosCreados = en.Libro;
                




                return alb;
            }

            else
            {
                return null;
            }

        }

        public IList<Album> ConvertListENToModel(IList<AlbumEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {

                IList<Album> alb = new List<Album>();
                foreach (AlbumEN en in ens)
                {
                    alb.Add(ConvertENToModelUI(en));
                }
                return alb;
            }
            else
            {
                return null;
            }
        }
    }
}