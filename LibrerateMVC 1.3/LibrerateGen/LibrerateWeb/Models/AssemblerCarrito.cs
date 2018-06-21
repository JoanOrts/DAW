using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;

namespace LibrerateWeb.Models
{
    public class AssemblerCarrito
    {
        public Carrito ConvertENToModelUI(CarritoEN en)
        {
            Carrito car = new Carrito();
            car.id = en.Id;
            car.Numerador = en.Numerador;
            car.Precio = en.Precio;
            car.Estado = en.Estado;
            car.LineaPedido = en.LineaPedido;
            /*
             * Así es como dice el profesor que se hacen las relaciones a muchos en el assembler, luego se tiene que hacer un foreach para obtener cada modelo
            AssemblerLineaPedido ass = new AssemblerLineaPedido();
            car.LineaPedido = ass.ConvertListENToModel(en.LineaPedido);
            */

            car.Usuario = en.Usuario.Nombre;
            car.IdUsuario = en.Usuario.Id;

            return car;


        }
        public IList<Carrito> ConvertListENToModel (IList<CarritoEN> ens){
            IList<Carrito> arts = new List<Carrito>();
            foreach (CarritoEN en in ens)
            {
                arts.Add(ConvertENToModelUI(en));
            }
            return arts;
        }
        
    }
}