
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
 * Clase Critica:
 *
 */

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial class CriticaCAD : BasicCAD, ICriticaCAD
{
public CriticaCAD() : base ()
{
}

public CriticaCAD(ISession sessionAux) : base (sessionAux)
{
}



public CriticaEN ReadOIDDefault (int id
                                 )
{
        CriticaEN criticaEN = null;

        try
        {
                SessionInitializeTransaction ();
                criticaEN = (CriticaEN)session.Get (typeof(CriticaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return criticaEN;
}

public System.Collections.Generic.IList<CriticaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CriticaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CriticaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CriticaEN>();
                        else
                                result = session.CreateCriteria (typeof(CriticaEN)).List<CriticaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CriticaEN critica)
{
        try
        {
                SessionInitializeTransaction ();
                CriticaEN criticaEN = (CriticaEN)session.Load (typeof(CriticaEN), critica.Id);

                criticaEN.Titulo = critica.Titulo;


                criticaEN.Texto = critica.Texto;




                session.Update (criticaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CriticaEN critica)
{
        try
        {
                SessionInitializeTransaction ();
                if (critica.Puntuacion_0 != null) {
                        // Argumento OID y no colección.
                        critica.Puntuacion_0 = (LibrerateGenNHibernate.EN.Librerate.PuntuacionEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.PuntuacionEN), critica.Puntuacion_0.Id);

                        critica.Puntuacion_0.Critica
                                = critica;
                }
                if (critica.Libro != null) {
                        // Argumento OID y no colección.
                        critica.Libro = (LibrerateGenNHibernate.EN.Librerate.LibroEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.LibroEN), critica.Libro.Id);

                        critica.Libro.Critica
                        .Add (critica);
                }
                if (critica.Usuario != null) {
                        // Argumento OID y no colección.
                        critica.Usuario = (LibrerateGenNHibernate.EN.Librerate.UsuarioEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.UsuarioEN), critica.Usuario.Id);

                        critica.Usuario.Critica
                        .Add (critica);
                }

                session.Save (critica);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return critica.Id;
}

public void Modify (CriticaEN critica)
{
        try
        {
                SessionInitializeTransaction ();
                CriticaEN criticaEN = (CriticaEN)session.Load (typeof(CriticaEN), critica.Id);

                criticaEN.Titulo = critica.Titulo;


                criticaEN.Texto = critica.Texto;

                session.Update (criticaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
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
                CriticaEN criticaEN = (CriticaEN)session.Load (typeof(CriticaEN), id);
                session.Delete (criticaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: CriticaEN
public CriticaEN ReadOID (int id
                          )
{
        CriticaEN criticaEN = null;

        try
        {
                SessionInitializeTransaction ();
                criticaEN = (CriticaEN)session.Get (typeof(CriticaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return criticaEN;
}

public System.Collections.Generic.IList<CriticaEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<CriticaEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(CriticaEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<CriticaEN>();
                else
                        result = session.CreateCriteria (typeof(CriticaEN)).List<CriticaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> LeerTitulo (string p_titulo)
{
        System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM CriticaEN self where from CriticaEN as c where c.Titulo = :p_titulo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("CriticaENleerTituloHQL");
                query.SetParameter ("p_titulo", p_titulo);

                result = query.List<LibrerateGenNHibernate.EN.Librerate.CriticaEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in CriticaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
