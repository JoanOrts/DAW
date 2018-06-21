using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateWeb.Models
{
    public class AssemblerAutor
    {
        public Autor ConvertENToModelUI(AutorEN en)
        {
            Autor art = new Autor();
            art.id = en.Id;
            art.Nombre = en.Nombre;
            art.Usuario = en.Usuario;
            art.Ganancias = en.Ganancias;
            art.Fecha = en.Fecha;

            art.Email = en.Email;
            /*
            AssemblerDonacion ass = new AssemblerDonacion();
            art.Donacion = ass.ConvertListENToModel(en.Donacion);
             */
            art.Donacion = en.Donacion;
            art.seguidores = en.Usuario_0;

            return art;


        }
        public IList<Autor> ConvertListENToModel (IList<AutorEN> ens){
            IList<Autor> arts = new List<Autor>();
            foreach (AutorEN en in ens)
            {
                arts.Add(ConvertENToModelUI(en));
            }
            return arts;
        }
        
    }
}