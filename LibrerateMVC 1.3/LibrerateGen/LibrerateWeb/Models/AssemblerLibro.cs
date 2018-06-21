using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateWeb.Models
{
    public class AssemblerLibro
    {
        public Libro ConvertENToModelUI(LibroEN en)
        {
            Libro lbr = new Libro();

            lbr.id = en.Id;
            lbr.Nombre = en.Nombre;
            lbr.Precio = en.Precio;
            lbr.Fecha = en.Fecha;
            lbr.Descripcion = en.Descripcion;
            lbr.Portada = en.Portada;
            lbr.Genero = en.Genero;
            lbr.Numpag = en.Numpag;
            lbr.Idioma = en.Idioma;
            lbr.Media = en.Media;
            lbr.Cantidadvendida = en.Cantidadvendida;

            return lbr;


        }
        public IList<Libro> ConvertListENToModel(IList<LibroEN> ens)
        {
            IList<Libro> lbrs = new List<Libro>();
            foreach (LibroEN en in ens)
            {
                lbrs.Add(ConvertENToModelUI(en));
            }
            return lbrs;
        }
        
    }
}