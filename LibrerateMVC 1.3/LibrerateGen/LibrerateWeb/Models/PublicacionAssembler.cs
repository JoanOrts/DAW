using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CP.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;

namespace LibrerateWeb.Models
{
    public class PublicacionAssembler
    {
        public Publicacion ConvertENToModelUI(PublicacionEN en)
        {
            if (en != null)
            {

                Publicacion pub = new Publicacion();

                pub.id = en.Id;
                pub.libro = en.Libro;
                pub.Nombre = en.Nombre;
                pub.NumPag = en.NumPag;
                pub.usuario = en.Usuario;
               



                return pub;
            }

            else
            {
                return null;
            }

        }

        public IList<Publicacion> ConvertListENToModel(IList<PublicacionEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {

                IList<Publicacion> pub = new List<Publicacion>();
                foreach (PublicacionEN en in ens)
                {
                    pub.Add(ConvertENToModelUI(en));
                }
                return pub;
            }
            else
            {
                return null;
            }
        }

    }
}