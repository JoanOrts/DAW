
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
 * Clase Album:
 *
 */

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial class AlbumCAD : BasicCAD, IAlbumCAD
{
public AlbumCAD() : base ()
{
}

public AlbumCAD(ISession sessionAux) : base (sessionAux)
{
}



public AlbumEN ReadOIDDefault (int id
                               )
{
        AlbumEN albumEN = null;

        try
        {
                SessionInitializeTransaction ();
                albumEN = (AlbumEN)session.Get (typeof(AlbumEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AlbumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return albumEN;
}

public System.Collections.Generic.IList<AlbumEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<AlbumEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(AlbumEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<AlbumEN>();
                        else
                                result = session.CreateCriteria (typeof(AlbumEN)).List<AlbumEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AlbumCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (AlbumEN album)
{
        try
        {
                SessionInitializeTransaction ();
                AlbumEN albumEN = (AlbumEN)session.Load (typeof(AlbumEN), album.Id);

                albumEN.Titulo = album.Titulo;


                albumEN.Descripcion = album.Descripcion;


                albumEN.Cantidad = album.Cantidad;



                session.Update (albumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AlbumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (AlbumEN album)
{
        try
        {
                SessionInitializeTransaction ();
                if (album.Usuario != null) {
                        // Argumento OID y no colección.
                        album.Usuario = (LibrerateGenNHibernate.EN.Librerate.UsuarioEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.UsuarioEN), album.Usuario.Id);

                        album.Usuario.Album
                        .Add (album);
                }

                session.Save (album);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AlbumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return album.Id;
}

public void Modify (AlbumEN album)
{
        try
        {
                SessionInitializeTransaction ();
                AlbumEN albumEN = (AlbumEN)session.Load (typeof(AlbumEN), album.Id);

                albumEN.Titulo = album.Titulo;


                albumEN.Descripcion = album.Descripcion;


                albumEN.Cantidad = album.Cantidad;

                session.Update (albumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AlbumCAD.", ex);
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
                AlbumEN albumEN = (AlbumEN)session.Load (typeof(AlbumEN), id);
                session.Delete (albumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AlbumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: AlbumEN
public AlbumEN ReadOID (int id
                        )
{
        AlbumEN albumEN = null;

        try
        {
                SessionInitializeTransaction ();
                albumEN = (AlbumEN)session.Get (typeof(AlbumEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AlbumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return albumEN;
}

public System.Collections.Generic.IList<AlbumEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<AlbumEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(AlbumEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<AlbumEN>();
                else
                        result = session.CreateCriteria (typeof(AlbumEN)).List<AlbumEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AlbumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public void AnyadirLibroAlbum (int p_Album_OID, System.Collections.Generic.IList<int> p_libro_OIDs)
{
        LibrerateGenNHibernate.EN.Librerate.AlbumEN albumEN = null;
        try
        {
                SessionInitializeTransaction ();
                albumEN = (AlbumEN)session.Load (typeof(AlbumEN), p_Album_OID);
                LibrerateGenNHibernate.EN.Librerate.LibroEN libroENAux = null;
                if (albumEN.Libro == null) {
                        albumEN.Libro = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.LibroEN>();
                }

                foreach (int item in p_libro_OIDs) {
                        libroENAux = new LibrerateGenNHibernate.EN.Librerate.LibroEN ();
                        libroENAux = (LibrerateGenNHibernate.EN.Librerate.LibroEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.LibroEN), item);
                        libroENAux.Album.Add (albumEN);

                        albumEN.Libro.Add (libroENAux);
                }


                session.Update (albumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AlbumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void QuitarLibroAlbum (int p_Album_OID, System.Collections.Generic.IList<int> p_libro_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                LibrerateGenNHibernate.EN.Librerate.AlbumEN albumEN = null;
                albumEN = (AlbumEN)session.Load (typeof(AlbumEN), p_Album_OID);

                LibrerateGenNHibernate.EN.Librerate.LibroEN libroENAux = null;
                if (albumEN.Libro != null) {
                        foreach (int item in p_libro_OIDs) {
                                libroENAux = (LibrerateGenNHibernate.EN.Librerate.LibroEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.LibroEN), item);
                                if (albumEN.Libro.Contains (libroENAux) == true) {
                                        albumEN.Libro.Remove (libroENAux);
                                        libroENAux.Album.Remove (albumEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_libro_OIDs you are trying to unrelationer, doesn't exist in AlbumEN");
                        }
                }

                session.Update (albumEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AlbumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> LeerNombre (string p_nombre)
{
        System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM AlbumEN self where  from AlbumEN as a where a.Titulo= :titulo";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("AlbumENleerNombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<LibrerateGenNHibernate.EN.Librerate.AlbumEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in AlbumCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
