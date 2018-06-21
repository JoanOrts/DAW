
using System;
// Definición clase UsuarioEN
namespace LibrerateGenNHibernate.EN.Librerate
{
public partial class UsuarioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo email
 */
private string email;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo album
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> album;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> lineaPedido;



/**
 *	Atributo puntuacion
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PuntuacionEN> puntuacion;



/**
 *	Atributo donacion
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.DonacionEN> donacion;



/**
 *	Atributo publicacion
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> publicacion;



/**
 *	Atributo administrador
 */
private LibrerateGenNHibernate.EN.Librerate.AdministradorEN administrador;



/**
 *	Atributo autor
 */
private LibrerateGenNHibernate.EN.Librerate.AutorEN autor;



/**
 *	Atributo carrito
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CarritoEN> carrito;



/**
 *	Atributo critica
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> critica;



/**
 *	Atributo libro
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> libro;



/**
 *	Atributo contrasena
 */
private String contrasena;



/**
 *	Atributo autor_0
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AutorEN> autor_0;



/**
 *	Atributo baneado
 */
private bool baneado;



/**
 *	Atributo libro_0
 */
private System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> libro_0;



/**
 *	Atributo imagen
 */
private string imagen;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> Album {
        get { return album; } set { album = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PuntuacionEN> Puntuacion {
        get { return puntuacion; } set { puntuacion = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.DonacionEN> Donacion {
        get { return donacion; } set { donacion = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> Publicacion {
        get { return publicacion; } set { publicacion = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.AdministradorEN Administrador {
        get { return administrador; } set { administrador = value;  }
}



public virtual LibrerateGenNHibernate.EN.Librerate.AutorEN Autor {
        get { return autor; } set { autor = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CarritoEN> Carrito {
        get { return carrito; } set { carrito = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> Critica {
        get { return critica; } set { critica = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> Libro {
        get { return libro; } set { libro = value;  }
}



public virtual String Contrasena {
        get { return contrasena; } set { contrasena = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AutorEN> Autor_0 {
        get { return autor_0; } set { autor_0 = value;  }
}



public virtual bool Baneado {
        get { return baneado; } set { baneado = value;  }
}



public virtual System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> Libro_0 {
        get { return libro_0; } set { libro_0 = value;  }
}



public virtual string Imagen {
        get { return imagen; } set { imagen = value;  }
}





public UsuarioEN()
{
        album = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.AlbumEN>();
        lineaPedido = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN>();
        puntuacion = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.PuntuacionEN>();
        donacion = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.DonacionEN>();
        publicacion = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.PublicacionEN>();
        carrito = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.CarritoEN>();
        critica = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.CriticaEN>();
        libro = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.LibroEN>();
        autor_0 = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.AutorEN>();
        libro_0 = new System.Collections.Generic.List<LibrerateGenNHibernate.EN.Librerate.LibroEN>();
}



public UsuarioEN(int id, string nombre, string email, Nullable<DateTime> fecha, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> album, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PuntuacionEN> puntuacion, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.DonacionEN> donacion, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> publicacion, LibrerateGenNHibernate.EN.Librerate.AdministradorEN administrador, LibrerateGenNHibernate.EN.Librerate.AutorEN autor, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CarritoEN> carrito, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> critica, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> libro, String contrasena, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AutorEN> autor_0, bool baneado, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> libro_0, string imagen
                 )
{
        this.init (Id, nombre, email, fecha, album, lineaPedido, puntuacion, donacion, publicacion, administrador, autor, carrito, critica, libro, contrasena, autor_0, baneado, libro_0, imagen);
}


public UsuarioEN(UsuarioEN usuario)
{
        this.init (Id, usuario.Nombre, usuario.Email, usuario.Fecha, usuario.Album, usuario.LineaPedido, usuario.Puntuacion, usuario.Donacion, usuario.Publicacion, usuario.Administrador, usuario.Autor, usuario.Carrito, usuario.Critica, usuario.Libro, usuario.Contrasena, usuario.Autor_0, usuario.Baneado, usuario.Libro_0, usuario.Imagen);
}

private void init (int id
                   , string nombre, string email, Nullable<DateTime> fecha, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AlbumEN> album, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LineaPedidoEN> lineaPedido, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PuntuacionEN> puntuacion, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.DonacionEN> donacion, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.PublicacionEN> publicacion, LibrerateGenNHibernate.EN.Librerate.AdministradorEN administrador, LibrerateGenNHibernate.EN.Librerate.AutorEN autor, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CarritoEN> carrito, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.CriticaEN> critica, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> libro, String contrasena, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.AutorEN> autor_0, bool baneado, System.Collections.Generic.IList<LibrerateGenNHibernate.EN.Librerate.LibroEN> libro_0, string imagen)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Email = email;

        this.Fecha = fecha;

        this.Album = album;

        this.LineaPedido = lineaPedido;

        this.Puntuacion = puntuacion;

        this.Donacion = donacion;

        this.Publicacion = publicacion;

        this.Administrador = administrador;

        this.Autor = autor;

        this.Carrito = carrito;

        this.Critica = critica;

        this.Libro = libro;

        this.Contrasena = contrasena;

        this.Autor_0 = autor_0;

        this.Baneado = baneado;

        this.Libro_0 = libro_0;

        this.Imagen = imagen;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        UsuarioEN t = obj as UsuarioEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
