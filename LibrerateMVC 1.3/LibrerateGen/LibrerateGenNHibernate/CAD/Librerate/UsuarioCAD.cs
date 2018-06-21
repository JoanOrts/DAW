
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
 * Clase Usuario:
 *
 */

namespace LibrerateGenNHibernate.CAD.Librerate
{
public partial class UsuarioCAD : BasicCAD, IUsuarioCAD
{
public UsuarioCAD() : base ()
{
}

public UsuarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public UsuarioEN ReadOIDDefault (int id
                                 )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(UsuarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                        else
                                result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Id);

                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Email = usuario.Email;


                usuarioEN.Fecha = usuario.Fecha;












                usuarioEN.Contrasena = usuario.Contrasena;



                usuarioEN.Baneado = usuario.Baneado;



                usuarioEN.Imagen = usuario.Imagen;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (usuario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuario.Id;
}

public void Modify (UsuarioEN usuario)
{
        try
        {
                SessionInitializeTransaction ();
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), usuario.Id);

                usuarioEN.Nombre = usuario.Nombre;


                usuarioEN.Email = usuario.Email;


                usuarioEN.Fecha = usuario.Fecha;


                usuarioEN.Contrasena = usuario.Contrasena;


                usuarioEN.Baneado = usuario.Baneado;


                usuarioEN.Imagen = usuario.Imagen;

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
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
                UsuarioEN usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), id);
                session.Delete (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: UsuarioEN
public UsuarioEN ReadOID (int id
                          )
{
        UsuarioEN usuarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Get (typeof(UsuarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return usuarioEN;
}

public System.Collections.Generic.IList<UsuarioEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<UsuarioEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(UsuarioEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<UsuarioEN>();
                else
                        result = session.CreateCriteria (typeof(UsuarioEN)).List<UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> LeerNombre (string p_nombre)
{
        System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.UsuarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where from UsuarioEN as u where u.Nombre = :nombre";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENleerNombreHQL");
                query.SetParameter ("p_nombre", p_nombre);

                result = query.List<LibrerateGenNHibernate.EN.Librerate.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void SeguirAutor (int p_Usuario_OID, int p_autor_OID)
{
        LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                usuarioEN.Autor = (LibrerateGenNHibernate.EN.Librerate.AutorEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.AutorEN), p_autor_OID);

                usuarioEN.Autor.Usuario = usuarioEN;




                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void DeseguirAutor (int p_Usuario_OID, int p_autor_OID)
{
        try
        {
                SessionInitializeTransaction ();
                LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuarioEN = null;
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);

                if (usuarioEN.Autor.Id == p_autor_OID) {
                        usuarioEN.Autor = null;
                        LibrerateGenNHibernate.EN.Librerate.AutorEN autorEN = (LibrerateGenNHibernate.EN.Librerate.AutorEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.AutorEN), p_autor_OID);
                        autorEN.Usuario = null;
                }
                else
                        throw new ModelException ("The identifier " + p_autor_OID + " in p_autor_OID you are trying to unrelationer, doesn't exist in UsuarioEN");

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void AnyadirLibro (int p_Usuario_OID, System.Collections.Generic.IList<int> p_libro_OIDs)
{
        LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);
                LibrerateGenNHibernate.EN.Librerate.LibroEN libroENAux = null;
                if (usuarioEN.Libro == null) {
                        usuarioEN.Libro = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.LibroEN>();
                }

                foreach (int item in p_libro_OIDs) {
                        libroENAux = new LibrerateGenNHibernate.EN.Librerate.LibroEN ();
                        libroENAux = (LibrerateGenNHibernate.EN.Librerate.LibroEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.LibroEN), item);
                        libroENAux.Usuario.Add (usuarioEN);

                        usuarioEN.Libro.Add (libroENAux);
                }


                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void QuitarLibro (int p_Usuario_OID, System.Collections.Generic.IList<int> p_libro_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                LibrerateGenNHibernate.EN.Librerate.UsuarioEN usuarioEN = null;
                usuarioEN = (UsuarioEN)session.Load (typeof(UsuarioEN), p_Usuario_OID);

                LibrerateGenNHibernate.EN.Librerate.LibroEN libroENAux = null;
                if (usuarioEN.Libro != null) {
                        foreach (int item in p_libro_OIDs) {
                                libroENAux = (LibrerateGenNHibernate.EN.Librerate.LibroEN)session.Load (typeof(LibrerateGenNHibernate.EN.Librerate.LibroEN), item);
                                if (usuarioEN.Libro.Contains (libroENAux) == true) {
                                        usuarioEN.Libro.Remove (libroENAux);
                                        libroENAux.Usuario.Remove (usuarioEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_libro_OIDs you are trying to unrelationer, doesn't exist in UsuarioEN");
                        }
                }

                session.Update (usuarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public LibrerateGenNHibernate.EN.Librerate.UsuarioEN LeerEmail (string p_email)
{
        LibrerateGenNHibernate.EN.Librerate.UsuarioEN result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM UsuarioEN self where from UsuarioEN as u where u.Email = :email";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("UsuarioENleerEmailHQL");
                query.SetParameter ("p_email", p_email);


                result = query.UniqueResult<LibrerateGenNHibernate.EN.Librerate.UsuarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is LibrerateGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new LibrerateGenNHibernate.Exceptions.DataLayerException ("Error in UsuarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
