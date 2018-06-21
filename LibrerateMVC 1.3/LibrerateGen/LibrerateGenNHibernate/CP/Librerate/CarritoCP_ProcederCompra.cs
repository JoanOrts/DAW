
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;



/*PROTECTED REGION ID(usingLibrerateGenNHibernate.CP.Librerate_Carrito_procederCompra) ENABLED START*/
//  references to other libraries
using System.Collections.Generic;
/*PROTECTED REGION END*/

namespace LibrerateGenNHibernate.CP.Librerate
{
public partial class CarritoCP : BasicCP
{
public void ProcederCompra (int p_oid)
{
        /*PROTECTED REGION ID(LibrerateGenNHibernate.CP.Librerate_Carrito_procederCompra) ENABLED START*/

        ICarritoCAD carritoCAD = null;
        CarritoCEN carritoCEN = null;
        UsuarioCAD usuarioCAD = null;
        UsuarioCEN usuarioCEN = null;
        LibroCAD libroCAD = null;
        LibroCEN libroCEN = null;

        try
        {
                SessionInitializeTransaction ();
                carritoCAD = new CarritoCAD (session);
                carritoCEN = new CarritoCEN (carritoCAD);
                usuarioCAD = new UsuarioCAD (session);
                usuarioCEN = new UsuarioCEN (usuarioCAD);
                libroCAD = new LibroCAD (session);
                libroCEN = new LibroCEN (libroCAD);




                // Write here your custom transaction ...

                CarritoEN carritoEN = carritoCAD.ReadOIDDefault (p_oid);
                UsuarioEN usuarioEN = usuarioCAD.ReadOIDDefault (carritoEN.Usuario.Id);
                LibroEN libroEN = null;


                foreach (LineaPedidoEN linea in carritoEN.LineaPedido) {
                        libroEN = linea.Libro;
                        usuarioCEN.AnyadirLibro (usuarioEN.Id, new List<int>() {
                                        libroEN.Id
                                });
                }

                carritoEN.Estado = true;
                carritoCAD.Modify (carritoEN);



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
