
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
 * Clase Autor:
 *
 */

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial class AutorCAD : BasicCAD, IAutorCAD
{
public AutorCAD() : base ()
{
}

public AutorCAD(ISession sessionAux) : base (sessionAux)
{
}



public AutorEN ReadOIDDefault (int id
                               )
{
        AutorEN autorEN = null;

        try
        {
                SessionInitializeTransaction ();
                autorEN = (AutorEN)session.Get (typeof(AutorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return autorEN;
}

public System.Collections.Generic.IList<AutorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AutorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AutorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AutorEN>();
                        else
                                result = session.CreateCriteria (typeof(AutorEN)).List<AutorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AutorEN autor)
{
        try
        {
                SessionInitializeTransaction ();
                AutorEN autorEN = (AutorEN)session.Load (typeof(AutorEN), autor.Id);

                autorEN.Ganancias = autor.Ganancias;


                autorEN.Email = autor.Email;


                autorEN.Fecha = autor.Fecha;





                autorEN.Nombre = autor.Nombre;

                session.Update (autorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AutorEN autor)
{
        try
        {
                SessionInitializeTransaction ();
                if (autor.Usuario != null) {
                        // Argumento OID y no colección.
                        autor.Usuario = (LibrerateGenNHibernate.EN.Librerate.UsuarioEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.UsuarioEN), autor.Usuario.Id);

                        autor.Usuario.Autor
                                = autor;
                }

                session.Save (autor);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return autor.Id;
}

public void Modify (AutorEN autor)
{
        try
        {
                SessionInitializeTransaction ();
                AutorEN autorEN = (AutorEN)session.Load (typeof(AutorEN), autor.Id);

                autorEN.Ganancias = autor.Ganancias;


                autorEN.Email = autor.Email;


                autorEN.Fecha = autor.Fecha;


                autorEN.Nombre = autor.Nombre;

                session.Update (autorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
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
                AutorEN autorEN = (AutorEN)session.Load (typeof(AutorEN), id);
                session.Delete (autorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: AutorEN
public AutorEN ReadOID (int id
                        )
{
        AutorEN autorEN = null;

        try
        {
                SessionInitializeTransaction ();
                autorEN = (AutorEN)session.Get (typeof(AutorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return autorEN;
}

public System.Collections.Generic.IList<AutorEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AutorEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AutorEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AutorEN>();
                else
                        result = session.CreateCriteria (typeof(AutorEN)).List<AutorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AutorEN> LeerNombre (string p_nombre)
{
        System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AutorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AutorEN self where from AutorEN as aut where aut.Nombre = :nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AutorENleerNombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<LibrerateGenNHibernate.EN.Librerate.AutorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AutorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
