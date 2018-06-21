
using System;
using System.Text;
using LibrerateGenNHibernate.CEN.Librerate;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using LibrerateGenNHibernate.EN.Librerate;
using LibrerateGenNHibernate.Exceptions;


/*
 * Clase Carrito:
 *
 */

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial class CarritoCAD : BasicCAD, ICarritoCAD
{
public CarritoCAD() : base ()
{
}

public CarritoCAD(ISession sessionAux) : base (sessionAux)
{
}



public CarritoEN ReadOIDDefault (int id
                                 )
{
        CarritoEN carritoEN = null;

        try
        {
                SessionInitializeTransaction ();
                carritoEN = (CarritoEN)session.Get (typeof(CarritoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carritoEN;
}

public System.Collections.Generic.IList<CarritoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CarritoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CarritoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CarritoEN>();
                        else
                                result = session.CreateCriteria (typeof(CarritoEN)).List<CarritoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CarritoEN carrito)
{
        try
        {
                SessionInitializeTransaction ();
                CarritoEN carritoEN = (CarritoEN)session.Load (typeof(CarritoEN), carrito.Id);

                carritoEN.Numerador = carrito.Numerador;


                carritoEN.Precio = carrito.Precio;




                carritoEN.Estado = carrito.Estado;

                session.Update (carritoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CarritoEN carrito)
{
        try
        {
                SessionInitializeTransaction ();
                if (carrito.Usuario != null) {
                        // Argumento OID y no colección.
                        carrito.Usuario = (LibrerateGenNHibernate.EN.Librerate.UsuarioEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.UsuarioEN), carrito.Usuario.Id);

                        carrito.Usuario.Carrito
                        .Add (carrito);
                }

                session.Save (carrito);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carrito.Id;
}

public void Modify (CarritoEN carrito)
{
        try
        {
                SessionInitializeTransaction ();
                CarritoEN carritoEN = (CarritoEN)session.Load (typeof(CarritoEN), carrito.Id);

                carritoEN.Numerador = carrito.Numerador;


                carritoEN.Precio = carrito.Precio;


                carritoEN.Estado = carrito.Estado;

                session.Update (carritoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                CarritoEN carritoEN = (CarritoEN)session.Load (typeof(CarritoEN), id);
                session.Delete (carritoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: CarritoEN
public CarritoEN ReadOID (int id
                          )
{
        CarritoEN carritoEN = null;

        try
        {
                SessionInitializeTransaction ();
                carritoEN = (CarritoEN)session.Get (typeof(CarritoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return carritoEN;
}

public System.Collections.Generic.IList<CarritoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CarritoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CarritoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CarritoEN>();
                else
                        result = session.CreateCriteria (typeof(CarritoEN)).List<CarritoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AdjuntarlineaPedido (int p_Carrito_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        LibrerateGenNHibernate.EN.Librerate.CarritoEN carritoEN = null;
        try
        {
                SessionInitializeTransaction ();
                carritoEN = (CarritoEN)session.Load (typeof(CarritoEN), p_Carrito_OID);
                LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN lineaPedidoENAux = null;
                if (carritoEN.LineaPedido == null) {
                        carritoEN.LineaPedido = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN>();
                }

                foreach (int item in p_lineaPedido_OIDs) {
                        lineaPedidoENAux = new LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN ();
                        lineaPedidoENAux = (LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN), item);
                        lineaPedidoENAux.Carrito = carritoEN;

                        carritoEN.LineaPedido.Add (lineaPedidoENAux);
                }


                session.Update (carritoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void QuitarlineaPedido (int p_Carrito_OID, System.Collections.Generic.IList<int> p_lineaPedido_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                LibrerateGenNHibernate.EN.Librerate.CarritoEN carritoEN = null;
                carritoEN = (CarritoEN)session.Load (typeof(CarritoEN), p_Carrito_OID);

                LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN lineaPedidoENAux = null;
                if (carritoEN.LineaPedido != null) {
                        foreach (int item in p_lineaPedido_OIDs) {
                                lineaPedidoENAux = (LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN), item);
                                if (carritoEN.LineaPedido.Contains (lineaPedidoENAux) == true) {
                                        carritoEN.LineaPedido.Remove (lineaPedidoENAux);
                                        lineaPedidoENAux.Carrito = null;
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_lineaPedido_OIDs you are trying to unrelationer, doesn't exist in CarritoEN");
                        }
                }

                session.Update (carritoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CarritoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
