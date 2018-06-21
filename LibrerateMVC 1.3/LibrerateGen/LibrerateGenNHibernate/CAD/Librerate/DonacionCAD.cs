
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
 * Clase Donacion:
 *
 */

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial class DonacionCAD : BasicCAD, IDonacionCAD
{
public DonacionCAD() : base ()
{
}

public DonacionCAD(ISession sessionAux) : base (sessionAux)
{
}



public DonacionEN ReadOIDDefault (int id
                                  )
{
        DonacionEN donacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                donacionEN = (DonacionEN)session.Get (typeof(DonacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in DonacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return donacionEN;
}

public System.Collections.Generic.IList<DonacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DonacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DonacionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<DonacionEN>();
                        else
                                result = session.CreateCriteria (typeof(DonacionEN)).List<DonacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in DonacionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DonacionEN donacion)
{
        try
        {
                SessionInitializeTransaction ();
                DonacionEN donacionEN = (DonacionEN)session.Load (typeof(DonacionEN), donacion.Id);

                donacionEN.Cantidad = donacion.Cantidad;



                session.Update (donacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in DonacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (DonacionEN donacion)
{
        try
        {
                SessionInitializeTransaction ();
                if (donacion.Autor != null) {
                        // Argumento OID y no colección.
                        donacion.Autor = (LibrerateGenNHibernate.EN.Librerate.AutorEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.AutorEN), donacion.Autor.Id);

                        donacion.Autor.Donacion
                        .Add (donacion);
                }
                if (donacion.Usuario != null) {
                        // Argumento OID y no colección.
                        donacion.Usuario = (LibrerateGenNHibernate.EN.Librerate.UsuarioEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.UsuarioEN), donacion.Usuario.Id);

                        donacion.Usuario.Donacion
                        .Add (donacion);
                }

                session.Save (donacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in DonacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return donacion.Id;
}

public void Modify (DonacionEN donacion)
{
        try
        {
                SessionInitializeTransaction ();
                DonacionEN donacionEN = (DonacionEN)session.Load (typeof(DonacionEN), donacion.Id);

                donacionEN.Cantidad = donacion.Cantidad;

                session.Update (donacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in DonacionCAD.", ex);
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
                DonacionEN donacionEN = (DonacionEN)session.Load (typeof(DonacionEN), id);
                session.Delete (donacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in DonacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: DonacionEN
public DonacionEN ReadOID (int id
                           )
{
        DonacionEN donacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                donacionEN = (DonacionEN)session.Get (typeof(DonacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in DonacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return donacionEN;
}

public System.Collections.Generic.IList<DonacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<DonacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(DonacionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<DonacionEN>();
                else
                        result = session.CreateCriteria (typeof(DonacionEN)).List<DonacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in DonacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
