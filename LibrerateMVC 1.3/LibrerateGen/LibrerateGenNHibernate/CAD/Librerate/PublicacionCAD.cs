
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
 * Clase Publicacion:
 *
 */

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial class PublicacionCAD : BasicCAD, IPublicacionCAD
{
public PublicacionCAD() : base ()
{
}

public PublicacionCAD(ISession sessionAux) : base (sessionAux)
{
}



public PublicacionEN ReadOIDDefault (int id
                                     )
{
        PublicacionEN publicacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                publicacionEN = (PublicacionEN)session.Get (typeof(PublicacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return publicacionEN;
}

public System.Collections.Generic.IList<PublicacionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PublicacionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PublicacionEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<PublicacionEN>();
                        else
                                result = session.CreateCriteria (typeof(PublicacionEN)).List<PublicacionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PublicacionEN publicacion)
{
        try
        {
                SessionInitializeTransaction ();
                PublicacionEN publicacionEN = (PublicacionEN)session.Load (typeof(PublicacionEN), publicacion.Id);

                publicacionEN.Nombre = publicacion.Nombre;




                publicacionEN.NumPag = publicacion.NumPag;

                session.Update (publicacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (PublicacionEN publicacion)
{
        try
        {
                SessionInitializeTransaction ();
                if (publicacion.Usuario != null) {
                        // Argumento OID y no colección.
                        publicacion.Usuario = (LibrerateGenNHibernate.EN.Librerate.UsuarioEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.UsuarioEN), publicacion.Usuario.Id);

                        publicacion.Usuario.Publicacion
                        .Add (publicacion);
                }

                session.Save (publicacion);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return publicacion.Id;
}

public void Modify (PublicacionEN publicacion)
{
        try
        {
                SessionInitializeTransaction ();
                PublicacionEN publicacionEN = (PublicacionEN)session.Load (typeof(PublicacionEN), publicacion.Id);

                publicacionEN.Nombre = publicacion.Nombre;


                publicacionEN.NumPag = publicacion.NumPag;

                session.Update (publicacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
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
                PublicacionEN publicacionEN = (PublicacionEN)session.Load (typeof(PublicacionEN), id);
                session.Delete (publicacionEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: PublicacionEN
public PublicacionEN ReadOID (int id
                              )
{
        PublicacionEN publicacionEN = null;

        try
        {
                SessionInitializeTransaction ();
                publicacionEN = (PublicacionEN)session.Get (typeof(PublicacionEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return publicacionEN;
}

public System.Collections.Generic.IList<PublicacionEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<PublicacionEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PublicacionEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<PublicacionEN>();
                else
                        result = session.CreateCriteria (typeof(PublicacionEN)).List<PublicacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> LeerNombre (string p_nombre)
{
        System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM PublicacionEN self where from PublicacionEN as p where p.Nombre =:nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("PublicacionENleerNombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<LibrerateGenNHibernate.EN.Librerate.PublicacionEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in PublicacionCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
