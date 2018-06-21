
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.CAD.Librerate;
using LibrerateGenNHibernate.CEN.Librerate;



/*PROTECTED REGION ID(usingLibrerateGenNHibernate.CP.Librerate_Carrito_calcularPrecio) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace LibrerateGenNHibernate.CP.Librerate
{
public partial class CarritoCP : BasicCP
{
public void CalcularPrecio (int p_oid)
{
        /*PROTECTED REGION ID(LibrerateGenNHibernate.CP.Librerate_Carrito_calcularPrecio) ENABLED START*/

        ICarritoCAD carritoCAD = null;
        CarritoCEN carritoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                carritoCAD = new CarritoCAD (session);
                carritoCEN = new  CarritoCEN (carritoCAD);



                // Write here your custom transaction ...

                CarritoEN en = carritoCAD.ReadOIDDefault (p_oid);

                int cont = 0;
                float total = 0;

                if (en.LineaPedido != null) {
                        for (int i = 0; i < en.LineaPedido.Count; i++) {
                                total = total + en.LineaPedido [i].Libro.Precio;
                                cont++;
                        }
                }

                en.Precio = total;


                carritoCAD.Modify (en);

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
