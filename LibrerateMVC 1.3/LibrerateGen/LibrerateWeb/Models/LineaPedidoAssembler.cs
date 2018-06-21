using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CP.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;


namespace LibrerateWeb.Models
{
    public class LineaPedidoAssembler
    {

        public LineaPedido ConvertENToModelUI(LineaPedidoEN en)
        {
            if (en != null)
            {

                LineaPedido lin = new LineaPedido();

                lin.id = en.Id;
                lin.cantidad = en.Cantidad;
                lin.usuario = en.Usuario;
                lin.libro = en.Libro;
                lin.carrito = en.Carrito;

                return lin;
            }

            else
            {
                return null;
            }

        }

        public IList<LineaPedido> ConvertListENToModel(IList<LineaPedidoEN> ens)
        {
            if (ens != null && ens.Count > 0)
            {

                IList<LineaPedido> lin = new List<LineaPedido>();
                foreach (LineaPedidoEN en in ens)
                {
                    lin.Add(ConvertENToModelUI(en));
                }
                return lin;
            }
            else
            {
                return null;
            }
        }
    }
}