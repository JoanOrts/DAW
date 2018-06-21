
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
 * Clase Puntuacion:
 *
 */

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial class PuntuacionCAD : BasicCAD, IPuntuacionCAD
{
public PuntuacionCAD() : base ()
{
}

public PuntuacionCAD(ISession sessionAux) : base (sessionAux)
{
}



public PuntuacionEN ReadOIDDefault (int id
                                    )
{
        PuntuacionEN puntuacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                puntuacionEN = (PuntuacionEN)session.Get (typeof(PuntuacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuacionEN;
}

public System.Collections.Generic.IList<PuntuacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PuntuacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PuntuacionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PuntuacionEN>();
                        else
                                result = session.CreateCriteria (typeof(PuntuacionEN)).List<PuntuacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PuntuacionEN puntuacion)
{
        try
        {
                SessionInitializeTransaction ();
                PuntuacionEN puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), puntuacion.Id);

                puntuacionEN.Nota = puntuacion.Nota;




                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PuntuacionEN puntuacion)
{
        try
        {
                SessionInitializeTransaction ();
                if (puntuacion.Libro != null) {
                        // Argumento OID y no colección.
                        puntuacion.Libro = (LibrerateGenNHibernate.EN.Librerate.LibroEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.LibroEN), puntuacion.Libro.Id);

                        puntuacion.Libro.Puntuacion
                        .Add (puntuacion);
                }
                if (puntuacion.Usuario != null) {
                        // Argumento OID y no colección.
                        puntuacion.Usuario = (LibrerateGenNHibernate.EN.Librerate.UsuarioEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.UsuarioEN), puntuacion.Usuario.Id);

                        puntuacion.Usuario.Puntuacion
                        .Add (puntuacion);
                }

                session.Save (puntuacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuacion.Id;
}

public void Modify (PuntuacionEN puntuacion)
{
        try
        {
                SessionInitializeTransaction ();
                PuntuacionEN puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), puntuacion.Id);

                puntuacionEN.Nota = puntuacion.Nota;

                session.Update (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
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
                PuntuacionEN puntuacionEN = (PuntuacionEN)session.Load (typeof(PuntuacionEN), id);
                session.Delete (puntuacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PuntuacionEN
public PuntuacionEN ReadOID (int id
                             )
{
        PuntuacionEN puntuacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                puntuacionEN = (PuntuacionEN)session.Get (typeof(PuntuacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return puntuacionEN;
}

public System.Collections.Generic.IList<PuntuacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PuntuacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PuntuacionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PuntuacionEN>();
                else
                        result = session.CreateCriteria (typeof(PuntuacionEN)).List<PuntuacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PuntuacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
