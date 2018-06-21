
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
 * Clase LineaPedido:
 *
 */

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial class LineaPedidoCAD : BasicCAD, ILineaPedidoCAD
{
public LineaPedidoCAD() : base ()
{
}

public LineaPedidoCAD(ISession sessionAux) : base (sessionAux)
{
}



public LineaPedidoEN ReadOIDDefault (int id
                                     )
{
        LineaPedidoEN lineaPedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                lineaPedidoEN = (LineaPedidoEN)session.Get (typeof(LineaPedidoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedidoEN;
}

public System.Collections.Generic.IList<LineaPedidoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<LineaPedidoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(LineaPedidoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<LineaPedidoEN>();
                        else
                                result = session.CreateCriteria (typeof(LineaPedidoEN)).List<LineaPedidoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (LineaPedidoEN lineaPedido)
{
        try
        {
                SessionInitializeTransaction ();
                LineaPedidoEN lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), lineaPedido.Id);

                lineaPedidoEN.Cantidad = lineaPedido.Cantidad;




                session.Update (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (LineaPedidoEN lineaPedido)
{
        try
        {
                SessionInitializeTransaction ();
                if (lineaPedido.Usuario != null) {
                        // Argumento OID y no colección.
                        lineaPedido.Usuario = (LibrerateGenNHibernate.EN.Librerate.UsuarioEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.UsuarioEN), lineaPedido.Usuario.Id);

                        lineaPedido.Usuario.LineaPedido
                        .Add (lineaPedido);
                }
                if (lineaPedido.Carrito != null) {
                        // Argumento OID y no colección.
                        lineaPedido.Carrito = (LibrerateGenNHibernate.EN.Librerate.CarritoEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.CarritoEN), lineaPedido.Carrito.Id);

                        lineaPedido.Carrito.LineaPedido
                        .Add (lineaPedido);
                }
                if (lineaPedido.Libro != null) {
                        // Argumento OID y no colección.
                        lineaPedido.Libro = (LibrerateGenNHibernate.EN.Librerate.LibroEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.LibroEN), lineaPedido.Libro.Id);

                        lineaPedido.Libro.LineaPedido
                        .Add (lineaPedido);
                }

                session.Save (lineaPedido);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedido.Id;
}

public void Modify (LineaPedidoEN lineaPedido)
{
        try
        {
                SessionInitializeTransaction ();
                LineaPedidoEN lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), lineaPedido.Id);

                lineaPedidoEN.Cantidad = lineaPedido.Cantidad;

                session.Update (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
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
                LineaPedidoEN lineaPedidoEN = (LineaPedidoEN)session.Load (typeof(LineaPedidoEN), id);
                session.Delete (lineaPedidoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: LineaPedidoEN
public LineaPedidoEN ReadOID (int id
                              )
{
        LineaPedidoEN lineaPedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                lineaPedidoEN = (LineaPedidoEN)session.Get (typeof(LineaPedidoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return lineaPedidoEN;
}

public System.Collections.Generic.IList<LineaPedidoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LineaPedidoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(LineaPedidoEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<LineaPedidoEN>();
                else
                        result = session.CreateCriteria (typeof(LineaPedidoEN)).List<LineaPedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LineaPedidoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
