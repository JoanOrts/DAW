
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
 * Clase Libro:
 *
 */

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial class LibroCAD : BasicCAD, ILibroCAD
{
public LibroCAD() : base ()
{
}

public LibroCAD(ISession sessionAux) : base (sessionAux)
{
}



public LibroEN ReadOIDDefault (int id
                               )
{
        LibroEN libroEN = null;

        try
        {
                SessionInitializeTransaction ();
                libroEN = (LibroEN)session.Get (typeof(LibroEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return libroEN;
}

public System.Collections.Generic.IList<LibroEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<LibroEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(LibroEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<LibroEN>();
                        else
                                result = session.CreateCriteria (typeof(LibroEN)).List<LibroEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (LibroEN libro)
{
        try
        {
                SessionInitializeTransaction ();
                LibroEN libroEN = (LibroEN)session.Load (typeof(LibroEN), libro.Id);

                libroEN.Nombre = libro.Nombre;


                libroEN.Precio = libro.Precio;


                libroEN.Fecha = libro.Fecha;


                libroEN.Descripcion = libro.Descripcion;


                libroEN.Portada = libro.Portada;


                libroEN.Genero = libro.Genero;


                libroEN.Numpag = libro.Numpag;


                libroEN.Idioma = libro.Idioma;


                libroEN.Media = libro.Media;








                libroEN.Cantidadvendida = libro.Cantidadvendida;


                session.Update (libroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (LibroEN libro)
{
        try
        {
                SessionInitializeTransaction ();
                if (libro.Publicacion != null) {
                        for (int i = 0; i < libro.Publicacion.Count; i++) {
                                libro.Publicacion [i] = (LibrerateGenNHibernate.EN.Librerate.PublicacionEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.PublicacionEN), libro.Publicacion [i].Id);
                                libro.Publicacion [i].Libro = libro;
                        }
                }
                if (libro.Usuario_0 != null) {
                        // Argumento OID y no colección.
                        libro.Usuario_0 = (LibrerateGenNHibernate.EN.Librerate.UsuarioEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.UsuarioEN), libro.Usuario_0.Id);

                        libro.Usuario_0.Libro_0
                        .Add (libro);
                }

                session.Save (libro);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return libro.Id;
}

public void Modify (LibroEN libro)
{
        try
        {
                SessionInitializeTransaction ();
                LibroEN libroEN = (LibroEN)session.Load (typeof(LibroEN), libro.Id);

                libroEN.Nombre = libro.Nombre;


                libroEN.Precio = libro.Precio;


                libroEN.Fecha = libro.Fecha;


                libroEN.Descripcion = libro.Descripcion;


                libroEN.Portada = libro.Portada;


                libroEN.Genero = libro.Genero;


                libroEN.Numpag = libro.Numpag;


                libroEN.Idioma = libro.Idioma;


                libroEN.Media = libro.Media;


                libroEN.Cantidadvendida = libro.Cantidadvendida;

                session.Update (libroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
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
                LibroEN libroEN = (LibroEN)session.Load (typeof(LibroEN), id);
                session.Delete (libroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: LibroEN
public LibroEN ReadOID (int id
                        )
{
        LibroEN libroEN = null;

        try
        {
                SessionInitializeTransaction ();
                libroEN = (LibroEN)session.Get (typeof(LibroEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return libroEN;
}

public System.Collections.Generic.IList<LibroEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<LibroEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(LibroEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<LibroEN>();
                else
                        result = session.CreateCriteria (typeof(LibroEN)).List<LibroEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerGenero (string p_genero)
{
        System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LibroEN self where from LibroEN as l where l.Genero= :genero";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LibroENleerGeneroHQL");
                query.SetParameter ("p_genero", p_genero);

                result = query.List<LibrerateGenNHibernate.EN.Librerate.LibroEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerUsuario (string p_usuario)
{
        System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LibroEN self where from LibroEN as l inner join l.Usuario as u where u.Nombre = :usuario";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LibroENleerUsuarioHQL");
                query.SetParameter ("p_usuario", p_usuario);

                result = query.List<LibrerateGenNHibernate.EN.Librerate.LibroEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerPrecio (string p_precio)
{
        System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LibroEN self where from LibroEN as l where l.Precio= :precio";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LibroENleerPrecioHQL");
                query.SetParameter ("p_precio", p_precio);

                result = query.List<LibrerateGenNHibernate.EN.Librerate.LibroEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> LeerNombre (string p_nombre)
{
        System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM LibroEN self where from LibroEN as l where l.Nombre= :nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("LibroENleerNombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<LibrerateGenNHibernate.EN.Librerate.LibroEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void AsignarAlbum (int p_Libro_OID, System.Collections.Generic.IList<int> p_album_OIDs)
{
        LibrerateGenNHibernate.EN.Librerate.LibroEN libroEN = null;
        try
        {
                SessionInitializeTransaction ();
                libroEN = (LibroEN)session.Load (typeof(LibroEN), p_Libro_OID);
                LibrerateGenNHibernate.EN.Librerate.AlbumEN albumENAux = null;
                if (libroEN.Album == null) {
                        libroEN.Album = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.AlbumEN>();
                }

                foreach (int item in p_album_OIDs) {
                        albumENAux = new LibrerateGenNHibernate.EN.Librerate.AlbumEN ();
                        albumENAux = (LibrerateGenNHibernate.EN.Librerate.AlbumEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.AlbumEN), item);
                        albumENAux.Libro.Add (libroEN);

                        libroEN.Album.Add (albumENAux);
                }


                session.Update (libroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void QuitardeAlbum (int p_Libro_OID, System.Collections.Generic.IList<int> p_album_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                LibrerateGenNHibernate.EN.Librerate.LibroEN libroEN = null;
                libroEN = (LibroEN)session.Load (typeof(LibroEN), p_Libro_OID);

                LibrerateGenNHibernate.EN.Librerate.AlbumEN albumENAux = null;
                if (libroEN.Album != null) {
                        foreach (int item in p_album_OIDs) {
                                albumENAux = (LibrerateGenNHibernate.EN.Librerate.AlbumEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.AlbumEN), item);
                                if (libroEN.Album.Contains (albumENAux) == true) {
                                        libroEN.Album.Remove (albumENAux);
                                        albumENAux.Libro.Remove (libroEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_album_OIDs you are trying to unrelationer, doesn't exist in LibroEN");
                        }
                }

                session.Update (libroEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in LibroCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
